using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace PruebasUnitarias
{
    /// <summary>
    /// Summary description for EmpresaManagerTest
    /// </summary>
    [TestClass]
    public class EmpresaManagerTest
    {

        [TestMethod]
        public void NuevaTest()
        {
            // Comprobamos un objeto con datos

            Empresa emp = new Empresa();

            emp.activa = true;
            emp.email = "aitortilla@gmail.com";
            emp.ff = DateTime.Now;
            emp.logo = "logo.png";
            emp.nif = "75258966";
            emp.nombre = "empresaPrueba";
            emp.poblacion = "almeria";
            emp.telefono = "6502824";
            emp.usr = "admin";

            EmpresaManager.Nueva(emp);

            Empresa buscarEmpresa = EmpresaManager.get(emp.nif);

            Assert.AreEqual(buscarEmpresa.email, "aitortilla@gmail.com");

            
            EmpresaManager.Eliminar(emp.nif);

            // Comprobamos un objeto null

            Empresa emp2 = new Empresa();

            emp2 = null;

            Assert.IsFalse(EmpresaManager.Nueva(emp2));

        }

        [TestMethod]
         public void ModificarTest()
        {
            
            Empresa emp = new Empresa();

            emp.activa = true;
            emp.email = "aitortilla@modificado.com";
            emp.ff = DateTime.Now;
            emp.logo = "modificado.png";
            emp.nif = "75258962";
            emp.nombre = "empresaPrueba";
            emp.poblacion = "almeria";
            emp.telefono = "6502824";
            emp.usr = "admin";

            EmpresaManager.Nueva(emp);

            Empresa BuscarEmpresa = EmpresaManager.get(emp.nif);

            Assert.AreEqual(BuscarEmpresa.email, "aitortilla@modificado.com");
            Assert.AreEqual(BuscarEmpresa.logo, "modificado.png");

            bool eliminado = EmpresaManager.Eliminar("75258962");

        }

        [TestMethod]
        public void GetTest()
        {
            Empresa emp = new Empresa();
            emp.activa = true;
            emp.email = "aitortila@gmail.com";
            emp.ff = DateTime.Now;
            emp.logo = "logo.png";
            emp.nif = "1234456789";
            emp.nombre = "aitortila";
            emp.poblacion = "aitortilaAlmeria";
            emp.telefono = "1233456789";
            emp.usr = "admin";

            Assert.IsNull(EmpresaManager.get("0380932"));

            EmpresaManager.Nueva(emp);

            Empresa buscar = EmpresaManager.get(emp.nif);

            Assert.AreEqual(buscar.nombre, "aitortila");

        }
        [TestMethod]
        public void EliminarTest()
        {
            bool eliminado = EmpresaManager.Eliminar("1234456789");
            Assert.IsTrue(eliminado);
        }
    }
}