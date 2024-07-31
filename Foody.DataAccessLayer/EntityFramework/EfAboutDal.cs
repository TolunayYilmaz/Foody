using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<Slider>, IAboutDal
    {
        public EfAboutDal(FoodyContext context) : base(context)
        {
        }

        public void Insert(EntityLayer.Concrete.About entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EntityLayer.Concrete.About entity)
        {
            throw new NotImplementedException();
        }

        List<EntityLayer.Concrete.About> IGenericDal<EntityLayer.Concrete.About>.GetAll()
        {
            throw new NotImplementedException();
        }

        EntityLayer.Concrete.About IGenericDal<EntityLayer.Concrete.About>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
