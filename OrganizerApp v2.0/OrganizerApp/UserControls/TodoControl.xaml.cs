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
    /// Interaction logic for TodoControl.xaml
    /// </summary>
    public partial class TodoControl : UserControl
    {
        OrganizerAppController controller = new OrganizerAppController();
        OrganizerContext context = new OrganizerContext();
        public TodoControl()
        {
            InitializeComponent();
        }

        int count = 0;

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            switch (count)
            {
                case 0:
                    Task_1.Content = Input.Text;
                    Task_1.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 1:
                    Task_2.Content = Input.Text;
                    Task_2.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 2:
                    Task_3.Content = Input.Text;
                    Task_3.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 3:
                    Task_4.Content = Input.Text;
                    Task_4.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 4:
                    Task_5.Content = Input.Text;
                    Task_5.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 5:
                    Task_6.Content = Input.Text;
                    Task_6.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 6:
                    Task_7.Content = Input.Text;
                    Task_7.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 7:
                    Task_8.Content = Input.Text;
                    Task_8.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 8:
                    Task_9.Content = Input.Text;
                    Task_9.Visibility = Visibility.Visible;
                    count++;
                    break;
                case 9:
                    Task_10.Content = Input.Text;
                    Task_10.Visibility = Visibility.Visible;
                    count++;
                    break;
            }
            this.Input.Text.Remove(0);
            this.Input.Clear();
        }
    }
}
