Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7 || num < 1)
{
    Console.WriteLine("Такого для недели не существует");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной!!!");
}
else
{
    Console.WriteLine("Не выходной :'(");
}