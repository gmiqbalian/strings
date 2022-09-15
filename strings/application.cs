using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class application
    {
        public void string1()
        {
            string result = "";
            for(int i = 1; i <=3 ; i++)
            {
                Console.Write("Mata in din text: ");
                string text = Console.ReadLine();
                result += text;

            }
            
            Console.WriteLine(result);
        }

        public void string2()
        {
            string text = "Hello, World";

            Console.WriteLine(text[7]);
            Console.WriteLine(text.IndexOf("W"));
        }

        public void string3()
        {
            string namn = "kurt andersson";
            namn = namn.Replace('k', 'K').Replace('a', 'A');
            Console.WriteLine(namn);
        }

        public void string4()
        {
            string text = "Detta är en sträng som du s kall ändra";
            string newText = text.Replace(' ', '*');
            Console.WriteLine(newText);

            int count = 0;
            foreach (var find in newText)
            {
                if(find == '*')
                {
                    count++;
                }
            }
            Console.WriteLine(count);            
        }

        public void string5()
        {
            Console.WriteLine("Mata in en mailadress: ");
            string mail = Console.ReadLine();
            bool atTheRate = mail.Contains('@');
            int dotIndex = mail.LastIndexOf('.');
                             
            if(atTheRate && (dotIndex < mail.Length-3))
            {
                Console.WriteLine("Det är en rätt adress.");                
            }
            else
            {
                Console.WriteLine("Det är en felaktig mailadress.");
            }
        }

        public void string6()
        {
            int i = 0;
            int words = 1;
            Console.WriteLine("Mata in en mening.");
            string text = Console.ReadLine();
            //Console.WriteLine(text.Length);

            while(i <= text.Length-1)
            {
                if (text[i] == ' ')
                {
                    words++;
                }
                i++;
            }

            Console.WriteLine($"Din text består av {words} ord.");
        }
        
    }
}
