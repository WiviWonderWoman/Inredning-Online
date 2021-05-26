using System.Collections.Generic;

namespace OnlineInterior.Models
{
    public interface IOrderlineRepository
    {
        IEnumerable<Orderline> AllOrderlines { get; }
        public int GetLineTotal { get; }
        Orderline GetOrderlineById(int orderlineId);
    }
}
