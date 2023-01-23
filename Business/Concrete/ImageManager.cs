using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImagesDal _imagesDal;
        public ImageManager(IImagesDal imagesDal)
        {
            _imagesDal = imagesDal;
        }

        public IResult Add(Image t)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _imagesDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(Image t)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _imagesDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imagesDal.GetAll());
        }

        public IDataResult<Image> GetById(int id)
        {
            return new SuccessDataResult<Image>(_imagesDal.Get(d => d.Id == id));
        }

        public IResult Update(Image t)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _imagesDal.Update(t);
            return new SuccessResult();
        }
    }
}
