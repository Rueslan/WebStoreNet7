using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStoreNet7.Domain.Entities.Base;
using WebStoreNet7.Domain.Entities.Base.Interfaces;

namespace WebStoreNet7.Domain.Entities
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
