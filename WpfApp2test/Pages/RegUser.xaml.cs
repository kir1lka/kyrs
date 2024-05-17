using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp2test.Db;

namespace WpfApp2test.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegUser.xaml
    /// </summary>
    public partial class RegUser : Page
    {
        public RegUser()
        {
            InitializeComponent();
        }

        private void Aut_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthUser());
        }

        private void Reg_click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTB.Text) || string.IsNullOrEmpty(PasswordTB.Password) || string.IsNullOrEmpty(MailTB.Text))
            {
                MessageBox.Show("введите данные");
            }
            else
            {
                var user = new User()
                {
                    Login = LoginTB.Text,
                    Password = PasswordTB.Password,
                    Mail = MailTB.Text,
                };
                user105dbEntities.GetContext().Users.Add(user);
                user105dbEntities.GetContext().SaveChanges();
                MessageBox.Show("ok");

                NavigationService.Navigate(new Tovars());
            }

        }

    }
}


