using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMilhao.Models
{
    public class Pergunta
    {

        public int Id { get; set; }
        public string Enunciado { get; set; }

        public List<Alternativa> Alternativas { get; set; }
    }
}
