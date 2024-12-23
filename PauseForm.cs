using System;
using System.Windows.Forms;

namespace Game
{
    public partial class PauseForm : Form
    {
        private GameForm gameForm;

        public PauseForm(GameForm gameForm)
        {
            InitializeComponent();
            this.gameForm = gameForm;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            try
            {
                gameForm.ResumeGame(); // Восстанавливаем игру
                this.Hide(); // Скрываем окно паузы
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при возобновлении игры: {ex.Message}");
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            try
            {
                gameForm.RestartGame(); // Начинаем игру заново
                this.Hide(); // Скрываем окно паузы
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при перезапуске игры: {ex.Message}");
            }
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                gameForm.Close(); // Закрываем игру
                MainMenuForm mainMenuForm = new MainMenuForm(); // Открываем главное меню
                mainMenuForm.Show(); // Показываем главное меню
                this.Hide(); // Скрываем окно паузы
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при переходе в главное меню: {ex.Message}");
            }
        }
    }
}