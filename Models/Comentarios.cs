using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieFans.Models
{
    public class Comentarios
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Utilizador))]
        public int UtilizadoresID { get; set; }
        public Utilizadores Utilizador{ get; set; }

        [ForeignKey(nameof(Serie))]
        public int SeriesID { get; set; }
        public Series Serie { get; set; }

        public string Comentario { get; set; }

        public int Estrelas { get; set; }
    }
}
