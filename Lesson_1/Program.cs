using static ArrayCreator;
using static ArrayMath;
using System.Diagnostics;

System.Console.Clear();
var array = Create(10); // Можно так еслит пишешь using static ArrayCreator
var array1 = ArrayCreator.Create(10); // Можно не писать using static ArrayCreator
int[] array2 = Create(10); // Можно так
int[] array3 = 1_000_000.CreateV2()
                    .FillRandomUpDate(1,10);
// array3.ConvertToStringAndPrintToTerminal(); // Можно так если добавить this

int max;
int n = 1_000;
Stopwatch sw = new Stopwatch();
sw.Start();
max = array3.BadGetSum(n);
sw.Stop();
System.Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array3.GoodGetSum(n);
sw.Stop();

System.Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");




// System.Console.WriteLine(array3.ConvertToString());


// "Можно даже так"

// 10.CreateV2()
//                     .Fill()
//                     .ConvertToStringAndPrintToTerminal();
// Конец "Можно даже так"
