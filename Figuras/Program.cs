using System;

public abstract class Figuras
{
    protected double largo;
    protected double ancho;
    protected string color;
    protected int x, y;

    public Figuras(int x, int y, string color, double largo, double ancho)
    {
        this.x = x;
        this.y = y;
        this.color = color;
        this.largo = largo;
        this.ancho = ancho;
    }

    public abstract float Area();
    public abstract void Dibuja();
}

public class Rectangulo : Figuras
{
    public Rectangulo(double l, double a, string color, int x, int y) : base(x, y, color, l, a)
    {
        largo = l;
        ancho = a;
    }

    public override float Area()
    {
        return (float)(ancho * largo);
    }

    public override void Dibuja()
    {
        Console.WriteLine($"El rectángulo está ubicado en las coordenadas ({x},{y})");
    }
}

public class Circulo : Figuras
{
    private int diametro;

    public Circulo(int d, double largo, double ancho, string color, int x, int y) : base(x, y, color, largo, ancho)
    {
        diametro = d;
    }

    public override float Area()
    {
        return (float)(MathF.PI * MathF.Pow((diametro / 2), 2));
    }

    public override void Dibuja()
    {
        Console.WriteLine($"El círculo está ubicado en las coordenadas ({x},{y})");
    }
}

public class Triangulo : Figuras
{
    private int baseT;
    private int altura;

    public Triangulo(int b, int a, double largo, double ancho, string color, int x, int y) : base(x, y, color, largo, ancho)
    {
        baseT = b;
        altura = a;
    }

    public override float Area()
    {
        return (float)((baseT * altura) / 2);
    }

    public override void Dibuja()
    {
        Console.WriteLine($"El triángulo está ubicado en las coordenadas ({x},{y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangulo r = new Rectangulo(25, 15, "azul", 25, 15);
        Console.WriteLine($"El área del rectángulo es: {r.Area()}");
        r.Dibuja();

        Triangulo t = new Triangulo(65, 25, 14, 25, "Verde", 15, 15);
        Console.WriteLine($"El área del triángulo es: {t.Area()}");
        t.Dibuja();

        Circulo c = new Circulo(15, 25, 15, "Negro", 15, 48);
        Console.WriteLine($"El área del círculo es: {c.Area()}");
        c.Dibuja();

        Console.ReadKey();
    }
}
