using Investment.Application.Repositories;
using Investment.Application.Repositories.Interfaces;
using Investment.Application.UnitOfWork.Interfaces;
using Investment.Data;
using Investment.Domain.Entities.Assets;
using Investment.Domain.Entities.Core;

namespace Investment.Application.UnitOfWork
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private ApplicationDbContext _context;

        private IGenericRepository<AppUser> _appUserRepository;
        private IGenericRepository<FamilyMember> _familyMemberRepository;
        private IGenericRepository<Organization> _organizationRepository;
        private IGenericRepository<Event> _eventRepository;

        private IGenericRepository<AgriCultureProperty> _agriculturePropertyRepository;
        private IGenericRepository<Bank> _bankRepository;
        private IGenericRepository<Cash> _cashRepository;
        private IGenericRepository<CommercialProperty> _commercialPropertyRepository;
        private IGenericRepository<FixedDeposit> _fixedDepositRepository;
        private IGenericRepository<Jewellery> _jewelleryRepository;
        private IGenericRepository<MutualFund> _mutualFundRepository;
        private IGenericRepository<NationalSavingCertificate> _nationalSavingCertificateRepository;
        private IGenericRepository<OtherProperty> _otherPropertyRepository;
        private IGenericRepository<PersonalProvidentFund> _personalProvidentFundRepository;
        private IGenericRepository<PostOfficeSaving> _postOfficeSavingRepository;
        private IGenericRepository<ProvidentFund> _providentFundRepository;
        private IGenericRepository<ResedentialProperty> _resendentialPropertyRepository;
        private IGenericRepository<Stock> _stockRepository;
        private IGenericRepository<Vehicle> _vehicleRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<AppUser> AppUserRepository
        {
            get
            {
                if (_appUserRepository == null)
                {
                    return new GenericRepository<AppUser>(_context);
                }

                return _appUserRepository;
            }
        }

        public IGenericRepository<FamilyMember> FamilyMemberRepository
        {
            get
            {
                if (_familyMemberRepository == null)
                {
                    return new GenericRepository<FamilyMember>(_context);
                }

                return _familyMemberRepository;
            }
        }

        public IGenericRepository<Event> EventRepository
        {
            get
            {
                if (_eventRepository == null)
                {
                    return new GenericRepository<Event>(_context);
                }

                return _eventRepository;
            }
        }

        public IGenericRepository<Organization> OrganizationRepository
        {
            get
            {
                if (_organizationRepository == null)
                {
                    return new GenericRepository<Organization>(_context);
                }

                return _organizationRepository;
            }
        }

        public IGenericRepository<AgriCultureProperty> AgriCulturePropertyRepository
        {
            get
            {
                if (_agriculturePropertyRepository == null)
                {
                    return new GenericRepository<AgriCultureProperty>(_context);
                }

                return _agriculturePropertyRepository;
            }
        }

        public IGenericRepository<Bank> BankRepository
        {
            get
            {
                if (_agriculturePropertyRepository == null)
                {
                    return new GenericRepository<Bank>(_context);
                }

                return _bankRepository;
            }
        }

        public IGenericRepository<Cash> CashRepository
        {
            get
            {
                if (_agriculturePropertyRepository == null)
                {
                    return new GenericRepository<Cash>(_context);
                }

                return _cashRepository;
            }
        }

        public IGenericRepository<CommercialProperty> CommercialPropertyRepository
        {
            get
            {
                if (_agriculturePropertyRepository == null)
                {
                    return new GenericRepository<CommercialProperty>(_context);
                }

                return _commercialPropertyRepository;
            }
        }

        public IGenericRepository<FixedDeposit> FixedDepositRepository
        {
            get
            {
                if (_fixedDepositRepository == null)
                {
                    return new GenericRepository<FixedDeposit>(_context);
                }

                return _fixedDepositRepository;
            }
        }

        public IGenericRepository<Jewellery> JewelleryRepository
        {
            get
            {
                if (_jewelleryRepository == null)
                {
                    return new GenericRepository<Jewellery>(_context);
                }

                return _jewelleryRepository;
            }
        }

        public IGenericRepository<MutualFund> MutualFundRepository
        {
            get
            {
                if (_mutualFundRepository == null)
                {
                    return new GenericRepository<MutualFund>(_context);
                }

                return _mutualFundRepository;
            }
        }

        public IGenericRepository<NationalSavingCertificate> NationalSavingCertificateRepository
        {
            get
            {
                if (_nationalSavingCertificateRepository == null)
                {
                    return new GenericRepository<NationalSavingCertificate>(_context);
                }

                return _nationalSavingCertificateRepository;
            }
        }

        public IGenericRepository<OtherProperty> OtherPropertyRepository
        {
            get
            {
                if (_otherPropertyRepository == null)
                {
                    return new GenericRepository<OtherProperty>(_context);
                }

                return _otherPropertyRepository;
            }
        }

        public IGenericRepository<PersonalProvidentFund> PersonalProvidentFundRepository
        {
            get
            {
                if (_personalProvidentFundRepository == null)
                {
                    return new GenericRepository<PersonalProvidentFund>(_context);
                }

                return _personalProvidentFundRepository;
            }
        }

        public IGenericRepository<PostOfficeSaving> PostOfficeSavingFundRepository
        {
            get
            {
                if (_postOfficeSavingRepository == null)
                {
                    return new GenericRepository<PostOfficeSaving>(_context);
                }

                return _postOfficeSavingRepository;
            }
        }

        public IGenericRepository<ProvidentFund> ProvidentFundRepository
        {
            get
            {
                if (_providentFundRepository == null)
                {
                    return new GenericRepository<ProvidentFund>(_context);
                }

                return _providentFundRepository;
            }
        }

        public IGenericRepository<ResedentialProperty> ResedentialPropertyRepository
        {
            get
            {
                if (_resendentialPropertyRepository == null)
                {
                    return new GenericRepository<ResedentialProperty>(_context);
                }

                return _resendentialPropertyRepository;
            }
        }

        public IGenericRepository<Stock> StockRepository
        {
            get
            {
                if (_stockRepository == null)
                {
                    return new GenericRepository<Stock>(_context);
                }

                return _stockRepository;
            }
        }

        public IGenericRepository<Vehicle> VehicleRepository
        {
            get
            {
                if (_vehicleRepository == null)
                {
                    return new GenericRepository<Vehicle>(_context);
                }

                return _vehicleRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
