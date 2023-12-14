using Microsoft.EntityFrameworkCore;
using ReviewManagementApp.BusinessLayer.ViewModels;
using ReviewManagementApp.DataLayer;
using ReviewManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReviewManagementApp.BusinessLayer.Services.Repository
{
    public class ReviewManagementRepository : IReviewManagementRepository
    {
        private readonly ReviewManagementAppDbContext _dbContext;
        public ReviewManagementRepository(ReviewManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Review> CreateReview(Review ReviewModel)
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