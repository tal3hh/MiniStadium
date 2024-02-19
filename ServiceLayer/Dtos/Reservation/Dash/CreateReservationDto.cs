﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Dtos.Reservation.Dash
{
    public class CreateReservationDto
    {
        public int areaId { get; set; }
        public string? ByName { get; set; }
        public decimal Price { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime Date { get; set; }
    }
}
