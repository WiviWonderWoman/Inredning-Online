using Microsoft.EntityFrameworkCore;
using OnlineInterior.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineInterior.Models
{
    public class OrderlineRepository : IOrderlineRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderlineRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Orderline> AllOrderlines
        {
            get
            {
                return _appDbContext.Orderlines.Include(o => o.Project);
            }
        }

        public int GetLineTotal
        {
            get
            {
                return GetLineTotal;
            }
        }

        public Orderline GetOrderlineById(int orderlineId)
        {
            return _appDbContext.Orderlines.FirstOrDefault(o => o.OrderLineId == orderlineId);
        }
    }
}
