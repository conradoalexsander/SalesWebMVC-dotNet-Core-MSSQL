﻿using SalesWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            this.id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
