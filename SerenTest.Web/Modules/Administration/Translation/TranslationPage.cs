using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenTest.Administration.Pages
{
    [PageAuthorize(PermissionKeys.Translation)]
    public class TranslationController : Controller
    {
        [Route("Administration/Translation")]
        public ActionResult Index()
        {
            return View(MVC.Views.Administration.Translation.TranslationIndex);
        }
    }
}