using OnlineStore.Repository.Entity.MetaData;
using OnlineStore.Repository.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Repository.Entity
{
    public class UnitOfWork : IDisposable
    {
        private OnlineStoreEntities context = new OnlineStoreEntities();
        private GenericRepository<Category> categoryRepository;
        private GenericRepository<ProductTitle> productTitleRepository;
        private GenericRepository<Product> productRepository;

        public GenericRepository<Category> CategoryRepository
        {
            get
            {

                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new GenericRepository<Category>(context);
                }
                return categoryRepository;
            }
        }

        public GenericRepository<ProductTitle> ProductTitleRepository
        {
            get
            {

                if (this.productTitleRepository == null)
                {
                    this.productTitleRepository = new GenericRepository<ProductTitle>(context);
                }
                return productTitleRepository;
            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
