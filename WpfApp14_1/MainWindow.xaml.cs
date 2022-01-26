using System;
using System.Collections.Generic;
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

namespace WpfApp14_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Молоко",
                Cost = 100,
                Image = "Data/milk.jpg",
                Category = ProductsTypes.Food

            });
            products.Add(new Product()
            {
                Name = "Хлеб",
                Cost = 50,
                Image = "Data/bread.jpg",
                Category = ProductsTypes.Food

            });
            products.Add(new Product()
            {
                Name = "Google Pixel 5a",
                Cost = 37000,
                Image = "Data/pixel.jpg",
                Category = ProductsTypes.Tech

            });
            lstBox.ItemsSource = products;
        }
    }
}
