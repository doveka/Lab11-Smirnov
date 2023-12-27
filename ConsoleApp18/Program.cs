using System;

public class Circle
{
    protected double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public virtual double Area()
    {
        return Math.PI * radius * radius;
    }

    public virtual void Increase(double factor)
    {
        radius *= factor;
    }

    public string Information()
    {
        return $"Радиус: {radius}, Площадь: {Area()}";
    }
}

public class Ring : Circle
{
    private double innerRadius;

    public Ring(double r, double rin) : base(r)
    {
        innerRadius = rin;
    }

    public override double Area()
    {
        return base.Area() - Math.PI * innerRadius * innerRadius;
    }

    public override void Increase(double factor)
    {
        base.Increase(factor);
        innerRadius *= factor;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Ring ring = new Ring(10, 7);

        Console.WriteLine("Информация о круге:");
        Console.WriteLine(circle.Information());

        Console.WriteLine("Информация о кольце:");
        Console.WriteLine(ring.Information());

        circle.Increase(1.5);
        ring.Increase(1.5);

        Console.WriteLine("Обновленная информация о круге:");
        Console.WriteLine(circle.Information());

        Console.WriteLine("Обновленная информация о кольце:");
        Console.WriteLine(ring.Information());
    }
}