using Microsoft.AspNetCore.Mvc;
using OnlineInterior.Database;
using OnlineInterior.Models;
using OnlineInterior.ViewModels;
using Project = OnlineInterior.Models.Project;

namespace OnlineInterior.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ICollectionOfProjects _collectionOfProducts;
        private readonly AppDbContext _appDbContext;

        public ProjectController(IProjectRepository projectRepository, ICollectionOfProjects collectionOfProducts, AppDbContext appDbContext)
        {
            _projectRepository = projectRepository;
            _collectionOfProducts = collectionOfProducts;
            _appDbContext = appDbContext;
        }

        public ViewResult Show()
        {
            ProjectShowViewModel projectShowViewModel = new ProjectShowViewModel();

            projectShowViewModel.Projects = _collectionOfProducts.AllProjects;
            projectShowViewModel.TotalPrice = _collectionOfProducts.GetCollectionTotalPrice();
            projectShowViewModel.AveragePrice = _collectionOfProducts.GetCollectionAveragePrice();


            return View(projectShowViewModel);
        }

        public IActionResult Details(int id)
        {
            var project = _projectRepository.GetProjectById(id);


            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        public IActionResult Edit(int id)
        {
            var project = _projectRepository.GetProjectById(id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }
        public IActionResult AddOrderline(int id)
        {
            var project = _projectRepository.GetProjectById(id);
            var orderline = new Orderline();

            orderline.ProjectId = project.ProjectId;
            orderline.OrderLineId = project.Orderlines.Count + 1;
            project.Orderlines.Add(orderline);

            return View(orderline);
        }

        [HttpPost]
        public IActionResult Save(Project project)
        {

            var _project = _projectRepository.GetProjectById(project.ProjectId);
            _project.ProjectName = project.ProjectName;
            _project.Creator = project.Creator;

            _appDbContext.SaveChanges();

            return View("_Save");
        }
        [HttpPost]
        public IActionResult SaveOrderline(Orderline orderline)
        {
            var _orderline = orderline;
            var _project = _projectRepository.GetProjectById(orderline.ProjectId);

            _project.Orderlines.Add(_orderline);

            _appDbContext.SaveChanges();

            return View("_Save");
        }

    }
}
