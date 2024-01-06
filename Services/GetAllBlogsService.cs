using ColonyReviewsBlazor8.Models;
using System.Net.Http.Json;

namespace ColonyReviewsBlazor8.Services
{
    public class GetAllBlogsService : IGetAllBlogsService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private List<BlogModel>? allBlogs = new List<BlogModel>();
        private string url = "https://localhost:7011/BlogPost";

        public List<BlogModel> GetData()
        {
            if (allBlogs == null) 
            {
                return new List<BlogModel>();
            }
            return allBlogs;
        }

        public async Task LoadDataAsync()
        {
            try
            {
                allBlogs = await httpClient.GetFromJsonAsync<List<BlogModel>>(url);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
