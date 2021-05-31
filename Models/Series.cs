using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieFans.Models
{
    public class Series
    {
        public Series()
        {
            ListaDeComentarios = new HashSet<Comentarios>();
        }
        [Key]
        public int ID { get; set; }

        public string Serie { get; set; }

        public string Sinopse { get; set; }

        public int Episodios { get; set; }

        public string Estado { get; set; }

        public int Ano { get; set; }

        public string Imagem { get; set; }

        [ForeignKey(nameof(Estudio))]
        public int EstudioID { get; set; }
        public Estudios Estudio { get; set; }

        public ICollection<Comentarios> ListaDeComentarios { get; set; }
    }
}
