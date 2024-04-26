using CompanyManagement.Application.Exceptions;

namespace CompanyManagement.Application
{
    public class CompanyService : ICompanyService
    {
        private List<string> _companies = new List<string>() { "Tbc", "Bog", "Magti" };

        public List<string> GetCompanies()
        {
            return _companies;
        }

        public string GetCompanyByName(string name)
        {
            var result = _companies.SingleOrDefault(x => x.Equals(name));
            if (result == null)
            {
                throw new CompanyNotFoundException(String.Format("Company {0} was not found", name));
            }

            return result;
        }

        public bool Delete(string name)
        {
            bool companyExists = _companies.Remove(name);
            if (!companyExists)
            {
                throw new CompanyNotFoundException(String.Format("Company {0} was not found", name));
            }
            return companyExists;
        }
    }
}

