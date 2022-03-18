int[] arr = new int[100];
for(int i = 0; i < 100; i++)
{
    arr[i] = (int)(new Random().NextDouble()*1000);
}

IEnumerable<int> orderedArr =
    from item in arr
    orderby item descending
    select item;

double avg = (from item in arr
         select item).Average();

double sum = (from item in arr
              select item).Sum();


Console.WriteLine("100个数按降序排列为：");
foreach (var a in orderedArr)
{
    Console.WriteLine(a);
}

Console.WriteLine("和为：");
Console.WriteLine(sum);

Console.WriteLine("平均数为：");
Console.WriteLine(avg);

