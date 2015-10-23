<Query Kind="Statements">
  <Reference>D:\entityframework.6.1.3\lib\net45\EntityFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\mscorlib.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Core.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Data.Entity</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

List<string> list = new List<string>();
list.AddRange(new string[]
{
    "item1",
    "item2",
    "item3",
    "item4"
});

string item2 = list.Find(x => x == "item2");
item2.Dump();
string item3 = list.Where(x => x == "item3").FirstOrDefault();
item3.Dump();
