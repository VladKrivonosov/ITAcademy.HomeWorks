using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Чтение файла по заданому пути. 
             2. Считываем весь файл
             3. Загоняем в массив разделяя пробелами 
             4. Создается байтовый массив
             5. В цикле перебирается массив и конвертируется в пиксели
             6. Собирается файл и сохраняется по заданому пути
             ?7. textReader.Dispose() какой-то сборщик мусора, но так и не понял что он дает.
                 Куда его не вставь, всё равно работает, как и без него. 
            */

            StreamReader textReader = new StreamReader(@"e:\C#\image.txt", true);
                string textReaderResult = textReader.ReadToEnd();
                    string[] arrayOfTextResult = textReaderResult.Split(" ");
                    byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"d:\image.png", imageBytes);

            textReader.Dispose();


        }
    }
}
