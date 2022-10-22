using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullCalenderIO.Models
{
    public class CalendarIndexViewModel
    {
        public string DefaultDT { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public List<CalendarItem> CalendarItems { get; set; } = new List<CalendarItem>();
    }

    public class CalendarItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string start { get; set; }
    }

    public class CalenderCreateViewModel
    {
        public bool IsSuccess { get; set; }

        public string ErrorMsg { get; set; } = "Unexpected server error.";

    }

    public class CalenderUpdateViewModel
    {
        public int HolidayID { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorMsg { get; set; } = "Unexpected server error.";

    }
}