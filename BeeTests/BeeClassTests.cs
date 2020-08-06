using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeesApplication;

namespace BeeTests
{
    [TestClass]
    public class BeeClassTests
    {
        [TestMethod]
        public void DamageInputAmountTest1()
        {
            int damageAmount = -1;
            Bee bee = new Bee();
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => bee.Damage(damageAmount));
        }

        [TestMethod]
        public void DamageInputAmountTest2()
        {
            int damageAmount = 101;
            Bee bee = new Bee();
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => bee.Damage(damageAmount));
        }

        [TestMethod]
        public void DamageInputAmountTest3()
        {
            int damageAmount = 0;
            Bee bee = new Bee();
            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 100);
        }

        [TestMethod]
        public void DamageInputAmountTest4()
        {
            int damageAmount = 100;
            Bee bee = new Bee();
            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 0);
        }

        [TestMethod]
        public void DamageInputAmountTest5()
        {
            int damageAmount = 50;
            Bee bee = new Bee();
            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 50);
        }

        [TestMethod]
        public void DeathTest1()
        {
            int damageAmount = 31;
            WorkerBee bee = new WorkerBee();

            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 69);
            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 69);
        }

        [TestMethod]
        public void DeathTest2()
        {
            int damageAmount = 81;
            QueenBee bee = new QueenBee();

            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 19);
            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 19);
        }

        [TestMethod]
        public void DeathTest3()
        {
            int damageAmount = 51;
            DroneBee bee = new DroneBee();

            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 49);
            bee.Damage(damageAmount);
            Assert.AreEqual(bee.Health, 49);
        }
    }
}
