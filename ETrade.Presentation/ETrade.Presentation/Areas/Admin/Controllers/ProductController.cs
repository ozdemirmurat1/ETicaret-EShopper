using ETrade.Business.Abstract;
using ETrade.Entities;
using ETrade.Presentation.Areas.Admin.Models;
using ETrade.Presentation.Extensions;
using ETrade.Presentation.Helpers;
using ETrade.Presentation.Models;
using Microsoft.AspNetCore.Hosting;
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
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;
        private readonly ICategoryService _categoryService;
        private readonly ICategoryProductService _categoryProductService;
        


        public ProductController(IProductService productService, IProductImageService productImageService, ICategoryService categoryService, ICategoryProductService categoryProductService)
        {
            _productService = productService;
            _productImageService = productImageService;
            _categoryService = categoryService;
            _categoryProductService = categoryProductService;
            
        }

        public IActionResult Index()
        {
            var product = _productService.List();
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.ProductImages = _productImageService.List();
            productListViewModel.Products = product;
            return View(productListViewModel);
        }

        public IActionResult Images(int id)
        {
            var productImages = _productImageService.List(id);
            ProductImageViewModel productImageViewModel = new ProductImageViewModel();
            productImageViewModel.ProductImages = productImages;
            //productImageViewModel.Name = _productService.GetById(id).Name;

            return View(productImageViewModel);

        }
        public IActionResult ImageUpload(IFormFile file)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            if (file != null)
            {              
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\products", fileName);
                file.CopyTo(new FileStream(path, FileMode.Create));
            }
            return View();
        }
        public IActionResult ProductAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(ProductAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                _productService.Add(new Product()
                {
                    Name=model.Name,
                    Price=model.Price,
                    Description=model.Description,
                    Status=model.Status,
                    SeoName=model.SeoName,
                    Counter=model.Counter
                });
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Product Transactions",
                    Message = "The Product Has Been Successfully Added!",
                    Css = "success"

                });
                return RedirectToAction("Index");
            }
        }
        public IActionResult ProductEdit(int id)
        {
            var product = _productService.GetById(id);
            if (product != null)
            {
                ProductEditModel productEditModel = new ProductEditModel
                {
                    Id=product.Id,
                    Name=product.Name,
                    Price=product.Price,
                    Description=product.Description,
                    Status=product.Status,
                    SeoName=product.SeoName,
                    Counter=product.Counter
                };
                return View(productEditModel);
            }
            else
            {
                TempData["error"] = "Ürün Bulunamadı";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult ProductEdit(ProductEditModel model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    Id=model.Id,
                    Name=model.Name,
                    Price=model.Price,
                    Description=model.Description,
                    Status=model.Status,
                    SeoName=model.SeoName,
                    Counter=model.Counter
                };
                _productService.Update(product);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Product Transactions",
                    Message = "The Product Has Been Successfully Edited!",
                    Css = "success"

                });
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult ProductDelete(int id)
        {
            var products = _productService.GetById(id);
            _productService.Delete(products);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Product Transactions",
                Message = "The Product Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("Index");
        }
        public IActionResult ProductImageList()
        {
            var productImage = _productImageService.List();
            //var productImages = _productImageService.List(id);
            ProductImageList productImageList = new ProductImageList();
            productImageList.List = productImage;
            
            return View(productImageList);
        }
        public IActionResult ProductImageAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProductImageAdd(ProductImageAdd model)
        {
            if (ModelState.IsValid)
            {
                
                ProductImage productImage = new ProductImage();              

                if (model.Name!= null)
                {
                    var extension = Path.GetExtension(model.Name.FileName);
                    var newImageName = model.Name.FileName;
                    var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/products/",newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    model.Name.CopyTo(stream);
                    productImage.Name = newImageName;
                                      
                    //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\products",file.FileName);
                    //productImage.Name = file.FileName;
                    //file.CopyTo(new FileStream(path, FileMode.Create));
                }
                productImage.ProductId = model.ProductId;
                productImage.Sort = model.Sort;
                productImage.Status = model.Status;
                productImage.AltText = model.AltText;

                _productImageService.Add(productImage);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Product Image Transactions",
                    Message = "The Product Image Has Been Successfully Added!",
                    Css = "success"

                });
                return RedirectToAction("ProductImageList");
            }
            else
            {
                return View(model);
            }
            
        }
        public IActionResult ProductImageDelete(int id)
        {
            var productImage = _productImageService.GetById(id);
            _productImageService.Delete(productImage);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Product Image Transactions",
                Message = "The Product Image Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("ProductImageList");
        }
        [HttpGet]
        public IActionResult ProductImageEdit(int id)
        {
            var productImage = _productImageService.GetById(id);
            if (productImage != null)
            {
                ProductImageEditModel productImageEditModel = new ProductImageEditModel();
                productImageEditModel.Id = productImage.Id;
                productImageEditModel.ProductId = productImage.ProductId;
                productImageEditModel.Sort = productImage.Sort;
                productImageEditModel.Status = productImage.Status;
                productImageEditModel.AltText = productImage.AltText;
                productImageEditModel.Name = productImage.Name;

                return View(productImageEditModel);
            }
            else
            {
                TempData["error"] = "Product Image Bulunamadı";
                return RedirectToAction("ProductImageList");
            }
        }
        [HttpPost]
        public IActionResult ProductImageEdit(ProductImageEditModel model,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var productImage = _productImageService.GetById(model.Id);
                if (productImage == null)
                {
                    return NotFound();
                }
                productImage.Id = model.Id;
                productImage.ProductId = model.ProductId;
                productImage.Sort = model.Sort;
                productImage.Status = model.Status;
                productImage.AltText = model.AltText;

                //var fileName = Guid.NewGuid().ToString() + ".jpg";
                if (file != null)
                {
                    productImage.Name = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\products", productImage.Name);
                    file.CopyTo(new FileStream(path, FileMode.Create));
                }
                _productImageService.Update(productImage);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Product Image Transactions",
                    Message = "The Product Image Has Been Successfully Edited!",
                    Css = "success"

                });

                return RedirectToAction("ProductImageList");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult CategoriesList()
        {
            var categories = _categoryService.List();
            CategoriesViewModel categoriesViewModel = new CategoriesViewModel();
            categoriesViewModel.Categories = categories;
            return View(categoriesViewModel);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoriesModel model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                if (model.Image!=null)
                {
                    var extension = Path.GetExtension(model.Image.FileName);
                    var newImageName = model.Image.FileName;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/categories/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    model.Image.CopyTo(stream);
                    category.Image = newImageName;
                }
                category.Name = model.Name;
                category.ParentId = model.ParentId;
                category.Sort = model.Sort;
                category.Status = model.Status;
                category.SeoName = model.SeoName;

                _categoryService.Add(category);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Category Transactions",
                    Message = "The Category Has Been Successfully Added!",
                    Css = "success"

                });
                return RedirectToAction("CategoriesList");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            var orders = _categoryService.GetById(id);
            _categoryService.Delete(orders);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Category Transactions",
                Message = "The Category Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("CategoriesList");
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = _categoryService.GetById(id);
            if (category != null)
            {
                CategoriesEditModel categoryEditModel = new CategoriesEditModel
                {
                    Name = category.Name,
                    ParentId = category.ParentId,
                    Sort = category.Sort,
                    Status = category.Status,
                    SeoName = category.SeoName,
                    Image = category.Image
                };
                return View(categoryEditModel);
            }
            else
            {
                TempData["error"] = "Kategori Bulunamadı";
                return RedirectToAction("CategoriesList");
            }

        }
        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoriesEditModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var category = _categoryService.GetById(model.Id);
                if (category == null)
                {
                    return NotFound();
                }
                category.Name = model.Name;
                category.ParentId = model.ParentId;
                category.Sort = model.Sort;
                category.Status = model.Status;
                category.SeoName = model.SeoName;
                if (file != null)
                {
                    category.Image = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\categories", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                _categoryService.Update(category);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Category Transactions",
                    Message = "The Category Has Been Successfully Edited!",
                    Css = "success"

                });
                return RedirectToAction("CategoriesList");
            }
            return View(model);

        }
        public IActionResult CategoryProductList()
        {
            var categoryProductList = _categoryProductService.List();
            CategoryProductViewModel categoryProductViewModel = new CategoryProductViewModel();
            categoryProductViewModel.List = categoryProductList;
            return View(categoryProductViewModel);
        }

        public IActionResult CategoryProductAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryProductAdd(CategoryProductAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                CategoryProduct categoryProduct = new CategoryProduct
                {
                   ProductId=model.ProductId,
                   CategoryId=model.CategoryId,
                   Sort=model.Sort
                };
                _categoryProductService.Add(categoryProduct);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Category-Product Transactions",
                    Message = "The Category-Product Has Been Successfully Added!",
                    Css = "success"

                });
                return RedirectToAction("CategoryProductList");
            }
        }
        public IActionResult DeleteCategoryProduct(int id)
        {
            var deleteCategoryProduct = _categoryProductService.GetById(id);
            _categoryProductService.Delete(deleteCategoryProduct);
            TempData.Put("message", new ResultMessage()
            {
                Title = "Category-Product Transactions",
                Message = "The Category-Product Has Been Successfully Deleted!",
                Css = "info"

            });
            return RedirectToAction("CategoryProductList");
        }
        public IActionResult EditCategoryProduct(int id)
        {
            var editCategoryProducts = _categoryProductService.GetById(id);
            if (editCategoryProducts != null)
            {
                CategoryProductEditModel categoryProductEditModel = new CategoryProductEditModel
                {
                    Id=editCategoryProducts.Id,
                    ProductId=editCategoryProducts.ProductId,
                    CategoryId=editCategoryProducts.CategoryId,
                    Sort=editCategoryProducts.Sort
                };
                return View(categoryProductEditModel);
            }
            else
            {
                TempData["error"] = "Böyle bir Sayfa Bulunamadı";
                return RedirectToAction("CategoryProductList");
            }
        }
        [HttpPost]
        public IActionResult EditCategoryProduct(CategoryProductEditModel model)
        {
            if (ModelState.IsValid)
            {
                CategoryProduct categoryProduct = new CategoryProduct()
                {
                    Id=model.Id,
                    ProductId=model.ProductId,
                    CategoryId=model.CategoryId,
                    Sort=model.Sort
                };
                _categoryProductService.Update(categoryProduct);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Category-Product Transactions",
                    Message = "The Category-Product Has Been Successfully Edited!",
                    Css = "success"

                });
                return RedirectToAction("CategoryProductList");
            }
            else
            {
                return View(model);
            }
        }





    }   
}
