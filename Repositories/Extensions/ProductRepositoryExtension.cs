using Entities.Models;


namespace Repositories.Extensions
{
    public static class ProductRepositoryExtension
    {
        public static IQueryable<Product> FilteredByCategoryId(this IQueryable<Product> products, int? categoryId)
        {
            if (categoryId is null)
                return products;
            else
            return products.Where(prd => prd.CategoryId.Equals(categoryId));
        }

        public static IQueryable<Product> FilteredBySearchTerm(this IQueryable<Product> products, String? SearchTerm)
        {
            if (string.IsNullOrWhiteSpace(SearchTerm))
                return products;
            else
                return products.Where(prd => prd.ProductName.ToLower().Contains(SearchTerm.ToLower()));
        }

        public static IQueryable<Product> FilteredByPrice(this IQueryable<Product> products, int minPrice, int maxPrice, bool isValidPrice)
        {
            if (isValidPrice)
                return products.Where(prd => prd.ProductPrice >= minPrice && prd.ProductPrice <= maxPrice);
            else
                return products;
        }

        public static IQueryable<Product> ToPaginage(this IQueryable<Product> products, int pageNumber, int pageSize)
        {
            return products
                .Skip((pageNumber-1)*pageSize)
                .Take(pageSize);
        }
    }
}