using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sagittis hendrerit ante.";
            char[] separators = new char[] {' ','.',',','<','>'};
            string[] separated = s.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(s);
            Console.WriteLine();
            for (int i = 0; i < separated.Length; i++)
            {
                Console.WriteLine(separated[i]);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            char[] konstrukotr = { 'a', 'b' };
            string ss = new string(konstrukotr);
            Console.WriteLine(ss);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            string time = DateTime.Now.ToString();
            Console.WriteLine(time);


            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            string stext = "Lorem ipsum dolor sit amet, <upcase>consectetuer</upcase> adipiscing <upcase>elit.</upcase>";
            Console.WriteLine(Up(stext));

            Console.ReadLine();
        }
        static string Up(string s)
        {
            StringBuilder builder = new StringBuilder(15);
            for (int i = s.IndexOf("<upcase>") + 8; i < s.IndexOf("</upcase>"); i++)
            {
                builder.Append(s[i].ToString());
            }
            string stext = s.Replace("<upcase>" + builder.ToString() + "</upcase>", builder.ToString().ToUpper());
            return stext;
        }
    }
}
