using Core.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFreamework
{
    public class EfCustomerImagesDal : EfEntityRepositoryBase<CustomerImages,CloudContext>,ICustomerImagesDal
    {
    }
}
