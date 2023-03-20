using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_Entities;

namespace Desktop.Repository
{
    public static class UserRepository
    {
        private static List<UserModel> users = new List<UserModel>()
        {
            new UserModel{Name = "Админ", Email = "tat123@mail.ru", Password = "1234567890"}
        };

        public static UserModel GetUser(string email, string password) { return users.FirstOrDefault(x => x.Email == email && x.Password == password); }
        public static bool CheckUser(string email, string password) { return users.Contains(GetUser(email, password)); }
        public static void AddUser(string name, string email, string password)
        {
            users.Add(new UserModel{Name = name, Email = email, Password = password});
        }
        public static bool CheckEmail(string email)
        {
            bool isUnique = true;
            foreach (UserModel user in users)
            {
                if (user.Email == email)
                {
                    isUnique = false;
                    break;
                }
            }
            return isUnique;
        }
    }
}
