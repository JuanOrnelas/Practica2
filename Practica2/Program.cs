using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CODIGO REALIZADO POR JUAN JOSE ORNELAS

            //variables
            int op;
            int retiros;
            //billetes
            double Bi1 = 0, Bi2 = 0, Bi3 = 0, Bi4 = 0, Bi5 = 0;
            //monedas
            double m1 = 0, m2 = 0, m3 = 0;
            int TBi, TMo;

            do
            {

                Console.Write("--------------------- BANCO CDIS ---------------------  \n");
                Console.Write("1.-Ingresar cantidad  de retiros hechos por los usuarios \n");
                Console.Write("2.-Revisar la cantidad entregada de billetes y monedas \n");
                Console.Write("Introduzca la opcion \n");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {

         
                    case 1:
                        do
                        {
                            {
                                Console.Write("Introduzca la cantidad de retiros \n");
                                retiros = int.Parse(Console.ReadLine());
                                if (retiros < 0 || retiros > 10)
                                {
                                    Console.Write("No se admmite esta opcion");
                                    Console.ReadLine();
                                    //limpieza de pantalla
                                    Console.Clear();
                                }
                                //arrelo con tamanio de retiros
                                double[] dinero = new double[retiros];

                                for (int i = 0; i < retiros; i++)
                                {
                                    Console.WriteLine("Introduzca el valor del retiro " + i+1 +": ");
                                    dinero[i] = double.Parse(Console.ReadLine());
                                    if(dinero[i]<0 || dinero[i]>50000)
                                    {
                                        retiros = -1;
                                    }
                                    //Proceso1
                                    if (dinero[i] >= 500)
                                        Bi1 = Math.Abs(dinero[i]) / 500;
                                   
                                    dinero[i] = dinero[i] - (Bi1 * 500);

                                    if (dinero[i] >= 200)
                                        Bi2 = Math.Abs(dinero[i]) / 200;
                                   
                                    dinero[i] = dinero[i] - (Bi2 * 200);

                                    if (dinero[i] >= 100)
                                        Bi3 = Math.Abs(dinero[i]) / 100;
                                    
                                    dinero[i] = dinero[i] - (Bi3 * 100);

                                    if (dinero[i] >= 50)
                                        Bi4 = Math.Abs(dinero[i]) / 50;
                                   
                                    dinero[i] = dinero[i] - (Bi4 * 50);

                                    if (dinero[i] >= 20)
                                        Bi5 = Math.Abs(dinero[i]) / 20;
                                   
                                    dinero[i] = dinero[i] - (Bi5 * 20);

                                    if (dinero[i] >= 10)
                                        m1 = Math.Abs(dinero[i]) / 10;
                                   
                                    dinero[i] = dinero[i] - (m1 * 10);

                                    if (dinero[i] >= 5)
                                        m2 = Math.Abs(dinero[i]) / 5;
                                    
                                    dinero[i] = dinero[i] - (m2 * 5);

                                    if (dinero[i] >= 1)
                                        m3 = Math.Abs(dinero[i]) / 1;
                                   
                                    dinero[i] = dinero[i] - (m3 * 1);

                                    //retorno a menu principal
                                    op = 3;
                                    Console.ReadLine();
                                    //limpieza de pantalla
                                    Console.Clear();
                                    break;
                                }
                            }
                        } while (retiros <0 || retiros > 10);
                    break;

                    case 2:
                        //Impresion de monedas y billetes
                        Console.WriteLine("La cantidad en billetes de $500: " + Bi1);
                        Console.WriteLine("La cantidad en billetes de $200: " + Bi2);
                        Console.WriteLine("La cantidad en billetes de $100: " + Bi3);
                        Console.WriteLine("La cantidad en billetes de $50: " + Bi4);
                        Console.WriteLine("La cantidad en billetes de $20: " + Bi5);
                        Console.WriteLine("La cantidad en monedas de $10: " + m1);
                        Console.WriteLine("La cantidad en monedas de $5: " + m2);
                        Console.WriteLine("La cantidad en monedas de $1: " + m3);
                        Console.ReadLine();
                        break;

                    default:
                        Console.Write("Opcion no permitida \n");
                        Console.ReadLine();
                        //limpieza de pantalla
                        Console.Clear();
                        op = 3;
                        break;
                }
            } while (op==3);
                
        }
    }
}
