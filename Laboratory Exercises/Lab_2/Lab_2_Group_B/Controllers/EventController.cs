using Lab_2_Group_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_2_Group_B.Controllers
{
    public class EventController : Controller
    {
        private static int newId = 0;
        private static List<EventModel> allEvents = new List<EventModel>();
        public ActionResult Index()
        {
            return View(allEvents);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EventModel newEvent)
        {
            if (!ModelState.IsValid)
                return View();

            newId++;
            newEvent.id = newId;
            allEvents.Add(newEvent);
            return RedirectToAction("Details", new { id = newEvent.id });
        }

        public ActionResult Edit(int id)
        {
            foreach(var evnt in allEvents)
                if(id == evnt.id)
                    return View(evnt);
            return View("Index");
        }

        [HttpPost]
        public ActionResult Edit(EventModel newEvent)
        {
            if (!ModelState.IsValid)
                return View();
            
            foreach (var other in allEvents)
            {
                if (other.id == newEvent.id)
                {
                    other.name = newEvent.name;
                    other.location = newEvent.location;
                    break;
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            foreach(var evnt in allEvents)
                if(id == evnt.id)
                    return View(evnt);
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            foreach (var item in allEvents) {
                if (item.id == id) { 
                    allEvents.Remove(item);
                    break;
                }
            }
            return RedirectToAction("Index");
        }
    }
}