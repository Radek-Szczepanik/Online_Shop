using OnlineShopCMSMySql.DAL;
using System;

namespace OnlineShopCMSMySql
{
    class Program
    {
        static void Main(string[] args)
        {  try
            {
                Login login = new Login();
                login.GetAccess();
            }
            catch (Exception loginProblem)
            {
                System.Console.WriteLine(loginProblem.Message);
                Console.WriteLine(loginProblem.StackTrace);
            }

            IProductRepository product = new ProductRespository();
            {
                try
                {
                    bool showMenu = true;
                    while (showMenu)
                    {
                        showMenu = ProductController.MainMenu(product);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }

        }
    }
}
