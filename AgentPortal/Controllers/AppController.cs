using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AgentPortal.Models;

namespace AgentPortal.Controllers
{
    public class AppController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("PersonalInfo");
        }

        public ActionResult PersonalInfo()
        {
            return View("~/Views/App/Pages/PersonalInfo.cshtml");
        }

        public ActionResult Documents()
        {
            return View("~/Views/App/Pages/Documents.cshtml");
        }

        public ActionResult Eligibility()
        {
            return View("~/Views/App/Pages/Eligibility.cshtml");
        }

        public ActionResult PlanDevice()
        {
            return View("~/Views/App/Pages/PlanDevice.cshtml");
        }
        public ActionResult Payments()
        {
            return View("~/Views/App/Pages/Payments.cshtml");
        }
        public ActionResult Enroll()
        {
            return View("~/Views/App/Pages/Enroll.cshtml");
        }


        public ActionResult DeviceList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Devices> _device = new List<Devices>();
                _device.Add(new Devices(2454790, 46545646556, 445646, "", "Tablet", "", "Unfulfilled Orders", "", 10));
                DataSourceResult result = _device.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult SIMList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<SIMS> _sim = new List<SIMS>();
                _sim.Add(new SIMS(2454790, 46545646556, "Pending"));
                _sim.Add(new SIMS(2454770, 46545646332, "Pending"));
                DataSourceResult result = _sim.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult PaymentList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Payments> _payment = new List<Payments>();
                _payment.Add(new Payments("Starter Plan", "$ 2.0", "Pending"));
                _payment.Add(new Payments("Device Price", "$ 10.0", "Pending"));
                DataSourceResult result = _payment.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
        public ActionResult OrderList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Orders> _order = new List<Orders>();
                _order.Add(new Orders(2743903, "Joshuva", "Daniel", "Device not assigned", "", "Enrolled"));
                DataSourceResult result = _order.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult DocumentList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Documents> _document = new List<Documents>();
                _document.Add(new Documents("Document Type 1", "Eception Code 1", "08-10-2023 5:30 PM", "Agent 007", "gov-id-card.pdf"));
                _document.Add(new Documents("Document Type 2", "Eception Code 2", "08-10-2023 5:30 PM", "Agent 007", "driving-license.pdf"));
                DataSourceResult result = _document.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult CoverageList([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                List<Coverage> _coverage = new List<Coverage>();
                _coverage.Add(new Coverage("Provider Name 1", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 2", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 3", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 4", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 5", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 6", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 7", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 8", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 9", "Yes", "Yes", "Sample Remarks"));
                _coverage.Add(new Coverage("Provider Name 10", "Yes", "Yes", "Sample Remarks"));
                DataSourceResult result = _coverage.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
    }
}
