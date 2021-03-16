using System;
using System.Windows;
using TRPO_Lab3.Lib;

namespace TRPO_Lab4.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }


        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txt_Result.Text = Convert.ToString(Math_1.Formula(Convert.ToDouble(txt_Height.Text), Convert.ToDouble(txt_Radius.Text)));
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверно введено число.");
            }        
        }
    }
}
