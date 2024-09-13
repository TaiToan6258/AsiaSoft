using model.EF;
using System;
using System.Collections.Generic;
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

    }
}
