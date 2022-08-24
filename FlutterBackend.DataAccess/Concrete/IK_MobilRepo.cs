using FlutterBackend.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlutterBackend.Entities;

namespace FlutterBackend.DataAccess.Concrete
{
    public class IK_MobilRepo : IIK_MobilRepo
    {
        public IK_Mobil Create(IK_Mobil ik_mobil)
        {
            using (var ik_MobilDbContext = new IK_MobilDbContext())
            {
                ik_MobilDbContext.IK_Mobil.Add(ik_mobil);
                ik_MobilDbContext.SaveChanges();
                return ik_mobil;

            }
        }

        public List<IK_Mobil> GetAll()
        {
            using (var ik_MobilDbContext = new IK_MobilDbContext())
            {
                return ik_MobilDbContext.IK_Mobil.ToList();
            }
        }

        public IK_Mobil GetById(int id)
        {
            using (var ik_MobilDbContext = new IK_MobilDbContext())
            {
                return ik_MobilDbContext.IK_Mobil.Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public IK_Mobil Update(IK_Mobil ik_mobil)
        {
            using (var ik_MobilDbContext = new IK_MobilDbContext())
            {
                ik_MobilDbContext.IK_Mobil.Update(ik_mobil);
                return ik_mobil;
            }
        }
    }
}
