using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortfolio.Models
{
    public class Experience
    {
       public int Id { get; set; }
        public string Post { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public int Beginning { get; set; } //год начало и конец
        //public string Ending {
        ////реализуй 
        //}

    }
}
