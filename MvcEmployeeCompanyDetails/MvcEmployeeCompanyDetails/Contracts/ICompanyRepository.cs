using MvcEmployeeCompanyDetails.Entities;

namespace MvcEmployeeCompanyDetails.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
