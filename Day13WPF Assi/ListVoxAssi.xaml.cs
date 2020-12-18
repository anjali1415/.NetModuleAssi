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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for ListVoxAssi.xaml
    /// </summary>
    public partial class ListVoxAssi : Window
    {
        public ListVoxAssi()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstBox1.Items.Add("Anjali");
            lstBox1.Items.Add("Tushar");
            lstBox1.Items.Add("Vaishali");
            lstBox1.Items.Add("Rahul");
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            
            lstBox2.Items.Add(lstBox1.SelectedItem.ToString());
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            foreach(var itm in lstBox1.SelectedItems)
            {
                lstBox2.Items.Add(itm.ToString());
            }
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            lstBox2.Items.Remove(lstBox2.SelectedItem);
        }

        private void btnfour_Click(object sender, RoutedEventArgs e)
        {
            /*foreach(var itm in lstBox2.SelectedItems)
            {
                lstBox2.Items.Remove(itm);
            }*/
            foreach (var it in lstBox2.SelectedItems)
            {
                lstBox1.Items.Remove(it);
            }
        }
    }
}
