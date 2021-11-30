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

namespace ProductDataTemplate
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
                NameProduct = "Apples",
                Price = 99,
                ImageProduct = "Data/apple.jpg",
                Category = Categories.Meal
            });
            products.Add(new Product()
            {
                NameProduct = "Bananas",
                Price = 69,
                ImageProduct = "Data/banana.jpg",
                Category = Categories.Meal
            });
            products.Add(new Product()
            {
                NameProduct = "Hoover",
                Price = 4999,
                ImageProduct = "Data/hoover.jpg",
                Category = Categories.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
