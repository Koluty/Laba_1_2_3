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

namespace Laba_2
{
    /// <summary>
    /// Логика взаимодействия для Abstract.xaml
    /// </summary>
    public partial class Abstract : Window
    {
        public Abstract()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow;
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numberSofa = Convert.ToInt32(Sofa_GUI.Text);
            int numberWardrobe = Convert.ToInt32(Wardrobe_GUI.Text);
            var a = new Furniture[numberSofa + numberWardrobe];
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < numberWardrobe; i++)
            {
                int v = random.Next(50, 150);
                a[count] = new Wardrobe(v);
                count++;
            }
            for (int i = 0; i < numberSofa; i++)
            {
                int v = random.Next(50, 150);
                a[count] = new Sofa(v);
                count++;
            }
            listBox_GUI.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                listBox_GUI.Items.Add(a[i].Show() + " Ціна = " + a[i].CalculateCost().ToString());
            }
        }
    }
}
