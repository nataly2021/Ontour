using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
    public class ServicioDetalleAbono : AbstractServices<DETALLE_ABONO>
    {
        public override void AddEntity(DETALLE_ABONO entity)
        {
            //throw new NotImplementedException();
            DETALLE_ABONO detalle_abono = GetEntity(entity.ABONOS_Nro_Abono);
            if (detalle_abono == null)
            {

                em.DETALLE_ABONO.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el  Detalle de Abono");
            }

        }

        public override List<DETALLE_ABONO> GetEntities()
        {
            return em.DETALLE_ABONO.ToList<DETALLE_ABONO>();
        }

        public override void DeleteEntity(object key)
        {

            DETALLE_ABONO DETALLE_ABONO = GetEntity(key);
            if (DETALLE_ABONO != null)
            {
                em.DETALLE_ABONO.Remove(DETALLE_ABONO);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar Detalle de Abono , debido a que existe o esta relacionado  ");

            }
        }

        public override DETALLE_ABONO GetEntity(object key)
        {

            return em.DETALLE_ABONO.Where(a => a.ABONOS_Nro_Abono == (int)key).FirstOrDefault<DETALLE_ABONO>();
        }

        public override List<DETALLE_ABONO> GetEntity()
        {

            return em.DETALLE_ABONO.ToList<DETALLE_ABONO>();
        }

        public override void UpdateEntity(DETALLE_ABONO entity)
        {

            DETALLE_ABONO detalle_abono = GetEntity(entity.ABONOS_Nro_Abono);
            if (detalle_abono != null)
            {
                detalle_abono.Nombre_Depositante = entity.Nombre_Depositante;
                detalle_abono.Tipo_Documento = entity.Tipo_Documento;
                detalle_abono.Monto = entity.Monto;
                detalle_abono.REPRESENTANTE_CURSO_RUT_Representante = entity.REPRESENTANTE_CURSO_RUT_Representante;



                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de Detalle de Abono");
            }
        }
    }
}
