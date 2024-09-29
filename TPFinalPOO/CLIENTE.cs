using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalPOO
{
    public class CLIENTE
    {
        #region propiedades
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public int EDAD {  get; set; }
        public string EMAIL { get; set; }

        public CLIENTE(int id, string n, string a, int e, string m)
        {
            ID = id;
            NOMBRE = n;
            APELLIDO = a;
            EDAD = e;
            EMAIL = m;
        }

        public CLIENTE()
        {
        }

        private List<PRODUCTO> ListaDeProductos = new List<PRODUCTO>();
        #endregion

        #region metodos

        public void AgregarProductoAlCarrito(PRODUCTO ProductoElegido)
        {
            this.ListaDeProductos.Add(ProductoElegido);
        }
        public void EliminarProductoDelCarrito(PRODUCTO ProductoElegido)
        {
            this.ListaDeProductos.Remove(ProductoElegido);
        }
        public List<PRODUCTO> VerProductos()
        {
            return this.ListaDeProductos;
        }



        #endregion
    }
}
