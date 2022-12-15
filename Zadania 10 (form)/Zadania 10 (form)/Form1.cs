using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_10__form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form")) //создание папки temp
            {
                Directory.CreateDirectory("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form"); //создает все файлы по пути
            }
            Directory.CreateDirectory("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1"); //создание папки к1
            Directory.CreateDirectory("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K2"); //создание папки к2
            StreamWriter sw = new StreamWriter("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1\\t1.txt"); //запись текста в файл
            sw.Write("Середенина Виктория Дмитриевна, 2004 года рождения, место жительства р.п.Гремячево");
            sw.Close();
            sw = new StreamWriter("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1\\t2.txt");
            sw.Write("Середенин Вадим Дмитриевич, 2004 года рождения, место жительства р.п.Гремячево");
            sw.Close();
            sw = new StreamWriter("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K2\\t3.txt"); //создание файла t3
            StreamReader sr = new StreamReader("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1\\t1.txt"); //считывание текста из t1
            sw.WriteLine(sr.ReadToEnd()); //считывание всех символов 
            sr.Close();
            sr = new StreamReader("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1\\t2.txt"); //считывание текста из t2
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            //описание файлов
            DirectoryInfo dir1 = new DirectoryInfo("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1");
            DirectoryInfo dir2 = new DirectoryInfo("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K2");
            FileInfo[] info = dir1.GetFiles();
            foreach (FileInfo fi in info)
            {
                textBox1.Text += "Путь к файлу: " + fi.FullName.ToString() + Environment.NewLine + "Имя файла: " + fi.Name.ToString() + Environment.NewLine +
                   "Расширение файла: " + fi.Extension.ToString() + Environment.NewLine + "Время создания файла: " + fi.CreationTime.ToString();
            }
            FileInfo[] info2 = dir2.GetFiles();
            foreach (FileInfo fi in info2)
            {
                textBox2.Text += "Путь к файлу: " + fi.FullName.ToString() + Environment.NewLine + "Имя файла: " + fi.Name.ToString() + Environment.NewLine +
                   "Расширение файла: " + fi.Extension.ToString() + Environment.NewLine + "Время создания файла: " + fi.CreationTime.ToString();
            }

            File.Move("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1\\t2.txt", "C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K2\\t2.txt"); //перенос файлф t2.txt в папку K2.
            File.Copy("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1\\t1.txt", "C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K2\\t1.txt"); //копирование файла t1.txt в папку K2.
            Directory.Move("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K2", "C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\ALL"); //переименование K2 в ALL
            Directory.Delete("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\K1", true); //удаление папки К1
            DirectoryInfo dinf = new DirectoryInfo("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\temp.form\\ALL"); //информация о файлах
            FileInfo[] finf = dinf.GetFiles();
            foreach (FileInfo fi in finf)
            {
               textBox3.Text += "Путь к файлу: " + fi.FullName.ToString() + Environment.NewLine + "Имя файла: " + fi.Name.ToString() + Environment.NewLine +
                   "Расширение файла: " + fi.Extension.ToString() + Environment.NewLine + "Время создания файла: " + fi.CreationTime.ToString();
            }
    }
    }
}
