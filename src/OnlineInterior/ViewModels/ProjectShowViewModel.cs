
using OnlineInterior.Models;
using System.Collections.Generic;

namespace OnlineInterior.ViewModels
{
    public class ProjectShowViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public int TotalPrice { get; set; }
        public int AveragePrice { get; set; }
    }

}
