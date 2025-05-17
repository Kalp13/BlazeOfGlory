using WPFToBlazor.ApiClient;
using WPFToBlazor.ApiClient.Models;

namespace WPFToBlazor
{
    public class DummyApiClient : IApiClient
    {
        public Task<BillApiModel?> CreateBillAsync(BillApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<BillRowItemApiModel?> CreateBillRowItemAsync(BillRowItemApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryApiModel?> CreateCategoryAsync(CategoryApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ItemApiModel?> CreateItemAsync(ItemApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionApiModel?> CreateTransactionAsync(TransactionApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task<UserApiModel?> CreateUserAsync(UserApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBillAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBillRowItemAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTransactionAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BillRowItemApiModel>> GetAllBillRowItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<BillApiModel>> GetAllBillsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryApiModel>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemApiModel>> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<TransactionApiModel>> GetAllTransactionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserApiModel>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BillApiModel?> GetBillByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<BillRowItemApiModel?> GetBillRowItemByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryApiModel?> GetCategoryByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ItemApiModel?> GetItemByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionApiModel?> GetTransactionByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<UserApiModel?> GetUserByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<string?> LoginAsync(LoginRequest request) => throw new NotImplementedException();

        public Task UpdateBillAsync(long id, BillApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBillRowItemAsync(long id, BillRowItemApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(long id, CategoryApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(long id, ItemApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTransactionAsync(long id, TransactionApiModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(long id, UserApiModel model)
        {
            throw new NotImplementedException();
        }
        // ...implement all other methods similarly...
    }
}
