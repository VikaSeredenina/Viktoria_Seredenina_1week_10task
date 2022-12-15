using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp")) //создание папки temp
            {
                Directory.CreateDirectory("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp"); //создает все файлы по пути
            }
            Directory.CreateDirectory("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1"); //создание папки к1
            Directory.CreateDirectory("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K2"); //создание папки к2
            StreamWriter sw = new StreamWriter("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1\\t1.txt"); //запись текста в файл
            sw.Write("Середенина Виктория Дмитриевна, 2004 года рождения, место жительства р.п.Гремячево");
            sw.Close();
            sw = new StreamWriter("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1\\t2.txt");
            sw.Write("Середенина Вадим Дмитриевич, 2004 года рождения, место жительства р.п.Гремячеов");
            sw.Close();
            sw = new StreamWriter("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K2\\t3.txt"); //создание файла t3
            StreamReader sr = new StreamReader("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1\\t1.txt"); //считывание текста из t1
            sw.WriteLine(sr.ReadToEnd()); //считывание всех символов 
            sr.Close();
            sr = new StreamReader("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1\\t2.txt"); //считывание текста из t2
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            //описание файлов
            DirectoryInfo dir1 = new DirectoryInfo("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1");
            DirectoryInfo dir2 = new DirectoryInfo("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K2");
            FileInfo[] info = dir1.GetFiles();
            Console.WriteLine("Информация о файлах в папке K1\n");
            foreach (FileInfo fi in info)
            {
                Console.WriteLine("Путь к файлу: " + fi.FullName.ToString() + '\n' +"Имя файла: " + fi.Name.ToString() + '\n' +
                   "Расширение файла: " + fi.Extension.ToString() + '\n' +"Время создания файла: " + fi.CreationTime.ToString());
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            FileInfo[] info2 = dir2.GetFiles();
            Console.WriteLine("\nИнформация о файлах в папке K2\n");
            foreach (FileInfo fi in info2)
            {
                Console.WriteLine("Путь к файлу: " + fi.FullName.ToString() + '\n' +  "Имя файла: " + fi.Name.ToString() + '\n' +
                   "Расширение файла: " + fi.Extension.ToString() + '\n' + "Время создания файла: " + fi.CreationTime.ToString());
                Console.WriteLine("\n");
            }

            File.Move("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1\\t2.txt", "C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K2\\t2.txt"); //перенос файлф t2.txt в папку K2.
            File.Copy("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1\\t1.txt", "C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K2\\t1.txt"); //копирование файла t1.txt в папку K2.
            Directory.Move("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K2", "C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\ALL"); //переименование K2 в ALL
            Directory.Delete("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\K1", true); //удаление папки К1
            DirectoryInfo dinf = new DirectoryInfo("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp\\ALL"); //информация о файлах
            FileInfo[] finf = dinf.GetFiles();
            Console.WriteLine("\nИнформация о файлах в папке ALL\n");
            foreach (FileInfo fi in finf)
            {
                Console.WriteLine("Путь к файлу: " + fi.FullName.ToString() + '\n' + "Имя файла: " + fi.Name.ToString() + '\n' +
                   "Расширение файла: " + fi.Extension.ToString() + '\n' + "Время создания файла: " + fi.CreationTime.ToString());
                Console.WriteLine("\n");
            }

        }
    }
}
