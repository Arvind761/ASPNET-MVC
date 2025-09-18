using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabMVC.Controllers
{
    public class DataPassController : Controller
    {
        #region ViewData
        public ViewResult IndexViewData()
        {
            ViewData["Id"] = 101;
            ViewData["Name"] = "Rahul";
            ViewData["Fee"] = 2500;


            return View();
        }
        public ViewResult IndexViewDataQ(int? id,string name,double? fee)
        {
            ViewData["Id"] = id;
            ViewData["Name"] = name;
            ViewData["Fee"] = fee;


            return View();
        }
        #endregion

        #region ViewBag
        public ViewResult IndexViewBag()
        {
            ViewBag.Id = 102;
            ViewBag.Name = "Dav";
            ViewBag.Fee = 20000;

            return View();
        }
        public ViewResult IndexViewBagQ(int? id,string name, double? fee)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Fee = fee;

            return View();
        }
        #endregion


    }
}