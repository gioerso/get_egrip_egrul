using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APINalog
{
    internal class stat
    {
        //public class Rootobject
        //{
        //    public string ДатаНач { get; set; }
        //    public string ДатаОконч { get; set; }
        //    public Методы Методы { get; set; }
        //}

        //public class Методы
        //{
        //    public Bo bo { get; set; }
        //    public Changes changes { get; set; }
        //    public Check check { get; set; }
        //    public Egr egr { get; set; }
        //    public Innfl innfl { get; set; }
        //    public Multinfo multinfo { get; set; }
        //    public Search search { get; set; }
        //    public Vyp vyp { get; set; }
        //}

        //public class Bo
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}

        //public class Changes
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}

        //public class Check
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}

        //public class Egr
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}

        //public class Innfl
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}

        //public class Multinfo
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}

        //public class Search
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}

        //public class Vyp
        //{
        //    public string Лимит { get; set; }
        //    public string ТипЛимита { get; set; }
        //    public string Истрачено { get; set; }
        //}


        public class Rootobject
        {
            public Response[] response { get; set; }
        }

        public class Response
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
        }



    }
}
