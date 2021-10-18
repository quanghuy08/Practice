using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Practice.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icons> Icons;
        //private List<Product> Product;
        private ObservableCollection<Product> Product;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icons>();
            Icons.Add(new Icons { Icon = "Assets/anh1.jpg" });
            Icons.Add(new Icons { Icon = "Assets/anh2.jpg" });
            Icons.Add(new Icons { Icon = "Assets/anh3.jpg" });
            Icons.Add(new Icons { Icon = "Assets/anh4.jpg" });

            //Product = new List<Product>();
            Product = new ObservableCollection<Product>();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icons)ImageComboBox.SelectedValue).Icon;
            Product.Add(new Product { Products = DescriptionTextBox.Text, Description = DescriptionTextBox.Text, Image = avatar });
            ProductsTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductsTextBox.Focus(FocusState.Programmatic);
        }
    }
}
