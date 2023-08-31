using ETourProject1.Models;

namespace ETourProject1.Repository
{
    public class Passanger_MasterRepository
    {
        void AddPassenger(PassengerMaster packageMaster);
        List<PassengerMaster> GetPassengerMasters();
        void Delete(int departureId);
     s
        PassengerMaster GetById(int id);
        int GetByCustId(int id);
        List<PassengerMaster> FindByCustId(int id);
        int FindSum(int id);



    }
}

