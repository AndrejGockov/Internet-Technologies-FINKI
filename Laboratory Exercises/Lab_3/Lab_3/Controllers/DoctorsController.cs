﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab_3.Models;

namespace Lab_3.Controllers
{
    public class DoctorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Doctors
        public ActionResult Index()
        {
            var doctors = db.Doctors.Include(d => d.Hospital);
            return View(doctors.ToList());
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Name");
            return View();
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,HospitalId")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Name", doctor.HospitalId);
            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Name", doctor.HospitalId);
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,HospitalId")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Name", doctor.HospitalId);
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor doctor = db.Doctors.Find(id);
            db.Doctors.Remove(doctor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult AddNewPatient(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }

            ViewBag.DoctorId = doctor.Id;
            ViewBag.DoctorName = doctor.Name;
            ViewBag.PatientId = new SelectList(db.Patients.ToList(), "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNewPatient(int doctorId, int patientId)
        {
            var doctor = db.Doctors.Include(d => d.Patients).FirstOrDefault(d => d.Id == doctorId);
            var patient = db.Patients.Find(patientId);

            if (doctor == null || patient == null)
            {
                return HttpNotFound();
            }

            if (!doctor.Patients.Contains(patient))
            {
                doctor.Patients.Add(patient);
                db.SaveChanges();
            }

            return RedirectToAction("Details", new { id = doctorId });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemovePatient(int doctorId, int patientId)
        {
            var doctor = db.Doctors.Include(d => d.Patients).FirstOrDefault(d => d.Id == doctorId);
            var patient = db.Patients.Find(patientId);

            if (doctor == null || patient == null)
            {
                return HttpNotFound();
            }

            if (doctor.Patients.Contains(patient))
            {
                doctor.Patients.Remove(patient);
                db.SaveChanges();
            }

            return RedirectToAction("Details", new { id = doctorId });
        }
    }
}
