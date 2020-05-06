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

namespace WPFAppQuiz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, RoutedEventArgs e)
        {
            Task1Form task1Form = new Task1Form();
            task1Form.Show();
        }

        private void btnTask2_Click(object sender, RoutedEventArgs e)
        {
            Task2Form task2Form = new Task2Form();
            task2Form.Show();
        }

        private void btnTask3_Click(object sender, RoutedEventArgs e)
        {
            List<int> numList = new List<int>();
            numList.Add(55);
            numList.Add(200);
            numList.Add(740);
            numList.Add(76);
            numList.Add(230);
            numList.Add(482);
            numList.Add(95);

            string members = "";
            foreach (int num in numList)
            {
                members += num+" ";
                
            }

            string output = "";
            foreach (int num in numList)
            {
                if (num > 80)
                {
                    output += num;
                    output += "\n";
                }
            }

            MessageBox.Show("The members of the list are: "+ members +
                            "\nThe numbers greater than 80 are:\n"+ output,"Result"
                             ,MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
