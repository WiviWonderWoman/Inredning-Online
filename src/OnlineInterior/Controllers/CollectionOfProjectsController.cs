using Microsoft.AspNetCore.Mvc;
using OnlineInterior.Database;
using OnlineInterior.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineInterior.Controllers
{
    public class CollectionOfProjectsController : Controller
    {
        
        private readonly ICollectionOfProjects _collectionOfProducts;
        private readonly AppDbContext _appDbContext;

        public CollectionOfProjectsController(ICollectionOfProjects collectionOfProducts, AppDbContext appDbContext)
        {
            
            _collectionOfProducts = collectionOfProducts;
            _appDbContext = appDbContext;
        }

        public IActionResult AddProject()
        {
            var project = new Project();
            var collection = _collectionOfProducts.AllProjects;

            project.ProjectId = collection.Count() + 1;
            _appDbContext.Projects.Add(project);

            return View(project);
        }
        [HttpPost]
        public IActionResult SaveCollection(Project project)
        {
            var _project = project;
            _project.Orderlines = new List<Orderline>();
            _project.ProjectName = project.ProjectName;
            _appDbContext.Projects.Add(project);
            _appDbContext.SaveChanges();

            return View("_Save");
        }
    }
}
