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

namespace calcpriject
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        private int Number1;
        private int Number2;
        private int Correctanswer;

        // Constructor
        public Window2()
        {
            InitializeComponent(); // This is necessary to initialize the window components
        }

        public void game(int gamekind)
        {
            Random random = new Random();
            Number1 = random.Next(1, 10); 
            Number2 = random.Next(1, 10);
        }
        public double add(double number1, double number2)
        {
            return number1 + number2;
        }

      

        public double subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return number1 / number2;

        }
        


    }
        }
