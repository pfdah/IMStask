using Ims_task.DBContext;
using Ims_task.Model;
//using Ims_task.Model;

namespace Ims_task.TariffDB
{
    public class TariffService : ITariffService
    {
        private readonly TariffContext _tariffContext;
        public TariffService(TariffContext tariffContext)
        {
            _tariffContext = tariffContext;
        }
        public void AddTariff(int id, int startUnit, int endUnit, decimal energyRate, decimal serviceCharge)
        {
            TariffMaster tariff = new TariffMaster()
            {
                tariffId = id,
                penaltyDays = 0,
                penaltyRate = 0,
                rebateDays = 0,
                rebateRate = 0
            };
            TariffDetails details = new TariffDetails()
            {
                tariffId = id,
                startUnit = startUnit,
                endUnit = endUnit,
                energyRate = energyRate,
                serviceCharge = serviceCharge
            };
            _tariffContext.TariffMaster.Add(tariff);
            _tariffContext.SaveChanges();
            _tariffContext.TariffDetails.Add(details);
            _tariffContext.SaveChanges();
        }
        public void UpdateTariff(int id, int startUnit, int endUnit, decimal energyRate, decimal serviceCharge)
        {
            var tariffDetails = _tariffContext.TariffDetails.FirstOrDefault(x => x.tariffId == id);
            TariffDetails details = tariffDetails;

            details.startUnit = startUnit;
            details.endUnit = endUnit;
            details.energyRate = energyRate;
            details.serviceCharge = serviceCharge;

            _tariffContext.TariffDetails.Update(details);
            _tariffContext.SaveChanges();
        }

        public TariffMaster getTariff(int id)
        {
            var tariff = _tariffContext.TariffMaster.FirstOrDefault(x => x.tariffId == id);
            if(tariff == null)
            {
                return null;
            }
            return tariff;
        }
    }
}
