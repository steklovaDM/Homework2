/*Task1

Console.WriteLine("Введите трехзначное число\n");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
*/

/*Task3

Console.Write("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("ERROR"); break;
}
Console.ReadKey();

switch (num)
{
    case 6:
    case 7: 
        Console.WriteLine("Да"); 
        break;
    default: 
        Console.WriteLine("Нет"); 
        break;
}
*/

/*Task 2

Console.WriteLine("Введите трехзначное число\n");
string? input = Console.ReadLine();

if (String.IsNullOrEmpty(input) || input.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(input[2]);
}
*/
