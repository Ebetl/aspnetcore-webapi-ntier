using FlutterBackend.Business.Abstract;
using FlutterBackend.DataAccess.Concrete;
using FlutterBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBackend.Business.Concrete
{
    public class IK_MobilManager: IIKMobilService
    {
        private DataAccess.Abstract.IIK_MobilRepo _mobilRepo;
        public IK_MobilManager()
        {
            _mobilRepo = new IK_MobilRepo();
        }
        public IK_Mobil Create(IK_Mobil ik_mobil)
        {
            return _mobilRepo.Create(ik_mobil);

        }

        public List<IK_Mobil> GetAll()
        {
            return _mobilRepo.GetAll();
        }

        public IK_Mobil GetById(int id)
        {
            return _mobilRepo.GetById(id);
        }

        public IK_Mobil Update(IK_Mobil ik_mobil)
        {
            return _mobilRepo.Update(ik_mobil);
        }
    }
}
