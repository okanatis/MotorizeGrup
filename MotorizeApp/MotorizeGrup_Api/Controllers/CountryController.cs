using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motorize_Business.Repository.Abstract;
using Motorize_Business.Repository.Concrete;
using MotorizeGrup_Entities.Models;

namespace MotorizeGrup_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private IRepository<Countries> CountryRepository;
        private IUnitOfWork _CountryUnitofWork;
        private DbContext _dbContext;
        public CountryController()
        {
            _dbContext = new TravelDbContext();
            _CountryUnitofWork = new EFUnitOfWork(_dbContext);
            CountryRepository = _CountryUnitofWork.GetRepository<Countries>();
        }
        //  [Route("GetCountries")]
        [HttpGet]
        public List<Countries> GetCountries()
        {
            return CountryRepository.GetAll().ToList();
        }
        //    [Route("AddCountries")]
        [HttpPost]
        public void POST(Countries countries)
        {
            CountryRepository.Insert(countries);
            _CountryUnitofWork.SaveChanges();
        }
    }
}