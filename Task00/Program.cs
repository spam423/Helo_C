/* Напишите программу которая на входе принимает два числа 
и проверяет, является ли первое число квдратом второго.
a = 25, b = 5 -> да
a = 2, b = 10  -> нет
a = 9, b = -3 -> да
a = -3, b = 9  -> нет*/

int firstNumber, secondNumber;

Console.WriteLine("Введите первое число");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine($"первое число = {firstNumber}, воторое число = {secondNumber} -> Да");
}
else
{
    Console.WriteLine($"первое число = {firstNumber}, второе число = {secondNumber} -> Нет");
}