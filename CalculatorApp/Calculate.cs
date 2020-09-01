using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculate
    {
        public Calculate()
        {

        }

        public Calculate(string calcFeed)
        {
            int output = assignToArray(calcFeed);
        }
        public int assignToArray(string calcFeed)
        {
            string[] numbers = new string[50];
            char[] signs = new char[50];
            string tempNum = "";
            int numbersIndex = 0;
            int signsIndex = 0;
            for (int i = 0; i < calcFeed.Length; i++)
            {
                if (calcFeed[i] == '-' || calcFeed[i] == '+' || calcFeed[i] == '*' || calcFeed[i] == '/')
                {
                    signs[signsIndex++] = calcFeed[i];
                    numbers[numbersIndex++] = tempNum;
                    tempNum = "";
                    continue;
                }
                tempNum += calcFeed[i];
            }
            return ExtractAndCalculate(numbersIndex, numbers, signs);
        }

        public int ExtractAndCalculate(int index, string[] numbers, char[] signs)
        {
            string equation = "";
            for (int i = 0; i < index; i++)
            {
                equation += numbers[i];
                if(i == signs.Length - 1)
                {
                    break;
                }
                equation += signs[i];
            }
            
            return 0;
        }
    }
}
