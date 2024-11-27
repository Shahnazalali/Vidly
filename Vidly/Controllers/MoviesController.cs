using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var Movie = new Movie() {Name="Shrik!" };

            var customers =new List<Customer>()
            {
                new Customer{Name="customer 1"},
                new Customer{Name="customer 2"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie=  Movie,
                Customers= customers
            };
       
            return View(viewModel);
           
        }

        [Route("/Movies/Released/{Year}/{Month:regex(\\d{{1,2}})}")]
        public IActionResult ByReleaseDay(int Year,int Month)
        {
           

            // return View(Movie);
            return Content(Year + "/"+ Month);
        }
    }
}
