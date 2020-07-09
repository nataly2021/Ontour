using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
     public class ServicioCliente : AbstractServices<CLIENTE>
    {
        public override void AddEntity(CLIENTE entity)
        {


            // Crear CLIENTE
            CLIENTE CLIENTE = GetEntity(entity.Rut_Cliente);
            if (CLIENTE == null)
            {
                // Insertar una actividad empresa
                em.CLIENTE.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el Cliente");
            }


        }


        public override List<CLIENTE> GetEntities()
        {
            return em.CLIENTE.ToList<CLIENTE>();
        }

        public override List<CLIENTE> GetEntity()
        {

            return em.CLIENTE.ToList<CLIENTE>();
        }

        public override void DeleteEntity(object key)
        {
            //Eliminar cliente por rut 
            CLIENTE cliente = GetEntity(key);
            if (cliente != null)
            {
                em.CLIENTE.Remove(cliente);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar Cliente , debido a que existe o esta relacionado  ");

            }
        }

        public override CLIENTE GetEntity(object key)
        {
            
            return em.CLIENTE.Where(a => a.Rut_Cliente == (string)key).FirstOrDefault<CLIENTE>();
        }

       
        public override void UpdateEntity(CLIENTE entity)
        {
            //Actualizar Cliente por Rut de cliente
            CLIENTE cliente = GetEntity(entity.Rut_Cliente);
            if (cliente != null)
            {
                cliente.Nombre_Completo = entity.Nombre_Completo;
                cliente.Apellido_Completo = entity.Apellido_Completo;
                cliente.Corre_Electronico = entity.Corre_Electronico;
                cliente.Tipo_Cliente = entity.Tipo_Cliente;
                cliente.Telefono = entity.Telefono;

                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de cliente");
            }
        }

    }
}

