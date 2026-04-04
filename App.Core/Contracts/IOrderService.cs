using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Contracts
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(string id);
        void Add(Order order);
        void Update(Order order);
        void Delete(string id);
        List<Order> GetByCustomerId(string customerId);
        List<Order> GetByStatus(OrderStatusEnum status);
    }
}
