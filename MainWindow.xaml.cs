using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Task4.models;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BusStop busStop;
        private Bus bus;

        public MainWindow()
        {
            InitializeComponent();

            init();

        }

        private void init()
        {
            busStop = new BusStop();
            bus = new Bus(10);

            busStop.BusStopped += () =>
            {
                MessageBox.Show("Bus has arrived at the bus stop!");
            };

            bus.PassengerBoarded += passenger =>
            {
                UpdateBusCapacityLabel();
            };

            bus.Overcrowded += () =>
            {
                MessageBox.Show("The bus is overcrowded!");
            };

            UpdateBusCapacityLabel();
        }

        private void ArriveBus_Click(object sender, RoutedEventArgs e)
        {
            bus = new Bus(10);
            init();
            busStop.Arrive();
        }

        private void BoardPassenger_Click(object sender, RoutedEventArgs e)
        {
            Passenger passenger = new Passenger();
            bus.BoardPassenger(passenger);
        }

        private void UpdateBusCapacityLabel()
        {
            busCapacityLabel.Content = $"Bus Capacity: {bus.PassengerCount}/{bus.Capacity}";
        }
    }
}
