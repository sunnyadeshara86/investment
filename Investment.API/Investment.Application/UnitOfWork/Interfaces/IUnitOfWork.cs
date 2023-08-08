using Investment.Application.Repositories.Interfaces;
using Investment.Domain.Entities.Assets;
using Investment.Domain.Entities.Core;

namespace Investment.Application.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<AgriCultureProperty> AgriCulturePropertyRepository { get; }
        IGenericRepository<AppUser> AppUserRepository { get; }
        IGenericRepository<Bank> BankRepository { get; }
        IGenericRepository<Cash> CashRepository { get; }
        IGenericRepository<CommercialProperty> CommercialPropertyRepository { get; }
        IGenericRepository<Event> EventRepository { get; }
        IGenericRepository<FamilyMember> FamilyMemberRepository { get; }
        IGenericRepository<FixedDeposit> FixedDepositRepository { get; }
        IGenericRepository<Jewellery> JewelleryRepository { get; }
        IGenericRepository<MutualFund> MutualFundRepository { get; }
        IGenericRepository<NationalSavingCertificate> NationalSavingCertificateRepository { get; }
        IGenericRepository<Organization> OrganizationRepository { get; }
        IGenericRepository<OtherProperty> OtherPropertyRepository { get; }
        IGenericRepository<PersonalProvidentFund> PersonalProvidentFundRepository { get; }
        IGenericRepository<PostOfficeSaving> PostOfficeSavingFundRepository { get; }
        IGenericRepository<ProvidentFund> ProvidentFundRepository { get; }
        IGenericRepository<ResedentialProperty> ResedentialPropertyRepository { get; }
        IGenericRepository<Stock> StockRepository { get; }
        IGenericRepository<Vehicle> VehicleRepository { get; }

        void Dispose();
        void Save();
    }
}