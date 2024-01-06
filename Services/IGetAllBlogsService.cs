using ColonyReviewsBlazor8.Models;

namespace ColonyReviewsBlazor8.Services
{
    public interface IGetAllBlogsService
    {
        Task LoadDataAsync();
        List<BlogModel> GetData();
    }
}
