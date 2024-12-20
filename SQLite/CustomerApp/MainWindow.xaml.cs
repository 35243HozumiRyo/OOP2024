﻿using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {

            if (NameTextBox.Text == string.Empty || PhoneTextBox.Text == string.Empty || AddressTextBox.Text == string.Empty) {
                MessageBox.Show("すべてに文字を入力してください");
                return;
            }

            byte[] image = null;

            if (PictureImage.Source != null) {
                var bitImage = PictureImage.Source as BitmapImage;
                if (bitImage != null) {
                    using (var memoryStream = new System.IO.MemoryStream()) {
                        BitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitImage));
                        encoder.Save(memoryStream);
                        image = memoryStream.ToArray();
                    }
                }
            }

            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = image,
            };
            
            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDatabase(); //ListView表示

            NameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            PictureImage.Source = null;
            SearchTextBox.Text = string.Empty;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {

            var item = CustomerListView.SelectedItem as Customer;

            if (item == null) {
                MessageBox.Show("更新したい行を選択してください");
                return;
            }

            if (NameTextBox.Text == string.Empty || PhoneTextBox.Text == string.Empty || AddressTextBox.Text == string.Empty) {
                MessageBox.Show("すべてに文字を入力してください");
                return;
            }

            byte[] image = null;

            if (PictureImage.Source != null) {
                var bitmapImage = PictureImage.Source as BitmapImage;
                if (bitmapImage != null) {
                    using (var memoryStream = new System.IO.MemoryStream()) {
                        BitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                        encoder.Save(memoryStream);
                        image = memoryStream.ToArray();
                    }
                }
            }

            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;
            item.Picture = image;


            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(item);
            }
            ReadDatabase(); //ListView表示

            NameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            PictureImage.Source = null;
            SearchTextBox.Text = string.Empty;
        }
        //ListView表示
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x=>x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if(item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);

                ReadDatabase(); //ListView表示

            }

            NameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            PictureImage.Source = null;
            SearchTextBox.Text = string.Empty;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase(); //ListView表示
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                return;
            }
            NameTextBox.Text = item.Name;
            PhoneTextBox.Text = item.Phone;
            AddressTextBox.Text = item.Address;
            if (item.Picture != null) {
                var image = new BitmapImage();
                using (var memoryStream = new System.IO.MemoryStream(item.Picture)) {
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = memoryStream;
                    image.EndInit();
                }

                PictureImage.Source = image;
            } else {
                PictureImage.Source = null;
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            {
                if (openFileDialog.ShowDialog() == true) {
                    PictureImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                }
            }
        }
    }
}
