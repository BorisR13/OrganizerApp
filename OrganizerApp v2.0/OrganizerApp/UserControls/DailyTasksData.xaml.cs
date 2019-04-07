using Business;
using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace OrganizerApp.UserControls
{
    /// <summary>
    /// Interaction logic for DailyTasksData.xaml
    /// </summary>
    public partial class DailyTasksData : UserControl
    {
        OrganizerAppController controller = new OrganizerAppController();
        OrganizerContext context = new OrganizerContext();

        public DailyTasksData()
        {
            InitializeComponent();
            Load();
        }        

        private void Load()
        {
            List<Day> viewDays = controller.OpenWeek();
            tasks.ItemsSource = viewDays.Where(x => x.TaskName != null);
            tasks.Items.Refresh();
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            controller.RemoveTask(controller.SelectDay(new Day()));
            this.context.SaveChanges();
            tasks.Items.Refresh();
        }
    }
}
