using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieFans.Models
{
    public class Estudios
    {
        public Estudios()
        {
            ListaDeSeries = new HashSet<Series>();
        }
        [Key]
        public int ID { get; set; }

        public string Estudio { get; set; }
        //logotipo e país
        public ICollection<Series> ListaDeSeries { get; set; }
    }
}
