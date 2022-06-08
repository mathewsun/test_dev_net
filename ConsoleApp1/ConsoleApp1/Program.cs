//Ниже представлены фрагменты кода. Для каждого из них нужно выбрать 1 ответ
//В ответах может быть:
//   CTE - compile - time exception,
//   RTE - runtime exception,
//   всё остальное - вывод на консоль.
//Код находится внутри метода Main

//1.
int a = 5;
object o = a;
var x = (long)o;
Console.Write(x.GetType().Name);

// A: CTE
// B: RTE
// C: int
// D: long
// E: Int32
// F: Int64

//2.
var str = "123";
var newStr = str;
str = newStr + "345";
Console.Write(newStr);

// A: CTE
// B: RTE
// C: 123
// D: 345
// E: 123345
// F:

//3.
var count = 0;
Enumerable.Repeat(1, 100)
    .Where((_) => count < 50)
    .Select((x) => count++);
Console.Write(count);

// A: CTE
// B: RTE
// C: 0
// D: 49
// E: 50
// F: 100

//4.
const int iterations = 1000000000;
var count = 0;
// аналог for(int i = 0; i < iterations; i++) { count++ },
// только в несколько потоков
Parallel.For(0, iterations, (_) => count++);
Console.Write($"{count > iterations}, {count < iterations}");

// A: CTE
// B: RTE
// C: True, False
// D: False, True
// E: False, False
// F: True, True

//5.
var actions = new List<Action>();
for (var count = 0; count < 5; count++)
{
    actions.Add(() => Console.Write(count + " "));
}
foreach (var action in actions)
{
    action();
}

// A: CTE
// B: RTE
// C: 0, 0, 0, 0, 0
// D: 0, 1, 2, 3, 4
// E: 1, 2, 3, 4, 5
// F: 5, 5, 5, 5, 5