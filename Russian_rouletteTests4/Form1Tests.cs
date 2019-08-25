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
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            try
            {
                Bullet obj = new Bullet();
                obj.generateFire();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, " Error");
            }
        }
    }
}