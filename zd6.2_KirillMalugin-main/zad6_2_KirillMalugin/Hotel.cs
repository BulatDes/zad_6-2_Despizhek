using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace zad6_2_KirillMalugin
{
    public class Hotel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Director { get; set; }
        public string Phone { get; set; }
        public int Category { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public DateTime CheckInDate { get; set; }
        public int StayDuration { get; set; }
        public bool IsPaymentCash { get; set; }
        public ImageSource imageSource { get; set; }
    }
}
