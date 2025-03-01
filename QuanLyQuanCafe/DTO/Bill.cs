﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount=0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];

            var dateCheckOutTemp= row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }

        private int discount;
        private int status;
        public int Status { get => status; set => status = value; }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }

        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }

        private int iD;
        public int ID { get => iD; set => iD = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
