using FlutterBackend.Business.Abstract;
using FlutterBackend.DataAccess.Concrete;
using FlutterBackend.DataAccess;
using FlutterBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBackend.Business.Concrete
{
    public class PhoneManager : IPhoneService
    {
        private DataAccess.Abstract.IPhoneRepo _phoneRepo;
        public PhoneManager()
        {
            _phoneRepo = new PhoneRepo();
        }
        public Phone CreatePhone(Phone phone)
        {
            return _phoneRepo.CreatePhone(phone);

            }

        public List<Phone> GetAllPhones()
        {
            return _phoneRepo.GetAllPhones();
        }

        public Phone GetPhoneById(int id)
        {
            return _phoneRepo.GetPhoneById(id);
        }

        public Phone UpdatePhone(Phone phone)
        {
            return _phoneRepo.UpdatePhone(phone);
        }
    }
}
