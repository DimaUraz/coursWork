using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;  // Подключаем пространство имен для работы с Windows Media Player

namespace Game
{
    public partial class GameForm : Form
    {
        private WindowsMediaPlayer mediaPlayer;
        private string difficulty; // Переменная для хранения сложности
        private PauseForm pauseForm; // Переменная для формы паузы
        private Point pos;
        private bool dragging;
        private bool lose = false;
        private int coinsCount = 0;
        private int enemySpeed; // Скорость врагов
        private int coinSpeed; // Скорость монет
        private bool isGameRunning = false; // Флаг для отслеживания состояния игры

        public GameForm(string difficulty)
        {
            InitializeComponent();

            road.MouseDown += MouseClickDown;
            road.MouseUp += MouseClickUp;
            road.MouseMove += MouseClickMove;
            road1.MouseDown += MouseClickDown;
            road1.MouseUp += MouseClickUp;
            road1.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            restartButton.Visible = false;
            KeyPreview = true;

            this.difficulty = difficulty;

            // Настройка игры в зависимости от сложности
            SetDifficultySettings();

            // Инициализация Windows Media Player
            mediaPlayer = new WindowsMediaPlayer();
            mediaPlayer.URL = "D:\\работы вуза\\Второй курс\\Курсовая работа\\Game\\music\\Нурминский - Джип (zaycev.net).mp3";  // Путь к вашему MP3 файлу
            mediaPlayer.controls.play();  // Воспроизведение музыки

            // Задаем зацикливание музыки
            mediaPlayer.settings.setMode("loop", true);  // Музыка будет повторяться
        }

        // Установим флаг, когда игра начнется
        public void StartGame()
        {
            isGameRunning = true;
            timer.Enabled = true;
        }

        // Остановим флаг, когда игра завершится или при паузе
        public void StopGame()
        {
            isGameRunning = false;
            timer.Enabled = false;
        }

        public bool IsGameRunning()
        {
            return isGameRunning;
        }

        // Метод для включения музыки
        public void PauseMusic()
        {
            try
            {
                if (mediaPlayer != null)
                {
                    mediaPlayer.controls.stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при остановке музыки: {ex.Message}");
            }
        }

        public void ResumeMusic()
        {
            try
            {
                if (mediaPlayer != null)
                {
                    mediaPlayer.controls.stop(); // Останавливаем, чтобы начать заново
                    mediaPlayer.controls.play(); // Запускаем музыку заново
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске музыки: {ex.Message}");
            }
        }

        private void PauseGame()
        {
            try
            {
                // Останавливаем таймер, чтобы игра не продолжалась в паузе
                timer.Enabled = false;
                // Приостанавливаем музыку
                PauseMusic();

                // Показываем форму паузы
                pauseForm = new PauseForm(this);
                pauseForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии паузы: {ex.Message}");
            }
        }

        public void ResumeGame()
        {
            try
            {
                // Возобновляем игру
                timer.Enabled = true;
                // Возобновляем музыку
                ResumeMusic();
                // Закрываем форму паузы
                pauseForm.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при возобновлении игры: {ex.Message}");
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Останавливаем музыку при закрытии игры
            mediaPlayer.controls.stop();
        }
        private void SetDifficultySettings()
        {
            if (difficulty == "Easy")
            {
                // Например, меньшая скорость врагов
                enemySpeed = 3;
                coinSpeed = 4;
            }
            else if (difficulty == "Medium")
            {
                // Средняя скорость
                enemySpeed = 5;
                coinSpeed = 6;
            }
            else if (difficulty == "Hard")
            {
                // Высокая скорость
                enemySpeed = 7;
                coinSpeed = 8;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                // При нажатии на Escape показываем форму паузы
                PauseGame();
            }
        }

        public void RestartGame()
        {
            try
            {
                // Перезапускаем игру (можно добавить логику сброса состояния игры)
                restartButton_Click(null, null); // вызываем обработчик кнопки "Restart"
                ResumeGame(); // После перезапуска продолжаем игру
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при перезапуске игры: {ex.Message}");
            }
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currentPoint.X - pos.X, currentPoint.Y - pos.Y + road.Top);
            }
        }

        private bool IsCollidingWithOtherObject(Control objectToCheck, List<Control> otherObjects)
        {
            foreach (var obj in otherObjects)
            {
                if (objectToCheck.Bounds.IntersectsWith(obj.Bounds))
                {
                    return true; // Объекты пересекаются
                }
            }
            return false; // Нет пересечения
        }

        private void SetRandomPosition(Control objectToMove, List<Control> otherObjects)
        {
            Random rand = new Random();
            bool isColliding;
            do
            {
                // Устанавливаем случайное положение объекта
                objectToMove.Left = rand.Next(150, 650);
                objectToMove.Top = rand.Next(-250, -50);

                // Проверяем, не накладывается ли объект на другие
                isColliding = IsCollidingWithOtherObject(objectToMove, otherObjects);

            } while (isColliding); // Повторяем, если есть пересечение
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Логика обновления игры с использованием скорости врагов и монет
                int roadSpeed = 5; // Скорость дороги, которая остается одинаковой
                road.Top += roadSpeed;
                road1.Top += roadSpeed;

                // Двигаем врагов
                enemy1.Top += enemySpeed;
                enemy2.Top += enemySpeed;

                // Двигаем монеты
                coin.Top += coinSpeed;

                // Логика появления монет и врагов
                if (coin.Top >= 650)
                {
                    SetRandomPosition(coin, new List<Control> { enemy1, enemy2 });
                }

                if (road.Top >= 650)
                {
                    road.Top = 0;
                    road1.Top = -650;
                }

                if (enemy1.Top >= 650)
                {
                    SetRandomPosition(enemy1, new List<Control> { enemy2, coin });
                }

                if (enemy2.Top >= 650)
                {
                    SetRandomPosition(enemy2, new List<Control> { enemy1, coin });
                }

                // Столкновения
                if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    PauseMusic();
                    timer.Enabled = false;
                    labelLose.Visible = true;
                    restartButton.Visible = true;
                    lose = true;
                }

                if (player.Bounds.IntersectsWith(coin.Bounds))
                {
                    coinsCount++;
                    coinCounter.Text = "COINS: " + coinsCount.ToString();
                    SetRandomPosition(coin, new List<Control> { enemy1, enemy2 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении игры: {ex.Message}");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            try
            {
                int speed = 10;

                if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 150)
                {
                    player.Left -= speed;
                }
                else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 700)
                {
                    player.Left += speed;
                }

                if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && player.Top > 0)
                {
                    player.Top -= speed;
                }
                else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && player.Bottom < this.ClientSize.Height)
                {
                    player.Top += speed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при движении игрока: {ex.Message}");
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            try
            {
                enemy1.Top = -130;
                enemy2.Top = -250;

                labelLose.Visible = false;
                restartButton.Visible = false;

                ResumeMusic();

                timer.Enabled = true;

                lose = false;
                coinsCount = 0;
                coinCounter.Text = "COINS: 0";

                coin.Top = -246;
                Random rand = new Random();
                coin.Left = rand.Next(150, 650);

                player.Left = 323;
                player.Top = 518;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при перезапуске игры: {ex.Message}");
            }
        }
    }
}