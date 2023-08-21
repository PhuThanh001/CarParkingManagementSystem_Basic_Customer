using DataObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObject;

namespace Repository
{
    public class BaixeRepository : IBaixeRepository
    {
        public List<Baixe> GetBaiXe() => BaiXeDao.Instance.GetBaixes();

        public List<Baixe> SearchProduct(string keyword, string type) => BaiXeDao.Instance.SearchProduct(keyword, type);

    }
}
