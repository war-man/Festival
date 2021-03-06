﻿using Festival.Data.Models;
using Festival.Data.Repositories;
using Festival.Web.Areas.Admin.ViewModels.TransferReservation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Festival.Web.Controllers;

namespace Festival.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TransferReservationController : BaseController
    {
        private readonly ITransferReservationRepository _repo;

        public TransferReservationController(ITransferReservationRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {

            var model = _repo.GetAll().Select(x => new TransferReservationListVM
            {
                ID = x.ID,
                FullName = x.Attendee.FirstName + " " + x.Attendee.LastName,
                Email = x.Attendee.Email,
                Date = x.TransferService.Date,
                MeetingPoint = x.TransferService.MeetingPoint
            }).ToList();

            return View(model);
        }

        public IActionResult New()
        {
            NewTransferReservationVM model = new NewTransferReservationVM()
            {
                Attendees = _repo.GetAllAttendees().Select(o => new SelectListItem
                {
                    Value = o.ID.ToString(),
                    Text = o.FirstName + " " + o.LastName
                }).ToList(),
                TransferServices = _repo.GetAllServices().Select(o => new SelectListItem
                {
                    Value = o.ID.ToString(),
                    Text = o.TransferVehicle.Name + " - " + o.MeetingPoint + " - " + o.Date.ToString()
                }).ToList()
            };

            return View(model);
        }

        public IActionResult SaveNew(NewTransferReservationVM model)
        {
            var reservation = new TransferReservation()
            {
                AttendeeID = model.AttendeeID,
                TransferServiceID = model.TransferServiceID
            };
            _repo.Add(reservation);
            return RedirectToAction("List");
        }

        public IActionResult Detail(int ID)
        {
            var reservation = _repo.GetByID(ID);
            var model = new DetailTransferReservationVM()
            {
                ID = reservation.ID,
                AttendeeEmail = reservation.Attendee.Email,
                AttendeeName = reservation.Attendee.FirstName + " " + reservation.Attendee.LastName,
                VehicleName = reservation.TransferService.TransferVehicle.Name,
                MeetingPoint = reservation.TransferService.MeetingPoint,
                DateOfService = reservation.TransferService.Date
            };

            return View(model);
        }

        public IActionResult Delete(int ID)
        {
            _repo.Delete(ID);
            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            var model = new EditTransferReservationVM()
            {
                ID = Id,
                Attendees = _repo.GetAllAttendees().Select(o => new SelectListItem
                {
                    Value = o.ID.ToString(),
                    Text = o.FirstName + " " + o.LastName
                }).ToList(),
                TransferServices = _repo.GetAllServices().Select(o => new SelectListItem
                {
                    Value = o.ID.ToString(),
                    Text = o.TransferVehicle.Name + " - " + o.MeetingPoint + " - " + o.Date.ToString()
                }).ToList()
            };

            return View(model);
        }

        public IActionResult Save(EditTransferReservationVM model)
        {
            var reservation = _repo.GetByID(model.ID);
            reservation.AttendeeID = model.AttendeeID;
            reservation.TransferServiceID = model.TransferServiceID;
            _repo.Save();
            return RedirectToAction("List");
        }
    }
}
