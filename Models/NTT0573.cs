using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiTrang573.Models
{
    public class NTT0573
    {
        [Key]
        
        public int NTTId { get; set; }
        
        public string NTTName { get; set; }

       public string NTTGender { get; set; }
    }
}