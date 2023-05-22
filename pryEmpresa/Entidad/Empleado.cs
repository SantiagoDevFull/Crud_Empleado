using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEmpresa.Entidad
{
    public class Empleado
    {

        String id_emp;
        String nombre_emp;
        String paterno_emp;
        String materno_emp;
        String fechaNaci_emp;
        String rol_emp;
        public static int id=1;

        public Empleado()
        {
        }

        public Empleado( string nombre_emp, string paterno_emp, 
            string materno_emp, string fechaNaci_emp, string rol_emp)
        {
            this.id_emp = GenerarID();
            this.nombre_emp = nombre_emp;
            this.paterno_emp = paterno_emp;
            this.materno_emp = materno_emp;
            this.fechaNaci_emp = fechaNaci_emp;
            this.rol_emp = rol_emp;
        }

        public String GenerarID()
        {
            return ("EMP000" + id++);
        }


        public double Sueldo()
        {
            double sueldo;
            if (rol_emp.Equals("Desarrollador back-end"))
            {
                sueldo = 3000;
            }else if(rol_emp.Equals("Desarrollador front-end"))
            {
                sueldo = 2800;
            }
            else
            {
                sueldo = 5100;
            }
            return sueldo;
        }

        public String getId_emp()
        {
            return id_emp;
        }

        public void setId_emp(String id_emp)
        {
            this.id_emp = id_emp;
        }

        public String getNombre_emp()
        {
            return nombre_emp;
        }

        public void setNombre_emp(String nombre_emp)
        {
            this.nombre_emp = nombre_emp;
        }

        public String getPaterno_emp()
        {
            return paterno_emp;
        }

        public void setPaterno_emp(String paterno_emp)
        {
            this.paterno_emp = paterno_emp;
        }

        public String getMaterno_emp()
        {
            return materno_emp;
        }

        public void setMaterno_emp(String materno_emp)
        {
            this.materno_emp = materno_emp;
        }

        public String getFechaNaci_emp()
        {
            return fechaNaci_emp;
        }

        public void setFechaNaci_emp(String fechaNaci_emp)
        {
            this.fechaNaci_emp = fechaNaci_emp;
        }

        public String getRol_emp()
        {
            return rol_emp;
        }

        public void setRol_emp(String rol_emp)
        {
            this.rol_emp = rol_emp;
        }

    }
}
