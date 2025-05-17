using System.Net.Http.Json;
using WPFToBlazor.ApiClient.Models;

namespace WPFToBlazor.ApiClient
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region Bill API Calls

        public async Task<List<BillApiModel>> GetAllBillsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BillApiModel>>("api/BillDataModels");
        }

        public async Task<BillApiModel?> GetBillByIdAsync(long id)
        {
            return await _httpClient.GetFromJsonAsync<BillApiModel>($"api/BillDataModels/{id}");
        }

        public async Task<BillApiModel?> CreateBillAsync(BillApiModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/BillDataModels", model);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<BillApiModel>();
        }

        public async Task UpdateBillAsync(long id, BillApiModel model)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/BillDataModels/{id}", model);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteBillAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"api/BillDataModels/{id}");
            response.EnsureSuccessStatusCode();
        }

        #endregion

        //Bill Row Items

        #region Bill Row Item API Calls

        public async Task<List<BillRowItemApiModel>> GetAllBillRowItemsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BillRowItemApiModel>>("api/BillRowItems");
        }

        public async Task<BillRowItemApiModel?> GetBillRowItemByIdAsync(long id)
        {
            return await _httpClient.GetFromJsonAsync<BillRowItemApiModel>($"api/BillRowItems/{id}");
        }

        public async Task<BillRowItemApiModel?> CreateBillRowItemAsync(BillRowItemApiModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/BillRowItems", model);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<BillRowItemApiModel>();
        }

        public async Task UpdateBillRowItemAsync(long id, BillRowItemApiModel model)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/BillRowItems/{id}", model);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteBillRowItemAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"api/BillRowItems/{id}");
            response.EnsureSuccessStatusCode();
        }

        #endregion

        #region Category API Calls

        public async Task<List<CategoryApiModel>> GetAllCategoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<CategoryApiModel>>("api/Categories");
        }

        public async Task<CategoryApiModel?> GetCategoryByIdAsync(long id)
        {
            return await _httpClient.GetFromJsonAsync<CategoryApiModel>($"api/Categories/{id}");
        }

        public async Task<CategoryApiModel?> CreateCategoryAsync(CategoryApiModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Categories", model);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CategoryApiModel>();
        }

        public async Task UpdateCategoryAsync(long id, CategoryApiModel model)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Categories/{id}", model);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteCategoryAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"api/Categories/{id}");
            response.EnsureSuccessStatusCode();
        }

        #endregion

        #region Transaction API Calls

        public async Task<List<TransactionApiModel>> GetAllTransactionsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<TransactionApiModel>>("api/Transactions");
        }

        public async Task<TransactionApiModel?> GetTransactionByIdAsync(long id)
        {
            return await _httpClient.GetFromJsonAsync<TransactionApiModel>($"api/Transactions/{id}");
        }

        public async Task<TransactionApiModel?> CreateTransactionAsync(TransactionApiModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Transactions", model);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TransactionApiModel>();
        }

        public async Task UpdateTransactionAsync(long id, TransactionApiModel model)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Transactions/{id}", model);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteTransactionAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"api/Transactions/{id}");
            response.EnsureSuccessStatusCode();
        }

        #endregion

        #region Item API Calls

        public async Task<List<ItemApiModel>> GetAllItemsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ItemApiModel>>("api/Items");
        }

        public async Task<ItemApiModel?> GetItemByIdAsync(long id)
        {
            return await _httpClient.GetFromJsonAsync<ItemApiModel>($"api/Items/{id}");
        }

        public async Task<ItemApiModel?> CreateItemAsync(ItemApiModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Items", model);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ItemApiModel>();
        }

        public async Task UpdateItemAsync(long id, ItemApiModel model)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Items/{id}", model);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteItemAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"api/Items/{id}");
            response.EnsureSuccessStatusCode();
        }

        #endregion

        #region User API Calls

        public async Task<List<UserApiModel>> GetAllUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<UserApiModel>>("api/Users");
        }

        public async Task<UserApiModel?> GetUserByIdAsync(long id)
        {
            return await _httpClient.GetFromJsonAsync<UserApiModel>($"api/Users/{id}");
        }

        public async Task<UserApiModel?> CreateUserAsync(UserApiModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Users", model);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<UserApiModel>();
        }

        public async Task UpdateUserAsync(long id, UserApiModel model)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Users/{id}", model);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteUserAsync(long id)
        {
            var response = await _httpClient.DeleteAsync($"api/Users/{id}");
            response.EnsureSuccessStatusCode();
        }

        #endregion
    }
}
