using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class Quadro
    {
        public String enunciado { get; set; }
        public String resposta { get; set; }

        public Quadro(String enunciado, String resposta)
        {
            this.enunciado = enunciado;
            this.resposta = resposta;
        }

        public Quadro(String enunciado)
        {
            this.enunciado = enunciado;
        }
    }
}
