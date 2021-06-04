using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ShipperManager : IShipperService
    {
        IShipperDAL _shipperDAL;
        public ShipperManager(IShipperDAL shipperDAL)
        {
            _shipperDAL = shipperDAL;
        }
        public List<Shipper> GetAll()
        {
            return _shipperDAL.GetAll();
        }

        public Shipper GetShipperById(int shipperID)
        {
            return _shipperDAL.Get(s => s.ShipperID == shipperID);
        }

    }
}
