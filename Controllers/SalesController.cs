using Microsoft.AspNetCore.Mvc;
using SalesAnalysisDbApp.Models;
using SalesAnalysisDbApp.Services;

namespace SalesAnalysisDbApp.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class SalesController:  ControllerBase
  {
  private readonly MongoDbService _mongoService;

    public SalesController(MongoDbService mongoService)
    {
    _mongoService = mongoService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
    var sales = await _mongoService.GetSalesAsync();
    return Ok(sales);
    }
    [HttpPost]
    public async Task<IActionResult> Create(SalesRecord newRecord)
    {
    await _mongoService.CreateSaleAsync(newRecord);
    return CreatedAtAction(nameof(GetAll), new { id = newRecord.Id}, newRecord);
    }
    [HttpGet("summary")]
    public async Task<IActionResult> GetSummary()
    {
    var summary = await _mongoService.GetSalesSummaryAsync();
    return Ok(summary);
    }
  }
}
