using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Наушники",
                ProdPrice = 3500,
                ProdImage = "Data/Headphones.jpg",
            ProdCathegory = ProdCathegorys.Lena
             });
            products.Add(new Product()
            {
                ProdName = "Удочка",
                ProdPrice = 5500,
                ProdImage = "Data/forfish.jpg",
                ProdCathegory = ProdCathegorys.Lena
            }); products.Add(new Product()
            {
                ProdName = "Смартфон",
                ProdPrice = 12500,
                ProdImage = "Data/smarthone.jpg",
                ProdCathegory = ProdCathegorys.Gena
            }); products.Add(new Product()
            {
                ProdName = "Шоколад",
                ProdPrice = 700,
                ProdImage = "Data/Choco.jpg",
                ProdCathegory = ProdCathegorys.Lena
            }); products.Add(new Product()
            {
                ProdName = "Ожерелье",
                ProdPrice = 10500,
                ProdImage = "Data/Jewel.jpg",
                ProdCathegory = ProdCathegorys.Gena
            }); products.Add(new Product()
            {
                ProdName = "чай",
                ProdPrice = 450,
                ProdImage = "Data/tea.jpg",
                ProdCathegory = ProdCathegorys.Lena
            });
            ListBox.ItemsSource = products;
        }
    }
}
