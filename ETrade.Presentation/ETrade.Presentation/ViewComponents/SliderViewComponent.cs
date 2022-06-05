using ETrade.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.ViewComponents
{
    public class SliderViewComponent:ViewComponent
    {
        private readonly ISliderService _sliderService;
        public SliderViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.List();
            return View(sliders);
        }
    }
}
