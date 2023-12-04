using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

public class HomeController : Controller
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<HomeController> _logger;

    public HomeController(AppDbContext dbContext, ILogger<HomeController> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
     public IActionResult AddPost()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddPost(GameReview review)
    {
        if (ModelState.IsValid)
        {
            
            _dbContext.GameReviews.Add(review);
            _dbContext.SaveChanges();

           
            return RedirectToAction("Review", review);
        }

     
        return View(review);
    }

    public IActionResult Review()
    {
       
        var reviews = _dbContext.GameReviews.ToList();
        return View(reviews); 
    }
    public IActionResult GameRatings()
    {
     
        var gameReviews = _dbContext.GameReviews.ToList();

        return View(gameReviews);
    }
    [HttpPost]
  
    public IActionResult SubmitRating(int gameId, int rating)
    {
        var gameReview = _dbContext.GameReviews.Include(g => g.Ratings).FirstOrDefault(g => g.Id == gameId);

        if (gameReview != null)
        {
            var gameRating = new GameRating { GameId = gameId, Rating = rating };
            gameReview.Ratings.Add(gameRating);

     
            gameReview.Rating = gameReview.Ratings.Any() ? (int)gameReview.Ratings.Average(r => r.Rating) : 0;

            _dbContext.SaveChanges();
        }

        return RedirectToAction("GameRatings");
    }
}