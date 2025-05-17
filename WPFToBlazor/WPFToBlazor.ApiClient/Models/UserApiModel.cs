using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToBlazor.ApiClient.Models
{
    public class UserApiModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int IsAdmin { get; set; }
        public string Password { get; set; }
        public string CashierId { get; set; }
        public string ProfilePicture { get; set; }

        public UserApiModel()
        {
            
        }
    }
}
