using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {

            float IMC, edad, peso, altura;
            int miembros;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            float pe = 0;
            float pa = 0;
            
            float edad1=0;
            float peso1=0;
            float altura1=0;
            float imc1 = 0;
            float imc2 = 0;


                            //*****************Ingreso de miembros************************ 
            do
            {
                Console.WriteLine("Ingrese la cantidad de miembros");

                    miembros = int.Parse(Console.ReadLine());

            } while (miembros <= 0);


            for (int i = 0; i < miembros; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese su edad");
                    edad = float.Parse(Console.ReadLine());


                    if (edad >= 15)
                    {
                       edad1 = edad1 + edad;
                    }
                    else
                    {
                        Console.WriteLine("Error el miembro es menor de la edad establecida. Favor de volver a ingresar ");
                    }

                } while (edad <= 14);

                do
                {
                Console.WriteLine("Ingrese su peso");
                peso = float.Parse(Console.ReadLine());
               
                    if (peso > 0)
                    {
                    ///    peso1 = peso;
                    }
                    else
                    {
                        Console.WriteLine("Error el peso no puede ser menor a 0");
                    }
                } while (peso <= 0);



                do
                   { 
                    Console.WriteLine("Ingrese su altura");
                    altura = float.Parse(Console.ReadLine());

                    if (altura > 0)
                     {
                      altura1 = altura1 + altura;
                     }
                     else
                     {
                     Console.WriteLine("La altura tiene que ser mayor a 0");

                     }
                 } while (altura < 0);

                           
 //               Console.WriteLine("La edad ingresada es " +edad1);
   //             Console.WriteLine("El peso ingresado es " +peso1);
     //           Console.WriteLine("La altura ingresada es " +altura1);


                // ********************************* Calculo de IMC **********************************************

                float a = altura / 100;


                IMC = peso/(a * a);



                //imc1 = IMC;

              
              
                if(IMC< 18.5)
                    {

                Console.WriteLine("Peso inferior al normal");
                    a1 = a1 + 1;

                     }

                if (IMC > 18.5 && IMC < 24.9)
                {

                    Console.WriteLine("Peso normal");
                    a2 = a2 + 1;
                }

                if (IMC > 25 && IMC < 29.9)
                {
                    Console.WriteLine("Peso superior al normal");
                    a3 = a3 + 1;
                }

                if (IMC >= 30)
                {

                    Console.WriteLine("Obesidad");
                    a4 = a4 + 1;
                }


                Console.WriteLine("El IMC de la persona numero" + i +"es " + IMC );

                if (imc1 == 0 && imc2 == 0)
                {
                    imc1 = IMC;
                    imc2 = IMC;
                }else
                {
                    if(IMC>=imc1)
                    {
                        imc1 = IMC;

                    }else
                    {
                        if (IMC <= imc2) 
                        imc2 = IMC;

                    }


                }







            }

            pe = edad1 / miembros;
            pa = (altura1 / miembros)/100;

            Console.WriteLine("El IMC mas alto es " + imc1);
            Console.WriteLine("El IMC mas bajo es " + imc2);
            Console.WriteLine("El promedio de edad es " + pe);
            Console.WriteLine("El promedio de altura es " + pa);
            Console.WriteLine("la cantidad de personas con peso inferior al normal es " +a1);
            Console.WriteLine("La cantidad de personas con peso normal es " +a2);
            Console.WriteLine("La cantidad de personas con peso superior al normal es "+a3);
            Console.WriteLine("La cantidad de personas con obesidad es " +a4); 






            Console.ReadKey();







        }
    }
}
