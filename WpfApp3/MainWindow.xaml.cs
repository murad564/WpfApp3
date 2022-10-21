using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Button button = new Button();
            //button.Content = "new";
            //listBox1.Items.Add(button);
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = sender as ListBox;
            if (item?.SelectedItem is Label lbl)
            {
                MessageBox.Show(lbl.Content.ToString());
            }
            else if (item?.SelectedItem is Button btn)
            {
                MessageBox.Show(btn.Content.ToString());
            }
        }

        //private void RepeatButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if(sender is RepeatButton rb)
        //    {
        //        switch (rb.Content)
        //        {
        //            case "Down":
        //                if(pbar.Value>0) pbar.Value--;
        //                break;
        //            case "Up":
        //                if (pbar.Value < 100) pbar.Value++;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}

        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (sender is Slider slider)
        //        lbl_fnt.FontSize = slider.Value;
        //}


    }
}