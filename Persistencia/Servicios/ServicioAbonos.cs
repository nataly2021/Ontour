using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
    public class ServicioAbonos : AbstractServices<ABONOS>
    {
        public override void AddEntity(ABONOS entity)
        {


            // CrearABONOS
            ABONOS abonos= GetEntity(entity.Nro_Abono);
            if (abonos == null)
            {

                em.ABONOS.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el abonos");
            }





        }

        public override List<ABONOS> GetEntities()
        {
            return em.ABONOS.ToList<ABONOS>();
        }

        public override void DeleteEntity(object key)
        {

            ABONOS abonos = GetEntity(key);
            if (abonos != null)
            {
                em.ABONOS.Remove(abonos);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar abonos , debido a que existe o esta relacionado  ");

            }
        }

        public override ABONOS GetEntity(object key)
        {

            return em.ABONOS.Where(a => a.Nro_Abono == (int)key).FirstOrDefault<ABONOS>();
        }

        public override List<ABONOS> GetEntity()
        {

            return em.ABONOS.ToList<ABONOS>();
        }

        public override void UpdateEntity(ABONOS entity)
        {

            ABONOS abonos = GetEntity(entity.Nro_Abono);
            if (abonos != null)
            {
                abonos.Fecha_Monto = entity.Fecha_Monto;
                abonos.Monto = entity.Monto;
                abonos.CONTRATO_NRO_Contrato = entity.CONTRATO_NRO_Contrato;



                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de abonos");
            }
        }

    }
}

