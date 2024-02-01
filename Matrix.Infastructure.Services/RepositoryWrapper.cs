using Matrix.Core.Application;
using Matrix.Core.Application.Interfaces;
using Matrix.Infastructure.Persistence;
using Matrix.Infastructure.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MatrixContext _repoContext;
        private ILocalPurchaseRepo _localpurchaseRepo;
        private ISupplierRepo _supplierRepo;
        private IWareHouseRepo _wareHouseRepo;
        private ILoginRepo _loginRepo;
        private IBankRepo _bankRepo;
        private ICustomerRepo _customerRepo;
        private ITradeWarrantyRepo _tradeWarrantyRepo;
        private IModelRepo _modelRepo;
        private IMenuListRepo _menulistRepo;
        private IAreasRepo _areasRepo;
        private IBrandRepo _brandRepo;

        public RepositoryWrapper(MatrixContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public ILocalPurchaseRepo LocalPurchaseRepo
        {
            get
            {
                if (_localpurchaseRepo == null)
                {
                    _localpurchaseRepo = new LocalPurchaseRepo(_repoContext);
                }
                return _localpurchaseRepo;
            }
        } 
     
        public IModelRepo ModelRepo
        {
            get
            {
                if (_modelRepo == null)
                {
                    _modelRepo = new ModelRepo(_repoContext);
                }
                return _modelRepo;
            }
        }
        public ISupplierRepo SupplierRepo
        {
            get
            {
                if (_supplierRepo == null)
                {
                    _supplierRepo = new SupplierRepo(_repoContext);
                }
                return _supplierRepo;
            }
        }
        public IWareHouseRepo WareHouseRepo
        {
            get
            {
                if (_wareHouseRepo == null)
                {
                    _wareHouseRepo = new WareHouseRepo(_repoContext);
                }
                return _wareHouseRepo;
            }
        }

        public ILoginRepo LoginRepo
        {
            get
            {
                if (_loginRepo == null)
                {
                    _loginRepo = new LoginRepo(_repoContext);
                }

                return _loginRepo;
            }
        }

        public IBankRepo BankRepo
        {
            get
            {
                if (_bankRepo == null)
                {
                    _bankRepo = new BankRepo(_repoContext);
                }
                return _bankRepo;
            }
        }

        public ICustomerRepo CustomerRepo
        {
            get
            {
                if (_customerRepo == null)
                {
                    _customerRepo = new CustomerRepo(_repoContext);
                }
                return _customerRepo;
            }
        }

        public ITradeWarrantyRepo TradeWarrantyRepo
        {
            get
            {
                if (_tradeWarrantyRepo == null)
                {
                    _tradeWarrantyRepo = new TradeWarrantyRepo(_repoContext);
                }
                return _tradeWarrantyRepo;
            }
        }
        public IMenuListRepo MenuListRepo
        {
            get
            {
                if (_menulistRepo == null)
                {
                    _menulistRepo = new MenuListRepo(_repoContext);
                }
                return _menulistRepo;
            }
        } 
       public IAreasRepo AreasRepo
        {
            get
            {
                if (_areasRepo == null)
                {
                    _areasRepo = new AreasRepo(_repoContext);
                }
                return _areasRepo;
            }
        } 
        public IBrandRepo BrandRepo
        {
            get
            {
                if (_brandRepo == null)
                {
                    _brandRepo = new BrandRepo(_repoContext);
                }
                return _brandRepo;
            }
        }

    }
}
