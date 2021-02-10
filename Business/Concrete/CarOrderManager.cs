using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarOrderManager : ICarOrderService
    {
        ICarOrderDal _orderDal;

        public CarOrderManager(ICarOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<CarOrder> GetAll()
        {
            return _orderDal.GetAll();
        }

        public CarOrder GetById(int carOrderId)
        {
            return _orderDal.Get(o => o.CarOrderId == carOrderId);
        }
    }
}
