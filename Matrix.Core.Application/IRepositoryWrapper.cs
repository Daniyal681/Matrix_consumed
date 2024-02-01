using Matrix.Core.Application.Interfaces;

namespace Matrix.Core.Application
{
    public interface IRepositoryWrapper
    {
        public ILocalPurchaseRepo LocalPurchaseRepo { get; }
        public ISupplierRepo SupplierRepo { get; }
        public IWareHouseRepo WareHouseRepo { get; }
        public ILoginRepo LoginRepo { get; }
        public IBankRepo BankRepo { get; }
        public ICustomerRepo CustomerRepo { get; }
        public ITradeWarrantyRepo TradeWarrantyRepo { get;}
        public IModelRepo ModelRepo { get;}
        public IMenuListRepo MenuListRepo { get;}
        public IAreasRepo AreasRepo { get;}
        public IBrandRepo BrandRepo { get;}

    }
}