using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }


            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    string tmp;
                    if (array[i].Length >= array[i + 1].Length)
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;

                    }
                }
            }
        }
    }
}
