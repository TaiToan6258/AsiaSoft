using model.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace model.Dao
{
    public class UserDao
    {
        public NWTMdbcontext dao = null;
        public UserDao()
        {
            dao = new NWTMdbcontext();

        }
        public bool Login(string username, string password)
        {
            object[] sqlPrams = 
            {
                new SqlParameter("username", username),
                new SqlParameter("password", password)
            };
            var result = dao.Database.SqlQuery<bool>("CheckLogin @username, @password",
                sqlPrams).SingleOrDefault();
            return result;
        }
    }
}
