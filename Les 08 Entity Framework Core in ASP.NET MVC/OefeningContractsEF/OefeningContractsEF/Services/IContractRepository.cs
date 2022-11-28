using OefeningContractEF.Models;

namespace OefeningContractEF.Services;

public interface IContractRepository
{
    IEnumerable<Contract> GetAll();
    Contract Get(int id);
    void Add(Contract contract);
    void Delete(Contract contract);
    void Update(Contract contract);
}
