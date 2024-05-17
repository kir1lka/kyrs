using System;
using System.IO;
using System.Windows;
using WpfApp2test.Db;
using WpfApp2test.Pages;

namespace WpfApp2test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthUser());
        }

        void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
                ButtonNavigate.Visibility = Visibility.Visible;
            else
                ButtonNavigate.Visibility = Visibility.Hidden;
        }

        void ButtonNavigate_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }

        public void ImportTovar()
        {
            var file = File.ReadAllLines(@"C:\Users\Кирилл\Desktop\tovar.txt");

            foreach (var line in file)
            {
                var data = line.Split('\t');

                var temp = new Tovar()
                {
                    Name_tovar = data[0],
                    Id_podkategoria = int.Parse(data[1]),
                    Zakupka = decimal.Parse(data[2]),
                    Procent = double.Parse(data[3]),
                    Itog_sum = decimal.Parse(data[4]),
                    Harakteristika = data[5],
                    Primechanie = data[6],
                    Ves = double.Parse(data[7]),
                    Id_proizvoditel = int.Parse(data[8]),
                    Srok_godnosti = DateTime.Parse(data[9]).Date,
                    Image = File.ReadAllBytes(data[10]),
                    Dop_image = data[11] == "" ? null : File.ReadAllBytes(data[11]),
                    Id_flag = int.Parse(data[12])
                };

                user105dbEntities.GetContext().Tovars.Add(temp);
                user105dbEntities.GetContext().SaveChanges();
            }
        }

        void ImportUslugi()
        {
            var file = File.ReadAllLines(@"C:\Users\Кирилл\Desktop\usluga.txt");

            foreach (var line in file)
            {
                var data = line.Split('\t');

                var temp = new Usluga
                {
                    Name_usluga = data[0],
                    Opisanie = data[1],
                    Stoimost = decimal.Parse(data[2]),
                    Skidka = double.Parse(data[3]),
                    Prodolzhitelnost = int.Parse(data[4]),
                    Osn_photo = File.ReadAllBytes(data[5]),
                    Dop_photo = data[6] == "" ? null : File.ReadAllBytes(data[6])
                };

                user105dbEntities.GetContext().Uslugas.Add(temp);
                user105dbEntities.GetContext().SaveChanges();
            }
        }
    }
}