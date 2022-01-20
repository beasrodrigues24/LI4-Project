using System;

namespace Geres4U.Data.DataModels
{
    public class ReviserDataModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ReviserDataModel(String email, String password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
