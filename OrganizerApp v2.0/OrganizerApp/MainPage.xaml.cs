using Business;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public OrganizerAppController controller;

        public MainPage()
        {
            InitializeComponent();
            controller = new OrganizerAppController();                     
            
            
        }
        private void Weekly_Plans(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WeeklyPlansPage());
            controller.OpenWeek();
        }
    }
}
