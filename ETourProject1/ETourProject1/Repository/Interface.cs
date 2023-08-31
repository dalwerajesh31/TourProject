using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Repository
{
    public interface Interface
    {
        Task<ActionResult<Passanger_Master>> AddPassenger(Passanger_Master passanger_Master);
        List<Passanger_Master> GetPassengerMasters();
        Task<Passanger_Master> Delete(int id);

        Task<Passanger_Master> GetById(int id);
        int GetByCustId(int id);
        List<Passanger_Master> FindByCustId(int id);

        Task<ActionResult<IEnumerable<Passanger_Master>?>> GetPassanger();
        int FindSum(int id);
    }
}






