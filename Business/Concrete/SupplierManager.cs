using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDAL _supplierDAL;

        public SupplierManager(ISupplierDAL supplierDAL)
        {
            _supplierDAL = supplierDAL;
        }

        public List<Supplier> GetAll()
        {
            return _supplierDAL.GetAll();
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return _supplierDAL.Get(s=>s.SupplierID == supplierId);
        }

    }
}
