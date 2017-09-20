using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = Console.ReadLine();
            var text = Console.ReadLine();
            //string email = "pesho.peshev@email.bg";
            //string text1 = "My name is Pesho Peshev. I am from Sofia, my email is: pesho.peshev@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, pesho.peshev@email.bg";



            var list =new List<char>();
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i]=='@')
                {
                    break;
                }
                else
                {
                    list.Add(email[i]);
                }
            }
            string emailName = string.Join("", list);

            string emailResult = email.Replace(emailName, new string('*', emailName.Length));
            Console.WriteLine(email);
            string result = text.Replace(email, emailResult);
            Console.WriteLine(result);


        }
    }
}
