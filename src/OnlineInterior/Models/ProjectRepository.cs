using Microsoft.EntityFrameworkCore;
using OnlineInterior.Database;
using System.Collections.Generic;
using System.Linq;

namespace OnlineInterior.Models
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _appDbContext;
        
        public ProjectRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }

        public IEnumerable<Orderline> Orderlines
        {
            get
            {
                return _appDbContext.Orderlines.Include(o => o.Project);
            }
        }

        public Project GetProjectById(int projectId)
        {
            return _appDbContext.Projects.Include(p => p.Orderlines).FirstOrDefault(p => p.ProjectId == projectId);
        }

        public int GetProjectPrice()
        {
            int total = 0;
            foreach (var orderline in Orderlines)
            {
                total += orderline.GetLineTotal();
            }
            return total;
        }
    }
}
