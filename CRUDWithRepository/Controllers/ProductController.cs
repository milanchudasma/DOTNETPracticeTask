using CRUDWithRepository.core;
using CRUDWithRepository.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWithRepository.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAll();
            return View(products);
        }


        [HttpGet]
        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Product());
            }
            else
            {
                Product product = await _productRepository.GetById(id);
                if (product != null)
                {

                    return View(product);
                }
                TempData["errorMessage"] = $"Product details not found with this id : {id}";
                return RedirectToAction("Index");
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(Product model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    if(model.Id==0)
                    {
                        await _productRepository.Add(model);
                        TempData["SuccessMessage"] = "Data Inserted SuccessFully";
                        
                    }
                    else
                    {
                        await _productRepository.Update(model);
                        TempData["SuccessMessage"] = "Data Updated SuccessFully";
                    }
                    return RedirectToAction(nameof(Index));

                } 
                else
                {
                    TempData["errorMessage"] = "Model state is InValid";
                    return View();
                }

            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Product product = await _productRepository.GetById(id);
                if (product != null)
                {
                    return View(product);
                }
                TempData["errorMessage"] = $"Product details not found with this id : {id}"; ;
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["errorMessage"] = $"Product details not found with this id : {id}"; ;
                return RedirectToAction("Index");
            }
           
           
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Product model)
        {
            try
            {
                await _productRepository.Delete(model.Id);
                TempData["SuccessMessage"] = "Data Inserted SuccessFully";
                return RedirectToAction("Index");

            }
            catch(Exception ex)
            {
                TempData["errorMessage"] = $"Product details not found with this id : {model.Id}"; ;
                return RedirectToAction("Index");
            }
           
        }

    }
}
