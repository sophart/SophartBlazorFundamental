using System.Collections.Generic;
using SophartBlazorFundamental.Shared;

namespace SophartBlazorFundamental.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
