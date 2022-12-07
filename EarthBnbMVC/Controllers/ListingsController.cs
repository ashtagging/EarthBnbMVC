using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EarthBnb.Models
{
    public class Listing
    {

        [Required]
        public int Id { get; set; }

        public string Location { get; set; }

        public int MaxGuests { get; set; }

        public int NightCost { get; set; }

        public DateTime DateOfBirth { get; set; }
        public DateTime AvailableDates { get; set; }

        public float StarScore { get; set; }

        public int Bedrooms { get; set; }

        public int ServiceFee { get; set; }

        public string Description { get; set; }
    }
}