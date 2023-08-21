using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DataObject.Models;
namespace DataAccessObject
{
    public class BaiXeDao
    {
        public static BaiXeDao instance = null;
        public static readonly object instanceLock = new object();

        public BaiXeDao() { }
        public static BaiXeDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BaiXeDao();
                    }
                    return instance;
                }
            }
        }

        public List<Baixe> GetBaixes()
        {
            var listOrders = new List<Baixe>();
            try
            {
                using (var context = new BookingCarParkingManagementContext())
                {
                    listOrders = context.Baixes.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrders;
        }
        public Baixe GetBaixeByID(string proID)
        {
            int id = int.Parse(proID);
            Baixe product = new Baixe();
            try
            {
                using (var dbContext = new BookingCarParkingManagementContext())
                {
                    product = dbContext.Baixes.SingleOrDefault(m => m.BaixeId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }

        public List<Baixe> SearchProduct(string keyword, string type)
        {
            List<Baixe> productSearchList = null;
            try
            {
                using (var dbContext = new BookingCarParkingManagementContext())
                {
                    if ("BaixeName".Equals(type))
                    {
                        var result = from p in dbContext.Baixes
                                     where p.BaixeName.Contains(keyword)
                                     select p;
                        productSearchList = result.ToList();
                    }
                    else if ("BaixeID".Equals(type))
                    {
                        var result = from p in dbContext.Baixes
                                     where p.BaixeId.ToString().Equals(keyword)
                                     select p;
                        productSearchList = result.ToList();
                    }                   
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return productSearchList;
        }
    }
}
