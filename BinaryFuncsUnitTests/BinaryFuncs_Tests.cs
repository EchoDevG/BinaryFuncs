using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryFuncs;


namespace Binary_Tests
{
    [TestClass]
    public class Binary_Tests
    {
        [TestMethod]
        public void SetWithDenary()
        {
            // Arrange
            int denary = 10;
            string initialBinary = new string('0', 8);
            Binary nBinary = new Binary(initialBinary);
            string expectedBinary = "00001010";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion from denary is incorrect");
        }
    }

    [TestClass]
    public class Sign_And_Magnitude_Binary_Tests
    {
        [TestMethod]
        public void SetWithDenary()
        {
            // Arrange
            int denary = 10;
            string initialBinary = new string('0', 8);
            Binary nBinary = new Binary(initialBinary);
            string expectedBinary = "00001010";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion from denary is incorrect");
        }
    }

    [TestClass]
    public class Twos_Compliment_Binary_Tests
    {
        [TestMethod]
        public void SetWithDenary()
        {
            // Arrange
            int denary = 10;
            string initialBinary = new string('0', 8);
            Binary nBinary = new Binary(initialBinary);
            string expectedBinary = "00001010";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion from denary is incorrect");
        }
    }



}


namespace EBinary_Tests
{
    [TestClass]
    public class Twos_Compliment
    {

            [TestMethod]
            public void SetWithDenary()
            {
                // Arrange
                int denary = 10;
                int length = 8;
                string initialBinary = new string('0', length);
                EBinary nBinary = new EBinary(length, initialBinary, "TWOS_COMPLIMENT");
                string expectedBinary = "00001010";

                // Act
                nBinary.SetBinaryWithDenary(denary);

                // Assert
                string actualBinary = nBinary.BinaryNum;
                Assert.AreEqual(expectedBinary, actualBinary, "Conversion from denary is incorrect");

            }
    }


}