using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
    public class ServicioContrato: AbstractServices<CONTRATO>
    {
        public override void AddEntity(CONTRATO entity)
        {


            // CrearCONTRATO
            CONTRATO Contrato = GetEntity(entity.NRO_Contrato);
            if (Contrato == null)
            {

                em.CONTRATO.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el Contrato");
            }





        }

        public override List<CONTRATO> GetEntities()
        {
            return em.CONTRATO.ToList<CONTRATO>();
        }

        public override void DeleteEntity(object key)
        {

            CONTRATO Contrato = GetEntity(key);
            if (Contrato != null)
            {
                em.CONTRATO.Remove(Contrato);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar Contrato, debido a que existe o esta relacionado  ");

            }
        }

        public override CONTRATO GetEntity(object key)
        {

            return em.CONTRATO.Where(a => a.NRO_Contrato == (int)key).FirstOrDefault<CONTRATO>();
        }

        public override List<CONTRATO> GetEntity()
        {

            return em.CONTRATO.ToList<CONTRATO>();
        }

        public override void UpdateEntity(CONTRATO entity)
        {

            CONTRATO Contrato = GetEntity(entity.NRO_Contrato);
            if (Contrato != null)
            {
                Contrato.Creacion = entity.Creacion;
                Contrato.Termino = entity.Termino;
                Contrato.Modalidad = entity.Modalidad;
                Contrato.Observaciones = entity.Observaciones;
                Contrato.Total_Abonos = entity.Total_Abonos;
                Contrato.Total_Descuento = entity.Total_Descuento;
                Contrato.Total_Neto = entity.Total_Neto;
                Contrato.Valor_Total_Contrato = entity.Valor_Total_Contrato;



                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos de Contrato");
            }
        }
    }
}
