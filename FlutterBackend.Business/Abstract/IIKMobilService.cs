using FlutterBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBackend.Business.Abstract
{
    public interface IIKMobilService
    {
        List<IK_Mobil> GetAll();

        IK_Mobil GetById(int id);

        IK_Mobil Create(IK_Mobil ik_mobil);

        IK_Mobil Update(IK_Mobil ik_mobil);

    }
}
