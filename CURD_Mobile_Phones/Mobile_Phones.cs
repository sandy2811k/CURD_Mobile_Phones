using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Mobile_Phones
{
    public class Mobile
    {
        int id;
        String name;
        int price;
        public Mobile(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return id + " :" + name + " " + price;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }

    public class MobileImplementation
    {
        Mobile[] mobile;
        int count;
        public MobileImplementation()
        {
            mobile = new Mobile[5];
            count = 0;
        }
        public void AddMobile(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Mobile id");
                int mid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Mobile name");
                String mname = Console.ReadLine();
                Console.WriteLine("Entre Mobile price");
                int mprice = int.Parse(Console.ReadLine());
                mobile[count] = new Mobile(mid, mname, mprice);
                count++;
            }
        }
        public void ShowAllMobile()
        {
            for (int i = 0; i < count; i++)
            {
                if (mobile[i] != null)
                {
                    Console.WriteLine(mobile[i]);
                }
            }
        }
        public void SearchMobileById(int id)
        {
            for (int i = 0; i < mobile.Length; i++)
            {
                if (mobile[i] != null)
                {
                    if (mobile[i].Id == id)
                    {
                        Console.WriteLine(mobile[i]);
                    }
                    if (mobile[i].Id != id)
                        {
                            Console.WriteLine("Mobile Not Available");
                        }
                }
            }
        }
        public void UpadteMobile(int id, int newprice)
        {
            for (int i = 0; i < mobile.Length; i++)
            {
                if (mobile[i] != null)
                {
                    if (mobile[i].Id == id)
                    {
                        mobile[i].Price = newprice;
                    }
                }
            }
        }
        public void DeleteMobile(int id)
        {
            for (int i = 0; i < mobile.Length; i++)
            {
                if (mobile[i] != null)
                {
                    if (mobile[i].Id == id)
                    {
                        mobile[i] = null;
                    }
                    if (mobile[i].Id != id)
                    {
                        Console.WriteLine("Mobile Not available");
                    }
                }
            }
        }
    }
}



