using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS2.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }
        
        public int streetNumber { get; set; }
        
        public string street { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public int postcode { get; set; }
        [Required]
        public string country { get; set; }

        //Foreign Key
        public int studentId { get; set; }
        //Navigation property
        public virtual Student student { get; set; }
    }
}
