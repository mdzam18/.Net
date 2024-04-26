namespace CompanyManagement.Application
{
    public interface ICompanyService
    {
        public string GetCompanyByName(string name);
        public List<string> GetCompanies();
        public bool Delete(string id);
    }
}
