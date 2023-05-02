Predicate<string> isUpper = (str) => str == str.ToUpper();

Console.WriteLine(isUpper.Invoke("ALI"));


Func<int, int, int> multiply = (num1, num2) =>  num1 * num2;

Console.WriteLine(multiply.Invoke(5, 10));


Action<int, int, int, int> sum = (num1, num2, num3, num4) => Console.WriteLine(num1 + num2 + num3 + num4);

Predicate<int> isDivided = (num) => num % 3 == 0 && num % 5 == 0;


Console.WriteLine(isDivided.Invoke(15));