using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPartialAsync.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult GetData()
        {
            System.Threading.Thread.Sleep(3000);
            Models.PopulationModel model = new Models.PopulationModel();
            model.regions = new List<Models.Region>() {
                new Models.Region () {
                    RegionName = "Europe",
                     Population =739207742,
                     Area =22131968
                },
                 new Models.Region () {
                    RegionName = "Asia",
                     Population =4478315164,
                     Area =31034755
                },
                  new Models.Region () {
                    RegionName = "North America",
                     Population =363224006,
                     Area =18626872
                },
                   new Models.Region () {
                    RegionName = "Latin America",
                     Population =647565336,
                     Area =20110725
                },
                   new Models.Region () {
                    RegionName = "Oceania",
                     Population =40467040,
                     Area =8430633
                },
                    new Models.Region () {
                    RegionName = "Africa",
                     Population =1246504865,
                     Area =29678687
                }
            };
            return View(model);
        }

        public ActionResult Sections()
        {
           
            return View();
        }
    }
}