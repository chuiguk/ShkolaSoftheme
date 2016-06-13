using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class StringCutter
    {
        char[] stringArr;
        public StringCutter(string s)
        {
            stringArr = s.ToCharArray();
        }
        public string Cut()
        {
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < stringArr.Length - 1; i++)
            {
                int counter = 1;
                strB.Append(stringArr[i]);
                if(stringArr[i] == stringArr[i+1])
                {
                    Count(ref i, ref counter);
                    strB.Append(counter);
                }
            }          
            return strB.ToString();
        }

        int Count(ref int i, ref int counter)
        {

                while (stringArr[i] == stringArr[i + 1] && i < stringArr.Length - 2)
                {
                    i++;
                    counter++;
                    Count(ref i, ref counter);
                }

            return counter;
        }
    }
}
