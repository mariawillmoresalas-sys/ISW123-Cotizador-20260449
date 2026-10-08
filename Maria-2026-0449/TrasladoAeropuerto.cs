using System;
using System.Collections.Generic;
using System.Text;

namespace Maria_2026_0449
{
    public class TrasladoAeropuerto
    {
        public int Pasajeros { get; set; }
        public bool Nocturno { get; set; }

        public decimal Subtotal => Pasajeros * 25m;
        public decimal Recargo => Nocturno ? Subtotal * 0.20m : 0m;
        public decimal Total => Subtotal + Recargo;
    }
}
