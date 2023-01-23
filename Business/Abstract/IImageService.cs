using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Abstract.IBaseService;

namespace Business.Abstract
{
    public interface IImageService : IBaseService<Image>
    {
    }
}
