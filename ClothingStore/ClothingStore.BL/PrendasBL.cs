using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.BL
{
    public class PrendasBL
    {
        Contexto _contexto;
        public List<Prendas> ListadePrendas { get; set; }
        public PrendasBL()
        {
            _contexto = new Contexto();
            ListadePrendas = new List<Prendas>();
        }
         public List<Prendas> ObtenerPrendas()    
        {   
            ListadePrendas = _contexto.Prendas.ToList();
            return ListadePrendas;
        }
    }
}
