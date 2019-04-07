using Business;
using Data;
using Data.Entities;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace OrganizerApp
{
    /// <summary>
    /// Interaction logic for ThursdayPage.xaml
    /// </summary>
    public partial class ThursdayPage : Page
    {
        OrganizerAppController controller = new OrganizerAppController();
        OrganizerContext context = new OrganizerContext();
        public ThursdayPage()
        {
            InitializeComponent();
        }

        private void Return_button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Day currentDay = Week.WeekDays[0];
            controller.AddTask(currentDay, title.Text, key_words.Text, description.Text);
            context.SaveChanges();

            title.Clear();
            key_words.Clear();
            description.Clear();
        }
    }
}
