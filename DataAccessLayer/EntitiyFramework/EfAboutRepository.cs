using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    internal class EfAboutRepository:GenericRepository<About>,IAboutDal
    {
    }
}
