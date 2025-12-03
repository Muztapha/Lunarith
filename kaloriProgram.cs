int almamgereken, bugünaldığım, adım, kaloriaçığı;
double adımkalori, toplamkalori;
Console.WriteLine("Daily calorie need:");
almamgereken = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Calorie intake today:");
bugünaldığım = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many steps have you walked:");
adım = Convert.ToInt32(Console.ReadLine());
adımkalori = (adım * 0.04);
toplamkalori = bugünaldığım - adımkalori;
kaloriaçığı = almamgereken - (int)toplamkalori;
Console.WriteLine("Daily calorie deficit:{0}", kaloriaçığı);
if (kaloriaçığı < almamgereken)
{
    Console.WriteLine("Losing weight!");
}
else
{
    Console.WriteLine("Gaining weight");
}
Console.ReadKey();
