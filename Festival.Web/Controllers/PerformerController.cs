﻿using Festival.Data.Repositories;
using FestivalWebApplication.ViewModels.Performer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FestivalWebApplication.Controllers
{
    [Authorize]
    public class PerformerController : Controller
    {
        private readonly IPerformerRepository _repo;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public PerformerController(IWebHostEnvironment environment, IPerformerRepository repo)
        {
            _hostingEnvironment = environment;
            _repo = repo;
        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            //fetching all records from Performer
            List<PerformersListVM> Model = _repo.GetAll().Select(p => new PerformersListVM
            {
                PerformerID = p.ID,
                PerformerName = p.Name,
                ManagerName = p.Manager.Name
            }).ToList();

            //ordered list
            int broj = 0;
            foreach (PerformersListVM x in Model)
            {
                x.Number = ++broj;
            }
            return View(Model);
        }

        public IActionResult New()
        {
            NewPerformerVM Model = new NewPerformerVM();
            return View(Model);
        }

        //public IActionResult SaveNew(NewPerformerVM Model)
        //{
        //    //creating new manager object
        //    Manager manager = new Manager();
        //    manager.Name = Model.ManagerName;
        //    manager.PhoneNumber = Model.ManagerPhoneNumber;
        //    manager.Email = Model.ManagerEmail;
        //    //adding new manager to db first, to be able to assign managerID to a performer
        //    _db.Manager.Add(manager);
        //    _db.SaveChanges();

        //    //creating a new performer object
        //    Performer performer = new Performer();
        //    performer.Name = Model.Name;
        //    performer.Fee = Model.Fee;
        //    performer.PromoText = Model.PromoText;
        //    performer.ManagerID = manager.ID;
        //    _db.Performer.Add(performer);
        //    _db.SaveChanges();

        //    //building a filepath and name
        //    string fileName = "image" + performer.ID.ToString() + Path.GetExtension(Model.Image.FileName);
        //    string folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "images/performerImages");
        //    string filePath = Path.Combine(folderPath, fileName);

        //    //uploading an image using a helper method
        //    ImageUpload.UploadImageToFolder(Model.Image, filePath);

        //    Image image = new Image();
        //    image.ImagePath = Path.Combine("~/images/performerImages/", fileName);
        //    //saving an image first, to get an imageID which will be saved in a performer object
        //    _db.Image.Add(image);
        //    _db.SaveChanges();

        //    performer.ImageID = image.Id;
        //    _db.SaveChanges();

        //    return RedirectToAction("List");
        //}

        //public IActionResult Edit(int id)
        //{
        //    //fetching performer and manager objects
        //    Performer x = _db.Performer.Find(id);
        //    Manager m = _db.Manager.Find(x.ManagerID);

        //    EditPerformerVM Model = new EditPerformerVM();
        //    Model.Id = x.ID;
        //    Model.Name = x.Name;
        //    Model.Fee = x.Fee;
        //    Model.PromoText = x.PromoText;
        //    if (x.ImageID != null)
        //        Model.ImagePath = _db.Image.Find(x.ImageID).ImagePath;
        //    Model.ManagerId = m.ID;
        //    Model.ManagerName = m.Name;
        //    Model.ManagerPhoneNumber = m.PhoneNumber;
        //    Model.ManagerEmail = m.Email;

        //    return View("Edit", Model);

        //}
        //public IActionResult Save(EditPerformerVM Model)
        //{
        //    //finding performer in db
        //    Performer x = _db.Performer.Find(Model.Id);
        //    //changing data
        //    x.Name = Model.Name;
        //    x.Fee = Model.Fee;
        //    x.PromoText = Model.PromoText;

        //    //check if there is a new image, and overwrite the previous one if there is
        //    if (Model.Image != null)
        //    {
        //        string fileName = "image" + x.ID.ToString() + Path.GetExtension(Model.Image.FileName);
        //        string folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "images/performerImages");
        //        string filePath = Path.Combine(folderPath, fileName);

        //        ImageUpload.UploadImageToFolder(Model.Image, filePath);
        //    }

        //    //fetching a manager object
        //    Manager m = _db.Manager.Find(Model.ManagerId);
        //    m.Name = Model.ManagerName;
        //    m.PhoneNumber = Model.ManagerPhoneNumber;
        //    m.Email = Model.ManagerEmail;

        //    _db.SaveChanges();

        //    return RedirectToAction("List");

        //}

        //public IActionResult Delete(int id)
        //{

        //    Performer x = _db.Performer.Find(id);
        //    Manager m = _db.Manager.Find(x.ManagerID);

        //    _db.Manager.Remove(m);
        //    _db.Performer.Remove(x);

        //    _db.SaveChanges();

        //    return RedirectToAction("List");
        //}
    }
}
