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

namespace WPFAppQuiz3
{
    /// <summary>
    /// Interaction logic for Task2Form.xaml
    /// </summary>
    public partial class Task2Form : Window
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Student> stdList = new List<Student>()
            {
                new Student(){ Id=6151001, FirstName= "Alice", LastName= "Ronald", IsRegistered= true},
                new Student(){ Id=6151002, FirstName= "Kiara", LastName= "Claude", IsRegistered= false},
                new Student(){ Id=6151003, FirstName= "John", LastName= "Mauvre", IsRegistered= false},
                new Student(){ Id=6151004, FirstName= "Paul", LastName= "Kumar", IsRegistered= true},
                new Student(){ Id=6151005, FirstName= "Tarun", LastName= "Rudra", IsRegistered= true}
            };
            this.stdDatagrid.ItemsSource = stdList;
        }
    }
}
