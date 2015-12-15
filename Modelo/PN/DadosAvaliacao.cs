using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class DadosAvaliacao
    {
        public String nomeAvaliador { get; set; }
        public int mediaAritimetica { get; set; }
        public int mediaPonderada { get; set; }

        public DadosAvaliacao( String nomeAvaliador, int mediaAr, int mediaPon)
        {
            this.nomeAvaliador = nomeAvaliador;
            this.mediaAritimetica = mediaAr;
            this.mediaPonderada = mediaPon;
        }

    }
}
