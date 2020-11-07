using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Remoting.Channels;

namespace Week_9___Bitwise.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Q20_AND_22_Alternative();
            //Q19_to_22();
            //Q23_to_26();
            //Q27_to_28();
            //Q29();
            //Q30();
            //Q31();
            BIO_1();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {   Console.WriteLine("Press <Esc> to exit");   }
        }
        
        static void Q20_AND_22_Alternative()
        {
            int bytenum = 0b10011;
            int byten = bytenum & 0b11100;
            double Byte = Math.Pow(2, 2);   // expoenent = total - number of digits you want
            double output = byten / Byte;

            Console.WriteLine(output);
            //Debug.Assert( output == 0b111, "not right");
        }

        static void Q19_to_22()
        {
            //int number = 0b110101; // binary value
            string number = "110101";
            int RightMostBit, LeftMostBit;

            // 19.
                // METHOD 1: odd has remainder 1, even has 0: when n % 2
            /*int Decimal = Convert.ToInt32(number, 2);
            int RightMostBit = Decimal % 2;*/

                // METHOD 2: built-in functions
            bool Last_Digit = number.EndsWith("1");         // Microsoft Doc
            if (Last_Digit) 
            {   RightMostBit = 1;   }
            else
            {   RightMostBit = 0;   }

            Debug.Assert(RightMostBit == 1, "Q19 Wrong"); // Fuse
                // METHOD 3: see Q20 -- substring cut

            // 20.
            string Q20 = number.Substring(number.Length - 3, 3);
            Debug.Assert(number.Length == 6);
            Debug.Assert(Q20 == "101","Q20 Wrong");
                    // this method can be used for Q19 & 21 as well: method 3
                // METHOD 4: built-in "trim" method (trim the unwanted away and store in a new string var)

            // 21.
            bool First_Digit = number.StartsWith("1");      // Microsoft Doc
            if (Last_Digit)
            { LeftMostBit = 1; }
            else
            { LeftMostBit = 0; }

            Debug.Assert(LeftMostBit == 1, "Q21 Wrong"); // Fuse

            // 22.
            string Q22 = number.Substring(0, 3);
            Debug.Assert(Q22 == "110", "Q22 Wrong");
        }

        static void Q23_to_26()
        {
            string number = "110101";

            // Q 23.
                // METHOD 1: if it's in binary, cause overflow / underflow (so the bit disappears)

            int Q23_num = Convert.ToInt32(number, 2);
            string Q23 = Convert.ToString(Q23_num >> 1, 2);
            Debug.Assert(Q23 == "11010","Q23 Wrong");

            // Q 24.
            int Q24_num = Convert.ToInt32(number, 2);
            string Q24 = Convert.ToString(Q24_num >> 3, 2);
            Debug.Assert(Q24 == "110", "Q24 Wrong");

            // Q 25.
            int Q25_num = Convert.ToInt32(number, 2);
            string Q25 = Convert.ToString(Q25_num << 1, 2);
            Debug.Assert(Q25 == "10101", "Q25 Wrong");

            // Q 26.
            int Q26_num = Convert.ToInt32(number, 2);
            string Q26 = Convert.ToString(Q26_num << 3, 2);
            Debug.Assert(Q26 == "10101", "Q26 Wrong");
                // METHOD 2: identity 
            Console.WriteLine("{0} is the rightmost bit, {0}{1}{2} is the right most bit",(Convert.ToInt32(number,2) >> 4) & 1, (Convert.ToInt32(number, 2) >> 3) & 1, (Convert.ToInt32(number, 2) >> 2) & 1);
                    // It's noisy because I didn't assign variables
        }

        static void Q27_to_28()
        {
            string number = "110001";
            
            // Q 27.
            string Q27_num = number.Substring(number.Length - 3, 3);
            Debug.Assert(Q27_num == "001", "Q27 Wrong");

            // Q 28.
            //Debug.Assert(Q28_start_to_end(number) == "100011", "Q28 Wrong");
            Console.WriteLine(Q28_start_to_end(number));
        }

        private static string Q28_start_to_end(string the_number)
        {
            string the_digit = the_number.Substring(0, 1);
            Debug.Assert(the_digit == "1", "Not the digit we want");

            string removed = the_number.Remove(0, 1);
            //string removed = the_number.TrimStart("1"); // trims away all the "1"
            string Q28 = String.Concat(removed, the_digit);

            return Q28;
        }

        static void Q29()
        {
            string number = "1100101";
            int tot_num = 2, start_pos = 2;

            Debug.Assert(Q29_cut(number, tot_num, start_pos) == "10", "Q29 Wrong");
        }

        private static string Q29_cut(string before_cut, int n, int p)
        {
            string cutted = before_cut.Substring(p-1, n);
            return cutted;
        }

        static void Q30()
        {
            int num = 23;
            Debug.Assert(Count_Ones(num) == 4, "Q30 Wrong");
        }

        private static int Count_Ones(int num)
        {
            string binary = Convert.ToString(num, 2);
            Debug.Assert(binary == "10111");

            List<char> ListofOnes = binary.Where(c => c == '1').ToList();

            return ListofOnes.Count();
        }

        static void Q31()
        {
            int den = 123;
            int base_you_want = 62;
            Debug.Assert(base_you_want <= 63, "You base value is too big");

            string num_str = Convert.ToString(den,base_you_want);
            // didn't finish
        }

        static void BIO_1()
        {
            string Letter1 = "B";
            string Letter2 = "C";

            foreach 


        }



        static void Num_Sys_Conversion()
        {
            int i = Convert.ToInt32("1010", 2);     // Convert.ToInt32(OBJECT, BASE)
            int j = Convert.ToInt32("AA", 16);      // whatever base you like
            Debug.Assert(i == 8 + 2, "Binary conversion error");
            Debug.Assert(j == 16 * 10 + 1 * 10, "Hex conversion error");
        }

        static void String_Trimming()
        {
            char[] Chars_to_Trim = { '!', ' ' };                // SINGLE speechmark
            string STRING = "Hello World !!!";

            string Trim_Specific = STRING.Trim(Chars_to_Trim);  // Trims EVERY single on of ALL the char in the list
            string Trim_Start = STRING.TrimStart('H');          // Trims only the FIRST char
            string Trim_End = STRING.TrimEnd('l');              // Trims only the LAST char
        }

        static void notes()
        {
            bool Logic_A = true, Logic_B = false;
            int A = 30, B = 3;

            bool Logical_AND = Logic_A && Logic_B;      // Logical AND
            bool Logical_OR = Logic_A || Logic_B;       // Logical OR
            bool Logical_NOT = ! Logic_B;               // Logical NOT

            int Bitwise_AND = A & B;                    // Bitwise AND
            int Bitwise_OR = A & B;                     // Bitwise OR
            int Bitwise_XOR = A & B;                    // Bitwise XOR
            int Tilder_Not = ~A;                        // Bitwise NOT

            int Right_Shifting = A >> B;                // (Bitwise) Right shifting = halving
            int Left_Shifting = A << B;                 // (Bitwise) Left shifting = doubling

            /*      a b c d e f g h i j 
                  & 0 0 0 0 0 0 0 1 1 1     bitwise AND    
                -------------------------
                    0 0 0 0 0 0 0 h i j

                 if (ValueTuple & (1 << n) == (1 << n)) then at that bit    */
        }
        
    }
}
