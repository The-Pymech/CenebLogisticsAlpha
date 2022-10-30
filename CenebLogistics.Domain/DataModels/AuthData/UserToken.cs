using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.DataModels.AuthData
{
    public class UserToken
    {
        public int Id { get; set; }

        public string Token { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime ExpiryDate { get; set; }



        //Relationship
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
