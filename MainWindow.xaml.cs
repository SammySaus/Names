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

namespace Names
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtname.Text) && !lstNames.Items.Contains(txtname.Text)) {
                lstNames.Items.Add(txtname.Text);
                txtname.Clear();
            }
        }

        private void ButtonRemoveNames_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Clear();
        }

        private void ButtonChangeProperties_Click(object sender, RoutedEventArgs e)
        {
            var rand= new Random();
            var bytes = new byte[3];
            rand.NextBytes(bytes);


            byte colourA = 0xFF;
            
            btnChange.Background = new SolidColorBrush(Color.FromArgb(colourA, bytes[0], bytes[1], bytes[2]));
        }
    }
}
