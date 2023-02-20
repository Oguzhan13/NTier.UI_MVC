namespace NTier.UI_MVC_GenericRepositoryAndBusiness.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public IActionResult Create()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            _personService.Create(person);
            return RedirectToAction("Index");
        }        

        [HttpGet]
        public IActionResult Index()
        {
            List<Person> persons = _personService.GetAllPersons().OrderBy(x => x.FirstName).ToList();
            return View(persons);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Person person = _personService.GetById(id);
            return View(person);
        }        
        [HttpPost]
        public IActionResult Update(Person person)
        {
            _personService.Update(person);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Active(int id) 
        {
            Person person = _personService.GetById(id);
            person.IsActive = true;
            _personService.Update(person);            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Person person = _personService.GetById(id);
            return View(person);
        }
    }
}