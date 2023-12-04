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

namespace calcpriject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GamePage : Window
    {
        public GamePage()
        {
            InitializeComponent();
        }
         internal class gamepage
        {
        
    }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string age = AgeTextBox.Text;
            GamePage gamepage = new GamePage();
            this.Visibility = Visibility.Hidden;
            gamepage.Show();

        }

    }

   
}