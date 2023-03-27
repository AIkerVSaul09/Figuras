# Figuras
27/03/23
public abstract class Figuras
{
  private double largo;
  private double ancho;
  private string? color;
  int x,y;

   public Figuras(int x,int y, string color,double largo,double ancho)
   {
    this. x=x;
    this. y=y;
    this. color=color;
    this. largo=largo;
    this. ancho=ancho;
   }
  public abstract float Area();
  public abstract void Dibuja();

}
 public class Rectangulo: Figuras
{
    public Rectangulo(double largo, double ancho, string color,int x, int y):base(largo:l,ancho:a,color:color,x:x,y:y)
    {
      largo=largo;
    }
    public override void Area()
    {
        return (largo*ancho);
    }
    public override void Dibuja()
    {
        Console.WriteLine("La figura esta ubicada en las siguiente coordenadas (2,9)");
    }

}
 public class Circulo: Figuras
{
    public int diametro{get;set;}
     public Circulo(int d,double largo, double ancho, string color,int x, int y):base(largo:largo,ancho:ancho,color:color,x:x,y:y)
    {
      diametro=d;
    }
    public override float Area()
    {
        return MathF.Pow((MathF.PI*diametro)/2,2);
    }
    public override void Dibuja()
    {
        Console.WriteLine("La figura esta ubicada en las siguiente coordenadas (2,9)");
    }

}
 public class Triangulo: Figuras
{
     public int Base{get;set;}
      public int Altura{get;set;}
     public Triangulo(int b,int a,double largo, double ancho, string color,int x, int y):base(largo:largo,ancho:ancho,color:color,x:x,y:y)
    {
      Base=b;
      Altura=a;
    }
    public override float Area()
    {
        return ((Base*Altura)/2);
    }
    public override void Dibuja()
    {
        Console.WriteLine("La figura esta ubicada en las siguiente coordenadas (2,9)");
    }

}
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
