using DataObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
<<<<<<<< HEAD:G3_BookingCarParkingManagement/Repository/IBaixeRepository.cs
    public interface IBaixeRepository
========
    public class UserRepository : RepositoryBase<User>
>>>>>>>> NewUp/main:G3_BookingCarParkingManagement/Repository/UserRepository.cs
    {
        public List<Baixe> GetBaiXe();

        List<Baixe> SearchProduct(string keyword, string type);
    }
}
