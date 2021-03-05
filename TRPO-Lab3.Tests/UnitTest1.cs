using NUnit.Framework;

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
            TRPO_Lab3.Lib.Math_1 math_1 = new Lib.Math_1();
            double s = math_1.Formula(10, 5);
            Assert.AreEqual(314.15,s, 0.01);
            
        }
        [Test]
        public void Test2()
        {
            TRPO_Lab3.Lib.Math_1 math_1 = new Lib.Math_1();
            double s = math_1.Formula(10, 5);
            Assert.Throws<System.ArgumentException>(()=> {
                TRPO_Lab3.Lib.Math_1 math_1 = new Lib.Math_1();
                double s = math_1.Formula(-10, 5);
            });
        }
    }
}