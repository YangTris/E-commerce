﻿using Entity;
using Microsoft.AspNetCore.Mvc;
using MVC_model.Models;
using Service;
using Service.Implementation;

namespace MVC_model.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        public OrderController(IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _orderService.GetAll().Select(order => new IndexOrderViewModel
            {
                orderID = order.orderID,
                OrderDate = order.OrderDate,
                FirstName = order.FirstName,
                LastName = order.LastName,
                Address = order.Address,
                Phone = order.Phone,
                Email = order.Email,
                Total = order.Total,
                paymentID = order.paymentID,
                //OrderDetails = order.OrderDetails,
            }).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateOrderViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var order = new Order
                {
                    orderID = model.orderID,
                    OrderDate = model.OrderDate,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Phone = model.Phone,
                    Email = model.Email,
                    Total = model.Total,
                    paymentID = model.paymentID,
                    //OrderDetails = model.OrderDetails
                };
            }
            return View();
        }
        [HttpGet]
        public IActionResult Detail(string id)
        {
            
            var order = _orderService.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            var model = new DetailOrderViewModel
            {
                orderID = order.orderID,
                OrderDate = order.OrderDate,
                FirstName = order.FirstName,
                LastName = order.LastName,
                Address = order.Address,
                Phone = order.Phone,
                Email = order.Email,
                Total = order.Total,
                paymentID = order.paymentID,
                listItem = _orderDetailService.getOrderDetail(order.orderID),
            };
            return View(model);
        }
    }
}
