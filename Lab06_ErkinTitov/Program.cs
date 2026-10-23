using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
// // Задача 1
// System.Console.Write("Введите сумму заказа: ");
// double sum = double.Parse(System.Console.ReadLine()!);

// if (sum >= 3000)
// {
//     System.Console.WriteLine("Бесплатная доставка");
// }
// System.Console.WriteLine();
// // Задача 2
// System.Console.Write("Введите остаток заказа: ");
// int stock = int.Parse(System.Console.ReadLine()!);

// if (stock > 0)
// {
//     System.Console.WriteLine("В наличии");
// }
// else
// {
//     System.Console.WriteLine("Под заказ");
// }
// System.Console.WriteLine();
// // Задача 3
// System.Console.Write("Введите вес посылки: ");
// double weight = double.Parse(System.Console.ReadLine()!);

// string result = weight switch
// {
//     >= 20 => "Требуется согласование",
//     >= 5 => "Грузовая доставка",
//     >= 1 => "Курьер на авто",
//     <= 1 => "Курьер на велосипеде",
//     _ => "Неправильный вес"
// };
// System.Console.WriteLine($"Состояние: {result}");
// System.Console.WriteLine();
// Задача 4
// using System.Runtime.InteropServices;

// System.Console.Write("Выберите способ оплаты (1 - карта, 2 - наличные, 3 - электронный кошелёк): ");
// int paymentMethod = int.Parse(System.Console.ReadLine()!);

// switch (paymentMethod)
// {
//     case 1:
//         System.Console.WriteLine("Карта");
//         break;
//     case 2:
//         System.Console.WriteLine("Наличные");
//         break;
//     case 3:
//         System.Console.WriteLine("Электронный кошелёк");
//         break;
//     default:
//         System.Console.WriteLine("Неизвестный способ оплаты");
//         break;
// }

// // Задача 5
// System.Console.WriteLine();
// System.Console.Write("Введите номер месяца (от 1 до 12): ");
// int monthNumber = int.Parse(System.Console.ReadLine()!);

// switch (monthNumber)
// {
//     case 1:
//         System.Console.WriteLine("I квартал");
//         break;
//     case 2:
//         System.Console.WriteLine("I квартал");
//         break;
//     case 3:
//         System.Console.WriteLine("I квартал");
//         break;
//     case 4:
//         System.Console.WriteLine("II квартал");
//         break;
//     case 5:
//         System.Console.WriteLine("II квартал");
//         break;
//     case 6:
//         System.Console.WriteLine("II квартал");
//         break;
//     case 7:
//         System.Console.WriteLine("III квартал");
//         break;
//     case 8:
//         System.Console.WriteLine("III квартал");
//         break;
//     case 9:
//         System.Console.WriteLine("III квартал");
//         break;
//     case 10:
//         System.Console.WriteLine("IV квартал");
//         break;
//     case 11:
//         System.Console.WriteLine("IV квартал");
//         break;
//     case 12:
//         System.Console.WriteLine("IV квартал");
//         break;
//     default:
//         System.Console.WriteLine("Неизвестный способ оплаты");
//         break;
// }

// // Задача 6
// System.Console.WriteLine();
// System.Console.Write("Введите сумму заказа: ");
// double sum = double.Parse(System.Console.ReadLine()!);

// System.Console.Write("Есть ли промокод? (1 - да, 0 - нет): ");
// int PromoCode = int.Parse(System.Console.ReadLine()!);

// bool hasPromoCode = PromoCode == 1;


// System.Console.WriteLine(hasPromoCode);

// if (sum >= 1000 && hasPromoCode)
// {
//     System.Console.WriteLine("Скидка 15% применена");
// }
// else
// {
//     System.Console.WriteLine("Скидка не применяется");
// }

// // Задача 7
// System.Console.WriteLine();
// System.Console.Write("Постоянный ли клиент? (1 - да, 0 - нет): ");
// int Regular = int.Parse(System.Console.ReadLine()!);

// bool isRegular = Regular == 1;


// System.Console.WriteLine(isRegular);
// System.Console.Write("Сумма заказа больше 5000? (1 - да, 0 - нет): ");
// int Order = int.Parse(System.Console.ReadLine()!);

// bool bigOrder = Order == 1;


// System.Console.WriteLine(bigOrder);

// if (isRegular || bigOrder)
// {
//     System.Console.WriteLine("Подарок к заказу");
// }
// else
// {
//     System.Console.WriteLine("Без подарка");
// }

// Задача 8
System.Console.Write("Выберите товар (Electronic - Cloth - Food): ");
string category = System.Console.ReadLine()!;

string result3 = category switch
{
    "Electronic" => "3-5 дней",
    "Cloth" => "2-3 дней",
    "Food" => "В течение суток",
    _ => "Неправильный товар"
};

System.Console.WriteLine($"Срок доставки: {result3}");

// Задача 9
System.Console.WriteLine();

System.Console.Write("Сумма заказа: ");
double sum = double.Parse(System.Console.ReadLine()!);

System.Console.Write("Постоянный ли клиент? (1 - да, 0 - нет): ");
int regular = int.Parse(System.Console.ReadLine()!);

bool isRegular = regular == 1;


System.Console.WriteLine(isRegular);
System.Console.Write("Есть промокод? (1 - да, 0 - нет): ");
int PromoCode = int.Parse(System.Console.ReadLine()!);

bool hasPromoCode = PromoCode == 1;


System.Console.WriteLine(hasPromoCode);

if ((isRegular || hasPromoCode) && sum >= 500)
{
    System.Console.WriteLine("Скидка предоставлена");
}
else
{
    System.Console.WriteLine("Скидка не предоставлена");
}

