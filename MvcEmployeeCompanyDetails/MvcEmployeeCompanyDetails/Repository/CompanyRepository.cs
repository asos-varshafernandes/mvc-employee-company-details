using Dapper;
using MvcEmployeeCompanyDetails.Context;
using MvcEmployeeCompanyDetails.Contracts;
using MvcEmployeeCompanyDetails.Entities;

namespace MvcEmployeeCompanyDetails.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;

        public CompanyRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "SELECT * FROM Companies";

            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var companies = await connection.QueryAsync<Company>(query);
                    return companies.ToList();
                }
                catch (Exception ex)
                {
                    var queryException = ex;
                }
                return new List<Company>();

            }
        }
    }
}
