
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999 ) {
    Console.WriteLine("Не правильное число");
}
else{
    int numberOne = number % 10;
    int numberTwo = ((number % 10000) / 1000) % 10;
    string result = Convert.ToString(numberTwo) + Convert.ToString(numberOne);
    string numberThree = Convert.ToString(number % 100);
    if(result == numberThree) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}