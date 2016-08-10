using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using capa_dac;

namespace capa_dao
{
  public class EmpleadoBO
    {   

      public static EmpleadoEntity obtenerEmpleadoPorUsuClave(string usu, string clave)
      {
          return EmpleadoDAL.obtenerEmpleadoPorUsuClave("sp_buscarEmpleadoPorUsuClave", usu, clave);
      }

      public static EmpleadoEntity insertaEmpleado_entity(EmpleadoEntity emp)
      {
          return EmpleadoDAL.insertaEmpleado("sp_insertaEmpleado", emp);
      }
      
    }
}
