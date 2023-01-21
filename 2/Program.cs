/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/
int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
string GetCoord(int chetvert)
{
    if (chetvert == 1)
    {
        return "x > 0 ; y > 0";
    }
    if (chetvert == 2)
    {
        return "x < 0 ; y > 0";
    }
    if (chetvert == 3)
    {
        return "x < 0 ; y < 0";
    }
    return "x > 0 ; y < 0";
}
int a = Prompt("Введите номер четверти");
if (a > 4 || a < 1)
{
    System.Console.WriteLine("Введен некорректный номер четверти");
}
else
{
    string resultat = GetCoord(a);
    System.Console.WriteLine(resultat);
}

//все переменные начинаются с маленькой буквы в c#
// все функции начинаются с большой буквы