using Microsoft.EntityFrameworkCore;
using OnlineInterior.Database;
using System.Collections.Generic;
using System.Linq;

namespace OnlineInterior.Models
{
    public class CollectionOfProjectsRepository : ICollectionOfProjects
    {
        private readonly IProjectRepository _projectRepository;
        private readonly AppDbContext _appDbContext;

        public CollectionOfProjectsRepository(IProjectRepository projectRepository, AppDbContext appDbContext)
        {
            _projectRepository = projectRepository;
            _appDbContext = appDbContext;

        }
        public IEnumerable<Project> AllProjects
        {
            get
            {
                return _appDbContext.Projects.Include(p => p.Orderlines);
            }
        }

        public int GetCollectionAveragePrice()
        {
            int total = GetCollectionTotalPrice();
            int amount = _appDbContext.Projects.Count();
            int average = total / amount;
            return average;
        }

        public int GetCollectionTotalPrice()
        {
            int total = 0;
            IEnumerable<Project> projects = AllProjects;
            foreach (var project in projects)
            {
                total += _projectRepository.GetProjectPrice();
            }
            return total;
        }
    }
}
