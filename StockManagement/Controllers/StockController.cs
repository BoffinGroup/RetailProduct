using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.DTOs;
using Entities.Models;

namespace StockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private ILoggerManager _logger;
        private IMapper _mapper;
        public StockController(IRepositoryWrapper repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStocks()
        {
            try
            {
                var stocks = await _repository.Stock.GetAllStocksAsync();
                _logger.LogInfo($"Returned all stocks from database.");

                var ownersResult = _mapper.Map<IEnumerable<StockReadDTO>>(stocks);
                return Ok(ownersResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllStocks action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateStock([FromBody]StockCreateDTO stock)
        {
            try
            {
                if (stock == null)
                {
                    _logger.LogError("Stock object sent from client is null.");
                    return BadRequest("Stock object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid stock object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var stockEntity = _mapper.Map<Stock>(stock);

                _repository.Stock.CreateStock(stockEntity);
                await _repository.SaveAsync();

                var createdStock = _mapper.Map<StockCreateDTO>(stockEntity);
                return CreatedAtRoute("OwnerById", new { id = createdStock.Id }, createdStock);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateStock action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}