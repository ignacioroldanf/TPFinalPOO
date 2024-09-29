
namespace MODELO
{
    public class CLIENTE
    {
        #region propiedades
        private int _id;
        public void setID(int id)
        {
            _id = id;
        }
        public int getID()
        {
            return _id;
        }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        private int _edad;
        public void setEdad(int edad)
        {
            _edad = edad;
        }
        public int getEDAD()
        {
            return _edad;
        }
        public string EMAIL { get; set; }

        public CLIENTE(int id, string n, string a, int e, string m)
        {
            _id = id;
            NOMBRE = n;
            APELLIDO = a;
            _edad = e;
            EMAIL = m;
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
