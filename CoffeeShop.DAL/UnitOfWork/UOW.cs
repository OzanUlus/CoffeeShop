using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Context;
using CoffeeShop.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.UnitOfWork
{
    public class UOW : IUOW
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICakeRepository _cakeRepository;
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly ICoffeeSizeRepository _coffeeSizeRepository;
        private readonly ICookyRepository _cookyRepository;
        private readonly IExtraRepository _extraRepository;
        private readonly IOrderLineRepository _orderLineRepository;
        private readonly IOrderRepository _orderRepository;

        public UOW(AppDbContext appDbContext, ICakeRepository cakeRepository, ICoffeeRepository coffeeRepository, 
            ICoffeeSizeRepository coffeeSizeRepository, ICookyRepository cookyRepository, IExtraRepository extraRepository, 
            IOrderLineRepository orderLineRepository, IOrderRepository orderRepository)
        {
            _appDbContext = appDbContext;
            _cakeRepository = cakeRepository;
            _coffeeRepository = coffeeRepository;
            _coffeeSizeRepository = coffeeSizeRepository;
            _cookyRepository = cookyRepository;
            _extraRepository = extraRepository;
            _orderLineRepository = orderLineRepository;
            _orderRepository = orderRepository;
        }

        public ICakeRepository GetCakeRepository()
        {
            return _cakeRepository;
        }

        public ICoffeeRepository GetCoffeeRepository()
        {
            return _coffeeRepository;
        }

        public ICoffeeSizeRepository GetCoffeeSizeRepository()
        {
            return _coffeeSizeRepository;
        }

        public ICookyRepository GetCookyRepository()
        {
            return _cookyRepository;
        }

        public IExtraRepository GetExtraRepository()
        {
            return _extraRepository;
        }

        public IOrderLineRepository GetOrderLineRepository()
        {
            return _orderLineRepository;
        }

        public IOrderRepository GetOrderRepository()
        {
            return _orderRepository;
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }

        IRepository<T> IUOW.GetGenericRepostory<T>()
        {
            return new GenericRepository<T>(_appDbContext);
        }
    }
}
