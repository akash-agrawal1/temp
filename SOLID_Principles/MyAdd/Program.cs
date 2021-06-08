using System;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our site. Would you like to order or repair?");
            string processOption = Console.ReadLine().ToLower().Trim();
            string productDetail;
            //PhoneOrderRepair phoneOrderRepair = new PhoneOrderRepair();
            //string productDetail = string.Empty;

            switch (processOption)
            {
                case "order":
                    Console.WriteLine("Please provide the phone model name");
                    productDetail = Console.ReadLine().Trim();
                    var order = new Order();
                    //phoneOrderRepair.ProcessOrder(productDetail);
                    order.ProcessOrder(productDetail);
                    break;
                case "repair":
                    Console.WriteLine("Is it the phone or the accessory that you want to be repaired?");
                    string productType = Console.ReadLine().ToLower();
                    var repair = new Repair();
                    if(productType.Equals("phone"))
                    {
                        Console.WriteLine("Please provide the phone model name");
                        productDetail = Console.ReadLine().Trim();
                        repair.ProcessPhoneRepair(productDetail);
                        //phoneOrderRepair.ProcessPhoneRepair(productDetail);
                    }
                    else
                    {
                        Console.WriteLine("Please provide the accessory detail, like headphone, tempered glass");
                        productDetail = Console.ReadLine().Trim();
                        repair.ProcessAccessoryRepair(productDetail);
                        //phoneOrderRepair.ProcessAccessoryRepair(productDetail);
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("Thanks for choosing us. Have a great day.");
        }
    }
}
