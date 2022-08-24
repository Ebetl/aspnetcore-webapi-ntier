using FlutterBackend.DataAccess.Abstract;
using FlutterBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlutterBackend.DataAccess.Concrete
{
    public class PhoneRepo : IPhoneRepo
    {
        public Phone CreatePhone(Phone phone)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                phoneDbContext.phones.Add(phone);
                phoneDbContext.SaveChanges();
                return phone;

            }
        }

           public List<Phone> GetAllPhones()
        {
            using (var phoneDbContext=new PhoneDbContext() )
            {
                return phoneDbContext.phones.ToList();
            }
        }

        public Phone GetPhoneById(int id)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                return phoneDbContext.phones.Where(x=>x.ID == id).FirstOrDefault();
            }
        }

        public Phone UpdatePhone(Phone phone)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                 phoneDbContext.phones.Update(phone);
                return phone;
            }
        }
    }
}
