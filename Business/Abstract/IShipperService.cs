using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IShipperService
    {
        List<Shipper> GetAll();
        Shipper GetShipperById(int shipperID);
    }
}
