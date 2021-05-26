using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineInterior.Models
{
    public class Project
    {
        [Required]
        public int ProjectId { get; set; }

        [Display(Name = "Projekt")]
        public string ProjectName { get; set; }

        [Display(Name = "Inredare")]
        public string Creator { get; set; }
        public List<Orderline> Orderlines { get; set; }
        public int GetProjectPrice()
        {
            var projectPrice = 0;
            foreach (var orderline in Orderlines)
            {
                projectPrice += orderline.GetLineTotal();
            }
            return projectPrice;
        }
    }
}
