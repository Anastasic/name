using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Проверка
{
    public class Class1
    {
        public bool telephone(string tel)
        {
            Regex regex = new Regex(@"((^7|^8)\(\d{3}\)\d{3}-\d{2}-\d{2}$)|((^7|^8)\d{10}$)");
            return regex.IsMatch(tel);
        }


    }
}
//public bool email(string em)
//{
//    Regex regex = new Regex(@"(^[A-Za-z0-9]{1,})@\w{1,}\.([a-z]{2,})$");
//    return regex.IsMatch(em);
//}

//public bool pasport(string ps)
//{
//    Regex regex = new Regex(@"(^\d{4})\s(\d{6})$");
//    return regex.IsMatch(ps);
//}

//public bool dt(string ps)
//{
//    Regex regex = new Regex(@"(^\d{2}.\d{2}.(\d{2}|\d{4}))$");
//    return regex.IsMatch(ps);
//}

//public bool fio(string ps)
//{
//    Regex regex = new Regex(@"^[А-Я]{1}[а-я]{1,}\s[А-Я]{1}[а-я]{1,}\s[А-Я]{1}[а-я]{1,}$");
//    return regex.IsMatch(ps);
//}