using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.DataAccess.Abstract;
using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Concrete
{
    public class SliderService:ISliderService
    {
        private readonly ISliderDal _sliderDal;
        private readonly ICacheManager _cacheManager;



        public SliderService(ISliderDal sliderDal, ICacheManager cacheManager)
        {
            _sliderDal = sliderDal;
            _cacheManager = cacheManager;
        }

        public void Add(Slider slider)
        {
            _sliderDal.Add(slider);
        }

        public List<Slider> AdminList()
        {
            return _sliderDal.List();
        }

        public void Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
        }

        public Slider GetById(int id)
        {
            return _sliderDal.Get(x => x.Id == id);
        }

        public List<Slider> List()
        {
            var cacheData = _cacheManager.Get<List<Slider>>("slider.list");

            if (cacheData==null)
            {
                var data = _sliderDal.List();
                _cacheManager.Set("slider.list", data);
                return data;
            }
            else
            {
                return cacheData;
            }
            
        }

        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
