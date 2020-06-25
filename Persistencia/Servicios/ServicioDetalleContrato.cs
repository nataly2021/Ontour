using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
    public class ServicioDetalleContrato: AbstractServices<DETALLE_CONTRATO>
    {
        public override void AddEntity(DETALLE_CONTRATO entity)
        {
            //throw new NotImplementedException();
            DETALLE_CONTRATO detalle_contrato = GetEntity(entity.CONTRATO_NRO_Contrato);
            if (detalle_contrato == null)
            {

                em.DETALLE_CONTRATO.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el  Detalle de Contrato");
            }

        }

        public override List<DETALLE_CONTRATO> GetEntities()
        {
            return em.DETALLE_CONTRATO.ToList<DETALLE_CONTRATO>();
        }

        public override void DeleteEntity(object key)
        {

            DETALLE_CONTRATO detalle_contrato = GetEntity(key);
            if (detalle_contrato != null)
            {
                em.DETALLE_CONTRATO.Remove(detalle_contrato);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar Detalle de Contrato, debido a que existe o esta relacionado  ");

            }
        }

        public override DETALLE_CONTRATO GetEntity(object key)
        {

            return em.DETALLE_CONTRATO.Where(a => a.CONTRATO_NRO_Contrato == (int)key).FirstOrDefault<DETALLE_CONTRATO>();
        }

        public override List<DETALLE_CONTRATO> GetEntity()
        {

            return em.DETALLE_CONTRATO.ToList<DETALLE_CONTRATO>();
        }

        public override void UpdateEntity(DETALLE_CONTRATO entity)
        {

            DETALLE_CONTRATO detalle_contrato = GetEntity(entity.CONTRATO_NRO_Contrato);
            if (detalle_contrato != null)
            {
                detalle_contrato.Descuento = entity.Descuento;
                detalle_contrato.Valor_Neto = entity.Valor_Neto;
                detalle_contrato.Cantidad = entity.Cantidad;
                detalle_contrato.PRODUCTOS_ID_Producto = entity.PRODUCTOS_ID_Producto;



                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de Detalle de Contrato ");
            }
        }

    }
}
