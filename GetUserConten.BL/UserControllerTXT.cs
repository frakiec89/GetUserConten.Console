using GetUserConten.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUserConten.BL
{
    public class UserControllerTXT : Core.IUserController
    {
        private string path = @"C:\Users\Ahtyamov\Desktop\Content\Content.txt"; // зависимость
        public List<User> GetUsers()
        {
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8, true))
            {
                var content = reader.ReadToEnd();
                return Pars(content);
            }
        }

        private List<User> Pars(string content)
        {
            List<User> users = new List<User>();
            string[] userString = content.Split('/');

            foreach (var us in userString )
            {
                if(string.IsNullOrEmpty(us) == false)
                {
                    var usMassiv = us.Split('*');
                    User user = new User();
                    user.fersName = usMassiv[0];
                    user.name = usMassiv[1];
                    user.group = usMassiv[2];

                    users.Add(user);
                }    
            }
            return users;
        }
    }
}
