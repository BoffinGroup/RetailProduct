using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        //purchase history to be added

        private IRepositoryWrapper _repository;
        private ILoggerManager _logger;
        private IMapper _mapper;
        public PurchasesController(IRepositoryWrapper repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPurchases()
        {
            try
            {
                var purchases = await _repository.Purchase.GetAllPurchasesAsync();
                _logger.LogInfo($"Returned all Purchases from database.");

                var purchasesResult = _mapper.Map<IEnumerable<PurchaseReadDTO>>(purchases);
                return Ok(purchasesResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllPurchases action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}