using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrganizerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OrganizerAppController controller;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            MainPage page = new MainPage();
            controller = new OrganizerAppController();
            Pages.Content= page;
            
        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Home_Window(object sender, RoutedEventArgs e)
        {
            MainPage page = new MainPage();
            Pages.Content = page;
        }

        private void Weekly_Plans(object sender, RoutedEventArgs e)
        {
            WeeklyPlansPage plans = new WeeklyPlansPage();
            Pages.Content = plans;
            controller.OpenWeek();
        }

        private void Daily_Plans(object sender, RoutedEventArgs e)
        {
            DateTime day = DateTime.Today;
            var today = day.DayOfWeek;
            controller.OpenCurrentDay();
            switch (today)
            {
                case DayOfWeek.Sunday:
                    Pages.Content = new SundayPage();
                    break;
                case DayOfWeek.Monday:
                    Pages.Content = new MondayPage();
                    break;
                case DayOfWeek.Tuesday:
                    Pages.Content = new TuesdayPage();
                    break;
                case DayOfWeek.Wednesday:
                    Pages.Content = new WednesdayPage();
                    break;
                case DayOfWeek.Thursday:
                    Pages.Content = new ThursdayPage();
                    break;
                case DayOfWeek.Friday:
                    Pages.Content = new FridayPage();
                    break;
                case DayOfWeek.Saturday:
                    Pages.Content = new SaturdayPage();
                    break;
                default:
                    break;
            }
        }

        private void Calendar_Button(object sender, RoutedEventArgs e)
        {
            Pages.Content = new CalendarPage();
        }
    }
}


