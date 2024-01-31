// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int cedula = 0;
Console.WriteLine("digite su cedula");
cedula = int.Parse(Console.ReadLine());



string nombre;
Console.WriteLine("digite el nombre");
nombre = Console.ReadLine();

int tipo = 0;
Console.WriteLine("digite el tipo de empleado");
Console.WriteLine("1-operario");
Console.WriteLine("2-tecnico");
Console.WriteLine("3-profecional");
tipo = int.Parse(Console.ReadLine());

float salario = 0;
float operario = 100;
float tecnico = 200;
float profecional = 300;

if (tipo == 1)
{
    salario = operario;

}
else if (tipo == 2)
{
    salario = tecnico;


}
else if (tipo == 3)
{
    salario = profecional;

}
Console.WriteLine("Su salario sera de", salario);


int hora = 0;
Console.WriteLine("digite las horas de trabajo");
hora = int.Parse(Console.ReadLine());





