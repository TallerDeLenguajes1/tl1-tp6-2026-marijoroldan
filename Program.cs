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
Console.WriteLine("1. Valor Absoluto 2. Número al cuadrado 3. Raíz cuadrada 4. Seno 5. Coseno 6.Parte entera de un float");
string opcion1 = Console.ReadLine();
int opciones;
float num;
bool resultado3 = int.TryParse(opcion1, out opciones);
if (opciones == 1 || opciones == 2 || opciones == 3 || opciones ==4|| opciones ==5|| opciones ==6)
{
Console.WriteLine("Ingrese un numero: ");
string numPrincipal = Console.ReadLine();
bool resultado1 = float.TryParse(numPrincipal, out num);
    
    if (resultado1 && resultado3)
    {
        switch (opciones)
        {
            case 1:
                float Vabsoluto = Math.Abs(num);
                Console.WriteLine("Valor absoluto: " + Vabsoluto);
                break;
            case 2:
                double exponente = 2;
                double NumCuadrado = Math.Pow(num, exponente);
                Console.WriteLine("Número elevado al cuadrado: " + NumCuadrado);
                break;
            case 3:
                double raizCuadrada = Math.Sqrt(num);
                Console.WriteLine("El resultado de la multiplicación: " + raizCuadrada);
                break;
            case 4:
                double seno = Math.Sin(num);
                Console.WriteLine("El seno del número: " + seno);
                break;
             case 5:
                double coseno = Math.Cos(num);
                Console.WriteLine("El coseno del número: " + coseno);
                break;
             case 6:
                int parteEntera = (int)num; //aca estoy parseando sin el try parse
                Console.WriteLine("La parte entera es: " + parteEntera);
                break;
        }
    } else
    {
        Console.WriteLine("Por favor ingrese bien los datos!!!");
    }
    Console.WriteLine("Ingrese el primer numero: ");
string num22 = Console.ReadLine();
Console.WriteLine("Ingrese el segundo numero ");
string num33 = Console.ReadLine();
float numParseado1, numParseado2;
bool resul1 = float.TryParse(num22, out numParseado1);
bool resul2 = float.TryParse(num33, out numParseado2);
if (resul1 && resul2)
{
    if (numParseado1 > numParseado2)
    {
        Console.WriteLine("Número Mayor: " + numParseado1);
        Console.WriteLine("Número Menor: " + numParseado2);
    }else if (numParseado1<numParseado2)
    {
        Console.WriteLine("Número Mayor: " + numParseado2);
        Console.WriteLine("Número Menor: " + numParseado1);
        
    }else
    {
      Console.WriteLine("Los números son iguales");
    }
}
    Console.WriteLine("Desea seguir operando? ");
    operando = Console.ReadLine();
} else
{
    Console.WriteLine("Por favor ingrese una operación válida!!!");
    Console.WriteLine("Desea seguir operando? (escriba 'no' para dejar de operar)");
    operando = Console.ReadLine();
}

} while (operando != "no");
