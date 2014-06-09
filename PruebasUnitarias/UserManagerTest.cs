using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace PruebasUnitarias
{
    /// <summary>
    /// Summary description for UserManagerTest
    /// </summary>
    [TestClass]
    public class UserManagerTest
    {
        // No te molestes en copiarme, hasta ultima hora no voy subir al repositorio este codigo pillin

        [TestMethod]
        public void getAllTest()
        {
            List<Usuario> list = new List<Usuario>();
            list = UserManager.getAll();
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void CrearAdminTest()
        {
            UserManager.CrearAdmin();

            Usuario user = UserManager.get("admin");
            Assert.AreEqual(user.username, "admin");
            Assert.AreEqual(user.email, "jucles@a2000.es");
        }
    }
}
