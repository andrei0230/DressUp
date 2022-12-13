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
            string actual_name = hoodie.Name;
            string actual_photo = hoodie.Photo;

            // Assert
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
            string actual_name = jeans.Name;
            string actual_photo = jeans.Photo;

            // Assert
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
            string actual_name = boots.Name;
            string actual_photo = boots.Photo;

            // Assert
            Assert.AreEqual(expected_name, actual_name);
            Assert.AreEqual(expected_photo, actual_photo);
        }
    }

    [TestClass]
    public class RGBColorTests
    {
        [TestMethod]
        public void TestAverage()
        {
            // Arrange
            double expected_average = 95.33;
            RGBColor actual_color = new RGBColor(45, 147, 94);

            // Act
            double actual_average = actual_color.Average();

            // Assert
            Assert.AreEqual(expected_average, actual_average);
        }
    }
}