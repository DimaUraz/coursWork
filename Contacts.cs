using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Game
{
    public partial class Contacts : Form
    {
        private GameForm gameForm;

        public Contacts(GameForm gameForm)
        {
            InitializeComponent();
            this.gameForm = gameForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainMenuForm mainMenuForm = new MainMenuForm();
                this.Hide(); // Скрываем настройки
                mainMenuForm.Show(); // Показываем главное меню
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при переходе к главному меню: {ex.Message}");
            }
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://github.com/DimaUraz"; 
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии GitHub: {ex.Message}");
            }
        }

        private void vkButton_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://vk.com/zlobny_sfinktor"; 
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии vk: {ex.Message}");
            }
        }
    }
}
