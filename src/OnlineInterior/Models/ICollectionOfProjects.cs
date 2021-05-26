using System.Collections.Generic;

namespace OnlineInterior.Models
{
    public interface ICollectionOfProjects
    {
        IEnumerable<Project> AllProjects { get; }
        int GetCollectionTotalPrice();
        int GetCollectionAveragePrice();

    }
}

