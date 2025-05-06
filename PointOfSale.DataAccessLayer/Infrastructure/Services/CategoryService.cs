using PointOfSale.DataAccessLayer.Infrastructure.Contracts;
using PointOfSale.Domain.Entities;

namespace PointOfSale.DataAccessLayer.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ECommerceDbContext db;
        public CategoryService(ECommerceDbContext context)
        {
            db = context;
        }
        public bool Delete(int Id)
        {
            var cat = db.Categories.Where(cat => cat.Id == Id).FirstOrDefault();
            db.Categories.Remove(cat!);
            db.SaveChanges();
            return true;
        }

        public List<Category> GetAll()
        {
            var category = db.Categories.ToList();
            return category;
        }

        public Category GetById(int Id)
        {
            var category = db.Categories.Where(cust => cust.Id == Id).FirstOrDefault();
            return category!;
        }

        public Category Insert(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return category;
        }

        public Category Update(Category category)
        {
            var categoryToUpdate = GetById(category.Id);
            categoryToUpdate.CategoryName = category.CategoryName;
            categoryToUpdate.Description = category.Description;
            categoryToUpdate.image = category.image;
            db.Categories.Update(categoryToUpdate);
            db.SaveChanges();
            return categoryToUpdate;
        }
    }
}
