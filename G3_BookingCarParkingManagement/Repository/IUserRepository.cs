using DataAccessObject;
using DataObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {
        

        public Users CheckLogin(string email, string password);

        public List<Users> GetMembers();

        public Users GetMemberByMemberID(string memberID);
        public bool CheckUpdateEmailDuplicated(int memberID, string email);

        public bool CheckMemberIdDuplicated(int memberID);

        public bool CheckEmailDuplicated(int memberID, string email);

         void UpdateMember(Users m);

    }
}
