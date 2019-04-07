using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class OrganizerAppController
    {
        private OrganizerContext context;

        public OrganizerAppController()
        {
            this.context = new OrganizerContext();
        }

        // adds a task to the selected day
        public void AddTask(Day day,string taskName, string taskKeyWords, string taskDescription)
        {
            var currentday = SelectDay(day);

            currentday.TaskName = taskName;
            currentday.TaskKeyWords = taskKeyWords;
            currentday.TaskDescription = taskDescription;

            context.Entry(currentday).CurrentValues.
                SetValues(context.Days.Where(x => x.date.Equals(currentday.date)));

            this.context.SaveChanges();
        }

        //deletes the task from the database
        public void RemoveTask(Day day)
        {
            var currentDay = SelectDay(day);

            currentDay.TaskName = null;
            currentDay.TaskKeyWords = null;
            currentDay.TaskDescription = null;

            this.context.SaveChanges();
        }

        //opens the current week , that's going
        public  List<Day> OpenWeek()
        {
            Day today = CheckCurrentDay();
            Week.WeekDays = new List<Day>();

            if (Week.WeekDays.Count > 0)
            {
                Week.WeekDays.Clear();
            }
            
            Week.WeekDays.AddRange(context.Days.Where(x => x.weekID == today.weekID));
            Week.WeekDays.OrderBy(x => x.date).ToList();

            context.SaveChanges();
            return Week.WeekDays;            
        }

        //check what the current day is
        public Day CheckCurrentDay()
        {
            var date = DateTime.Today.Date;

            var currentDay = context.Days.FirstOrDefault(x => x.date.Equals(date));
            return currentDay;
        }

        //Opens the current day of the week
        public Day OpenCurrentDay()
        {
            var weekDays = OpenWeek();
            var today = CheckCurrentDay();
            switch (today.DayName)
            {
                case "Monday":
                    return weekDays[0];
                case "Tuesday":
                    return weekDays[1];
                case "Wednesday":
                    return weekDays[2];
                case "Thursday":
                    return weekDays[3];
                case "Friday":
                    return weekDays[4];
                case "Saturday":
                    return weekDays[5];
                case "Sunday":
                    return weekDays[6];
                default:
                    return null;
            }

        }

        //selects a date when it is not the date today
        public Day SelectDay(Day day)
        {
            var weekDays = OpenWeek();
            Day selectedDay = context.Days.FirstOrDefault(x => x.DayName.Equals(day.DayName));

            switch (selectedDay.DayName)
            {
                case "Monday":
                    return weekDays[0];
                case "Tuesday":
                    return weekDays[1];
                case "Wednesday":
                    return weekDays[2];
                case "Thursday":
                    return weekDays[3];
                case "Friday":
                    return weekDays[4];
                case "Saturday":
                    return weekDays[5];
                case "Sunday":
                    return weekDays[6];
                default:
                    return null;
            }

        }

        //add an activity for the todo list
        public void AddActivity(ToDoActivity activity, string name)
        {
            context.Activities.Add(activity);

            var newActivity = activity;

            newActivity.Activity = name;

            context.Entry(newActivity).CurrentValues.SetValues(activity);
        }

    }
}
