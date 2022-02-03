using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4个数字
{
    class Program
    {
        static void Main(string[] args)
        {
            double primoNumero, secondoNumero, terzoNumero, quartoNumero;//首先我有4个数字，问题是怎么把这些数字安排好从小到大。
            //解决方法:假如这4个数字分别是，4321.首先是4-3和2-1换位，变成3-4和1-2，然后3-2和4-1换位，变成2-1和4-3，然后再次换位2-1和4-3变成1-2和3-4，完。
            double a;
            Console.WriteLine("Inserisci primo valore");
            primoNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci secondo valore");
            secondoNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserisci terzo valore");
            terzoNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserisci quardo valore");
            quartoNumero = Convert.ToDouble(Console.ReadLine());
            if(primoNumero > secondoNumero)//<如果第二个数字大于第一个数字他会直接跳到这个程序到下个程序,所以要用>
            {
                    a = primoNumero;//a 变成第一个数字
                    primoNumero = secondoNumero;//第一个数字（这个数字不是a）变成第二个数字,这里他们都是一样的数字
                    secondoNumero = a;//第二个数字变成 a,变成第一个数字。

            }
            if(terzoNumero > quartoNumero)
            {
                a = terzoNumero;
                terzoNumero = quartoNumero;
                quartoNumero = a;
            }
            if(secondoNumero > terzoNumero)
            {
                a = secondoNumero;
                secondoNumero = terzoNumero;
                terzoNumero = a;
            }
            if(primoNumero  > quartoNumero)
            {
                a = primoNumero;
                primoNumero =quartoNumero;
                quartoNumero= a;
            }
            if (primoNumero > secondoNumero)
            {
                a = primoNumero;
                primoNumero = secondoNumero;
                secondoNumero = a;

            }
            if (terzoNumero > quartoNumero)
            {
                a = terzoNumero;
                terzoNumero = quartoNumero;
                quartoNumero = a;
            }
            Console.WriteLine("risultato");
            Console.WriteLine(primoNumero);
            Console.WriteLine(secondoNumero);
            Console.WriteLine(terzoNumero);
            Console.WriteLine(quartoNumero);
            Console.ReadKey();
            // && and, || or
        }
    }
}
