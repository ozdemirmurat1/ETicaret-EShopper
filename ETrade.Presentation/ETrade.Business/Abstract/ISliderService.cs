using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface ISliderService
    {
        List<Slider> List();
        List<Slider> AdminList();

        Slider GetById(int id);
        void Add(Slider slider);
        void Update(Slider slider);
        void Delete(Slider slider);

    }
}
