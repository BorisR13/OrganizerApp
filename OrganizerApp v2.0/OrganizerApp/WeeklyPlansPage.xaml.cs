using Business;
using Data.Entities;
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

namespace OrganizerApp
{
    /// <summary>
    /// Interaction logic for WeeklyPlansPage.xaml
    /// </summary>
    public partial class WeeklyPlansPage : Page
    {
        public OrganizerAppController controller;
        public WeeklyPlansPage()
        {
            InitializeComponent();
            controller = new OrganizerAppController();
            controller.OpenWeek();
        }

        public static DependencyProperty ChildContentProperty =
             DependencyProperty.Register("ChildContent", typeof(object),
             typeof(WeeklyPlansPage), new FrameworkPropertyMetadata(null));

        public object ChildContent
        {
            get { return (object)GetValue(ChildContentProperty); }
            set { SetValue(ChildContentProperty, value); }
        }

        private void MondayBtn_Click(object sender, RoutedEventArgs e)
        {
            MondayPage monday = new MondayPage();
            controller.SelectDay(Week.WeekDays[0]);
            NavigationService.Navigate(monday);
        }

        private void TuesdayBtn_Click(object sender, RoutedEventArgs e)
        {
            TuesdayPage tuesday = new TuesdayPage();
            controller.SelectDay(Week.WeekDays[1]);
            NavigationService.Navigate(tuesday);
        }

        private void WednesdayBtn_Click(object sender, RoutedEventArgs e)
        {
            WednesdayPage wednesday = new WednesdayPage();
            controller.SelectDay(Week.WeekDays[2]);
            NavigationService.Navigate(wednesday);
        }

        private void ThursdayBtn_Click(object sender, RoutedEventArgs e)
        {
            ThursdayPage thursday = new ThursdayPage();
            controller.SelectDay(Week.WeekDays[3]);
            NavigationService.Navigate(thursday);
        }

        private void FridayBtn_Click(object sender, RoutedEventArgs e)
        {
            FridayPage friday = new FridayPage();
            controller.SelectDay(Week.WeekDays[4]);
            NavigationService.Navigate(friday);
        }

        private void SaturdayBtn_Click(object sender, RoutedEventArgs e)
        {
            SaturdayPage saturday = new SaturdayPage();
            controller.SelectDay(Week.WeekDays[5]);
            NavigationService.Navigate(saturday);
        }

        private void SundayBtn_Click(object sender, RoutedEventArgs e)
        {
            SundayPage sunday = new SundayPage();
            controller.SelectDay(Week.WeekDays[6]);
            NavigationService.Navigate(sunday);
        }

        private void Return_button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
