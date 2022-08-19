using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using BusinessLayer;


namespace Reimbursement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseReimbursemtController : ControllerBase
    {
        
        private readonly ReimbursementBusinessLayer _businessLayer;
        public ExpenseReimbursemtController()
        {
            this._businessLayer = new ReimbursementBusinessLayer();


        }



        /// <summary>
        //  Get all the pending requests
        //  </summary>

        [HttpGet("RequestsAsync")]  // get all requests
        [HttpGet("RequestsAsync/{type}")]  // Get all of a type of requst
       // [HttpGet("RequestsAsync/{type}/{id}")] // get all or a specific type and employee
       // [HttpGet("RequestsAsync/{id}")] // get all of a specific employees requests

        public async Task<ActionResult<List<ReimbursementReq>>> RequestsAsync(int type, Guid ? id)
        {
              
                List<ReimbursementReq> requestList = await this._businessLayer.RequestsAsync(type);
                return Ok(requestList);
             
        }

        [HttpPut("UpdateRequestAsync")]
        public async Task<ActionResult<UpdateReRequestDto>> updateRequestAsync(ApprovalDto approval)
        {
            if (ModelState.IsValid)
            { 
            // Send the ApprivalDto to business layer
             UpdateReRequestDto approvedRequest = await this._businessLayer.UpdateRequestAsync(approval);
            return Ok( approvedRequest);
              }
             else return Conflict(approval);//StatusCode(StatusCodes.Status409Conflict);
        }

    }
}
