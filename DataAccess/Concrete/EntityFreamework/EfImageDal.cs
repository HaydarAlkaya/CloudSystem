using Core.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFreamework
{
    public class EfImageDal : EfEntityRepositoryBase<Image,CloudContext> , IImagesDal
    {

    }
}