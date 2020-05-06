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
    /// Interaction logic for Task1Form.xaml
    /// </summary>
    public partial class Task1Form : Window
    {
        List<Student> studentsList = new List<Student>();
        public int counter = 0;
        public Task1Form()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            bool isReg = false;
            if (chYes.IsChecked == true)
            {
                isReg = true;
            }

            studentsList.Add(new Student { Id = id, FirstName = fname, LastName = lname, IsRegistered = isReg });
            counter++;
            MessageBox.Show("There are " + counter + " students Added in the list", "Total No of Students", MessageBoxButton.OK, MessageBoxImage.Information);
        } 
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRegistered { get; set; }
    }
}
