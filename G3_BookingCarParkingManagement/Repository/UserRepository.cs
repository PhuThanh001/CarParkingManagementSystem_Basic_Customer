<<<<<<< HEAD
﻿using DataAccessObject;
using DataObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
=======
﻿using DataObject.Models;
using System;
using System.Collections.Generic;
>>>>>>> NewUp/main
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
<<<<<<< HEAD
    public class UserRepository : IUserRepository
    {
        public List<Users> GetMembers() => CustomerDao.Instance.GetMembers();

        public Users CheckLogin(string email, string password) => CustomerDao.Instance.CheckLogin(email, password);

        public Users GetMemberByMemberID(string memberID) => CustomerDao.Instance.GetMemberByMemberID(memberID);

        public bool CheckUpdateEmailDuplicated(int memberID, string email) => CustomerDao.Instance.CheckUpdateEmailDuplicated(memberID, email);

        public bool CheckMemberIdDuplicated(int memberID) => CustomerDao.Instance.CheckMemberIdDuplicated(memberID);

        public bool CheckEmailDuplicated(int memberID, string email) => CustomerDao.Instance.CheckEmailDuplicated(email);

        public void UpdateMember(Users m) => CustomerDao.Instance.UpdateMember(m);
=======
<<<<<<<< HEAD:G3_BookingCarParkingManagement/Repository/IBaixeRepository.cs
    public interface IBaixeRepository
========
    public class UserRepository : RepositoryBase<User>
>>>>>>>> NewUp/main:G3_BookingCarParkingManagement/Repository/UserRepository.cs
    {
        public List<Baixe> GetBaiXe();

        List<Baixe> SearchProduct(string keyword, string type);
>>>>>>> NewUp/main
    }
}
