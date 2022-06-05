using ETrade.Business.Abstract;
using ETrade.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Concrete
{
    public class ReviewService:IReviewService
    {
        private readonly IReviewDal _reviewDal;

        public ReviewService(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }
    }
}
