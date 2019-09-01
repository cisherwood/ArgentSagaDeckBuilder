﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArgentSagaDeckBuilder.Data
{
    public class Card
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }


        
    }
}
