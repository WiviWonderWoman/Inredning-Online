using Microsoft.AspNetCore.Mvc;
using OnlineInterior.Database;
using OnlineInterior.Models;

namespace OnlineInterior.Controllers
{
    public class OrderlineController : Controller
    {
        private readonly IOrderlineRepository _orderlineRepository;
        private readonly AppDbContext _appDbContext;
        public OrderlineController(IOrderlineRepository orderlineRepository, AppDbContext appDbContext)
        {
            _orderlineRepository = orderlineRepository;
            _appDbContext = appDbContext;

        }

        public IActionResult Edit(int id)
        {
            var ordeline = _orderlineRepository.GetOrderlineById(id);
            if (ordeline == null)
            {
                return NotFound();
            }

            return View(ordeline);
        }

        [HttpPost]
        public IActionResult Save(Orderline orderline)
        {
            var _orderline = _orderlineRepository.GetOrderlineById(orderline.OrderLineId);
            _orderline.ProductName = orderline.ProductName;
            _orderline.Supplier = orderline.Supplier;
            _orderline.Amount = orderline.Amount;
            _orderline.UnitPrice = orderline.UnitPrice;

            _appDbContext.SaveChanges();

            return View("_Save");
        }
    }
}
