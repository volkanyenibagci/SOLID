using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class UserWithSRP
    {
        private long id;
        private String name;
        private String username;
        Address address;

        public UserWithSRP(long id, string name, string username, Address address)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.address = address;
        }
    }
}
