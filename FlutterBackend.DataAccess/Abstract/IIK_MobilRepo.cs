using System;
using System.Collections.Generic;
using System.Text;
using FlutterBackend.Entities;


namespace FlutterBackend.DataAccess.Abstract
{
    public interface IIK_MobilRepo
    {
        List<IK_Mobil> GetAll();

        IK_Mobil GetById(int id);

        IK_Mobil Create(IK_Mobil ik_mobil);

        IK_Mobil Update(IK_Mobil ik_mobil);
    }
}
