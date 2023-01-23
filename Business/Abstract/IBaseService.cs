using Core.Entities;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IBaseService
    {
        public interface IBaseService<T> where T : IEntity, new()
        {
            IResult Add(T t);
            IResult Delete(T t);
            IResult Update(T t);
            IDataResult<T> GetById(int id);
            IDataResult<List<T>> GetAll();
        }
    }
}
