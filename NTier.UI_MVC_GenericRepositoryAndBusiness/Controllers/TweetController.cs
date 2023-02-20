namespace NTier.UI_MVC_GenericRepositoryAndBusiness.Controllers
{
    public class TweetController : Controller
    {
        private readonly ITweetService _tweetService;
        public TweetController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            Tweet tweet = new Tweet() { PersonId = id };
            return View(tweet);
        }
        [HttpPost]
        public IActionResult Create(Tweet tweet)
        {
            _tweetService.Create(tweet);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Tweet> tweets = _tweetService.GetAll().OrderByDescending(x => x.Id).ToList();            
            return View(tweets);
        }
        [HttpGet]
        public IActionResult PersonTweets(int id) 
        {
            List<Tweet> tweets = _tweetService.GetAll();
            if (tweets.Any(x => x.PersonId == id))
            {                
                return View(_tweetService.GetAllByPersonId(id).OrderByDescending(x => x.Id).ToList());
            }
            else
            {
                return RedirectToAction(nameof(Create), new {id});
            }              
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _tweetService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Tweet tweet = _tweetService.GetById(id);
            return View(tweet);
        }
        [HttpPost]
        public IActionResult Update(Tweet tweet)
        {
            _tweetService.Update(tweet);
            return RedirectToAction(nameof(Index)); 
        }
        [HttpGet]
        public IActionResult Active(int id)
        {
            Tweet tweet = _tweetService.GetById(id);
            tweet.IsActive = true;
            _tweetService.Update(tweet);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Tweet tweet = _tweetService.GetById(id);
            return View(tweet);
        }
    }
}
