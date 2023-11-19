using Lab4.Models;
namespace Lab4.Helpers.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<Student> GetActiveUsers(this IQueryable<Student> query)
        {
            return query.Where(x => !x.IsDeleted);
        }
    }
}
