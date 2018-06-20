using HeroFlix.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroFlix.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime AssistidoEm { get; set; }
        public StatusFilme Status { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public string Elenco { get; set; }
    }
}
