using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Mobile_Phones
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MobileImplementation mobile = new MobileImplementation();
            char ch = ' ';
            do
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("1.Insert\n2.Show\n3.Update\n4.Delete\n5.Serach");
                Console.WriteLine("Enter Your choice Number:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many products you want to add:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        mobile.AddMobile(n);
                        break;
                    case 2:
                        Console.WriteLine("-----------------------------");
                        mobile.ShowAllMobile();
                        break;
                    case 3:
                        Console.WriteLine("Enter the id for update:");
                        int mid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the new price:"); 
                        int price = int.Parse(Console.ReadLine());
                        mobile.UpadteMobile(mid,price);
                        break;
                    case 4:
                        Console.WriteLine("Enter the id for delete:");
                        int dbid = Convert.ToInt32(Console.ReadLine());
                        mobile.DeleteMobile(dbid);
                        break;
                    case 5:
                        Console.WriteLine("Enter id for search:");
                        int id = int.Parse(Console.ReadLine());
                        mobile.SearchMobileById(id);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Do you want to continue then enter (y/Y....");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');



        }
    }
}



    


