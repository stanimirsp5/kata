using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.HackerRank
{
    internal class CeaserCipher
    {
        //static void Main(string[] args)
        //{
        //   char a = 'A';
        //    byte aByte = ((byte)a);
        //    int incrementor = 3;
        //    aByte += (byte)incrementor;
        //    var newChar = (char)aByte;
        //    Cipher( "Z", 10); // test + 3 = whvw
        //}

        // s - text to cipher, k - number of letters to rotate
        public static string Cipher(string s, int k)
        {
            Encoding unicode = Encoding.UTF8;

            byte[] unicodeBytes = unicode.GetBytes(s);


            byte[] cipheredBytes = new byte[unicodeBytes.Length];

            var currLetter = 0;
            for (int i = 0; i < unicodeBytes.Length; i++)
            {
                currLetter = unicodeBytes[i];


                if (currLetter >= 97 && currLetter <= 122)
                {
                    cipheredBytes[i] = (byte)GetSmallLetter(currLetter + k);

                }
                else if (currLetter >= 65 && currLetter <= 90)
                {
                    cipheredBytes[i] = (byte)GetBigLetter(currLetter + k);
                }
                else
                {
                    cipheredBytes[i] = (byte)currLetter;
                }

            }

            var text = unicode.GetString(cipheredBytes);


            return text;
        }


        private static int GetBigLetter(int letterInt)
        {

            if (letterInt <= 90)
            {
                return letterInt;
            }

            var diff = letterInt - 90;

            letterInt = diff + 64;

            return GetBigLetter(letterInt);

        }
        private static int GetSmallLetter(int letterInt)
        {

            if (letterInt <= 122)
            {
                return letterInt;
            }

            var diff = letterInt - 122;

            letterInt = diff + 96;

            return GetSmallLetter(letterInt);

        }


    }
}
