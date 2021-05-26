using System.Collections.Generic;

namespace OnlineInterior.Models
{
    public interface IProjectRepository
    {
        IEnumerable<Orderline> Orderlines { get; }
        Project GetProjectById(int projectId);
        public int GetProjectPrice();
    }
}
