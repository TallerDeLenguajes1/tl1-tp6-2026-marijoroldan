// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);
// Console.WriteLine("Ingrese un número: ");
// string numIngresado = Console.ReadLine();
// int num;
// bool resultado = int.TryParse(numIngresado, out num);

// if (resultado)
// {
//     if (num > 0)
//     {
//         int numInvertido = 0;
//             int aux = num;
//         while (aux != 0)
//         {
//         numInvertido*=10;
//         numInvertido += aux % 10;
//         aux /= 10; 
//         }    
//         Console.WriteLine("Número invertido: "+numInvertido);
//     }
// }else
// {
//     Console.WriteLine("Ingrese un número!!!!"); 
// }
string operando;

do
{
Console.WriteLine("Elegir una opcion: ");
Console.WriteLine("1. Suma 2. Resta 3. Multiplicación 4. Dividir ");
string opcion = Console.ReadLine();
int num1, num2, opcion2;
bool resultado3 = int.TryParse(opcion, out opcion2);
if (opcion2 == 1 || opcion2 == 2 || opcion2 == 3 || opcion2 ==4)
{
Console.WriteLine("Ingrese un numero ");
string num1S = Console.ReadLine();
Console.WriteLine("Ingrese otro numero ");
string num2S = Console.ReadLine();
bool resultado1 = int.TryParse(num1S, out num1);
bool resultado2 = int.TryParse(num2S, out num2);
    
    if (resultado1 && resultado2 && resultado3)
    {
        switch (opcion2)
        {
            case 1:
                int suma = num1 + num2;
                Console.WriteLine("Suma: " + suma);
                break;
            case 2:
                int resta = num1 - num2;
                Console.WriteLine("Resta: " + resta);
                break;
            case 3:
                int multi = num1 * num2;
                Console.WriteLine("El resultado de la multiplicación: " + multi);
                break;
            case 4:
                int div = num1 / num2;
                Console.WriteLine("División: " + div);
                break;
        }
    } else
    {
        Console.WriteLine("Por favor ingrese bien los datos!!!");
    }
    Console.WriteLine("Desea seguir operando? ");
    operando = Console.ReadLine();
} else
{
    Console.WriteLine("Por favor ingrese una operación válida!!!");
    Console.WriteLine("Desea seguir operando? ");
    operando = Console.ReadLine();
}

} while (operando != "no");



