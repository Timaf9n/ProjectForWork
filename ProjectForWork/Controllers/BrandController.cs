using Microsoft.AspNetCore.Mvc;
using ProjectForWork.Data;
using Microsoft.EntityFrameworkCore;
using ProjectForWork.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectForWork.Controllers
{
    [Route("[controller]/[action]")]
    public class BrandController : Controller
    {
        private readonly ProjectForWorkDataContext _dbContext;

        public BrandController(ProjectForWorkDataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Brand> GetBrands()
        {
            return _dbContext.Brands.Include(b => b.Models).ThenInclude(c => c.GetGenerations).ToList();
        }
        [HttpPost]
        public async Task<IActionResult> AddBrand([FromBody] Brand brand)
        {
            _dbContext.Brands.Add(brand);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddModel([FromBody] Model model)
        {
            _dbContext.Models.Add(model);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddGeneration([FromBody] Generation generation)
        {
            _dbContext.Generations.Add(generation);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBrand([FromQuery] int id, [FromBody] Brand brand)
        {
            if (id != brand.id || brand.id < 0)
                return BadRequest("Ids not equals or id less then 0");

            _dbContext.Brands.Update(brand);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateModel([FromQuery] int id, [FromBody] Model model)
        {
            if (id != model.id || model.id < 0)
                return BadRequest("Ids not equals or id less then 0");

            _dbContext.Models.Update(model);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGeneration([FromQuery] int id, [FromBody] Generation generation)
        {
            if (id != generation.id || generation.id < 0)
                return BadRequest("Ids not equals or id less then 0");

            _dbContext.Generations.Update(generation);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            _dbContext.Brands.Remove(new Brand() { id = id });
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveModel(int id)
        {
            _dbContext.Models.Remove(new Model() { id = id });
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveGeneration(int id)
        {
            _dbContext.Generations.Remove(new Generation() { id = id });
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
