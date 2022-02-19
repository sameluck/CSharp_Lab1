using System;
using System.Windows;

namespace CSharp_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var BYear = Birthday.DisplayDate.Year;
            var BMonth = Birthday.DisplayDate.Month + 1;
            var BDay = Birthday.DisplayDate.Day;
            
            var CYear = DateTime.Now.Year;
            var CMonth = DateTime.Now.Month + 1;
            var CDay = DateTime.Now.Day;

            var yearsOld = CYear - BYear;

            if (CMonth < BMonth && !((CMonth == BMonth) && CDay<BDay)) yearsOld--;
            
            if (yearsOld < 0 || yearsOld > 135)
            {
                MessageBox.Show(" the date you entered is not correct, you can't be " + yearsOld + " years old",
                    "ErrorMessage");
            }
        }
    }
}