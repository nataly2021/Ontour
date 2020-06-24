using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Servicios
{

    /// <summary>
    /// Creación de clase Abstracta
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractServices<T>
    {
        /// <summary>
        /// planilla de metodos para conexión BD
        /// </summary>
        protected ONTOUREntities em = new ONTOUREntities();


        public abstract void AddEntity(T entity);

        public abstract void UpdateEntity(T entity);

        public abstract void DeleteEntity(object key);

        public abstract T GetEntity(object key);

        public abstract List<T> GetEntity();

        public abstract List<T> GetEntities();
    }
}
