﻿using System;
using System.Collections.Generic;
using System.Text;
using Enumecomp0.Entities.Enums;

namespace Enumecomp0.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
