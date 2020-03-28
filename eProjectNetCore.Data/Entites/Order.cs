﻿using eProjectNetCore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eProjectNetCore.Data.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public AppUser AppUser { get; set; }





    }
}
