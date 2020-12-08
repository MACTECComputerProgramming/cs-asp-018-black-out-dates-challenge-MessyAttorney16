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

namespace Black_Out_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime firstDate, secondDate;

        //button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetBlackOutDates(firstDate, secondDate);

            DateTime startTime = firstDate;
            DateTime endTime = secondDate;

            TimeSpan duration = endTime - startTime;

            numberLabel.Content = duration;
        }

        public void secondCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            secondDate = secondCalendar.SelectedDate.Value;
            secondDateLabel.Content = secondDate;
        }

        public void firstCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            firstDate = firstCalendar.SelectedDate.Value;
            firstDateLabel.Content = firstDate;
        }

        private void SetBlackOutDates(DateTime firstDate, DateTime secondDate)
        {
            blackoutCalendar.BlackoutDates.Add(new CalendarDateRange(firstDate, secondDate));
        }

        


    }
}
