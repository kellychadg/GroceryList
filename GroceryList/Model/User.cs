using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryList.Model
{
    public class User
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public bool CreateUserName(string userName)
        {
            UserName = userName;

            return (UserName.Length > 0);
            
        }



    }
}