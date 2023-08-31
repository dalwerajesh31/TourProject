using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace ETourProject1.Repository
{
    public interface IPackage_Master_Interface
    {
        Task<ActionResult<Package_master>>AddPackage(Package_master packageMaster);
        Task<ActionResult<IEnumerable<Package_master>>> GetPackageMasters();

        Task<ActionResult<Package_master>?> GetById(int id);
        //Task<ActionResult<IEnumerable<Package_master>>> getByCatmaster(int id);
    }
}
