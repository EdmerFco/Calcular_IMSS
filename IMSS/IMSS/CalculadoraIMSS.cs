using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    public class CalculadoraIMSS
    {
         public static void  Presentacion()
        {
            decimal SBC;
            decimal UMAS;
            int Rol; 

            Console.WriteLine("Calculadora IMSS");
            Console.WriteLine("Para calcular los Aportaciones de Patrones coloca le numero 1");
            Console.WriteLine("Para calcular los Aportaciones de Trabajador coloca le numero 2");
            Rol = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la SBC");
            SBC = decimal.Parse(Console.ReadLine());
            Console.WriteLine("ingresa la UMAS");
            UMAS = decimal.Parse(Console.ReadLine());

            Aportaciones aport = new Aportaciones(); 
            aport = calcular(SBC, UMAS, Rol);

            Console.WriteLine($"Enfermedades y Maternidad: \n{aport.EnFer}");
            Console.WriteLine($"Invalidez y Vida: \n{aport.Inc}");
            Console.WriteLine($"Retiro:  \n{aport.Ret}");
            Console.WriteLine($"Cesantia: \n{aport.Ces}");
            Console.WriteLine($"Credito Infonavit: \n{aport.InF}"); 


        }
        public static Aportaciones calcular(decimal SBC, decimal UMAS, int Rol)
        {
            Aportaciones Apor = new Aportaciones();

            if (Rol == 1)
            {
                Apor.EnFer = (SBC - (3m * UMAS)* 0.011m);
                Apor.Inc =   (SBC * 0.0175m);
                Apor.Ret =   (SBC * 0.02m);
                Apor.Ces =   (SBC * 0.0315m);
                Apor.InF =   (SBC * 0.5m);
            }
            else if (Rol == 2)
            {
                Apor.EnFer = (SBC - (3m * UMAS)* 0.004m);
                Apor.Inc =   (SBC * 0.00625m);
                Apor.Ret =   (SBC * 0m);
                Apor.Ces =   (SBC * 0.0125m);
                Apor.InF =   (SBC * 0m);
            }
            else
                Console.WriteLine("no se puede realisar El Calcular intente de nuevo con una numeracion correcta");
            
            return Apor;
        }
    }
}
