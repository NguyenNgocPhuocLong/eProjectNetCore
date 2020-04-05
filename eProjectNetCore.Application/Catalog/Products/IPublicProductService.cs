using eProjectNetCore.ViewModels.Catalog.Products;
using eProjectNetCore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eProjectNetCore.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest reuqest);
        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
