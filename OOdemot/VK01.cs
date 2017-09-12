using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class VK01
    {
        
 public static void Main(String []arg)
 {
        float a,b,c,summa,keskiarvo;
        Console.WriteLine("Syota kolme numeroa: ");
        a=Convert.ToInt32(Console.ReadLine());
        b=Convert.ToInt32(Console.ReadLine());
        c=Convert.ToInt32(Console.ReadLine());
        //summan lasku
        summa=a+b+c;
        //keskiarvon lasku
        keskiarvo=summa/3;
        Console.WriteLine("\nSumma= " + summa);
        Console.WriteLine("\nKeskiarvo= " + keskiarvo);
 }
}
    }

