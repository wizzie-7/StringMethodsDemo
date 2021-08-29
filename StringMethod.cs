using System;

namespace StringMethodsDemo
{
    class StringMethod
    {
        static void Main(string[] args)
        {
            string firstname = " Vivek Jadhav ";
            string lastname = "Kamble";
            string middlename = "Kamble";

            //console.writeline(firstname.clone()); //give string as it is out put

            //console.writeline(lastname.compareto(middlename)); // gives 1

            //console.writeline(firstname.contains("vek")); //gives true

            //console.writeline(firstname.endswith("v")); // gives true
            //console.writeline(firstname.equals(lastname)); // gives false 
            //console.writeline(firstname.indexof(" ")); // gives int value
            //console.writeline(firstname.tolower());
            //console.writeline(lastname.toupper());
            //console.writeline(firstname.insert(0, "hellow "));

            //console.writeline("length of string:{0}", firstname.length);

            //console.writeline(firstname.remove(3));
            //console.writeline(lastname.replace('m', 'n'));
            //string[] split = firstname.split(new char[] {'d'});

            //console.writeline(split[0]);
            //console.writeline(split[1]);
            //console.writeline(split[2]);
            //console.writeline(firstname.startswith('v'));

            //console.writeline(firstname.substring(3, 8));

            //string details = "employee details";
            //int salary = 20000;
            //datetime dt = new datetime(2019, 2, 23);
            //string result = string.format("{0}:{1:0.0} - {2:yyyy}", details, salary, dt);
            //console.writeline(result);
            Console.WriteLine(firstname.ToCharArray());
            Console.WriteLine(firstname.Trim());

        }
    }
}
