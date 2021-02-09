using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dm;

namespace DaMeng
{
    class Program
    {
        private static int ret = 1;
        static DmConnection cnn = new DmConnection();
        static void Main(string[] args)
        {
            try
            {
                cnn.ConnectionString = "Server=localhost; User Id=SYSDBA; PWD=SYSDBA";
                cnn.Open();
                Program program = new Program();
                program.TestFunc();
                cnn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TestFunc()
        {
            DmCommand command = new DmCommand();
            command.Connection = cnn;
            try
            {
                string a, b, c;
                command.CommandText = "select * from Production.Product;";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    a = reader.GetString(0);
                    b = reader.GetString(1);
                    c = reader.GetString(2);

                    Console.WriteLine("Name：" + a);
                    Console.WriteLine("Author: " + b);
                    Console.WriteLine("Publisher: " + c);
                    Console.WriteLine("-----------------------------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ret = 0;

            }
        }
    }
}
