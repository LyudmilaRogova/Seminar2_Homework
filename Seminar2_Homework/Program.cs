//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondDigit(){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Исходное число: " + num);
//     int result = num / 10 % 10;
//     return result;
// }

// Console.WriteLine("Вторая цифра числа: " + SecondDigit());



//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThirdDigit(int number){
//     int result;
//     int i = 0; //длина числа
//     int num = number;
//     if(number / 100 == 0){
//         result = -1;
//         return result;
//     }
//     else{
//         while (num > 0){ 
//             num /= 10;
//             i++;
//         }
//         result = (number / (Convert.ToInt32(Math.Pow(10, i - 3)))) % 10;
//         return result;
//     }
    
// }

// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int third = ThirdDigit(number1);
// if (third == -1){
//     Console.WriteLine("Третьей цифры нет");
// }
// else{
//     Console.WriteLine("Третья цифра: " + third);
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void WeekendDay(int day){
    if (day == 6 || day == 7){
        Console.WriteLine("Ура! Выходной!");
    }
    else if(day == 1 || day == 2 || day == 3 || day == 4 || day == 5){
        Console.WriteLine("Будний день");
    }
    else{
        Console.WriteLine("Дня недели с введенным номером нет");
    }
}

Console.Write("Введите номер дня недели: ");
int NumDay = Convert.ToInt32(Console.ReadLine());
WeekendDay(NumDay);

