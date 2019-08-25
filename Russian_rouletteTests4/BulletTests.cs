using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_roulette;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_roulette.Tests
{
    [TestClass()]
    public class BulletTests
    {
        [TestMethod()]
        public void generateFireTest()
        {

            try {
                Bullet obj = new Bullet();
                obj.winner();
            }
            catch (Exception ex) {
                StringAssert.Contains(ex.Message, " Error");
            }
        }
    }
}