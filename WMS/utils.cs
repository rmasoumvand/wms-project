using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace WMS
{
    class utils
    {
        private static utils instance;
        private PersianCalendar dtePersianCalendar;

        private utils() { 
            this.dtePersianCalendar = new PersianCalendar();
        }

        public static utils Instance {
            get {
                if (instance == null)
                    instance = new utils();
                return instance;
            }
        }
        
        public String getPersianDate() {
            DateTime dateTime = DateTime.Now;
            String year = dtePersianCalendar.GetYear(dateTime).ToString();
            String month = dtePersianCalendar.GetMonth(dateTime).ToString();
            String day = dtePersianCalendar.GetDayOfMonth(dateTime).ToString();
            return (year + "/" + month + "/" + day);
        }
    }
}
