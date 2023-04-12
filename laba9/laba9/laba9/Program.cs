class Program
{
    static void Main(string[] args)
    {
        // Створення компонувальника
        var composer = new HelicopterComposer();

        // Створення складових гелікоптера
        var rotor1 = composer.CreateRotor("Ротор 1");
        var rotor2 = composer.CreateRotor("Ротор 2");
        var engine = composer.CreateEngine("Двигун 1");
        var body = composer.CreateBody("Тип 1");

        // Взаємодія зі складовими гелікоптера
        rotor1.Rotate();
        rotor2.Rotate();
        engine.Start();
        body.Assemble();
        engine.Stop();

        Console.ReadKey();
    }
}