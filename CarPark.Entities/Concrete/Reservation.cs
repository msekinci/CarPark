﻿using System;

namespace CarPark.Entities.Concrete
{
    public class Reservation : BaseModel
    {
        public string ImagePath { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Price { get; set; }
        public bool IsExit { get; set; }
        public bool IsPayment { get; set; }
        public ReservationDetail ReservationDetail { get; set; }

    }
}
