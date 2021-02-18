using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Athlete
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        
        public string Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime NextFight { get; set; }


    }
}
