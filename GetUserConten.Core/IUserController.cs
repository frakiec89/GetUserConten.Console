using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUserConten.Core
{
    public interface IUserController
    {
        public List<User> GetUsers();
    }
}
