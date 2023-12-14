using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReviewManagementApp.BusinessLayer.Interfaces;
using ReviewManagementApp.BusinessLayer.ViewModels;
using ReviewManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewManagementApp.Entities;

namespace ReviewManagementApp.Controllers
{
    [ApiController]
    public class ReviewManagementController : ControllerBase
    {
        private readonly IReviewManagementService  _reviewService;
        public ReviewManagementController(IReviewManagementService reviewservice)
        {
             _reviewService = reviewservice;
        }

        [HttpPost]
        [Route("create-review")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateReview([FromBody] Review model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-review")]
        public async Task<IActionResult> UpdateReview([FromBody] ReviewViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-review")]
        public async Task<IActionResult> DeleteReview(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-review-by-id")]
        public async Task<IActionResult> GetReviewById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-reviews")]
        public async Task<IEnumerable<Review>> GetAllReviews()
        {
           //write your code here
           throw new NotImplementedException();
        }
    }
}
