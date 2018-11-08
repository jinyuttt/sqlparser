using AnalysisSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = "select * from student m join  Test n  on m.id=n.id";
            SqlParser parser = new SqlParser();
            parser.Parse(sql);
           Console.WriteLine(parser.ToText());
        }
    }
}
