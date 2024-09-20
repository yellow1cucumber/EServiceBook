using DAL;

using Domain.Core.Users;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.GraphQL.Queries
{
    [GQLQuery]
    [ExtendObjectType("Query")]
    public class UsersQuery 
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<User>> GetUsers([FromServices] Repository<User> users) 
            => await users.GetAllAsync().ToArrayAsync();
    }
}
