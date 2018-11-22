using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPhoneProject
{
    public class Iphone8Priv
    {

        private string phoneName;


        private void ShowMyName()
        {
            Console.WriteLine(phoneName);
            Console.WriteLine(phoneName);
            Console.WriteLine(phoneName);
            Console.WriteLine(phoneName);
        }

        public void ShowName()
        {
            GetName();
            ShowMyName();
        }

        private string GetName()
        {
            Console.WriteLine(phoneName);
            Console.WriteLine(phoneName);
            Console.WriteLine(phoneName);
            Console.WriteLine(phoneName);
            Console.WriteLine(phoneName);
            return phoneName;
        }

    }
}
