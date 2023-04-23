using System;

namespace Angka_2_dri_angka
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=21; i++)
            {
               Console.Write("\t"+i);
               if(i==5) {
                i+=8;
                Console.WriteLine();
                for(int j=6 ; j <= 8 ; j++) {
                    Console.WriteLine();
                    Console.WriteLine("\t \t \t \t \t"+j);
                }
               }
               if(i==13) {
                Console.WriteLine();
                i++;
                for(int k = 13; k >=9 ; k--){
                    Console.Write("\t" + k);
                }
               }
                if (i==14) {
                    Console.WriteLine();
                    i+=2;
                    for(int l=14;l<=16;l++){
                        Console.WriteLine();
                        Console.WriteLine("\t"+l);
                    }
                    Console.WriteLine();
                }
                
               
            }
        }
    }
}
