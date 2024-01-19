using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Inheritance.Models
{
    public class Studentdetails{
    [Key]    
    public string Name {get;set;}=string.Empty;
    public string Rollno {get;set;}=string.Empty;
    }
    public class Percentage:Studentdetails
    {
        public string totalpercentage {get;set;}=string.Empty;
    }
    public class Address:Studentdetails
    {
        public string Permanentaddress {get;set;}=string.Empty;
    }
}