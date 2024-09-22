using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkishLocalFlavors.Dto.BasketDto
{
    public class UpdateQuantityDto
    {
        public int BasketId { get; set; }
        public int Count { get; set; }
    }
}
