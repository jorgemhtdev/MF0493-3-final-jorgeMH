using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    class UserManagerTest
    {
        [TestMethod]
        public void getAllTest()
        {
            UserManager curso = new UserManager();

            List<UserManager> lista = curso.getAll();

            Assert.AreEqual(lista.Count, 2);

        }
    }
}
