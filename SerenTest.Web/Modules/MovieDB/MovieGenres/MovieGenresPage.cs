using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenTest.MovieDB.Pages
{

    [PageAuthorize(typeof(MovieGenresRow))]
    public class MovieGenresController : Controller
    {
        [Route("MovieDB/MovieGenres")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/MovieGenres/MovieGenresIndex.cshtml");
        }
    }
}