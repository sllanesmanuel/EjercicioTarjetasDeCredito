using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sea V una lista de tarjetas de crédito de clientes, y sea T una única instancia 
//de esa tarjeta de crédito la cual debe contener: número de tarjeta, banco asociado, 
//fecha de vencimiento y código de seguridad. Los bancos disponibles son "Macro", "Bancor", 
//"Nación" y "Santander Río". Se pide que un programa lea N tarjetas y nos diga cuál de las 
//tarjetas introducidas está vencida al día de hoy, sabiendo que cada tarjeta no pudo haber sido 
//emitida antes del 05/01 (MM/YY), su código de seguridad Cx debe ser 100 <= Cx <= 800 y debe 
//pertenecer al banco Macro.


namespace EjercicioTarjetasDeCredito
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tarjeta> Listatarjetas = new List<Tarjeta>();

            int r;

            do
            {
                Tarjeta tarjeta = new Tarjeta();


                Console.WriteLine("Ingrese el numero de la tarjeta:");
                tarjeta.NumeroTarjeta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el banco asociado Los bancos disponibles son Macro, Bancor, Nación y Santander Río:");
                tarjeta.BancoAsociado = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de vencimiento:");
                tarjeta.FechaVencimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ingrese el codigo de seguridad:");
                tarjeta.CodigoSeguridad = Convert.ToInt32(Console.ReadLine());

                Listatarjetas.Add(tarjeta);

                Console.WriteLine("¿Desea agregar otra Tarjeta? 1=Si 0=No");
                r = Convert.ToInt32(Console.ReadLine());



            } while (r != 0);

            //01 / 05 / 2001
            DateTime fechaMinima = new DateTime(2001, 5, 1);

            foreach (var Tarjeta in Listatarjetas)
            {
                if (Tarjeta.FechaVencimiento < fechaMinima)
                {
                    //cada tarjeta no pudo haber sido emitida antes del 05/01 (MM/YY)
                    Console.WriteLine("La Tarjeta Nro: {0} Fue emitida antes del 01/05/2001 por lo que esta vencida.", Tarjeta.NumeroTarjeta);
                }

                //Los bancos disponibles son "Macro", "Bancor", "Nación" y "Santander Río".
                if (Tarjeta.BancoAsociado != "Macro")
                {
                    Console.WriteLine("La Tarjeta Nro: {0} no pertenece al banco Macro. ", Tarjeta.NumeroTarjeta);
                }

                //su código de seguridad Cx debe ser 100 <= Cx <= 800
                if (Tarjeta.CodigoSeguridad < 100 | Tarjeta.CodigoSeguridad > 800)
                {
                    Console.WriteLine("El codigo de seguridad {0} de la tarjeta Nro: {1} no es válido.", Tarjeta.CodigoSeguridad, Tarjeta.NumeroTarjeta);
                }

                Console.WriteLine("------------------------------------------------------------------------------------------");
            }
        Console.ReadKey();
        }
    }

}




class Tarjeta
{
    public int NumeroTarjeta { get; set; }
    public string BancoAsociado { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public int CodigoSeguridad { get; set; }
}





