
using tascN2_Classes;
Console.WriteLine("Результаты с браслетов участников конкурса за 10 дней:");
Human[] steps = new Human[10];
Random rand = new Random();

for (int i = 0; i < steps.Length; i++)
{
    steps[i] = new Human(rand.Next(10000), rand.Next(10000), rand.Next(10000));
    Console.WriteLine(steps[i]);
}