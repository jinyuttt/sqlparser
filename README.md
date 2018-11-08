# sqlparser
c#解析SQL语句（分析语句）

将SQL语句按照关键字填入XML,构造成节点方便查询使用。  
  SqlParser parser = new SqlParser();
            parser.Parse(sql);
