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
            var BMonth = Birthday.DisplayDate.Month;
            var BDay = Birthday.DisplayDate.Day;
            
            var CYear = DateTime.Now.Year;
            var CMonth = DateTime.Now.Month;
            var CDay = DateTime.Now.Day;

            var yearsOld = CYear - BYear;

            if (CMonth < BMonth && !((CMonth == BMonth) && CDay<BDay)) yearsOld--;
            
            if (yearsOld < 0 || yearsOld > 135)
            {
                MessageBox.Show(" the date you entered is not correct, you can't be " + yearsOld + " years old",
                    "ErrorMessage");
            }
            else
            {
                Print_Age(CDay,BDay,CMonth,BMonth,yearsOld);
                
                Print_Zodiac(BDay,BMonth);
                
                Print_Chinese(BYear);
            }
        }

        private void Print_Age(int CDay,int BDay,int CMonth,int BMonth,int yearsOld)
        {
            if (CDay==BDay && CMonth==BMonth)
            {
                age.Text = yearsOld.ToString() + " Happy birthday!";
            }
            else
            {
                age.Text = yearsOld.ToString();
            }
        }

        private void Print_Zodiac(int BDay, int BMonth)
        {
            switch (BMonth)
                {
                    case 1:
                        zodiac.Text = BDay > 19 ? "Aquarius" : "Capricorn";
                        break;
                    case 2:
                        zodiac.Text = BDay > 18 ? "Pisces" : "Aquarius";
                        break;
                    case 3:
                        zodiac.Text = BDay > 20 ? "Aries" : "Pisces";
                        break;
                    case 4:
                        zodiac.Text = BDay > 19 ? "Taurus" : "Aries";
                        break;
                    case 5:
                        zodiac.Text = BDay > 20 ? "Gemini" : "Taurus";
                        break;
                    case 6:
                        zodiac.Text = BDay > 21 ? "Cancer" : "Gemini";
                        break;
                    case 7:
                        zodiac.Text = BDay > 22 ? "Leo" : "Cancer";
                        break;
                    case 8:
                        zodiac.Text = BDay > 22 ? "Virgo" : "Leo";
                        break;
                    case 9:
                        zodiac.Text = BDay > 22 ? "Libra" : "Virgo";
                        break;
                    case 10:
                        zodiac.Text = BDay > 23 ? "Scorpius" : "Libra";
                        break;
                    case 11:
                        zodiac.Text = BDay > 21 ? "Sagittarius" : "Scorpius";
                        break;
                    case 12:
                        zodiac.Text = BDay > 21 ? "Capricorn" : "Sagittarius";
                        break;
                }
        }

        private void Print_Chinese(int BYear)
        {
            switch (BYear % 12)
            {
                case 0:
                    chinese.Text = "Monkey";
                    break;
                case 1:
                    chinese.Text = "Rooster";
                    break;
                case 2:
                    chinese.Text = "Dog";
                    break;
                case 3:
                    chinese.Text = "Pig";
                    break;
                case 4:
                    chinese.Text = "Rat";
                    break;
                case 5:
                    chinese.Text = "Ox";
                    break;
                case 6:
                    chinese.Text = "Tiger";
                    break;
                case 7:
                    chinese.Text = "Rabbit";
                    break;
                case 8:
                    chinese.Text = "Dragon";
                    break;
                case 9:
                    chinese.Text = "Snake";
                    break;
                case 10:
                    chinese.Text = "Horse";
                    break;
                case 11:
                    chinese.Text = "Goat";
                    break;
            }
        }
    }
}