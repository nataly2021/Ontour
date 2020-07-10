using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
    public class ServicioProductos : AbstractServices<PRODUCTOS>
    {
        public override void AddEntity(PRODUCTOS entity)
        {

            // Crear PRODUCTOS
            PRODUCTOS productos = GetEntity(entity.ID_Producto);
            if (productos == null)
            {

                em.PRODUCTOS.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el productos");
            }

        }

        public override List<PRODUCTOS> GetEntities()
        {
            return em.PRODUCTOS.ToList<PRODUCTOS>();
        }

        public override List<PRODUCTOS> GetEntity()
        {

            return em.PRODUCTOS.ToList<PRODUCTOS>();
        }

        public override void DeleteEntity(object key)
        {
            //Eliminar producto
            PRODUCTOS productos = GetEntity(key);
            if (productos != null)
            {
                em.PRODUCTOS.Remove(productos);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar productos , debido a que existe o esta relacionado  ");

            }
        }

        public override PRODUCTOS GetEntity(object key)
        {

            return em.PRODUCTOS.Where(a => a.ID_Producto == (string)key).FirstOrDefault<PRODUCTOS>();
        }

       

        public override void UpdateEntity(PRODUCTOS entity)
        {
            //Actualizar producto 

            PRODUCTOS productos = GetEntity(entity.ID_Producto);
            if (productos != null)
            {
                productos.Nombre_Paquete = entity.Nombre_Paquete;
                productos.Precio_Unitario = entity.Precio_Unitario;
                productos.Detalle_Producto = entity.Detalle_Producto;

                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de productos");
            }
        }
    }
}
