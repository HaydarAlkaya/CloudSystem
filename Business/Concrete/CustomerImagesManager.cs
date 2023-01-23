using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerImagesManager : ICustomerImagesService
    {
        ICustomerImagesDal _customerImages;
        public CustomerImagesManager(ICustomerImagesDal customerImages)
        {
            _customerImages = customerImages;
        }
        public IResult Add(CustomerImages t)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _customerImages.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(CustomerImages t)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _customerImages.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<CustomerImages>> GetAll()
        {
            return new SuccessDataResult<List<CustomerImages>>(_customerImages.GetAll());
        }

        public IDataResult<CustomerImages> GetById(int id)
        {
            return new SuccessDataResult<CustomerImages>(_customerImages.Get(d => d.Id == id));
        }

        public IResult Update(CustomerImages t)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _customerImages.Update(t);
            return new SuccessResult();
        }
    }
}
