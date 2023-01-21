/*Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/
int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Prompt("Введите координату x первой точки");
int y1 = Prompt("Введите координату y первой точки");
int x2 = Prompt("Введите координату x второй точки");
int y2 = Prompt("Введите координату y второй точки");

double Distance(double x1, double x2, double y1, double y2)// дабл - десятичное число
{
    double a; double b;
    a = x2 - x1;
    b = y2 - y1;
    return Math.Sqrt(a * a + b * b);//вывод математического корня Math.Sqrt(a * a)
}
System.Console.Write(Distance(x1, x2, y1, y2));