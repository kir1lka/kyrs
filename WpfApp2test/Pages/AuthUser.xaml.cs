using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp2test.Db;

namespace WpfApp2test.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthUser.xaml
    /// </summary>
    public partial class AuthUser : Page
    {
        user105dbEntities db = new user105dbEntities();
        int count = 0;

        public AuthUser()
        {
            InitializeComponent();
        }

        private async void Auth_click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTB.Text) || string.IsNullOrEmpty(PasswordTB.Password))
            {
                MessageBox.Show("введите данные");
            }
            else
            {
                if (db.Users.Select(user => user.Login + " " + user.Password).Contains(LoginTB.Text + " " + PasswordTB.Password))
                {
                    MessageBox.Show("ok");
                    NavigationService.Navigate(new Tovars());
                    return;
                }
                count++;

                if (count == 3)
                {
                    LoginTB.IsEnabled = false;
                    PasswordTB.IsEnabled = false;
                    BtnLog.IsEnabled = false;
                    MessageBox.Show($"вы заблокированы на 1 минуту ");
                    await Task.Delay(60000);
                    LoginTB.IsEnabled = true;
                    PasswordTB.IsEnabled = true;
                    BtnLog.IsEnabled = true;

                    count = 0;
                }
                else
                {
                    MessageBox.Show($"не правильные данные, попыток {3 - count}");
                }
            }

        }

        private void Reg_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegUser());
        }
    }
}
