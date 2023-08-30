using ETourProject1.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETourProject1.Models;

namespace ETourProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_MasterController : ControllerBase
    {
        private readonly ICategory_MasterInterface _repository;

        public Category_MasterController(ICategory_MasterInterface repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category_Master>>> GetCategories()
        {
            var categories = await _repository.GetAllCategory();
            if (categories == null)
            {
                return NotFound();
            }

            return categories.Value.ToList(); // Assuming GetAllCategory() returns an ActionResult<IEnumerable<Category_Master>>
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category_Master>> GetById(int id)
        {
            var category = await _repository.GetCategory(id);
            if (category.Value == null)
            {
                return NotFound();
            }

            return category.Value;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category_Master category)
        {
            if (id != category.catMasterID)
            {
                return BadRequest();
            }

            try
            {
                var updatedCategory = await _repository.Update(id, category);
                if (updatedCategory == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Category_Master>> PostCategory(Category_Master category)
        {
            var addedCategory = await _repository.Add(category);
            return CreatedAtAction(nameof(GetById), new { id = addedCategory.Value.catMasterID }, addedCategory.Value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var deletedCategory = await _repository.Delete(id);
            if (deletedCategory == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
