using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Empleado
{
    class Program
    {
        static void Main(string[] args)
        {

            //Realizar un programa llamado “Empleado” con interfaz para consola en C# .NET que permita ingresar el nombre de un empleado
            //la antigüedad, la cantidad de horas trabajadas en el mes y el valor de la hora, además se requiere calcular el valor a cobrar teniendo en cuenta que al total
            //que resulte de multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumar la cantidad de años trabajados multiplicados por $50.000
            //y al total de todas esas operaciones restarle el 15 % en concepto de descuentos.
            //Imprimir en pantalla la información correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar

            //Pedimos datos de entrada 
            Console.Write("Por favor ingrese el nombre del empleado:");
            string nomEmpleado = Console.ReadLine();
            Console.WriteLine("\nAhora, ingrese la antiguedad (en años) de [{0}]", nomEmpleado);
            int antiguedad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nCuántas horas ha trabajado en el mes?");
            int horasMes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuál es el valor por hora de esas [{0}] horas?", horasMes);
            double valorHora = Convert.ToInt32(Console.ReadLine());

            //Hacemos las operaciones correspondientes de los valores
            double totalValorHoras = (valorHora * horasMes);
            double totalValorAños = (antiguedad * 50000);
            double sumaDinero = (totalValorAños + totalValorHoras);
            double descuento = (sumaDinero * 0.15);
            double totalNeto = (sumaDinero - descuento);

            //Daots de salida con su posterior cálculo
            Console.WriteLine("\nDatos de ingresos de [{0}]", nomEmpleado);
            Console.WriteLine("Antiguedad en años: [{0}]", antiguedad);
            Console.WriteLine("Valor de la hora: [{0}]", valorHora);
            Console.WriteLine("Total a cobrar (valor bruto): [{0}]", sumaDinero);
            Console.WriteLine("Total de descuentos: [{0}]", descuento);
            Console.WriteLine("Valor neto a cobrar: [{0}]", totalNeto);

            Console.ReadKey();
        }
    }
}
