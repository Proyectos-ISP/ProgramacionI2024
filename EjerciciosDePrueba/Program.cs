
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiasDeVida();
        //ImprimirMinimoDe4();
        //type_of_triangle();
        validate_date();
    }

    /// <summary>
    /// algoritmo que imprime el mínimo entre cuatro valores que se piden al usuario.
    /// </summary>
    private static void ImprimirMinimoDe4()
    {
        //declaramos las variables
        int num1, num2, num3, num4;

        //pedimos el ingreso de los 4 números
        Console.Write("Ingrese el primer número:");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número:");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número:");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto número:");
        num4 = int.Parse(Console.ReadLine());
    }

    //Creamos un método que pida el nombre y apellido del usuario
    //y posteriormente lo salude con "Bienvenido [Apellido], [Nombre]
    private static void PedirNombreYSaludar()
    {
        //Declaramos las variables
        string nombre, apellido;

        Console.Write("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido:");
        apellido = Console.ReadLine();

        //Console.WriteLine("Bienvenido "+apellido+", "+nombre);
        Console.WriteLine($"Bienvenido {apellido}, {nombre}");
    }

    /*Creamos un método que nos pida los años, meses y días de vida
    y muestre al final la cantidad total de días de vida
     */
    private static void CalcularDiasDeVida()
    {
        //declaramos las variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida:");
        años = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida:");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus días de vida:");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;

        Console.WriteLine($"Los días de vida totales son:{diasDeVida}");
    }

    //    Realizar un programa que pida los valores de los tres lados de
    //un triángulo e imprima si el mismo es equilátero, isósceles o
    //escaleno.Hacer el diagrama de flujo correspondiente.

    private static void type_of_triangle()
    {
        // def vars
        int side_1, side_2, side_3;

        // read the response
        Console.WriteLine("Put the size of the side 1");
        side_1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the size of the side 2");
        side_2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Put the size of the side 3");
        side_3 = int.Parse(Console.ReadLine());

        // compare the results
        //  equilateral = same sides
        // isosceles = 2 same 1 diff
        // scalene = 3 diff sides

        if (side_1 == side_2 && side_2 == side_3)
        {
            Console.WriteLine("This triangle is a equilateral.");
        }
        else if (side_1 == side_2 || side_2 == side_3 || side_1 == side_3)
        {
            Console.WriteLine("This triangle is a isosceles");
        }
        else
        {
            Console.WriteLine("This triangle is a scalene");
        }


    }

    //    Leer tres valores que corresponden a un día, un mes y un año y
    //determinar si se trata de una fecha válida o no.

    private static void validate_date()
    {
        // def vars

        int day, month, year;

        Console.WriteLine("Enter the day of birth.");
        day = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the month of birth.");
        month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the year of birth.");
        year = int.Parse(Console.ReadLine());

        if(day == 0 || day > 31)
        {
            Console.WriteLine("The day is incorrectly formatted");
        }

        if(month > 12 || month == 0)
        {
            Console.WriteLine("The month is incorrectly formatted");
        }

        if(year == 0)
        {
            Console.WriteLine("The year is incorrectly formatted");
        }
    }
}

