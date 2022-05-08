using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_Szpital.Interface;
using Projekt_Szpital.Models;
namespace Testy
{
    class ControllerTest
    {
        [TestClass]
        public class PacjentControllerTest
        {
            [TestMethod]
            public void TestStanu()
            {
                var controller = new PacjentController();
                var result = controller.Details(5) as ViewResult;
                Assert.AreEqual("Stan_przyjecia", result.ViewName);
            }
        }
        public class PacjentController : Controller
        {
            public ActionResult Index()
            {
                
                throw new NotImplementedException();
            }

            public ActionResult Details(int Id)
            {
                var pacjent = new Pacjent(12341234, "nowoprzyjenty");
                return View("Stan_przyjecia", pacjent);
            }
        }
        [TestClass]
        public class PacjentControllerTestDwa
        {
            [TestMethod]
            public void TestDetailsViewData()
            {
                var controller = new PacjentController();
                var result = controller.Details(2) as ViewResult;
                var product = (Pacjent)result.ViewData.Model;
                Assert.AreEqual(12341234, "nowoprzyjenty");
            }
        }


        public class PacjentControllerDwa : Controller
        {
            public ActionResult Index()
            {
                throw new NotImplementedException();
            }
            public ActionResult Details(int Id)
            {
                if (Id < 1)
                {
                    return RedirectToAction("Index");
                }
                var pacjent = new Pacjent(12341234, "nowoprzyjenty");
                return View("Stan_przyjecia", pacjent);
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
