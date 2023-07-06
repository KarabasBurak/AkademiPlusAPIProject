using AkademiPlusAPI.BusinessLayer.Abstract;
using AkademiPlusAPI.DataAccessLayer.Abstract;
using AkademiPlusAPI.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusAPI.BusinessLayer.Concrete
{
    public class ActivityManager : IActivityService
    {
        private readonly IActivityDal _activityDal;

        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public void TDelete(Activity t)
        {
            _activityDal.Delete(t);
        }

        public Activity TGetByID(int id)
        {
            return _activityDal.GetByID(id);
        }

        public List<Activity> TGetList()
        {
            return _activityDal.GetList();
        }

        public void TInsert(Activity t)
        {
            _activityDal.Insert(t);
        }

        public void TUpdate(Activity t)
        {
            _activityDal.Update(t);
        }
    }
}
