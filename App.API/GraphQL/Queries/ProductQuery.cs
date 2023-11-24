using App.Domain.Entities;
using App.Repository.Contexts;

namespace App.API.GraphQL.Queries;

public class ProductQuery
{
    public IQueryable<Product> GetProducts(AppReadDbContext dbContext)
    {
        return dbContext.products;
    }

    public Product? GetProductById(AppReadDbContext dbContext, int id)
    {
        var product = dbContext.Find<Product>(id);

        if (product == null) return null;

        //Load Details if has

        return product;
    }
}
