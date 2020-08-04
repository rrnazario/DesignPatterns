using DesignPatterns.Composition.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Composition.Test
{
    [TestClass]
    public class GeneralTests
    {
        [TestMethod]
        public void Create_Characters()
        {
            var horse = new Character();
            horse.AddAttack(Enums.CharacterEnums.TypeAttack.Kick, 10);
            horse.AddAttack(Enums.CharacterEnums.TypeAttack.Bit, 10);

            Assert.AreEqual(horse.CanBite, true);
            Assert.AreEqual(horse.CanKick, true);

            var dog = new Character();
            dog.AddAttack(Enums.CharacterEnums.TypeAttack.Bit, 8);

            Assert.AreEqual(dog.CanBite, true);
            Assert.AreEqual(dog.CanKick, false);
            Assert.AreEqual(dog.CanPunch, false);
        }
    }
}
