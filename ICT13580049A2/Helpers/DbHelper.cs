using System;
using SQLite;
using ICT13580049A2.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICT13580049A2.Helpers

{
    public class DbHelper
	{
		SQLiteConnection db;
		public DbHelper(String dbPath)

		{
			db = new SQLiteConnection(dbPath);
			db.CreateTable<Product>();
		}

		public int AddProduct(Product product)
		{
            db.Insert(product);
            return product.id;
		}
        public List<Product> GetProducts()
        {
            return db.Table<Product>().ToList();
            
        }
        public int UpdateProduct(Product product)
        {
            return db.Update(product);
        }
        public int DeleteProduct(Product product)
        {
            return db.Delete(product);
        }
	}
}