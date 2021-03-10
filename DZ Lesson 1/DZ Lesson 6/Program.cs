using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DZ_Lesson_6
{
    class Program
    {
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory, string fail)
        {
            string text;
            Console.Write(indent);
            File.AppendAllText(fail, indent);
            if (lastDirectory)
            {
                Console.Write("└─");
                text = "└─";
                File.AppendAllText(fail, text);
                indent += "  ";
                                
            }
            else
            {
                Console.Write("├─");
                text = "├─";
                File.AppendAllText(fail, text);
                indent += "│ ";                              
            }

            Console.WriteLine(dir.Name);
            File.AppendAllText(fail, dir.Name);
            File.AppendAllText(fail, Environment.NewLine);

            DirectoryInfo[] subDirs = dir.GetDirectories();

            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1, fail);
            }
        }
        static void SaveIsDoneNev(int a, ToDo ToDoList)
        {
            if (a == 1) ToDoList.IsDone = true;
            else ToDoList.IsDone = false;
        }

        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Сохранить дерево каталогов и файлов.");
            Console.WriteLine("2. Список задач(ToDo - list).");
            Console.WriteLine("3. Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4.");
            Console.WriteLine("4. Создать класс Сотрудник с полями");
            Console.WriteLine("5. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            {
                #region task 1
                case 1: // 1. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
                    Console.Clear();
                    Console.Title = "Сохранить дерево каталогов и файлов";
                    string put = @"E:\Battle.net";
                    string filename1 = "strukturDir.txt";
                    DateTime localDate = DateTime.Now;
                    File.WriteAllText(filename1, Convert.ToString(localDate));
                    File.AppendAllText(filename1, Environment.NewLine);
                    PrintDir(new DirectoryInfo(put), "", true, filename1);
                    Console.ReadKey();

                    filename1 = "strukturDir1.txt";
                    File.WriteAllText(filename1, Convert.ToString(localDate));
                    File.AppendAllText(filename1, Environment.NewLine);

                    string[] entries = Directory.GetFileSystemEntries(put, "*", SearchOption.AllDirectories);

                    for (int i = 0; i < entries.Length; i++)
                    {
                        Console.WriteLine(entries[i]);
                    }
                    File.AppendAllLines(filename1, entries);                    
                    Console.ReadKey();
                    break;
                #endregion

                #region task 2
                case 2:
                    /* 2.Список задач(ToDo - list):
                     написать приложение для ввода списка задач;
                     задачу описать классом ToDo с полями Title и IsDone;
                     на старте, если есть файл tasks.json / xml / bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
                     если задача выполнена, вывести перед её названием строку «[x]»;
                     вывести порядковый номер для каждой задачи;
                     при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
                     записать актуальный массив задач в файл tasks.json / xml / bin.*/

                    int task2;
                    Console.Clear();
                    Console.Title = "Список задач(ToDo - list)";
                    ToDo[] ToDoList1mas = new ToDo[4];
                    ToDo ToDoList1 = new ToDo();
                    ToDoList1.Title = "Задание 1 ";
                    ToDoList1.IsDone = true;
                    ToDoList1mas[0] = ToDoList1;
                    ToDo ToDoList2 = new ToDo();
                    ToDoList2.Title = "Задание 2 ";
                    ToDoList2.IsDone = true;
                    ToDoList1mas[1] = ToDoList2;
                    ToDo ToDoList3 = new ToDo();
                    ToDoList3.Title = "Задание 3 ";
                    ToDoList3.IsDone = false;
                    ToDoList1mas[2] = ToDoList3;
                    ToDo ToDoList4 = new ToDo();
                    ToDoList4.Title = "Задание 4 ";
                    ToDoList4.IsDone = false;
                    ToDoList1mas[3] = ToDoList4;
                    for (int i = 0; i < ToDoList1mas.Length; i++)
                    {
                        ToDoList1mas[i].print();
                    }
                    Console.WriteLine("5. Выход");
                    Console.Write("Выберите задание: ");
                    task2 = Convert.ToInt32(Console.ReadLine());
                    int IsDone = 0;
                    do
                        {
                            Console.Write("Ведите цифру 1-Задание готово, 2-Задание не готово: ");
                            IsDone = Convert.ToInt32(Console.ReadLine());
                        }
                    while (IsDone < 1 || IsDone > 2);
                    SaveIsDoneNev(IsDone, ToDoList1mas[task2-1]);
                    for (int i = 0; i < ToDoList1mas.Length; i++)
                    {
                        ToDoList1mas[i].print();
                    }

                    for (int i = 0; i < ToDoList1mas.Length; i++)
                    {
                        StringWriter stringWriter = new StringWriter();
                        XmlSerializer serializer = new XmlSerializer(typeof(ToDo));
                        serializer.Serialize(stringWriter, ToDoList1mas[i]);
                        string xml = stringWriter.ToString();
                        File.AppendAllText("tasks.xml", xml);
                    }
                    Console.WriteLine("Данные записаны в файл tasks.xml");
                    string json = System.Text.Json.JsonSerializer.Serialize(ToDoList1mas);
                    File.WriteAllText("tasks.json", json);
                    Console.WriteLine("Данные записаны в файл tasks.json");
                    Console.ReadKey();
                    break;
                #endregion
                #region task 3
                case 3:
                    /*  3.Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,
                      при подаче массива другого размера необходимо бросить исключение MyArraySizeException.
                      Далее метод должен пройтись по всем элементам массива, преобразовать в int, и просуммировать.
                      Если в каком - то элементе массива преобразование не удалось
                      (например, в ячейке лежит символ или текст вместо числа), должно быть брошено исключение MyArrayDataException, с детализацией в какой именно ячейке лежат неверные данные.
                      В методе main() вызвать полученный метод, обработать возможные исключения MySizeArrayException и MyArrayDataException, и вывести результат расчета.*/
                    Console.Clear();
                    Console.Title = "Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4";

                    string[,] Array3 =  {
                                        { "2", "2", "2", "2" },
                                        { "2", "2", "2", "2" },
                                        { "2", "Д", "2", "2" },
                                        { "2", "2", "2", "2" },                                        
                                        };
                    try
                    {
                        Console.WriteLine(Arraytect(Array3));
                    }
                    catch (MyArraySizeException)
                    {
                        Console.WriteLine("Не верный размер массива");
                    }
                    catch (MyArrayDataException)
                    {
                        Console.WriteLine("В массиве есть не число");
                    }
                    Console.ReadKey();
                    break;
                #endregion

                #region task 4
                case 4: /*4.Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
                        Конструктор класса должен заполнять эти поля при создании объекта;
                        Внутри класса «Сотрудник» написать метод, который выводит информацию об объекте в консоль;
                        Создать массив из 5 сотрудников

                        Пример:
                        Person[] persArray = new Person[5]; // Вначале объявляем массив объектов
                        persArray[0] = new Person("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 30); // потом для каждой ячейки массива задаем объект
                        persArray[1] = new Person(...);
                        ...
                        persArray[4] = new Person(...);

                        С помощью цикла вывести информацию только о сотрудниках старше 40 лет;*/
                                        
                    Sotrudnik[] persArray = new Sotrudnik[5];

                    persArray[0] = new Sotrudnik("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 40000, 30);
                    persArray[1] = new Sotrudnik("Владимир Бро", "Юрист", "Vladbro@mailbox.com", "892586950", 50000, 51);
                    persArray[2] = new Sotrudnik("Юрина Юрьевна", "Бухгалтер", "Buh@mailbox.com", "892999999", 70000, 45);
                    persArray[3] = new Sotrudnik("Татьяна Владимировна", "Менеджер", "Tanka@mailbox.com", "892515820", 30000, 25);
                    persArray[4] = new Sotrudnik("Варвара Варварова", "Уборщица", "Vara@mailbox.com", "892317682", 20000, 49);

                    for (int i = 0; i < persArray.Length; i++)
                    {
                        persArray[i].Print();
                    }

                    Console.WriteLine("Сотрудники старше 40 лет: ");

                    for (int i = 0; i < persArray.Length; i++)
                    {
                        if (persArray[i].Age > 40)
                        persArray[i].Print();
                    }

                    Console.ReadKey();
                    break;
                    #endregion


            }
        }
        static int Arraytect(string[,] Array)
        {
                if (Array.Length != 16)
                {
                    throw new MyArraySizeException();
                }
                    int sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Char.IsDigit(Convert.ToChar(Array[i,j])))
                        {
                            sum += Convert.ToInt32(Array[i, j]);
                        }
                        else
                        {
                        Console.WriteLine(sum);
                        Console.Write($"По координатам {i} {j} : ");
                        throw new MyArrayDataException();
                        }
                    }
                }
            return sum;
        }
    }
}
