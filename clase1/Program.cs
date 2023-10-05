// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Profe!");
// Programa para dividir si un numero es mayor que otro.
/*
double num1, num2, resultado;

Console.WriteLine("Ingresa dos numeros");
num1 = Convert.ToDouble(Console.ReadLine());
num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    resultado = num1 / num2;
    Console.WriteLine("el resultado es: " + resultado);
}
else if (num2 > num1)
{
    resultado = num2 / num1;
    Console.WriteLine("el resultado es: " + resultado);
}
else
{
    Console.WriteLine("los 2 numeros son iguales");
}
*/

//ejercicio 2
/*
double num1, num2,producto;
string mensajeResultado;

Console.WriteLine("ingresa el primer numero: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingresa el segundo numero: ");
num2 = Convert.ToDouble(Console.ReadLine());

producto = num1 * num2;

if (producto > 0)
{
    mensajeResultado = "positivo";
}
else if (producto < 0)
{
    mensajeResultado = "negativo";
}
else
{
    mensajeResultado = "cero";
}
Console.WriteLine("El resultado del producto es: " + producto);
Console.WriteLine("El producto es: " + mensajeResultado + ".");
*/

/*

//ejercicio 3 

Console.Write("Ingrese su nombre completo: ");
string nombreCompleto = Console.ReadLine();

Console.Write("Ingrese su salario: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese los años de antigüedad en la empresa: ");
int antiguedad = Convert.ToInt32(Console.ReadLine());

double incremento = 0;

if (antiguedad < 1)
    incremento = salario * 0.01; // 1% de incremento
else if (antiguedad >= 2 && antiguedad <= 5)
    incremento = salario * 0.02; // 2% de incremento
else
    incremento = salario * 0.10; // 10% de incremento

double salarioNeto = salario + incremento;

Console.WriteLine($"Salario Neto: {salarioNeto:C}");

*/

/*
//ejercicio 4

Console.Write("Ingrese el nombre del artículo: ");
string nombreArticulo = Console.ReadLine();

Console.Write("Ingrese el valor unitario del artículo: ");
double valorUnitario = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la cantidad de artículos: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

double valorCompra = valorUnitario * cantidad;

if (valorCompra > 200000)
{
    valorCompra *= 0.98; // Aplicar descuento del 2%
}

double iva = valorCompra * 0.16; // 16% de IVA
double totalCompra = valorCompra + iva;

Console.WriteLine($"Valor total de la compra (con IVA): {totalCompra:C}");
*/

// ejercicio 5
/*
        int sumaPares = 0;
        int sumaImpares = 0;

        for (int i = 1; i <= 200; i++)
        {
            if (i % 2 == 0)
            {
                sumaPares += i;
            }
            else
            {
                sumaImpares += i;
            }
        }

        Console.WriteLine($"Suma de números pares: {sumaPares}");
        Console.WriteLine($"Suma de números impares: {sumaImpares}");
*

/*Console.Write("Ingrese un número entre 1 y 200: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero < 1 || numero > 200)
{
    Console.WriteLine("El número ingresado debe estar entre 1 y 200.");
}
else
{
    int sumaPares = 0;
    int sumaImpares = 0;

    for (int i = 1; i <= numero; i++)
    {
        if (i % 2 == 0)
        {
            sumaPares += i;
        }
        else
        {
            sumaImpares += i;
        }
    }

    Console.WriteLine($"Suma de números pares hasta {numero}: {sumaPares}");
    Console.WriteLine($"Suma de números impares hasta {numero}: {sumaImpares}");
}*/

// ejercicio 6 
/*
int tarifaDiurna = 20000;
int tarifaNocturna = 30000;
int incrementoDiurnoDomingo = 7000;
int incrementoNocturnoDomingo = 12000;

// Pedir al usuario que ingrese el turno y si es domingo
Console.WriteLine("Ingrese el turno (1 para diurno, 2 para nocturno): ");
int turno = int.Parse(Console.ReadLine());

Console.WriteLine("¿Es domingo? (Sí=1, No=0): ");
int esDomingo = int.Parse(Console.ReadLine());

// Calcular el salario
int salario = 0;

if (turno == 1) // Turno diurno
{
    salario = tarifaDiurna;

    if (esDomingo == 1)
    {
        salario += incrementoDiurnoDomingo;
    }
}
else if (turno == 2) // Turno nocturno
{
    salario = tarifaNocturna;

    if (esDomingo == 1)
    {
        salario += incrementoNocturnoDomingo;
    }
}
else
{
    Console.WriteLine("Turno no válido.");
    return;
}

Console.WriteLine("El salario es: " + salario + " pesos.");
    */
/*
// ejrcicio 7
// Pedir al usuario que ingrese los tres números
Console.WriteLine("Ingrese el primer número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número: ");
int numero3 = int.Parse(Console.ReadLine());

// Comprobar si la suma de una de las parejas es igual al tercer número
if ((numero1 + numero2 == numero3) || (numero1 + numero3 == numero2) || (numero2 + numero3 == numero1))
{
    Console.WriteLine("Son iguales");
}
else
{
    Console.WriteLine("Distintos");
}
*/

//ejercicio 8
// Pedir al usuario que ingrese el nombre del trabajador
Console.WriteLine("Ingrese el nombre del trabajador: ");
string nombre = Console.ReadLine();

// Pedir al usuario que ingrese las horas trabajadas y el precio de la hora
Console.WriteLine("Ingrese las horas trabajadas: ");
double horasTrabajadas = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el precio de la hora: ");
double precioHora = double.Parse(Console.ReadLine());

// Calcular el salario bruto
double salarioBruto = horasTrabajadas * precioHora;

// Calcular los impuestos (10% del salario bruto)
double impuestos = salarioBruto * 0.10;

// Calcular el salario neto
double salarioNeto = salarioBruto - impuestos;

// Mostrar el resultado
Console.WriteLine("Nombre del trabajador: " + nombre);
Console.WriteLine("Salario Bruto: $" + salarioBruto);
Console.WriteLine("Impuestos: $" + impuestos);
Console.WriteLine("Salario Neto: $" + salarioNeto);
    