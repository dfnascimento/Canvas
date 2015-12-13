using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class PNPeso
    {
        public static Peso getPeso()
        {
            try
            {
                CanvasEntities2 db = new CanvasEntities2();

                var p = (from peso in db.Pesoes
                         select peso).Count();

                if (p == 0)
                {
                    Peso peso = new Peso();
                    peso.Peso_Quadro_1 = 1;
                    peso.Peso_Quadro_2 = 1;
                    peso.Peso_Quadro_3 = 1;
                    peso.Peso_Quadro_4 = 1;
                    peso.Peso_Quadro_5 = 1;
                    peso.Peso_Quadro_6 = 1;
                    peso.Peso_Quadro_7 = 1;
                    peso.Peso_Quadro_8 = 1;
                    peso.Peso_Quadro_9 = 1;

                    db.Pesoes.Add(peso);
                    db.SaveChanges();
                }

                Peso pe = (from peso in db.Pesoes
                           where peso.Id == 1
                          select peso ).First();

                return pe;
            }
            catch (Exception)
            {
                throw;
            }    
        }

        public static bool setPeso(Peso p)

        {
            try {
                CanvasEntities2 db = new CanvasEntities2();

                Peso pe = (from peso in db.Pesoes
                           where peso.Id == 1
                           select peso).First();

                pe.Peso_Quadro_1 = p.Peso_Quadro_1;
                pe.Peso_Quadro_2 = p.Peso_Quadro_2;
                pe.Peso_Quadro_3 = p.Peso_Quadro_3;
                pe.Peso_Quadro_4 = p.Peso_Quadro_4;
                pe.Peso_Quadro_5 = p.Peso_Quadro_5;
                pe.Peso_Quadro_6 = p.Peso_Quadro_6;
                pe.Peso_Quadro_7 = p.Peso_Quadro_7;
                pe.Peso_Quadro_8 = p.Peso_Quadro_8;
                pe.Peso_Quadro_9 = p.Peso_Quadro_9;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }





    }
}
