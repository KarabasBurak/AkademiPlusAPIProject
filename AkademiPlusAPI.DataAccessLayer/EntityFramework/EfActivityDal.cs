using AkademiPlusAPI.DataAccessLayer.Abstract;
using AkademiPlusAPI.DataAccessLayer.Repositories;
using AkademiPlusAPI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusAPI.DataAccessLayer.EntityFramework
{
    public class EfActivityDal:GenericRepository<Activity>,IActivityDal
    {
    }
}
