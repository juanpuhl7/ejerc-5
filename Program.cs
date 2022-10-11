using System;

namespace ejerc_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0, factor;

            

            do{
                
                Console.Clear();
                Console.WriteLine("**FACTORIAL DE UN NUMERO**");
                Console.WriteLine("0 - Salir");    
                Console.WriteLine("Numero para Factorial: ");
                num=Convert.ToInt32(Console.ReadLine());

                if(num!=0){
                    factor=1;

                    for(int i=1; i<=num ; i++){
                        factor=factor*i;

                    }
                Console.WriteLine("El Factorial de: " + num +" es " + factor);
                Console.ReadKey();
                }
 
            } while(num!=0);
        }
    }
}
