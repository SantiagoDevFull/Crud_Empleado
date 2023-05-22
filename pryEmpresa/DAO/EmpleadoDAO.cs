using pryEmpresa.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEmpresa.DAO
{
    public class EmpleadoDAO
    {

        List<Empleado> listaEmpleado = new List<Empleado>();

        public EmpleadoDAO()
        {
            listaEmpleado.Add(new Empleado("AGUSTÍN","CASTAÑEDA","BENITES", "27/04/1977", "Desarrollador back-end"));
            listaEmpleado.Add(new Empleado("SEBASTIAN", "TAIPE", "OSORIO", "15/12/1991", "Desarrollador front-end"));
            listaEmpleado.Add(new Empleado("HEYSSEL", "NUÑEZ", "GUERRERO", "01/11/1977", "Desarrollador back-end"));
            listaEmpleado.Add(new Empleado("WALTER", "RIOS", "PESO", "03/01/1981", "Desarrollador full-stack"));
            listaEmpleado.Add(new Empleado("KIARA", "ROSARIO", "BALBUENA", "10/09/1975", "Desarrollador front-end"));
            listaEmpleado.Add(new Empleado("JOSE", "SANTIAGO", "MARTINEZ", "25/05/1968", "Desarrollador full-stack"));
            listaEmpleado.Add(new Empleado("PAOLA", "HILARIO", "MORENO", "21/08/1970", "Desarrollador full-stack"));
        }

        public List<Empleado> getListaEmpleado()
        {
            return listaEmpleado;
        }

        public void EliminarEmpleado(String id)
        {
            foreach(Empleado obj in listaEmpleado)
            {
                if (id.Equals(obj.getId_emp()))
                {
                    listaEmpleado.Remove(obj);
                    break;
                }
            }
        }

        public void EditarEmpleado(Empleado obj)
        {
            foreach(Empleado emp in listaEmpleado)
            {
                if (emp.getId_emp().Equals(obj.getId_emp()))
                {
                    emp.setNombre_emp(obj.getNombre_emp());
                    emp.setPaterno_emp(obj.getPaterno_emp());
                    emp.setMaterno_emp(obj.getMaterno_emp());
                    emp.setFechaNaci_emp(obj.getFechaNaci_emp());
                    emp.setRol_emp(obj.getRol_emp());
                    break;
                }
            }
        }

        public void AgregarEmpleado(Empleado obj)
        {
            listaEmpleado.Add(obj);
        }

        public String CodigoActual()
        {
            String res;
            res = "EMP000"+Empleado.id;
            return res;
        }
         



    }
}
