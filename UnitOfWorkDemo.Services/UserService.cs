using Abstractions.Interfaces.Repositories;
using Abstractions.Interfaces.Services;
using Models.Entities;
using Models.InputDtos;

namespace Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;
        public IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public async Task<bool> Create(CreateUserDto dto)
        {
            if (dto != null)
            {

                User user = new User
                {
                    Email = dto.Email,
                    Password = dto.Password,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    CreateAt = DateTime.Now,
                };

                await _userRepository.Add(user);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        //public async Task<bool> DeleteProduct(int productId)
        //{
        //    if (productId > 0)
        //    {
        //        var productDetails = await _unitOfWork.Products.GetById(productId);
        //        if (productDetails != null)
        //        {
        //            _unitOfWork.Products.Delete(productDetails);
        //            var result = _unitOfWork.Save();

        //            if (result > 0)
        //                return true;
        //            else
        //                return false;
        //        }
        //    }
        //    return false;
        //}

        public async Task<IEnumerable<User>> GetAll()
        {
            var users = await _userRepository.GetAll();
            return users;
        }

        //public async Task<ProductDetails> GetProductById(int productId)
        //{
        //    if (productId > 0)
        //    {
        //        var productDetails = await _unitOfWork.Products.GetById(productId);
        //        if (productDetails != null)
        //        {
        //            return productDetails;
        //        }
        //    }
        //    return null;
        //}

        //public async Task<bool> UpdateProduct(ProductDetails productDetails)
        //{
        //    if (productDetails != null)
        //    {
        //        var product = await _unitOfWork.Products.GetById(productDetails.Id);
        //        if(product != null)
        //        {
        //            product.ProductName= productDetails.ProductName;
        //            product.ProductDescription= productDetails.ProductDescription;
        //            product.ProductPrice= productDetails.ProductPrice;
        //            product.ProductStock= productDetails.ProductStock;

        //            _unitOfWork.Products.Update(product);

        //            var result = _unitOfWork.Save();

        //            if (result > 0)
        //                return true;
        //            else
        //                return false;
        //        }
        //    }
        //    return false;
        //}
    }
}
