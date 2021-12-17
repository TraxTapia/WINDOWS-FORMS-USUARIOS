using Correos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correos.Datos
{
  public  class Usuarios
    {

        List<UsuariosModels> lista = new List<UsuariosModels>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="models"></param>
        public void Guardar(UsuariosModels models)
        {
            lista.Add(models);
        }

        public List<UsuariosModels> Consultar()
        {
            return lista;
        }
    }
}
