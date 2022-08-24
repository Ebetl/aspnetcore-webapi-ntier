using FlutterBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBackend.DataAccess.Abstract
{
    public interface IPhoneRepo
    {
        List<Phone> GetAllPhones();

        Phone GetPhoneById(int id);

        Phone CreatePhone(Phone phone);

        Phone UpdatePhone(Phone phone);

    }
}
