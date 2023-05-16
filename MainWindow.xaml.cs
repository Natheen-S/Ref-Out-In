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

namespace Ref___Out___In
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmb_product.Items.Add("Towel");
            cmb_product.Items.Add("Trimmer");
            cmb_product.Items.Add("Razor");
            cmb_product.Items.Add("Conditioner");
            cmb_product.Items.Add("Facewash");
            cmb_product.Items.Add("Faceserum");
        }
        int shipprice = 0;
        int price;
        int[] towel = { 299, 499, 99, 249, 349, 299 };
        int tax;
        int total;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            price = towel[cmb_product.SelectedIndex];
            int tax = towel[cmb_product.SelectedIndex] / 10;
            int quantity = Convert.ToInt32(txtbox_quantity.Text);
            Total(price,quantity,ref shipprice,in tax,out total);
            MessageBox.Show("Product Name : " + cmb_product.SelectedItem.ToString() + "\nPrice : " + price + "\nQuantity : " + quantity + "\nShipping Cost : "+shipprice+"\nTax : "+tax+"\nTotal Price : "+total);
        }
        public void Total(int price ,int quantity,ref int ship,in int tax,out int total)
        {
            ship += 10;
            total = (price * quantity) + ship + tax;
        }
    }
}
