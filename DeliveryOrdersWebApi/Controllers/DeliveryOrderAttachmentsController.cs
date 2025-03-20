using DeliveryOrdersWebApi.DAL;
using DeliveryOrdersWebApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryOrdersWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DeliveryOrderAttachmentsController : ControllerBase
    {
        private readonly DeliveryOrderDbContext _dbContext;

        public DeliveryOrderAttachmentsController(DeliveryOrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                var deliveryAttachmentsList = _dbContext.DELIVERY_ORDER_DOCUMENTS.ToList();
                if (deliveryAttachmentsList.Count == 0)
                    return NotFound("Not a Single Delivery Attachment List Found");
                return Ok(deliveryAttachmentsList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(List<sDELIVERY_ORDER_DOCUMENTS> Data)
        {
            try
            {
                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                foreach (var model in Data)
                {
                    if (_dbContext.DELIVERY_ORDER_DOCUMENTS.Find(model.Delivery_Document_ID) != null)
                        return NotFound($"Delivery Order Attachment with Id {model.Delivery_Document_ID} is already Present");
                    _dbContext.Add(model);
                    _dbContext.SaveChanges();
                }
                return Ok("New Delivery Order Attachment Created Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

