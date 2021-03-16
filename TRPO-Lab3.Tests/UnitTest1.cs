using NUnit.Framework;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double s = Math_1.Formula(10, 5);
            Assert.AreEqual(314.15,s, 0.01);
            
        }
        [Test]
        public void Test2()
        {
            double s = Math_1.Formula(10, 5);
            Assert.Throws<System.ArgumentException>(()=> {
                double s = Math_1.Formula(-10, 5);
            });
        }
    }
}