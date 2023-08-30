using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Repository
{
    public interface ICategory_MasterInterface
    {
            Task<ActionResult<Category_Master>> GetCategory(int id);
            Task<ActionResult<IEnumerable<Category_Master>>> GetAllCategory();
            Task<ActionResult<Category_Master>> Add(Category_Master category);

            Task<Category_Master> Update(int id, Category_Master category);
            Task<Category_Master> Delete(int id);

            ActionResult<IEnumerable<dynamic>> Get(int id);

     }
}

