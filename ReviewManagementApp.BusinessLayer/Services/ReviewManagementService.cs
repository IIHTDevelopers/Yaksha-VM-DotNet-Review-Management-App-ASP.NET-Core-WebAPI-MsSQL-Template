using ReviewManagementApp.BusinessLayer.Interfaces;
using ReviewManagementApp.BusinessLayer.Services.Repository;
using ReviewManagementApp.BusinessLayer.ViewModels;
using ReviewManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReviewManagementApp.BusinessLayer.Services
{
    public class ReviewManagementService : IReviewManagementService
    {
        private readonly IReviewManagementRepository _repo;

        public ReviewManagementService(IReviewManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Review> CreateReview(Review employeeReview)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteReviewById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Review> GetAllReviews()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Review> GetReviewById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Review> UpdateReview(ReviewViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
