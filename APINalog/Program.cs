using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Specialized;

namespace APINalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            // название пр-мы
            Console.Title = "ЕГРЮЛ и ЕГРИП Console Edition";
            // остаток по запросам
            //var remainsObj = methods.GetStats().Result;
            //int remainsEgr = Convert.ToInt32(remainsObj.Методы.egr.Лимит) - Convert.ToInt32(remainsObj.Методы.egr.Истрачено);
            //int remainsMult = Convert.ToInt32(remainsObj.Методы.multinfo.Лимит) - Convert.ToInt32(remainsObj.Методы.multinfo.Истрачено);


            // начало ветки
            //Console.WriteLine($"Проверка ЕГРЮЛ и ЕГРИП\nОстатки по выпискам (одиночные): {remainsEgr}\nОстатки по выпискам (мульти): {remainsMult}");
            Console.WriteLine("\nДля заказа ЕГРЮЛ нажмите 1;\nДля заказа ЕГРИП нажмите 2;\nДля комплексного заказа (до 100 организаций) нажмите 3\nДля закрытия программы нажмите любую клавишу\n");
            string check = Console.ReadLine();
            if (check == "1") // Юрики
            {
                try
                {
                    Console.WriteLine("Введите ИНН или ОГРН");
                    data = Console.ReadLine();

                    var remainsEGRUL = methods.GetEgrul("").Result;

                    Console.WriteLine($"{remainsEGRUL.response[0].first_name}\n{remainsEGRUL.response[0].last_name}");
                //    Console.WriteLine($"\nНазвание организации: {remainsEGRUL.items[0].ЮЛ.НаимПолнЮЛ}\n" +
                //$"ИНН: {remainsEGRUL.items[0].ЮЛ.ИНН}\nОГРН: {remainsEGRUL.items[0].ЮЛ.ОГРН}\n" +
                //$"Дата регистрации: {remainsEGRUL.items[0].ЮЛ.ДатаРег}\n" +
                //$"Адрес организации: {remainsEGRUL.items[0].ЮЛ.Адрес.АдресПолн}\n" +
                //$"Статус: {remainsEGRUL.items[0].ЮЛ.Статус}\n\n" +
                //$"Уставной капитал: {remainsEGRUL.items[0].ЮЛ.Капитал.СумКап}\n" +
                //$"Учередитель: {remainsEGRUL.items[0].ЮЛ.Учредители[0].УчрФЛ}\n" +
                //$"Руководитель: {remainsEGRUL.items[0].ЮЛ.Руководитель.ФИОПолн} Должность: {remainsEGRUL.items[0].ЮЛ.Руководитель.Должн}\n\n" +
                //$"Контакты: \n" +
                //$"Сайт: {remainsEGRUL.items[0].ЮЛ.Контакты.Сайт[0]}\n" +
                //$"Телефон: {remainsEGRUL.items[0].ЮЛ.Контакты.Телефон[0]}\n\n" +
                //$"Выручка: {remainsEGRUL.items[0].ЮЛ.ОткрСведения.СумДоход}" +
                //$"\n\nДля выхода нажмите любую клавишу...");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Организация не найдена!\nНажмите любую кнопку для выхода.");
                    Console.ReadLine();
                }
            }
            else if(check == "2") // ИП
            {
                try
                {
                    Console.WriteLine("Введите ИНН или ОГРН");
                    data = Console.ReadLine();

                    var remainsEGRIP = methods.GetEgrip(data).Result;

                    Console.WriteLine($"ФИО: {remainsEGRIP.items[0].ИП.ФИОПолн} Пол: {remainsEGRIP.items[0].ИП.Пол}\n" +
                        $"ИНН: {remainsEGRIP.items[0].ИП.ИННФЛ} ОГРН: {remainsEGRIP.items[0].ИП.ОГРНИП}\n" +
                        $"Адрес регистрации: {remainsEGRIP.items[0].ИП.Адрес.АдресПолн}\n\n" +
                        $"Для выхода нажмите любую клавишу...");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Организация не найдена!\nНажмите любую кнопку для выхода.");
                    Console.ReadLine();
                }
            }
            else if(check == "3") // Мультизапрос (Юрики + ИП)
            {
                Console.WriteLine("Введите ИНН или ОГРН через запятую(пример - 253801190331, 9726001152, 1234567890)");
                data = Console.ReadLine();

                var remainsMR = methods.GetMulti(data).Result;

                if(remainsMR.items.Length > 1)
                {
                    for(int i = 0; i < remainsMR.items.Length; i++)
                    {
                        if(remainsMR.items[i].ЮЛ == null) // ИП
                        {
                            Console.WriteLine($"\n ИП {i} \nФИО: {remainsMR.items[i].ИП.ФИОПолн} Пол: {remainsMR.items[i].ИП.Пол}\n" +
                                $"ИНН: {remainsMR.items[i].ИП.ИННФЛ} ОГРН: {remainsMR.items[i].ИП.ОГРНИП}\n" +
                                $"Адрес регистрации: {remainsMR.items[i].ИП.Адрес.АдресПолн}\n\n");
                        }
                        else // Юрики
                        {
                            Console.WriteLine($"\n ЮЛ {i} \nНазвание организации: {remainsMR.items[i].ЮЛ.НаимПолнЮЛ}\n" +
                                $"ИНН: {remainsMR.items[i].ЮЛ.ИНН}\nОГРН: {remainsMR.items[i].ЮЛ.ОГРН}\n" +
                                $"Дата регистрации: {remainsMR.items[i].ЮЛ.ДатаРег}\n" +
                                $"Адрес организации: {remainsMR.items[i].ЮЛ.Адрес.АдресПолн}\n" +
                                $"Статус: {remainsMR.items[i].ЮЛ.Статус}\n\n" +
                                $"Уставной капитал: {remainsMR.items[i].ЮЛ.Капитал.СумКап}\n" +
                                $"Руководитель: {remainsMR.items[i].ЮЛ.Руководитель.ФИОПолн} Должность: {remainsMR.items[i].ЮЛ.Руководитель.Должн}\n\n");
                        }
                    }
                    Console.WriteLine("\n Конец выгрузки. Для выхода нажмите любую клавишу...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nЗапрос не может быть выполен, так как вы указали всего 1 компанию. Попробуйте другие методы.");
                }
            }
            else
            {
                return;
            }
        }
    }
}
