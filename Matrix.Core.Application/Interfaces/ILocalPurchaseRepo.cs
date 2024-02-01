using Matrix.Core.Application.DTOs;


namespace Matrix.Core.Application.Interfaces
{
    public interface ILocalPurchaseRepo
    {
        void GenerateLocalPurchase(LocalPurchaseRequest req);
        Task<List<GetLocalPurchase>> GetLocalPurchase();
        Task<bool> EditLocalPurchase(EditLocalPurchase req);
        Task<EditLocalPurchase> GetLocalPurchase(int RecID);

    }
}
