using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieFans.Models
{
    public class Utilizadores
    {
        public Utilizadores()
        {
            ListaDeComentarios = new HashSet<Comentarios>();
        }
        [Key]
        public int ID { get; set; }

        public string Utilizador { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public ICollection<Comentarios> ListaDeComentarios { get; set; }
        
    }
}
