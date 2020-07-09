using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
    public class ServicioSeguro: AbstractServices<SEGURO>
    {
        public override void AddEntity(SEGURO entity)
        {


            // CrearSEGURO
            SEGURO seguro = GetEntity(entity.ID_Seguro);
            if (seguro == null)
            {

                em.SEGURO.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("Seguro ya existe, No es posible grabar");
            }


        }

        public override List<SEGURO> GetEntities()
        {
            return em.SEGURO.ToList<SEGURO>();
        }

        public override List<SEGURO> GetEntity()
        {

            return em.SEGURO.ToList<SEGURO>();
        }

        public override void DeleteEntity(object key)
        {
            //Eliminar Seguro
            SEGURO seguro = GetEntity(key);
            if (seguro != null)
            {
                em.SEGURO.Remove(seguro);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar seguro , debido a que existe o esta relacionado  ");

            }
        }

        public override SEGURO GetEntity(object key)
        {

            return em.SEGURO.Where(a => a.ID_Seguro == (decimal)key).FirstOrDefault<SEGURO>();

        }


        public override void UpdateEntity(SEGURO entity)
        {
            //Actualizar Seguro
            SEGURO seguro = GetEntity(entity.ID_Seguro);
            if (seguro != null)
            {
                seguro.Nombre_Seguro = entity.Nombre_Seguro;
                seguro.Monto_Seguro = entity.Monto_Seguro;
                seguro.CONTRATO_NRO_Contrato = entity.CONTRATO_NRO_Contrato;



                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de seguro");
            }
        }

    }
}
