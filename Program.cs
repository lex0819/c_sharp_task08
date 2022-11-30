/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Enter number more than 1:");
string numberStr = Console.ReadLine() ?? "";

if(int.TryParse(numberStr, out int number)){
  if(number >= 2){
    Console.Write($"{number} -> ");
    for (int i = 2; i <= number; i = i + 2){
      Console.Write($"{i}, ");
    }
  }else{
    Console.WriteLine($"invalid input {number} less than 2");
  }
}else{
  Console.WriteLine($"invalid input");
}