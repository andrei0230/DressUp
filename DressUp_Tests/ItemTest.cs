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

        [TestMethod]
        public void TestGetColor()
        {
            // Arrange
            RGBColor expected_color = new RGBColor(160, 81, 145);
            Body actual_body = new Body("body", "C:\\Users\\andre\\source\\repos\\DressUp\\DressUp_Tests\\Pictures\\test_picture.png");
            Pants actual_pants = new Pants("pants", "C:\\Users\\andre\\source\\repos\\DressUp\\DressUp_Tests\\Pictures\\test_picture.png");
            Shoes actual_shoes = new Shoes("shoes", "C:\\Users\\andre\\source\\repos\\DressUp\\DressUp_Tests\\Pictures\\test_picture.png");
            bool body_works = false;
            bool pants_works = false;
            bool shoes_works = false;

            // Act
            RGBColor actual_bodycolor = actual_body.GetColor();
            RGBColor actual_pantscolor = actual_pants.GetColor();
            RGBColor actual_shoescolor= actual_shoes.GetColor();

            // Assert
            if(expected_color == actual_bodycolor) body_works = true;
            if(expected_color == actual_pantscolor) pants_works = true;
            if(expected_color == actual_shoescolor) shoes_works = true;

            Assert.IsTrue(body_works);
            Assert.IsTrue(pants_works);
            Assert.IsTrue(shoes_works);
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