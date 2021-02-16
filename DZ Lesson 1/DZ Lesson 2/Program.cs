using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_2
{
    class Program
    {
        [Flags]
        public enum Knowledges
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четрерг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }


        static void Main(string[] args)
        {
            Console.Title = "Меню";
            Console.WriteLine("Какое задание вы хотите проверить:");
            Console.WriteLine("1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.");
            Console.WriteLine("2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.");
            Console.WriteLine("3. Определить, является ли введённое пользователем число чётным.");
            Console.WriteLine("4. Вывести чек в кансоли");
            Console.WriteLine("5. График работы офиса");
            Console.WriteLine("6. Выход");
            Console.Write("Введите номер задачи: ");
            int tasknam = Convert.ToInt32(Console.ReadLine());
            switch (tasknam)
            { 
                #region task 1
                case 1: /* 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру. */
                    Console.Clear();
                    Console.Title = "Средняя температура";
                    Console.Write("Введите минимальную температуру за сутки: ");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите максимальную температуру за сутки: ");
                    int max = Convert.ToInt32(Console.ReadLine());
                    int sr = (min + max) / 2;
                    Console.WriteLine($"Cреднесуточная температура {sr} градусов");
                    Console.ReadLine();

                    break;
                #endregion

                #region task 2
                case 2: // Запросить у пользователя порядковый номер текущего месяца и вывести его название.
                    Console.Clear();
                    Console.Title = "Порядковый номер текущего месяца";
                    Console.Write("Введите минимальную температуру за сутки: ");
                    int min2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите максимальную температуру за сутки: ");
                    int max2 = Convert.ToInt32(Console.ReadLine());
                    int sr2 = (min2 + max2) / 2;
                    Console.Write("Введите номер текущего месяца: ");
                    int dayOfWeek = Convert.ToInt32(Console.ReadLine());
                    string title = "";
                    switch (dayOfWeek)
                    {
                        case 0:
                            title = "Неизвестно!";
                            Console.Write($"Месяца под номером {dayOfWeek} не бывает");
                            break;
                        case 1:
                            title = "Январь";
                            Console.WriteLine("Январь");
                            if (sr2>=1 && sr2<=5 ) Console.WriteLine("Дождливая зима");
                            else if (sr2 >5) Console.WriteLine("Вы уверены что у Вас зима?");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Теплая зима");
                            else Console.WriteLine("Морозная зима");
                            break;
                        case 2:
                            title = "Февраль";
                            Console.WriteLine("Февраль");
                            if (sr2 >= 1 && sr2 <= 5) Console.WriteLine("Дождливая зима");
                            else if (sr2 > 5) Console.WriteLine("Вы уверены что у Вас зима?");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Теплая зима");
                            else Console.WriteLine("Морозная зима");
                            break;
                        case 3:
                            title = "Март";
                            Console.WriteLine("Март");
                            if (sr2 >= 1 && sr2 <= 5) Console.WriteLine("Весна");
                            else if (sr2 > 5) Console.WriteLine("Тёплая Весна");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Холодная Весна");
                            else Console.WriteLine("Вы уверены что у Вас весна?");
                            break;
                        case 4:
                            title = "Апрель";
                            Console.WriteLine("Апрель");
                            if (sr2 >= 1 && sr2 <= 5) Console.WriteLine("Весна");
                            else if (sr2 > 5) Console.WriteLine("Тёплая Весна");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Холодная Весна");
                            else Console.WriteLine("Вы уверены что у Вас весна?");
                            break;
                        case 5:
                            title = "Май";
                            Console.WriteLine("Май");
                            if (sr2 >= 1 && sr2 <= 5) Console.WriteLine("Холодная весна");
                            else if (sr2 > 5) Console.WriteLine("Весна");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Вы уверены что у Вас весна?");
                            else Console.WriteLine("Вы уверены что у Вас весна?");
                            break;
                        case 6:
                            title = "Июнь";
                            Console.WriteLine("Июнь");
                            if (sr2 >= 1 && sr2 <= 15) Console.WriteLine("Холодное лето");
                            else if (sr2 > 15) Console.WriteLine("Лето");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Вы уверены что у Вас весна?");
                            else Console.WriteLine("Вы из за полярного круга?");
                            break;
                        case 7:
                            title = "Июль";
                            Console.WriteLine("Июль");
                            if (sr2 >= 1 && sr2 <= 15) Console.WriteLine("Холодное лето");
                            else if (sr2 > 15) Console.WriteLine("Лето");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Вы уверены что у Вас весна?");
                            else Console.WriteLine("Вы из за полярного круга?");
                            break;
                        case 8:
                            title = "Август";
                            Console.WriteLine("Август");
                            if (sr2 >= 1 && sr2 <= 15) Console.WriteLine("Холодное лето");
                            else if (sr2 > 15) Console.WriteLine("Лето");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Вы уверены что у Вас весна?");
                            else Console.WriteLine("Вы из за полярного круга?");
                            break;
                        case 9:
                            title = "Сентябрь";
                            Console.WriteLine("Сентябрь");
                            if (sr2 >= 1 && sr2 <= 10) Console.WriteLine("Осень");
                            else if (sr2 > 10) Console.WriteLine("Теплая осень");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Холодная осень");
                            else Console.WriteLine("Вы уверены что у Вас осень?");
                            break;
                        case 10:
                            title = "Октябрь";
                            Console.WriteLine("Октябрь");
                            if (sr2 >= 1 && sr2 <= 5) Console.WriteLine("Осень");
                            else if (sr2 > 5) Console.WriteLine("Теплая осень");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Холодная осень");
                            else Console.WriteLine("Вы уверены что у Вас осень?");
                            break;
                        case 11:
                            title = "Ноябрь";
                            Console.WriteLine("Ноябрь");
                            if (sr2 >= 1 && sr2 <= 5) Console.WriteLine("Осень");
                            else if (sr2 > 5) Console.WriteLine("Теплая осень");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Холодная осень");
                            else Console.WriteLine("Холодная осень");
                            break;
                        case 12:
                            title = "Декабрь";
                            Console.WriteLine("Декабрь");
                            if (sr2 >= 1 && sr2 <= 5) Console.WriteLine("Дождливая зима");
                            else if (sr2 > 5) Console.WriteLine("Вы уверены что у Вас зима?");
                            else if (sr2 <= 0 && sr2 > -15) Console.WriteLine("Теплая зима");
                            else Console.WriteLine("Морозная зима");
                            break;
                        default:
                            title = "Неизвестно!";
                            Console.WriteLine($"Месяца под номером {dayOfWeek} не бывает");
                            break;
                    }
                    Console.ReadLine();

                    break;
                #endregion

                #region task 3
                case 3: // 3. Определить, является ли введённое пользователем число чётным.
                    Console.Clear();
                    Console.Title = "Определить, является ли введённое пользователем число чётным.";
                    Console.Write("Введите чтсло: ");
                    int a4 = Convert.ToInt32(Console.ReadLine());

                    if (a4%2 == 0) Console.WriteLine($"Число {a4} четное");
                    else Console.WriteLine($"Число {a4} нечетное");
                    Console.ReadLine();

                    break;
                #endregion

                #region task 4
                case 4:  /*Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
                         только за место динамических, по вашему мнению, данных(это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые 
                         были заранее заготовлены до вывода на консоль.*/
                    Console.Clear();
                    Console.Title = "Чек";
                    string score = "ООО ГИПЕРГЛОБУС";
                    string product1 = "Сардельки глобус";
                    double quantity1 = 0.990;
                    double price1 = 379.9;
                    int code1 = 286180;
                    string product2 = "Морож ленинг бат 80г";
                    double quantity2 = 4;
                    double price2 = 29.99; 
                    long code2 = 4600625307629;
                    string product3 = "Зельц глобус";
                    double quantity3 = 0.318;
                    double price3 = 249.9;
                    int code3 = 286226;
                    double sum4 = quantity1 * price1 + quantity2 * price2 + quantity3 * price3;

                    Console.WriteLine(score);
                    for (int i = 0; i <= 40; i++)
                    {
                        Console.Write("─");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{product1}  {quantity1} * {price1}  {quantity1*price1} ");
                    Console.WriteLine($"{code1}");
                    Console.WriteLine($"{product2}  {quantity2} * {price2}  {quantity2 * price2} ");
                    Console.WriteLine($"{code2}");
                    Console.WriteLine($"{product3}  {quantity3} * {price3}  {quantity3 * price3} ");
                    Console.WriteLine($"{code3}");
                    for (int i = 0; i <= 40; i++)
                    {
                        Console.Write("─");
                    }
                    Console.WriteLine();
                                        
                    DateTime date = new DateTime(2020, 2, 10, 20, 20, 20);
                    Console.WriteLine($"Оплата {date.ToString("dd.MM.yy")} {date.ToString("HH:mm")} чек 0188");
                    Console.WriteLine($"Терминал 22173283         Мерчант: 851000099754");
                    Console.WriteLine($"Код авторизации:                         081582");
                    Console.WriteLine($"Номер ссылки RRN                   715774108633");
                    Console.WriteLine($"Симма(руб) {sum4}  Комиссия за операцию 0 руб");

                    Console.WriteLine($"ИТОГ ={sum4}");
                    Console.WriteLine($"Электронными  ={sum4}");
                    Console.WriteLine("Получено: ");
                    Console.WriteLine($"Безналичными   ={sum4}");
                    Console.WriteLine($"Сумма нас 20%  ={sum4*20/100}");
                    Console.WriteLine($"Сумма нас 10%  ={sum4*10/100}");
                    Console.ReadLine();

                    break;
                #endregion
                #region task 5
                case 5:
                    /*(*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, 
                        к примеру, чтобы описать работу какого либо офиса. Явный пример -офис номер 1 работает со вторника 
                        до пятницы, офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли. */
                    Console.Title = "График работы офиса";
                    Console.WriteLine("График работы офиса");
                    Knowledges office1 = (Knowledges)0b0011011;
                    Knowledges office2 = (Knowledges)0b1100011;
                    Knowledges office3 = (Knowledges)0b0111110;
                    Console.WriteLine($"Первый офис работает по графику: {office1}");
                    Console.WriteLine($"Второй офис работает по графику: {office2}");
                    Console.WriteLine($"Третий офис работает по графику: {office3}");
                    Console.ReadLine();

                    break;
                    #endregion
            }
        }
    }
}
