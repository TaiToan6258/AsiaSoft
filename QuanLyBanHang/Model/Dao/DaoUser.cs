using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class UserDao
    {

        SODBContext db = null;
        public UserDao()
        {
            db = new SODBContext();
        }
        // Insert Data
        public long Insert(UserInfo entity)
        {
            db.UserInfoes.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }
        // Get User
        public UserInfo GetByUser(string user)
        {
            return db.UserInfoes.SingleOrDefault(x => x.Username == user);
        }
        // Check input login 
        public int CheckLogin(string username, string password)
        {
            var result = db.UserInfoes.SingleOrDefault(x => x.Username == username);
            if (result == null)
            {
                return 0;

            }
            else if (result.PassWord == password)
            {

                return 1;

            }
            else
            {
                return -1;
            }
        }
        // 
        public IEnumerable<UserInfo> ListAllpaging(int page, int pageSize)
        {
            return db.UserInfoes.OrderByDescending(x =>x.CreateDate).ToPagedList(page, pageSize);
        }

    }
}
