using System;

// Клас, що представляє складові гелікоптера
public class Rotor
{
    public string Name { get; set; }

    public Rotor(string name)
    {
        Name = name;
    }

    public void Rotate()
    {
        Console.WriteLine($"Ротор {Name} обертається.");
    }
}

public class Engine
{
    public string Name { get; set; }

    public Engine(string name)
    {
        Name = name;
    }

    public void Start()
    {
        Console.WriteLine($"Двигун {Name} запущений.");
    }

    public void Stop()
    {
        Console.WriteLine($"Двигун {Name} зупинений.");
    }
}

public class Body
{
    public string Type { get; set; }

    public Body(string type)
    {
        Type = type;
    }

    public void Assemble()
    {
        Console.WriteLine($"Тип корпусу: {Type}. Корпус зібраний.");
    }
}

// Компонувальник для формування гелікоптера
public class HelicopterComposer
{
    public Rotor CreateRotor(string name)
    {
        return new Rotor(name);
    }

    public Engine CreateEngine(string name)
    {
        return new Engine(name);
    }

    public Body CreateBody(string type)
    {
        return new Body(type);
    }
}


