using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gpay.Core.Models.Entities
{
    public class Cards
    {
        [Key]
        public string adviceReference { get; set; }
        public string token { get; set; }
        
    }
}