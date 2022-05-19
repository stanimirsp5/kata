using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSoftuni.CodingGames
{
    class OffsetArrays
    {

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<int, int>> arrayDefinitions = new Dictionary<string, Dictionary<int, int>>();

            for (int i = 0; i < n; i++)
            {
                string assignment = Console.ReadLine();

                var listArr = FillListArray(assignment);

                arrayDefinitions.Add(assignment.Substring(0, assignment.IndexOf("[")), listArr);

            }

            string elementToPrint = Console.ReadLine();
            string[] arrayNames = elementToPrint.Split(new char[] { ']', '[' }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(arrayNames[arrayNames.Length - 1]);

            for (int i = arrayNames.Length - 2; i >= 0; i--)
            {
                index = arrayDefinitions[arrayNames[i]][index];
            }

                   Console.WriteLine(index);
        }

        public static Dictionary<int, int> FillListArray(string assignment)
        {

            (int indexFrom, int indexTo) = GetIndexes(assignment);

            var dict = new Dictionary<int, int>();
            int[] arrValues = GetArrayValues(assignment);

            for (int index = indexFrom, i = 0; index <= indexTo; index++, i++)
            {

                dict.Add(index, arrValues[i]);
            }

            return dict;
        }

        public static (int, int) GetIndexes(string str)
        {
            int numbersFrom = str.IndexOf("[") + 1; 
            int numbersTo = str.LastIndexOf("]"); 

            String result = str.Substring(numbersFrom, numbersTo - numbersFrom);
            int firstNumBegining = result.IndexOf("."); 
            var firstNum = Int32.Parse(result.Substring(0, firstNumBegining));

            int secondNumBegining = result.LastIndexOf(".") + 1;
            int secondNumLength = result.Length - secondNumBegining;
            var secondNum = Int32.Parse(result.Substring(secondNumBegining, secondNumLength));

            return (firstNum, secondNum);
        }

        public static int[] GetArrayValues(string assignment)
        {
            int leftSideOfString = assignment.IndexOf("=") + 2;

            string result = assignment.Substring(leftSideOfString);
            string[] valuesAsString = result.Split(' ');
            int[] valuesAsInt = Array.ConvertAll(valuesAsString, int.Parse);
            return valuesAsInt;
        }

    }
}
