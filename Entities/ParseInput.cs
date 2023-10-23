using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Entities
{
    public static class ParseInput
    {
        private static int[] DefaultValueArray = { 0, 15, 4 };
        public static string DefaultValues => $"({DefaultValueArray[0]}, {DefaultValueArray[1]}, {DefaultValueArray[2]})";
        public static Settings ParseInputValue(string input)
        {
            if (input == "") return new Settings(DefaultValueArray[0], DefaultValueArray[1], DefaultValueArray[2]);
            int[] parsevalue = new int[3];
            try
            {
                var inputArray = input.Split(','); //(new string[] { ","}, StringSplitOptions.None);
                parsevalue[0] = int.Parse(inputArray[0]);
                parsevalue[1] = int.Parse(inputArray[1]);
                parsevalue[2] = int.Parse(inputArray[2]);

                return new Settings(parsevalue[0], parsevalue[1], parsevalue[2]);
            }
            catch
            {
                return null;
            }
            
        }
        public static bool TryParse(string input)
        {
            try
            {
                int i = int.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
