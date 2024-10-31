using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColloerChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor currentColor = new MyColor();
        public MainWindow() {
            InitializeComponent();
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            DataContext = GetColorList();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static).Select(i=>new MyColor() { Color = (Color)i.GetValue(null),Name=i.Name}).ToArray();
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)RedSlider.Value,(byte)GreenSlider.Value,(byte)BlueSlider.Value);
            currentColor.Name = GetColorList().Where(c=>c.Equals());
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }


        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (!stockList.Items.Contains((MyColor)currentColor)) {
                stockList.Items.Insert(0,currentColor);
            } else {
                MessageBox.Show("既に登録済みです!");
            }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);

        }

        private void setSliderValue(Color color) {
            RedSlider.Value = color.R;
            GreenSlider.Value = color.G;
            BlueSlider.Value = color.B;
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var tempCurrntColor = currentColor = (MyColor)((ComboBox)sender).SelectedItem;
            setSliderValue(currentColor.Color);
            currentColor.Name = tempCurrntColor.Name;

        }
    }
}
