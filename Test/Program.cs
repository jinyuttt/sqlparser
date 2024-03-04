// See https://aka.ms/new-console-template for more information
using AnalysisSQL;

Console.WriteLine("Hello, World!");
string sql = "select * from student m join  Test n  on m.id=n.id";
SqlParser parser = new SqlParser();
parser.Parse(sql);
Console.WriteLine(parser.ToText());
