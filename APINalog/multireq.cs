using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APINalog
{
    internal class multireq
    {

        public class Rootobject
        {
            public Item[] items { get; set; }
        }

        public class Item
        {
            public ИП ИП { get; set; }
            public ЮЛ ЮЛ { get; set; }
        }

        public class ИП
        {
            public string ФИОПолн { get; set; }
            public string ИННФЛ { get; set; }
            public string ОГРНИП { get; set; }
            public string ДатаОГРН { get; set; }
            public string ДатаРег { get; set; }
            public string ВидИП { get; set; }
            public string Пол { get; set; }
            public string ВидГражд { get; set; }
            public string Статус { get; set; }
            public Адрес Адрес { get; set; }
            public Оснвиддеят ОснВидДеят { get; set; }
            public string ДопВидДеят { get; set; }
            public Реестрмсп РеестрМСП { get; set; }
        }

        public class Адрес
        {
            public string КодРегион { get; set; }
            public string Индекс { get; set; }
            public string АдресПолн { get; set; }
        }

        public class Оснвиддеят
        {
            public string Код { get; set; }
            public string Текст { get; set; }
        }

        public class Реестрмсп
        {
            public string КатСубМСП { get; set; }
            public string ДатаСост { get; set; }
        }

        public class ЮЛ
        {
            public string ИНН { get; set; }
            public string КПП { get; set; }
            public string ОГРН { get; set; }
            public string ДатаОГРН { get; set; }
            public string ДатаРег { get; set; }
            public string Статус { get; set; }
            public Капитал Капитал { get; set; }
            public string НаимСокрЮЛ { get; set; }
            public string НаимПолнЮЛ { get; set; }
            public Адрес1 Адрес { get; set; }
            public Руководитель Руководитель { get; set; }
            public Оснвиддеят1 ОснВидДеят { get; set; }
            public string ДопВидДеят { get; set; }
            public Финансы Финансы { get; set; }
            public string Контакты { get; set; }
        }

        public class Капитал
        {
            public string СумКап { get; set; }
        }

        public class Адрес1
        {
            public string КодРегион { get; set; }
            public string Индекс { get; set; }
            public string АдресПолн { get; set; }
        }

        public class Руководитель
        {
            public string Должн { get; set; }
            public string ФИОПолн { get; set; }
            public string ИННФЛ { get; set; }
        }

        public class Оснвиддеят1
        {
            public string Код { get; set; }
            public string Текст { get; set; }
        }

        public class Финансы
        {
            public string Выручка { get; set; }
            public string Год { get; set; }
        }
    }
}
