using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CountryApp.Models
{
    public class Country
    {   
        [Key]   
        public int Id {get; set;}
        public required string CountryName {get; set;}
        public required string CountryCode {get; set;}
        public required string Flag {get; set;}
        public required string CapitalName {get; set;}
        public  string? CapitalImg {get; set;}
        public string? TelCode {get; set;}
        
        
    }
}