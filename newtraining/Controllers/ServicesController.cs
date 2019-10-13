using Microsoft.AspNetCore.Mvc;
using newtraining.Data.Interfaces;
using newtraining.ViewModels;

namespace newtraining.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IAllServices _allServices;
        private readonly IServiceCategory _allserviceCategory;

        public ServicesController(IAllServices iAllServices, IServiceCategory iServiceCat)
        {
            _allServices = iAllServices;
            _allserviceCategory = iServiceCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Услуги";
            ServiceListViewModel obj = new ServiceListViewModel();
            obj.AllServices = _allServices.AllServices;
            obj.currCategory = "Услуги вот такие вот";
            return View(obj);
        }
    }
}
