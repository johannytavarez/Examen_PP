using System;

namespace examen_primer_parcial
{
    class Cajero
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bienvenido al cajero automatico de el banco FDP INVERSMENTS");
           Console.WriteLine("Ingrese el nombre de el banco al que pertenece");
           string banco;
           banco = Console.ReadLine();
           int limite_de_retiro, efectivo_a_retirar; 



           if (banco == "FDP INVERSMENTS") {
                limite_de_retiro = 20000;
                Console.WriteLine("Ingrese la cantidad de efectivo que desea retirar");
                efectivo_a_retirar = int.Parse(Console.ReadLine());

                if (efectivo_a_retirar <= 20000){

                    int CAN, C1000, C500, C200, C100;
                    C1000 = 0;
                    C500 = 0;
                    C200 = 0;
                    C100 = 0;


                    CAN = efectivo_a_retirar;
                    if( (CAN >= 1000) )
                    {
                    C1000 = (CAN / 1000);
                        //while (C1000<= 18) {
                        CAN = CAN - (C1000 * 1000);
                        //}
                    }
                    if( (CAN >= 500) )
                    {
                    C500 = (CAN / 500);
                    CAN = CAN - (C500 * 500);
                    }
                    if( (CAN >= 200) )
                    {
                    C200 = (CAN / 200);
                    CAN = CAN - (C200 * 200);
                    }
                    if( (CAN >= 100) )
                    {
                    C100 = (CAN / 100);
                    CAN = CAN - (C100 * 100);
                    }

                    Console.WriteLine("BILLETES DE A 1000: "+ C1000);
                    Console.WriteLine("BILLETES DE A 500 : " + C500);
                    Console.WriteLine("BILLETES DE A 200 : " + C200);
                    Console.WriteLine("BILLETES DE A 100 : " + C100);


                }



                else {
                     Console.WriteLine("El monto que ha ingresado excede el limite");
                }



           }

           else {
               limite_de_retiro = 10000;
                Console.WriteLine("Ingrese la cantidad de efectivo que desea retirar");
                efectivo_a_retirar = int.Parse(Console.ReadLine());
                               if (efectivo_a_retirar <= 10000){

                    int CAN, C1000, C500, C200, C100;
                    C1000 = 0;
                    C500 = 0;
                    C200 = 0;
                    C100 = 0;



                    CAN = efectivo_a_retirar;
                    if( (CAN >= 1000) )
                    {
                    C1000 = (CAN / 1000);
                    
                    CAN = CAN - (C1000 * 1000);
                    
                    }
                    if( (CAN >= 500) )
                    {
                    C500 = (CAN / 500);
                    CAN = CAN - (C500 * 500);
                    }
                    if( (CAN >= 200) )
                    {
                    C200 = (CAN / 200);
                    CAN = CAN - (C200 * 200);
                    }
                    if( (CAN >= 100) )
                    {
                    C100 = (CAN / 100);
                    CAN = CAN - (C100 * 100);
                    }
                    Console.WriteLine("Usted recibira:");
                    Console.WriteLine("BILLETES DE A 1000: "+ C1000);
                    Console.WriteLine("BILLETES DE A 500 : " + C500);
                    Console.WriteLine("BILLETES DE A 200 : " + C200);
                    Console.WriteLine("BILLETES DE A 100 : " + C100);


                }



                else {
                     Console.WriteLine("El monto que ha ingresado excede el limite");
                }


           }

            Console.WriteLine("Fin de la transaccion"); 
            Console.Write("Pulse una tecla para salir:"); Console.ReadLine();





        }
    }
} 