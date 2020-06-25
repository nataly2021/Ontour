using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{
    public class ServicioRepresentanteCurso:AbstractServices<REPRESENTANTE_CURSO>
    {
        public override void AddEntity(REPRESENTANTE_CURSO entity)
        {


            // Crear REPRESENTANTE_CURSO
            REPRESENTANTE_CURSO representantecurso = GetEntity(entity.RUT_Representante);
            if (representantecurso == null)
            {
                // Insertar una actividad empresa
                em.REPRESENTANTE_CURSO.Add(entity);
                //Guardar Cambios
                em.SaveChanges();

            }
            else
            {
                throw new ArgumentException("No se logro Registrar el representante de curso");
            }





        }

        public override List<REPRESENTANTE_CURSO> GetEntities()
        {
            return em.REPRESENTANTE_CURSO.ToList<REPRESENTANTE_CURSO>();
        }

        public override void DeleteEntity(object key)
        {

            REPRESENTANTE_CURSO representantecurso = GetEntity(key);
            if (representantecurso != null)
            {
                em.REPRESENTANTE_CURSO.Remove(representantecurso);
                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede Eliminar representante de curso , debido a que existe o esta relacionado  ");

            }
        }

        public override REPRESENTANTE_CURSO GetEntity(object key)
        {

            return em.REPRESENTANTE_CURSO.Where(a => a.RUT_Representante == (string)key).FirstOrDefault<REPRESENTANTE_CURSO>();
        }

        public override List<REPRESENTANTE_CURSO> GetEntity()
        {

            return em.REPRESENTANTE_CURSO.ToList<REPRESENTANTE_CURSO>();
        }

        public override void UpdateEntity(REPRESENTANTE_CURSO entity)
        {

            REPRESENTANTE_CURSO representantecurso = GetEntity(entity.RUT_Representante);
            if (representantecurso != null)
            {
                representantecurso.Nombre_Completo = entity.Nombre_Completo;
                representantecurso.Curso = entity.Curso;
                representantecurso.Colegio = entity.Colegio;
                representantecurso.Corre_Electronico = entity.Corre_Electronico;

                representantecurso.Telefono = entity.Telefono;

                em.SaveChanges();
            }
            else
            {
                throw new ArgumentException("No se puede actualizar los Datos representante de curso");
            }
        }

    }
}
