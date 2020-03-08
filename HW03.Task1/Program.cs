using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Implicit conversion
            short ifirst_number = 32000;
            ushort ifirst_numberConv = (ushort)ifirst_number;

            //2 Implicit conversion
            int isecond_number = 3;
            byte isecond_numbeConv = (byte)isecond_number;

            //3 Implicit conversion
            double ithird_number = 159753.789;
            int ithird_numberConv = (int)ithird_number;


            //1 Explicit conversion
            byte efirst_number = 23;
            int efirst_numberConv = efirst_number;

            //2 Explicit conversion
            ushort esecond_number = 32767;
            uint esecond_numberConv = esecond_number;

            //3 Explicit conversion
            int ethird_number = 15346846;
            long ethird_numberConv = ethird_number;

            //1 boxing/unboxing
            int boxing1 = 256;
            object first_boxing = boxing1;
            int first_unboxing = (int)first_boxing;

            //2 boxing/unboxing
            object second_boxing = (long)258000;
            int second_unboxing = (int)(long)second_boxing;

            //3 boxing/unboxing
            float boxing3 = 13.28f;
            object third_boxing = boxing3;
            float third_unboxing = (float)third_boxing;

            //Пример с упаковкой int типа и распаковкой в ushort тип
            int numberInt = 65000;
            object boxingInt = numberInt;
            ushort unboxingInt = (ushort)(int)boxingInt;

            //Пример с упаковкой Логического типа и распаковой в byte тип
            bool bool_byte = false;
            object boxing_bool_byte = bool_byte;
            byte unboxing_bool_byte = Convert.ToByte(boxing_bool_byte);

            //Но ведь надо было byte)
            bool bool_byte2 = true;
            object boxing_bool_byte2 = bool_byte2;
            string text = boxing_bool_byte2.ToString();
            int text_lenght = text.Length;
            byte bool_byteDONE = (byte)text_lenght;

            //Пример с упаковкой char типа и распаковкой в int тип
            char char_int = 'f';
            object boxing_char_int = char_int;
            int unboxing_char_int = Convert.ToInt32(boxing_char_int);

        }
    }
}
