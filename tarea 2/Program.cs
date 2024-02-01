using System.Net;

Console.WriteLine("N de aumentos salariales.");


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

int salarioordi = 0;
int operario = 100;
int tecnico = 200;
int profecional = 300;

if (tipo == 1)
{
    salarioordi = operario;

}
else if (tipo == 2)
{
    salarioordi = tecnico;


}
else if (tipo == 3)
{
    salarioordi = profecional;

}


int hora = 0;
Console.WriteLine("digite las horas de trabajo");
hora = int.Parse(Console.ReadLine());


int salariohoras = 0;
salariohoras = salarioordi * hora;
Console.WriteLine("Su salario Ordinario sera de.....{0}", salarioordi);
Console.WriteLine("El salario por horas es de......{0}",salariohoras);


double aumento, salariobruto;
int porcentaje;
Console.WriteLine("Digite el porcentaje de aumento ");
Console.WriteLine("Operacio 15%");
Console.WriteLine("Tecnico 10%");
Console.WriteLine("Tecnico 5%");
porcentaje = int.Parse(Console.ReadLine());

aumento = (salariohoras * porcentaje)/100;
salariobruto = salariohoras + aumento;

Console.WriteLine("Salario Bruto....{0}", salariohoras);
Console.WriteLine("Aumento....{0}", aumento);
Console.WriteLine("Total....{0}", salariobruto);


double seguro = 9.17;
double deduccion;
deduccion = salariobruto - seguro;
Console.WriteLine("El salario con la deduccion de CCSS es.....{0}", deduccion);
Console.WriteLine("El salario neto es....{0}", deduccion);




