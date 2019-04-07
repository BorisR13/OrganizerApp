using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace My.Calendar
{
    public class MyCalendar : Control
    {
        public ObservableCollection<Day> Days { get; set; }
        public ObservableCollection<string> DayNames { get; set; }
        public static readonly DependencyProperty CurrentDateProperty = DependencyProperty.Register("CurrentDate", typeof(DateTime), typeof(MyCalendar));

        public event EventHandler<DayChangedEventArgs> DayChanged;

        public DateTime CurrentDate
        {
            get { return (DateTime)GetValue(CurrentDateProperty); }
            set { SetValue(CurrentDateProperty, value); }
        }

        static MyCalendar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCalendar), new FrameworkPropertyMetadata(typeof(MyCalendar)));
        }

        public MyCalendar()
        {
            DataContext = this;
            CurrentDate = DateTime.Today;

            DayNames = new ObservableCollection<string> {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Days = new ObservableCollection<Day>();
            BuildCalendar(DateTime.Today);
        }

        public void BuildCalendar(DateTime targetDate)
        {
            Days.Clear();

            //Calculate first day of the month and work out  
            //offset so we can fill in any boxes before that.
            DateTime startDate = new DateTime(targetDate.Year, targetDate.Month, 1);
            int dateNumber = DayOfWeekNumber(startDate.DayOfWeek);
            if (dateNumber != 1)
            {
                startDate = startDate.AddDays(-dateNumber);
            }
            //Show 6 weeks each with 7 days
            for (int box = 1; box <= 42; box++)
            {
                Day day = new Day { Date = startDate, Enabled = true, IsTargetMonth = targetDate.Month == startDate.Month };
                day.PropertyChanged += Day_Changed;
                day.IsToday = startDate == DateTime.Today;
                Days.Add(day);
                startDate = startDate.AddDays(1);
                day.Plans = new Button();
            }
        }

        private void Day_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Notes")
            {
                return;
            }
            if (DayChanged == null) {
                return;
                }

            DayChanged(this, new DayChangedEventArgs(sender as Day));
        }

        private static int DayOfWeekNumber(DayOfWeek dow)
        {
            return Convert.ToInt32(dow.ToString("D"));
        }
    }

    public class DayChangedEventArgs : EventArgs
    {
        public Day Day { get; private set; }

        public DayChangedEventArgs(Day day)
        {
            this.Day = day;
        }
    }
}