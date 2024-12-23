using System;
using System.Windows.Forms;

namespace Game
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранную сложность
                string selectedDifficulty = difficultyComboBox.SelectedItem.ToString();

                // Создаем форму игры и передаем выбранную сложность
                GameForm gameForm = new GameForm(selectedDifficulty);
                this.Hide(); // Скрываем меню
                gameForm.Show(); // Показываем форму игры
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске игры: {ex.Message}");
            }
        }

        private void contactsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Contacts settingsForm = new Contacts(null);
                settingsForm.Show(); // Показываем форму настроек
                this.Hide(); // Скрываем меню
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии настроек: {ex.Message}");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрыть приложение
        }
    }
}
