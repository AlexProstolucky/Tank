
class Tank : ICloneable
{
    public string name { get; set; }
    public int mas { get; set; }
    public int max_p { get; set; }
    public int max_range { get; set; }
    public int max_V { get; set; }
    public int max_S { get; set; }

    public Tank(string name, int mas, int max_p, int max_range, int max_V, int max_S)
    {
        this.name = name;
        this.mas = mas;
        this.max_p = max_p;
        this.max_range = max_range;
        this.max_V = max_V;
        this.max_S = max_S;
    }

    public object Clone() 
    {
        return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $" Name -> {name}\n Weight -> {mas} \n Number of seats -> {max_p} \n Range -> {max_range} \n Speed -> {max_V} \n Drive km -> {max_S}";
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Tank t1 = new Tank("T62", 38, 4, 500, 50, 580);
        Tank t2 = (Tank)t1.Clone();
        t2.name = "T64";
        t2.max_range = 770;
        t2.max_S = 550;
        Console.WriteLine("The first tank:");
        Console.WriteLine(t1.ToString());
        Console.WriteLine("\nA copy of the first one that was changed:");
        Console.WriteLine(t2.ToString());
    }
}