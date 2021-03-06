using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        List<Supplier> GetAll();
        Supplier GetSupplierById(int supplierId);

    }
}
