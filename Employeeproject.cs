using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = " ";
            string type = " ";
            int years = 0;
            int x = 0,y =0 , w = 0, p = 0;
            char time = ' ';
            int sum = 0, sum2 = 0, sum3 = 0 ,su = 0 ,sumw2 = 0 , sumw3 =  0 ,sum11 = 0 , sum22 = 0 , sum33 = 0 ;
            while(x < 2)
            {
                Console.WriteLine("What is your name\t:");
                name = Console.ReadLine();
                Console.WriteLine("What type of employee are you\t:");
                type = Console.ReadLine();
                Console.WriteLine("Employee's year for service for sveral unknown years \t:");
                years = int.Parse(Console.ReadLine());

                Console.Write("Are you a full-time employee represent with letter \"F \" OR are you a part- time employee represent with\"P\"\t:");
                time = char.Parse(Console.ReadLine().ToUpper());


                
                if (time == 'F')
                {
                    if (years > 5)
                    {
                        p = 4;
                       
                    }
                    if (years <= 5)
                    {
                        w = 2;
                    }
                }
                if(time == 'P')
                {
                    y = 0;

                }
                Console.Write("Employee name is\t:" + name);
                

                
        if (time == 'F')
            {
                if (years > 5)
                {
                    Console.Write("Total of weaks ' vacation\t:" + p + "\tweeks");

                }
            if(years <= 5)
            {
         
                    Console.Write("Total of weeks' vacation\t:" + w + "\tweeks");
            }
        }
                if(time == 'P')
                {
               Console.Write("Total of weeks vacation' vacation\t: " + y + "\tweeks");
                }
           
            x++;

                }

            if (time == 'F')
            {
                if (years > 5)
                {
                    sum = w + p;
                    sum2 = p + p;
                    sum3 = y + p; 

                }
                if (years <= 5)
                {
                    su = w + w;
                    sumw2 = p + w;
                    sumw3 = y + w;
                }
            }
            if(time == 'P')
            {
                sum11 = y + y;
                sum22 = w + y;
                sum33 = p + y;
            }
            x++;
        }
           if (time == 'F')
                {
                    if (years > 5)
                    {
                        Console.WriteLine("The total number of weeks of vacation owing all of the employees\t:"+);;
                       
                    }
                    if (years <= 5)
                    {
                        Console.WriteLine("The total number of weeks of vacation owing all of the employees\t:"+);
                    }
                }
                if(time == 'P')
                {
                    Console.WriteLine("The total number of weeks of vacation owing all of the employees\t:"+);;

                }
        
                                                                                                   
                Console.Write("The total number of weeks of vacation owing all of the employees\t:"+sum);


            Console.ReadLine();


        }
    }
}
