using DressUp_Logic;

namespace DressUp_Tests
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void TestBody()
        {
            // Arrange
            string expected_name = "Hoodie";
            string expected_photo = "hoodie.png";
            Body hoodie = new Body("Hoodie", "hoodie.png");

            // Act
            // nothing here for now

            // Assert
            string actual_name = hoodie.Name;
            string actual_photo = hoodie.Photo;
            Assert.AreEqual(expected_name, actual_name);
            Assert.AreEqual(expected_photo, actual_photo);
        }

        [TestMethod]
        public void TestPants()
        {
            // Arrange 
            string expected_name = "Jeans";
            string expected_photo = "jeans.png";
            Pants jeans = new Pants("Jeans", "jeans.png");

            // Act
            // nothing here for now

            // Assert
            string actual_name = jeans.Name;
            string actual_photo = jeans.Photo;
            Assert.AreEqual(expected_name, actual_name);
            Assert.AreEqual(expected_photo, actual_photo);
        }

        [TestMethod]
        public void TestShoes()
        {
            // Arrange
            string expected_name = "Boots";
            string expected_photo = "boots.png";
            Shoes boots = new Shoes("Boots", "boots.png");

            // Act
            // nothing here now

            // Assert
            string actual_name = boots.Name;
            string actual_photo = boots.Photo;
            Assert.AreEqual(expected_name, actual_name);
            Assert.AreEqual(expected_photo, actual_photo);
        }
    }
}