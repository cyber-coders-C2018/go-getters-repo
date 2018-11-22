using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPhoneProject;

namespace AccessModifierProject
{
    public class Program
    {

        public  Iphone6 whiteIphone6 = new Iphone6();



        static void Main(string[] args)
        {
            /*
             * public
             * private
             * internal
             * protected
             * protected internal 
             * private internal             * 
             */

            Iphone7Pub blackIphone7 = new Iphone7Pub();
            Console.WriteLine(blackIphone7.GetName());

        }
    }
}
