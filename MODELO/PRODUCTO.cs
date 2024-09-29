using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class PRODUCTO
    {
        #region propiedades
        private int _id;
        public void setID(int id)
        {
            _id = id;
        }
        public int getId()
        {
            return _id;
        }
        public required string NOMBRE {  get; set; }
        public required string DESCRIPCION {  get; set; }
        
        public double PRECIO { get; set; }
        public int STOCK {  get; set; }

        public PRODUCTO(int id, string nombre, string descripcion, double precio, int stock)
        {
            this._id = id;
            this.NOMBRE = nombre;
            this.DESCRIPCION = descripcion;
            this.PRECIO = precio;
            this.STOCK = stock;
        }

        #endregion
    }

    public class CREMA : PRODUCTO
    {
        public CREMA(int id, string tipo, string nombre, double precio, int stock)
            : base (id,tipo, nombre, precio, stock) { tipo = "CREMA"; }
    }
    public class PERFUME : PRODUCTO
    {
        public PERFUME(int id, string tipo, string nombre, double precio, int stock)
            : base(id, tipo, nombre, precio, stock) { tipo = "PERFUME"; }
    }
}
