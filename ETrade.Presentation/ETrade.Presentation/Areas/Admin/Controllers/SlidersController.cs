using ETrade.Business.Abstract;
using ETrade.Entities;
using ETrade.Presentation.Areas.Admin.Models;
using ETrade.Presentation.Extensions;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;

        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IActionResult Index()
        {
            var sliders = _sliderService.AdminList();
            SliderListViewModel sliderListViewModel = new SliderListViewModel();
            sliderListViewModel.List = sliders;
            return View(sliderListViewModel);
        }
        public IActionResult DeleteSlider(int id)
        {
            var sliders = _sliderService.GetById(id);
            _sliderService.Delete(sliders);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Slider Transactions",
                Message = "The Slider Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("Index");
        }
        public IActionResult AddSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSlider(SliderModel model)
        {
            if (ModelState.IsValid)
            {
                Slider slider = new Slider();
                if (model.Image!=null)
                {
                    var extension = Path.GetExtension(model.Image.FileName);
                    var newImageName = model.Image.FileName;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    model.Image.CopyTo(stream);
                    slider.Image = newImageName;
                }
                slider.Header = model.Header;
                slider.Description = model.Description;
                slider.Sort = model.Sort;
                slider.Status = model.Status;
                slider.EndDate = model.EndDate;
                slider.Link = model.Link;

                _sliderService.Add(slider);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Slider Transactions",
                    Message = "The Slider Has Been Successfully Added!",
                    Css = "success"

                });
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult EditSlider(int id)
        {
            var slider = _sliderService.GetById(id);
            if (slider != null)
            {
                SliderEditModel sliderEditModel = new SliderEditModel
                {
                   Id=slider.Id,
                   Header=slider.Header,
                   Description=slider.Description,
                   Link=slider.Link,
                   EndDate=slider.EndDate,
                   Status=slider.Status,
                   Sort=slider.Sort,
                   Image = slider.Image
                };
                return View(sliderEditModel);
            }
            else
            {
                TempData["error"] = "Slider Bulunamadı";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult EditSlider(SliderEditModel model,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var slider = _sliderService.GetById(model.Id);
                if (slider == null)
                {
                    return NotFound();
                }
                slider.Id = model.Id;
                slider.Header = model.Header;
                slider.Description = model.Description;
                slider.Link = model.Link;
                slider.EndDate = model.EndDate;
                slider.Status = model.Status;
                slider.Sort = model.Sort;
                if (file != null)
                {
                    slider.Image = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    file.CopyTo(new FileStream(path, FileMode.Create));
                }
                _sliderService.Update(slider);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Slider Transactions",
                    Message = "The Slider Has Been Successfully Edited!",
                    Css = "success"

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
       
        
    }
}
