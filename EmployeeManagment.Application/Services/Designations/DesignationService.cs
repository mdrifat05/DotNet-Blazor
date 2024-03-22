using EmployeeManagment.Application.Abstraction;
using EmployeeManagment.Application.Services.Base;
using EmployeeManagment.Domain.Abstraction;
using EmployeeManagment.Domain.Entities.Designations;

namespace EmployeeManagment.Application.Services.Designations;

public class DesignationService: BaseService<Designation>, IDesignationService
{
    readonly IDesignationRepository _designationRepository;
    public DesignationService(IDesignationRepository designationRepository): base(designationRepository)
    {
        _designationRepository = designationRepository;
    }
    public async Task<Designation> GetById(Guid id, CancellationToken cancellationToken = default)
    {
      return await _designationRepository.GetById(id, cancellationToken);
    }
}
