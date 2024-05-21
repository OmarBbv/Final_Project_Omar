using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.TableModels
{
    public class Activitie : BaseEntity
    {
        public string Text { get; set; }
        public int AboutId { get; set; }
        public virtual About About { get; set; }
    }
}
