using Business;
using Data;
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
    /// Interaction logic for SundayPage.xaml
    /// </summary>
    public partial class SundayPage : Page
    {
        OrganizerAppController controller = new OrganizerAppController();
        OrganizerContext context = new OrganizerContext();
        public SundayPage()
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
