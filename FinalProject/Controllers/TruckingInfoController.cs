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

    }
}
