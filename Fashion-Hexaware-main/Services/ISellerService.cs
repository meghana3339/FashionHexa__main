using FashionHexa.Entities;
namespace FashionHexa.Services
{
    public interface ISellerService
    {
        List<Seller> GetAllSeller();  //Done
        Seller  GetSellerById(int sellerId); //Done
        void AddSeller(Seller seller); //Done
        void UpdaterSeller(Seller seller); //Done
        void Deleteseller(int sellerId); //Done

    }
}
