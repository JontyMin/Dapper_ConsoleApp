using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Dapper_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new SqlConnection("server=.;database=StudentsDB;uid=sa;pwd=123;");

            var result = connection.Execute("insert into Student values (@Name,@Age,@Address,@Gid)", new
            {
                Name="jonty",
                Age=18,
                Address="广东惠州",
                Gid=1
            });

            Console.WriteLine(result);
        }
    }
}
