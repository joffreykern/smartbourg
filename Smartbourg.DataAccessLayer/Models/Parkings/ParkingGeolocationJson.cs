﻿using System.Runtime.Serialization;

namespace Smartbourg.DataAccessLayer.Models.Parkings
{
    [DataContract]
    internal class ParkingGeolocationJson
    {
        [DataMember(Name = "x")]
        public decimal Longitude { get; set; }

        [DataMember(Name = "y")]
        public decimal Latitude { get; set; }
    }
}