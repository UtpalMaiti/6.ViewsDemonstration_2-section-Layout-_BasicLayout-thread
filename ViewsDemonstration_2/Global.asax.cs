using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ViewsDemonstration_2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Debug.WriteLine("Hello World!");

            Thread thread = new Thread(InsertProcess);
            Thread thread2 = new Thread(InsertProcess2);
            thread.Start();
            thread2.Start();

            //Task task1 = Task.Run(async () =>  // <- marked async
            //{
            //    while (true)
            //    {
            //        Debug.WriteLine("Task.Delay(3000)!");

            //        InsertProcess();
            //        await Task.Delay(1000);
            //    }
            //});
            //Task task2 = Task.Run(async () =>  // <- marked async
            //{
            //    while (true)
            //    {
            //        Debug.WriteLine("Task.Delay(10000)!");

            //        InsertProcess();
            //        await Task.Delay(10000);
            //    }
            //});

            Debug.WriteLine("--------------");

            Debug.WriteLine("---------------------------------!");

            //Task.WaitAll(new[] { task1, task2 });
        }

        public static async void InsertProcess()
        {
            while (true)
            {
                Debug.WriteLine("InsertProcess!Delay(1000)");
                await Task.Delay(1000);
            }
            //using (SqlConnection conn = new SqlConnection(RO1DBConn))
            //{
            //    // ... query database
            //}
        }

        public static async void InsertProcess2()
        {
            while (true)
            {
                Debug.WriteLine("InsertProcess!");
                await Task.Delay(5000);
            }
            //using (SqlConnection conn = new SqlConnection(RO1DBConn))
            //{
            //    // ... query database
            //}
        }
    }
}