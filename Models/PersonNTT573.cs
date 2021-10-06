using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiTrang573.Models
{
    public class PersonNTT573
    {
        [Key]
        
        public int PersonId { get; set; }
        
        public string PersonName { get; set; }

       
    }
}