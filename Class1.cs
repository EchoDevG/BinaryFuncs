using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    #region parent classes
    class Binary
    {

        private string binary;

        public Binary(string _binary = "00000000")
        {
            binary = _binary;
        }

        public string getBinary() { return binary; }
        public bool setBinary(string _binary) { if (_binary.Length == 8) { binary = _binary; return true; } else { return false; } }



        // sets the binary attribute with a denary number
        public virtual bool setBinaryWithDenary(int denary)
        {
            //if it will fit in an 8 bit number
            if (denary >= 0 && denary <= 255)
            {

                string outputBinary = "";

                int currentPower = 7;

                //find the binary
                while (currentPower >= 0)
                {
                    if ((denary - Math.Pow(2, currentPower) >= 0))
                    {
                        outputBinary += "1";
                        denary -= (int)Math.Pow(2, currentPower);
                        currentPower -= 1;
                    }
                    else
                    {
                        outputBinary += "0";
                        currentPower -= 1;
                    }

                }

                setBinary(outputBinary);
                return true;
            }
            else { return false; }
        }

    }

    #endregion


    #region child classes

    class SignAndMagnitudeBinary : Binary
    {
        private string binary;



        public SignAndMagnitudeBinary(string _binary = "00000000") : base(_binary)
        {
            binary = _binary;
        }

        public override bool setBinaryWithDenary(int denary)
        {
            //if it will fit in an 8 bit sign and magnitude number
            if (denary >= -127 && denary <= 127)
            {

                string outputBinary = "";
                bool isNegative = false;

                if (denary < 0) { isNegative = true; }

                denary = Math.Abs(denary);

                int currentPower = 6;

                //find the binary
                while (currentPower >= 0)
                {
                    if ((denary - Math.Pow(2, currentPower) >= 0))
                    {
                        outputBinary += "1";
                        denary -= (int)Math.Pow(2, currentPower);
                        currentPower -= 1;
                    }
                    else
                    {
                        outputBinary += "0";
                        currentPower -= 1;
                    }

                }

                if (isNegative == true) { outputBinary = "1" + outputBinary; } else { outputBinary = "0" + outputBinary; }


                setBinary(outputBinary);
                return true;
            }
            else { return false; }
        }




        public void changeSign()
        {
            if (binary.Substring(0, 1) == "1")
            { binary = "0" + binary.Substring(1, 7); }
            else if (binary.Substring(0, 1) == "0")
            { binary = "1" + binary.Substring(1, 7); }
        }
    }







    class TwosComplimentBinary : Binary
    {
        private string binary;



        public TwosComplimentBinary(string _binary = "00000000") : base(_binary)
        {
            binary = _binary;
        }





        public override bool setBinaryWithDenary(int denary)
        {
            //if it will fit in an 8 bit sign and magnitude number
            if (denary >= -128 && denary <= 127)
            {

                string outputBinary = "";
                bool isNegative = false;

                if (denary < 0)
                {
                    isNegative = true;
                    denary = Math.Abs(denary);
                    denary = 128 - denary;
                }
                else
                {
                    denary = Math.Abs(denary);
                }



                int currentPower = 6;

                //find the binary
                while (currentPower >= 0)
                {
                    if ((denary - Math.Pow(2, currentPower) >= 0))
                    {
                        outputBinary += "1";
                        denary -= (int)Math.Pow(2, currentPower);
                        currentPower -= 1;
                    }
                    else
                    {
                        outputBinary += "0";
                        currentPower -= 1;
                    }

                }

                if (isNegative == true) { outputBinary = "1" + outputBinary; } else { outputBinary = "0" + outputBinary; }


                setBinary(outputBinary);
                return true;
            }
            else { return false; }
        }


        public void changeSign()
        {
            bool firstOneFound = false;
            string newBinary = "";
            string existingBinary = getBinary();

            for (int i = 7; i >= 0; i--)
            {
                string currentDigit = existingBinary.Substring(i, 1);

                if (firstOneFound == true)
                {
                    if (currentDigit == "1")
                    {
                        newBinary = "0" + newBinary;
                    }
                    else if (currentDigit == "0")
                    {
                        newBinary = "1" + newBinary;
                    }
                }
                else
                { newBinary = currentDigit + newBinary; }

                if (currentDigit == "1") { firstOneFound = true; }

                setBinary(newBinary);
            }
        }

    }
    #endregion
