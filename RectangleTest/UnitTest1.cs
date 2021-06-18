using NUnit.Framework;
using Assignment01;



namespace RectangleTest
{
    public class Tests
    {
        Rectangle rec = new Rectangle();



        [Test]
        public void TC01_Default_value_0f_Rectangle()
        {
            Assert.AreEqual(1, rec.GetLength());



        }



        [Test]
        public void TC02_Default_value_of_Width()
        {
            Assert.AreEqual(1, rec.getWidth());
        }



        [TestCase(6)]
        public void TC03_Setting_length_of_Rectangle(int length)
        {
            Assert.AreEqual(length, rec.setLength(length));



        }



        [TestCase(4)]
        public void TC04_Setting_Width_of_Rectangle(int width)
        {
            Assert.AreEqual(width, rec.setWidth(width));



        }



        [Test]
        public void TC05_Getting_New_length_of_rectange()
        {
            Assert.AreEqual(6, rec.GetLength());



        }



        [Test]
        public void TC06_Getting_New_width_of_rectange()
        {
            Assert.AreEqual(4, rec.getWidth());
        }



        [TestCase(6, 5)]
        [TestCase(7, 6)]
        [TestCase(8, 5)]
        public void TC07_Checking_Perimeter_of_Rectangle(int len, int wid)
        {
            int result = 2 * (len + wid);
            rec.setLength(len);
            rec.setWidth(wid);
            int perimeter = rec.GetPerimeter();
            Assert.AreEqual(result, perimeter);
        }




        [Test]
        public void TC08_Checking_width_of_Rectangle_after_Perimeter_calculation()
        {
            Assert.AreEqual(5, rec.getWidth());
        }



        [Test]
        public void TC09_Checking_Length_of_Rectangle_after_Perimeter_calculation()
        {
            Assert.AreEqual(8, rec.GetLength());
        }



        [TestCase(6, 5)]
        [TestCase(7, 6)]
        [TestCase(11, 9)]
        public void TC10_Area_Calculation_of_Rectangle(int len, int wid)
        {
            int result = len * wid;
            rec.setLength(len);
            rec.setWidth(wid);
            int area = rec.GetArea();
            Assert.AreEqual(result, area);
        }



        [Test]
        public void TC11_Checking_width_of_Rectangle_after_Area_calculation()
        {
            Assert.AreEqual(9, rec.getWidth());
        }



        [Test]
        public void TC12_Checking_Length_of_Rectangle_after_Area_calculation()
        {
            Assert.AreEqual(11, rec.GetLength());
        }





    }
}