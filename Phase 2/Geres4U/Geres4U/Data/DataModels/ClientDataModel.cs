using System;

namespace Geres4U.Data.DataModels
{
    public class ClientDataModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ClientDataModel(String email, String password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
