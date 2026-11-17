using System.Text;


#region Q1
string title = "clean code ";
string title02 = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(title02);
#endregion




#region Q2
string x = "clean code";
string y="clean code";
Console.WriteLine(object.ReferenceEquals(x,y));
#endregion

#region Q3
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("book list");
Console.WriteLine(stringBuilder);
stringBuilder.Append("_updated");
   Console.WriteLine( stringBuilder.ToString());
#endregion

#region Q4
stringBuilder.Replace("book list","library");
Console.WriteLine( stringBuilder.ToString());
#endregion

#region Q5
string title03 = "clean code";
int pages = 464;
Console.WriteLine("book:" + title03+ "pages:"+ pages);
#endregion
#region Q6
Console.WriteLine($"book:{title03},pages:{pages}");
#endregion

#region Q7
string result = string.Format("book : {0}, pages : {1}", title03, pages);

Console.WriteLine(result);

#endregion
# region Q8


int pages04 = 464;
if (pages > 300)
{
    Console.WriteLine("long book");
}
   else
{
    Console.WriteLine("short book");
}
#endregion


#region Q9

int pages05 = 464;
bool isAvailable = true;
if (pages > 300 && isAvailable == true)
{
    Console.WriteLine("you can borrow this book");
}
#endregion







#region Q10
string title07 = "refactoring";

switch (title07)
{
    case "clean code":
        Console.WriteLine("great choice");
        break;
    case "refactoring":
        Console.WriteLine( "nice pick" );
        break;
    default:
        Console.WriteLine( "never heard of it" );
        break;

}
#endregion




#region Q11
string[] bookTitles = { "clean code", "progmatic programmer", "refacrtoring" };

for (int i = 0; i < bookTitles.Length; i++)
{
    Console.WriteLine((i + 1) + " ," + bookTitles[i]);
}
#endregion





#region Q12
int index = 0;
while (index < bookTitles.Length)

{
    Console.WriteLine(bookTitles[index]);
    index++;

}
#endregion

#region Q13
int count = 0;
do
{
    Console.WriteLine("checking book");
    count++;

} while (count < 3);

#endregion

#region Q14
foreach (string book in bookTitles)
{
    Console.WriteLine(book);

}
#endregion

#region Q15
foreach (string book in bookTitles)
{
    if (book == "refractoring")
    {
        break;
    }
    Console.WriteLine(book);

}
#endregion

#region Q16
foreach (string book in bookTitles)

{
    if ( book == "the pragmtic programmer")
    {
        continue;
    }
    Console.WriteLine(book);

}
#endregion

#region Q17

void printFirstBook(string[]books)
{
    if (books.Length == 0)
    {
        return;
    }
    Console.WriteLine(books[0]);

}
#endregion 