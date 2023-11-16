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
    /// Логика взаимодействия для Inheritance.xaml
    /// </summary>
    public partial class Inheritance : Window
    {
        public Inheritance()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Express_Bus bus;
                int n_passenger = Convert.ToInt32(Number_Passenger.Text);
                double speed = Convert.ToDouble(Speed.Text);
                double price_ticket = Convert.ToDouble(Price_ticket.Text);
                bus = new Express_Bus(n_passenger, price_ticket, Brand.Text, speed);
                total_price.Content = bus.total_price_seats();
            }
            catch
            {
                MessageBox.Show("Помилка при введенні даних");
            }
        }
    }
}
