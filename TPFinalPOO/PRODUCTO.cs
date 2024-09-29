using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalPOO
{
    public abstract class PRODUCTO
    {
        #region propiedades
        public  int ID {  get; set; }
        public string NOMBRE { get; set; }
        public string TIPO { get; set; }

        public double PRECIO { get; set; }
        public int STOCK { get; set; }

        public PRODUCTO(int id, string tipo, string nombre, double precio, int stock)
        {
            this.ID = id;
            this.NOMBRE = nombre;
            this.TIPO = tipo;
            this.PRECIO = precio;
            this.STOCK = stock;
        }

        #endregion
    }

    public class CREMA : PRODUCTO
    {

        public CREMA(int id, string nombre, double precio, int stock)
            : base(id, "CREMA", nombre, precio, stock) { }
    }
    public class PERFUME : PRODUCTO
    {
        public PERFUME(int id, string nombre, double precio, int stock)
            : base(id, "PERFUME", nombre, precio, stock) { }
    }
}
