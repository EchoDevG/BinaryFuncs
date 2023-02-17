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

        [TestMethod]
        public void SetWithDenaryNegative()
        {
            // Arrange
            int denary = -10;
            string initialBinary = new string('0', 8);
            Binary nBinary = new Binary(initialBinary);
            string expectedBinary = initialBinary;

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Attempted conversion with negative denary");
            
        }

        [TestMethod]
        public void SetWithDenaryZero()
        {
            // Arrange
            int denary = 0;
            string initialBinary = new string('1', 8);
            Binary nBinary = new Binary(initialBinary);
            string expectedBinary = "00000000";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion failed with denary being zero");

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
            SignAndMagnitudeBinary nBinary = new SignAndMagnitudeBinary(initialBinary);
            string expectedBinary = "00001010";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion from denary is incorrect");
        }

        [TestMethod]
        public void SetWithDenaryNegative()
        {
            // Arrange
            int denary = -10;
            string initialBinary = new string('0', 8);
            SignAndMagnitudeBinary nBinary = new SignAndMagnitudeBinary(initialBinary);
            string expectedBinary = "10001010";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Incorrect conversion with negative denary");

        }

        [TestMethod]
        public void SetWithDenaryZero()
        {
            // Arrange
            int denary = 0;
            string initialBinary = new string('1', 8);
            SignAndMagnitudeBinary nBinary = new SignAndMagnitudeBinary(initialBinary);
            string expectedBinary = "00000000";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion failed with denary being zero");

        }

        [TestMethod]
        public void ChangeSignFromPositive()
        {
            // Arrange
            string initialBinary = "00001010";
            SignAndMagnitudeBinary nBinary = new SignAndMagnitudeBinary(initialBinary);
            string expectedBinary = "10001010";

            // Act
            nBinary.changeSign();

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Incorrectly changed the sign from +ve to -ve");
        }

        [TestMethod]
        public void ChangeSignFromNegative()
        {
            // Arrange
            string initialBinary = "10001010";
            SignAndMagnitudeBinary nBinary = new SignAndMagnitudeBinary(initialBinary);
            string expectedBinary = "00001010";

            // Act
            nBinary.changeSign();

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Incorrectly changed the sign from -ve to +ve");
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
            TwosComplimentBinary nBinary = new TwosComplimentBinary(initialBinary);
            string expectedBinary = "00001010";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion from denary is incorrect");
        }

        [TestMethod]
        public void SetWithDenaryNegative()
        {
            // Arrange
            int denary = -10;
            string initialBinary = new string('0', 8);
            TwosComplimentBinary nBinary = new TwosComplimentBinary(initialBinary);
            string expectedBinary = "11110110";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Incorrect conversion with negative denary");

        }

        [TestMethod]
        public void SetWithDenaryZero()
        {
            // Arrange
            int denary = 0;
            string initialBinary = new string('1', 8);
            TwosComplimentBinary nBinary = new TwosComplimentBinary(initialBinary);
            string expectedBinary = "00000000";

            // Act
            nBinary.setBinaryWithDenary(denary);

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Conversion failed with denary being zero");

        }

        [TestMethod]
        public void ChangeSignFromPositive() 
        {
            // Arrange
            string initialBinary = "00001010";
            TwosComplimentBinary nBinary = new TwosComplimentBinary(initialBinary);
            string expectedBinary = "11110110";

            // Act
            nBinary.changeSign();

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Incorrectly changed the sign from +ve to -ve");
        }

        [TestMethod]
        public void ChangeSignFromNegative()
        {
            // Arrange
            string initialBinary = "11110110";
            TwosComplimentBinary nBinary = new TwosComplimentBinary(initialBinary);
            string expectedBinary = "00001010";

            // Act
            nBinary.changeSign();

            // Assert
            string actualBinary = nBinary.getBinary();
            Assert.AreEqual(expectedBinary, actualBinary, "Incorrectly changed the sign from -ve to +ve");
        }
    }



}


namespace EBinary_Tests
{
    [TestClass]
    public class Standard
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


    [TestClass]
    public class Sign_And_Magnitude
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