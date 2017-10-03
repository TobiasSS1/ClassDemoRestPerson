using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClassDemoRestPerson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //private static List<Person> personer = new List<Person>()
        //{
        //    new Person(22, "peter"),
        //    new Person(23, "anders")
        //};



        private String connStr =
                "Server=tcp:db-pele-easj.database.windows.net,1433;Initial Catalog=pele-easj;Persist Security Info=False;User ID=pele;Password=Secret1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            ;

        public List<Person> GetPersoner()
        {
            List<Person> personer = new List<Person>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                String sql = "SELECT * FROM DBO.PERSON";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();

                
                while (reader.Read())
                {
                    Person p = new Person();

                    p.Id = reader.GetInt32(0);
                    p.Name = reader.GetString(1);

                    personer.Add(p);
                }
            }

            return personer;
        }

        
    }
}
