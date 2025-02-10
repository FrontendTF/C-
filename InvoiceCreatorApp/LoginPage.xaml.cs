using System.Windows;
using System.Windows.Controls;


namespace InvoiceCreatorApp
{
    // LoginPage erbt von Window Standard
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent(); 
        }

        // Bei Login wird das MainWindow Fenster geöfnnet
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string password = Password.Password;

            if (username == "admin12321" && password == "password65456")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Falscher Benutzername oder Passwort");
            }
        }
    }
}
