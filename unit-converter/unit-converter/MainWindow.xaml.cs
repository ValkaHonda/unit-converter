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

namespace unit_converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Converter lengthConverter;
        private Converter temperatureConverter;
        public MainWindow()
        {
            InitializeComponent();
            this.lengthConverter = new LengthConverter();
            this.temperatureConverter = new TemperatureConverter();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String fromType = lenComboFrom.Text;
            String toType = lenComboTo.Text;
            String fromStr = lenFrom.Text;
            double fromValue = double.Parse(fromStr);
            double result = lengthConverter.convert(fromType, toType, fromValue);
            lenTo.Text = result.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String fromType = tempComboTypeFrom.Text;
            String toType = tempComboTypeTo.Text;
            String fromStr = tempFromValue.Text;
            double fromValue = double.Parse(fromStr);
            double result = temperatureConverter.convert(fromType, toType, fromValue);
            tempToValue.Text = result.ToString();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            String fromType = WeightComboFromType.Text;
            String toType = WeightComboToType.Text;
            String fromStr = weightFrom.Text;
            double fromValue = double.Parse(fromStr);
            double result = temperatureConverter.convert(fromType, toType, fromValue);
            weightTo.Text = result.ToString();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            String fromType = preComboFromType.Text;
            String toType = preComboToType.Text;
            String fromStr = pressureFrom.Text;
            double fromValue = double.Parse(fromStr);
            double result = temperatureConverter.convert(fromType, toType, fromValue);
            pressureTo.Text = result.ToString();
        }
    }
}
