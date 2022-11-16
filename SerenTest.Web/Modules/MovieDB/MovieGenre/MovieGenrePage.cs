using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenTest.MovieDB.Pages
{

    [PageAuthorize(typeof(MovieGenreRow))]
    public class MovieGenreController : Controller
    {
        [Route("MovieDB/MovieGenre")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/MovieGenre/MovieGenreIndex.cshtml");
        }
    }
}