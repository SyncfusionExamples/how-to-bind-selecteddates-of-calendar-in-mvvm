using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarAppointment
{
    public class CalendarViewModel : INotifyPropertyChanged
    {
        private List<DateTime> selectedDates;
        public List<DateTime> SelectedDates
        {
            get { return selectedDates; }
            set
            {
                selectedDates = value;
                RaisePropertyChanged("SelectedDates");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public CalendarViewModel()
        {
            SelectedDates = new List<DateTime>();
            SelectedDates.Add(DateTime.Now.Date);
            SelectedDates.Add(DateTime.Now.Date.AddDays(1));
            SelectedDates.Add(DateTime.Now.Date.AddDays(2));
        }

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
    }
}
