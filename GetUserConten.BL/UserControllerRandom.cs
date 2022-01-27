using GetUserConten.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUserConten.BL
{
    public class UserControllerRandom : Core.IUserController
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>()
                {

                    new User () { fersName ="dsds" , group ="dsds21"  , name ="dsdsdsds"},
                    new User () { fersName ="dsdsdsds" , group ="ds231ds"  , name ="dsdsdsds"},
                    new User () { fersName ="dsddss" , group ="dsdssds"  , name ="dsdsdsds"},
                    new User () { fersName ="dsssds" , group ="d2121sds"  , name ="dsdsdsddsdssdsds"},

                };
            return users;
        
        }
    }
}
