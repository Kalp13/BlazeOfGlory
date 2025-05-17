using WPFToBlazor.ApiClient.Models;

namespace WPFToBlazor.ApiClient
{
    public interface IApiClient
    {
        // Bill API Calls
        Task<List<BillApiModel>> GetAllBillsAsync();
        Task<BillApiModel?> GetBillByIdAsync(long id);
        Task<BillApiModel?> CreateBillAsync(BillApiModel model);
        Task UpdateBillAsync(long id, BillApiModel model);
        Task DeleteBillAsync(long id);

        // Bill Row Item API Calls
        Task<List<BillRowItemApiModel>> GetAllBillRowItemsAsync();
        Task<BillRowItemApiModel?> GetBillRowItemByIdAsync(long id);
        Task<BillRowItemApiModel?> CreateBillRowItemAsync(BillRowItemApiModel model);
        Task UpdateBillRowItemAsync(long id, BillRowItemApiModel model);
        Task DeleteBillRowItemAsync(long id);

        // Category API Calls
        Task<List<CategoryApiModel>> GetAllCategoriesAsync();
        Task<CategoryApiModel?> GetCategoryByIdAsync(long id);
        Task<CategoryApiModel?> CreateCategoryAsync(CategoryApiModel model);
        Task UpdateCategoryAsync(long id, CategoryApiModel model);
        Task DeleteCategoryAsync(long id);

        // Transaction API Calls
        Task<List<TransactionApiModel>> GetAllTransactionsAsync();
        Task<TransactionApiModel?> GetTransactionByIdAsync(long id);
        Task<TransactionApiModel?> CreateTransactionAsync(TransactionApiModel model);
        Task UpdateTransactionAsync(long id, TransactionApiModel model);
        Task DeleteTransactionAsync(long id);

        // Item API Calls
        Task<List<ItemApiModel>> GetAllItemsAsync();
        Task<ItemApiModel?> GetItemByIdAsync(long id);
        Task<ItemApiModel?> CreateItemAsync(ItemApiModel model);
        Task UpdateItemAsync(long id, ItemApiModel model);
        Task DeleteItemAsync(long id);

        // User API Calls
        Task<List<UserApiModel>> GetAllUsersAsync();
        Task<UserApiModel?> GetUserByIdAsync(long id);
        Task<UserApiModel?> CreateUserAsync(UserApiModel model);
        Task UpdateUserAsync(long id, UserApiModel model);
        Task DeleteUserAsync(long id);

        // Authentication API Calls
        Task<string?> LoginAsync(LoginRequest request);
    }
}