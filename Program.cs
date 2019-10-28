using System;
using System.Collections.Generic;
using System.Text;

namespace DB_BitMaps
{
    class Program
    {
        public static void Print_Empl(string[,] Mas)
        {

        }

        static Dictionary<string, int[]> Create_Bit_Map(string[,] arr_Emp, string[] arr_Keys, int number_field)
        {
            int N = arr_Emp.GetLength(0);   //The size of a bit scale
            var bitMap = new Dictionary<string, int[]>();
            //Adding items to the dictionary
            for (int i=0; i < arr_Keys.Length; i++)
            {
                var temp_arr = new int[N];
                for (int j = 0; j < N; j++)
                {
                    if (arr_Emp[j, number_field] == arr_Keys[i])
                        temp_arr[j] = 1;
                    else temp_arr[j] = 0;
                }
                //forming a bitmap and adding it to the dictionary
                bitMap.Add(arr_Keys[i], temp_arr);

                //bitmap printing
                for (int j=0; j<N; j++)
                { Console.Write(bitMap[arr_Keys[i]][j]); }
                Console.WriteLine();
            }
            return bitMap;
        }

        public static void Devision_BitMaps(string[,] arr, Dictionary<string, int[]> bm1,
            string field_bm1, Dictionary<string, int[]> bm2, string field_bm2)
        {

        }
        public static void Bit_Devision(string[,] Array, Dictionary<string, int[]> bm1,
            string field_bm1, Dictionary<string, int[]> bm2, string field_bm2,
            Dictionary<string, int[]> bm3, string field_bm3)
        {

        }
        //Full table scan method
        public static void Finf_ScanTable(string[,] arr, int N, string field1,
            string field2)
        {

        }
        static void Main(string[] args)
        {

        }

    }
}
