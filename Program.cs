using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creador: Orlando Santiago Cárdenas Vargas");
            Console.WriteLine(" - - - VOTACIONES - - - ");
            List<string> opcion = new List<string>();
            opcion.Add("A = Aceptar.");
            opcion.Add("B = Blanco.");
            opcion.Add("R = Rechazado.");
            opcion.Add("N = Nulos.");
            opcion.Add("X = Terminar votaciones");
            for (int i = 0; i < opcion.Count(); i++)
            {
                Console.WriteLine(">" + opcion[i]);
            }
            Console.WriteLine("Por favor, digite el número de universidades que participan en las votaciones.");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] voto = new string[35];
            string[] uni = new string[num];
            int R1=0, R2 = 0,R3=0;           
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Ingrese el nombre de la universidad " + (i+1)+":");
                uni[i] = Console.ReadLine();
                int r1 = 0, r2 = 0, r3 = 0, r4 = 0;
                for (int a = 0; a < 35; a++)
                {
                    Console.WriteLine("Voto " + (a + 1) + ":");
                    voto[a] = Console.ReadLine();                                  
                    if (voto[a] == "A")
                    {
                        r1 += 1;                        
                    }
                    else if (voto[a] == "R")
                    {
                        r2 += 1;   
                    }
                    else if (voto[a] == "N")
                    {
                        r3 += 1;
                    }
                    else if (voto[a] == "B")
                    {
                        r4 += 1;
                    }
                    else if(voto[a]=="X"){
                        break;                        
                    }                                       
                }
                Console.WriteLine(uni[i] + ": "  +r1+ " aceptan, "+ r2 + " rechazan, " + r4 + " blancos, " + r3 + " nulos.");
                if (r1 > r2 && r1 > r3 && r1 > r4)
                {
                    R1 += 1;
                }
                if (r2 > r1 && r2 > r3 && r2 > r4)
                {
                    R2 += 1;
                }
                if (r1 == r2) 
                {
                    R3 += 1;
                }               
            }            
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Universidades que aceptan: "+R1);
            Console.WriteLine("Universidades que rechazan: "+R2);
            Console.WriteLine("Universidades con empate: "+R3);
            Console.ReadKey();
        }
        
    }

}
