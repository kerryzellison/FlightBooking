﻿namespace FlightBooking.Models
{
    public class Airport
    {
        public string IataID { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public Airport(string iataID, string country, string state)
        {
            IataID = iataID;
            Country = country;
            State = state;
        }
    }
}