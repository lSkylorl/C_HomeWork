Console.WriteLine("Введите координату X точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X вточки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y вточки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z вточки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double len = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zA - zB) * (zA - zB));
Console.WriteLine($"Длинна отрезка: {len}");