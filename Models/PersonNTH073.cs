using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiHanh073.Models
{
    public class PersonNTH073
    {
        [Key]
        public int  PersonId { get; set; }
        public string PersonName { get; set; }

    
    }
}