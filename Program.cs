Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);
Console.WriteLine("Ingrese un número: ");
string numIngresado = Console.ReadLine();
int num;
bool resultado = int.TryParse(numIngresado, out num);
 
if (resultado)
{
    if (num > 0)
    {
        int numInvertido = 0;
            int aux = num;
        while (aux != 0)
        {
        numInvertido*=10;
        numInvertido += aux % 10;
        aux /= 10; 
        }    
        Console.WriteLine("Número invertido: "+numInvertido);
    }
}else
{
    Console.WriteLine("Ingrese un número!!!!"); 
}