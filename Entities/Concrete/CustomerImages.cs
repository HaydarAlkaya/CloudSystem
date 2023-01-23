using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CustomerImages : IEntity
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string ImageId { get; set; }
    }
}
