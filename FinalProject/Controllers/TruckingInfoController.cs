using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class TruckingInfoController : Controller
    {
        private readonly ITruckingInfoRepository repo;

        public TruckingInfoController(ITruckingInfoRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var truckingInfos = repo.GetAllInfo();
            return View(truckingInfos);
        }

        public IActionResult ViewTruckingInfo(int id)
        {
            var truckinginfo = repo.GetInfo(id);
            return View(truckinginfo);
        }

        public IActionResult UpdateTruckingInfo(int id)
        {
            TruckingInfo prod = repo.GetInfo(id);    // can use info instead of prod
            if (prod == null)
            {
                return View("TruckingInfoNotFound");
            }
            return View(prod);
        }

        public IActionResult UpdateTruckingInfoToDatabase(TruckingInfo info)
        {
            repo.UpdateTruckingInfo(info);

            return RedirectToAction("ViewTruckingInfo", new { id = info.TruckID });
        }

        public IActionResult InsertTruckingInfo()
        {
            var prod = repo.AssignCategory();
            return View(prod);
        }

        public IActionResult InsertTruckingInfoToDatabase(TruckingInfo infoToInsert)
        {
            repo.InsertTruckingInfo(infoToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTruckingInfo(TruckingInfo info)
        {
            repo.DeleteTruckingInfo(info);
            return RedirectToAction("Index");
        }
    }
}
