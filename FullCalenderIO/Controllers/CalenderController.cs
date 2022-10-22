using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FullCalenderIO.Models;

namespace FullCalenderIO.Controllers
{
    public class CalenderController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new CalendarIndexViewModel();


            viewModel.CalendarItems.Add(new CalendarItem() { id = 1, start = "2018-01-03", title = "Holiday A" });

            viewModel.CalendarItems.Add(new CalendarItem() { id = 2, start = "2018-01-04", title = "Holiday C" });
            viewModel.CalendarItems.Add(new CalendarItem() { id = 3, start = "2018-01-04", title = "Holiday D" });
            viewModel.CalendarItems.Add(new CalendarItem() { id = 4, start = "2018-01-04", title = "Holiday E" });
            viewModel.CalendarItems.Add(new CalendarItem() { id = 5, start = "2018-01-04", title = "Holiday F" });
            viewModel.CalendarItems.Add(new CalendarItem() { id = 6, start = "2018-01-04", title = "Holiday G" });
            viewModel.CalendarItems.Add(new CalendarItem() { id = 7, start = "2018-01-04", title = "Holiday B" });
            viewModel.CalendarItems.Add(new CalendarItem() { id = 8, start = "2018-01-04", title = "Holiday H" });


            return View(viewModel);
        }

        public ActionResult HolidayCreate(string date)
        {
            var viewModel = new CalenderCreateViewModel();
            var selectedDT = DateTime.ParseExact(date, "yyyyMMdd", null);

            return PartialView("_HolidayCreate", viewModel);
        }

        [HttpPost]
        public ActionResult HolidayCreate(CalenderCreateViewModel viewModel)
        {
            return View();
        }

        public ActionResult HolidayUpdate(int holidayID)
        {
            var viewModel = new CalenderUpdateViewModel();

            viewModel.HolidayID = holidayID;

            return PartialView("_HolidayUpdate", viewModel);
        }

        [HttpPost]
        public ActionResult HolidayUpdate(CalenderUpdateViewModel viewModel)
        {
            return View();
        }
    }
}