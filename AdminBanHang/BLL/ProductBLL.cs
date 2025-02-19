﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminBanHang.DTO;

namespace AdminBanHang.BLL
{
    class ProductBLL
    {
        public DataTable GetAllProduct()
        {
            return DAL.ProductDAL.GetAllProduct();
        }
        public List<Types> GetAllType()
        {
            return DAL.ProductDAL.GetAllType();
        }
        public List<Company> GetAllCompany()
        {
            return DAL.ProductDAL.GetAllCompany();
        }
        public List<Company> GetCompany(int id)
        {
            return DAL.ProductDAL.GetCompany(id);
        }
        public List<Types> GetTypes(int id)
        {
            return DAL.ProductDAL.GetTypes(id);
        }
        public string pathImage(int id)
        {
            return DAL.ProductDAL.pathImage(id);
        }
        public void AddProduct(Product product)
        {
            DAL.ProductDAL.AddProduct(product);
        }    
        public void EditProduct(Product product, int id)
        {
            DAL.ProductDAL.EditProduct(product, id);
        }
        public void EditProduct(int amount, int id)
        {
            DAL.ProductDAL.EditProduct(amount, id);
        }    
        public void DeleteProduct(int id)
        {
            DAL.ProductDAL.DeleteProduct(id);
        }
        public DataTable Search(int idtype, int idcate, string text)
        {
            return DAL.ProductDAL.Search(idtype, idcate, text);
        }
    }
}
