using model.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    
    public class CustomersModel
    {
        private NWTMdbcontext context = null;
        public CustomersModel() {
            context = new NWTMdbcontext();
        }

    public List<Customer> ListAll() 
        {
            var listCustomer = context.Database.SqlQuery
                <Customer>("Sql_ListAllCustomer").ToList();
            return listCustomer;
        }
    public int Insert(String FN, String LN, String City, String Country, String Phone) {
            object[] parameter = {
                new SqlParameter("FirstName", FN),
                new SqlParameter("LastName", LN),
                new SqlParameter("City", City),
                new SqlParameter("Country", Country),
                new SqlParameter("Phone", Phone),
            };
            int res = context.Database.ExecuteSqlCommand("Sql_Insert_Customer @FirstName, @LastName,  @City, @Country,@Phone", parameter);
            return res;
        }
        public List<Customer> Search(String input) {
            var listOfSearch = context.Database.SqlQuery<Customer>("exec searchCusandOrdByName @input",
                new SqlParameter("@input", input )).ToList();
            
            return listOfSearch;
        }

    }
}
