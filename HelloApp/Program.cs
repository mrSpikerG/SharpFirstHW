using System;
using System.Text;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Lorem Ipsum - это текст- \"рыба\", часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной \"рыбой\" для " +
                "текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, " +
                "используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул " +
                "в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в " +
                "более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum.";

            string[] textArr = text.Split(' ');


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < textArr.Length; j++)
                {

                }
            }

            //task1
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Length < 3)
                {
                    textArr[i] = "secret";
                }
            }

            //task5
            for (int i = 0; i < textArr.Length; i++)
            {
               textArr[i] = task5(textArr[i]);
            }

            //task2
            for (int i = 0; i < textArr.Length; i++)
            {
                for (int j = i; j < textArr.Length; j++)
                {
                    if (textArr[i].Length < textArr[j].Length)
                    {
                        string temp = textArr[i];
                        textArr[i] = textArr[j];
                        textArr[j] = temp;
                    }
                }
            }


            //task4
            string paragraphs = String.Join("\n", textArr);
            

            //task3
            paragraphs = task3(paragraphs);

           
            Console.WriteLine(paragraphs);
        }
       
      
        private static string task3(string str)
        {
            return str.Replace("z", "Z").Replace("s", "S").Replace("c", "C");
        }
        private static string task5(string str)
        {
            return str.Replace("I", "same");
        }
    }
}
