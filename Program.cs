﻿ using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Capital duplo ,taxa,juros,total,mes;
            

            Console. Claro();
            Console. WriteLine("+-------------+");
            Console. WriteLine("| JUROS SIMPLES| " );
            Console. WriteLine("+-------------+");
            
            Console. Write("Capital [c] (R$).......:" );
            capital=Convert. ToDouble(Console. ReadLine());

            Console. Write("Taxa de juros [i] (%)..:" ); 
            taxa=Convert. ToDouble(Console. ReadLine());

            Console. Write("Tempo [t] (meses)......:" ); 
            mes=Convert. ToDouble(Console. ReadLine());


            juros=((capital/100)*taxa)*mes;
            total = capital + juros;
            Console. WriteLine($"\nJuros (R$)....: {juros:c}" ); 
            Console. Write($Montante(R$)..: {total:c}" );

            Console. Write("\n\npronto? " );
            Console. ReadKey();
            Console. Claro();
        }
    }
}