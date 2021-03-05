using System;
using System.Windows;
using TRPO_Lab4.WPF;

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
                Formula.Radius = Convert.ToDouble(txt_Radius.Text);
                Formula.Height = Convert.ToDouble(txt_Height.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверно введено число.");
            }
            Formula.Solve();
            txt_Result.Text = Convert.ToString(Formula.Result);
                     
        }
    }
}
