using CoffeeMug.Common.DTO.Request;
using CoffeeMug.Common.DTO.Response;
using CoffeeMug.Logic.ILogic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CoffeeMug.API.Controllers
{

    
    public class ProductsController : Controller
    {
        private readonly IProductLogic _productLogic;
        public ProductsController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        [HttpGet, Route("api/[controller]/{id}")]
        [SwaggerOperation(Summary = "Get product by id")]
        [ProducesResponseType(typeof(ProductResponseModel), 200)]
        [ProducesResponseType(typeof(void), 400)]
        public IActionResult Get([FromRoute]Guid id)
        {
            try
            {
                var model = _productLogic.GetSingle(id);
                return Ok(model);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }
        [HttpPost("api/[controller]")]
        [SwaggerOperation(Summary = "Add new product")]
        [ProducesResponseType(typeof(ProductResponseModel), 200)]
        [ProducesResponseType(typeof(void), 400)]
        public IActionResult Add([FromBody]AddProductRequestModel model)
        {
           if (ModelState.IsValid)
            {
                try
                {
                    var response = _productLogic.Add(model);
                    return Ok(response);
                }
                catch (Exception e)
                {

                    return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
                }
            }
            return StatusCode(StatusCodes.Status500InternalServerError);

        }
        [HttpGet("api/[controller]")]
        [SwaggerOperation(Summary = "Get list of products")]
        [ProducesResponseType(typeof(List<ProductResponseModel>), 200)]
        [ProducesResponseType(typeof(void), 400)]
        public IActionResult GetAll()
        {
            try
            {
                var response = _productLogic.GetAll();
                return Ok(response);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("api/[controller]/{id}")]
        [SwaggerOperation(Summary = "Delete product")]
        [ProducesResponseType(typeof(Boolean), 200)]
        [ProducesResponseType(typeof(void), 400)]
        public IActionResult Delete([FromRoute] Guid id)
        {
            try
            {
                var response = _productLogic.Delete(id);
                return Ok(response);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("api/[controller]/{id}")]
        [SwaggerOperation(Summary = "Update product")]
        [ProducesResponseType(typeof(ProductResponseModel), 200)]
        [ProducesResponseType(typeof(void), 400)]
        public IActionResult Update([FromRoute]Guid id, [FromBody] UpdateProductRequestModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _productLogic.Update(id, model);
                    return Ok(response);
                }
                catch (Exception e)
                {

                    return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
                }

            }
            return StatusCode(StatusCodes.Status500InternalServerError);
        
        }
    }
}
