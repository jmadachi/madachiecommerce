using madachiecommerce.ApplicationBusinessRules.Dtos;
using madachiecommerce.ApplicationBusinessRules.Interfaces;
using madachiecommerce.EnterpriseBusinessRules.Entities;
using madachiecommerce.EnterpriseBusinessRules.Interfaces;

namespace madachiecommerce.InterfaceAdapters.Gateways.Repositories
{
    public class ListProductsRepository: IListProductsRepository
    {
        readonly madachiecommerceContext Context;

        public ListProductsRepository(madachiecommerceContext context)
        {
            Context = context;
        }   

        public ValueTask<IEnumerable<ProductDto>> ListProducts()
        {
            var list = Context.Products
                .Select(product => new ProductDto
                {
                    Id = product.Id,
                    Code = product.Code,
                    Name = product.Name,
                    Price = product.Price
                });

            return ValueTask.FromResult(list.AsEnumerable());
        }

    }
}
