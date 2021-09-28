using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.BL
{
    public class PrendasBL
    {
         public List<Prendas> ObtenerPrendas()    
        {
            var prendas1 = new Prendas();
            prendas1.Id = 1;
            prendas1.Descripcion = "Jeans";
            prendas1.Precio = 300;

            var prendas2 = new Prendas();
            prendas2.Id = 2;
            prendas2.Descripcion = "Camisa";
            prendas2.Precio = 160;

            var prendas3 = new Prendas();
            prendas3.Id = 3;
            prendas3.Descripcion = "Vestido";
            prendas3.Precio = 220;

            var prendas4 = new Prendas();
            prendas4.Id = 4;
            prendas4.Descripcion = "Blusa";
            prendas4.Precio = 140;

            var listadeprendas = new List<Prendas>();
            listadeprendas.Add(prendas1);
            listadeprendas.Add(prendas2);
            listadeprendas.Add(prendas3);
            listadeprendas.Add(prendas4);

            return listadeprendas;
        }
    }
}
