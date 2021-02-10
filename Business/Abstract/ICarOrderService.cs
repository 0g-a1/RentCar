using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarOrderService
    {
        List<CarOrder> GetAll();
        CarOrder GetById(int carOrderId);
    }
}
