using System.Linq;
using System.Windows.Controls;
using WpfApp2test.Db;

namespace WpfApp2test.Pages
{
    /// <summary>
    /// Логика взаимодействия для Tovars.xaml
    /// </summary>
    public partial class Tovars : Page
    {
        public Tovars()
        {
            InitializeComponent();
            DataGrid.ItemsSource = user105dbEntities.GetContext().Tovars.ToList();
        }
    }
}
