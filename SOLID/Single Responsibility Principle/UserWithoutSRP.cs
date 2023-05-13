using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    /// <summary>
    /// Adres ile ilgili street ve city gibi veriler direkt olarak User Sınıfı içerisinde bulunmalı mı gerçekten?
    /// Herhangi bir ek adres bilgisi istendiğinde(country yada zipCode gibi) burada tamamen User sınıfını etkileyecektir. User sınıfı direkt olarak sorumlu olmadığı bir işlemden etkilenmiş olacak. “street”, “city” gibi veriler sadece adres için gereklidir, bu durumda Address adında yeni bir class oluştursak nasıl olur ?
    /// </summary>
    public class UserWithoutSRP
    {
        private long id;
        private String name;
        private String street;
        private String city;
        private String username;

        public UserWithoutSRP(long id, string name, string street, string city, string username)
        {
            this.id = id;
            this.name = name;
            this.street = street;
            this.city = city;
            this.username = username;
        }
    }
}
