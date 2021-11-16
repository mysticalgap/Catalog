using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic.Core;
using System.Reflection;
using Repository.Extensions.Utility;

namespace Repository.Extensions
{
    public static class RepositoryAuthorExtensions
    {
        public static IQueryable<Author> Search(this IQueryable<Author> authors, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return authors;
            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return authors.Where(e => e.Surname.ToLower().Contains(lowerCaseTerm));
        }
        public static IQueryable<Author> Sort(this IQueryable<Author> authors, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return authors.OrderBy(e => e.Surname);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Author>(orderByQueryString);
            if (string.IsNullOrWhiteSpace(orderQuery))
                return authors.OrderBy(e => e.Surname);
            return authors.OrderBy(orderQuery);
}
    }
}
