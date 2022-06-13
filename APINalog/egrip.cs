using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APINalog
{
    internal class egrip
    {

        public class Rootobject
        {
            public Item[] items { get; set; }
        }

        public class Item
        {
            public ИП ИП { get; set; }
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
            public НО НО { get; set; }
            public ПФ ПФ { get; set; }
            public Адрес Адрес { get; set; }
            public object[] Контакты { get; set; }
            public Оснвиддеят ОснВидДеят { get; set; }
            public Допвиддеят[] ДопВидДеят { get; set; }
            public СПВЗ[] СПВЗ { get; set; }
            public История История { get; set; }
        }

        public class НО
        {
            public string Рег { get; set; }
            public string РегДата { get; set; }
            public string Учет { get; set; }
            public string УчетДата { get; set; }
        }

        public class ПФ
        {
            public string РегНомПФ { get; set; }
            public string ДатаРегПФ { get; set; }
            public string КодПФ { get; set; }
        }

        public class Адрес
        {
            public string КодРегион { get; set; }
            public string Индекс { get; set; }
            public string АдресПолн { get; set; }
            public string Дата { get; set; }
        }

        public class Оснвиддеят
        {
            public string Код { get; set; }
            public string Текст { get; set; }
            public string Дата { get; set; }
        }

        public class История
        {
            public Адрес1 Адрес { get; set; }
        }

        public class Адрес1
        {
            public _2010031620220103 _2010031620220103 { get; set; }
        }

        public class _2010031620220103
        {
            public string АдресПолн { get; set; }
        }

        public class Допвиддеят
        {
            public string Код { get; set; }
            public string Текст { get; set; }
            public string Дата { get; set; }
        }

        public class СПВЗ
        {
            public string Дата { get; set; }
            public string Текст { get; set; }
        }

    }
}
