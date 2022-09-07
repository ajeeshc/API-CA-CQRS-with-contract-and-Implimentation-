

using Contracts.Commands;
using Contracts.Models.Associations;
using Contracts.Repository;

namespace Implimentation.Applications.Services.Associations.Commands
{
    public class AssociationCommandService : IAssociationCommandService
    {
        private readonly IAssociationRepository _associationRepository;
        public AssociationCommandService(IAssociationRepository associationRepository)
        {
            _associationRepository = associationRepository;
        }

        AssociationCommandResult IAssociationCommandService.AddAssociation(AssociationsRequest request)
        {
            var entity = new AssociatiosEntity
            {
                Id = request.Id,
                Name = request.Name
            };
            var entityResponse = _associationRepository.AddAssociation(entity);

            var result = new AssociationCommandResult
            {
                Id = entityResponse.Id,
                Name = entityResponse.Name
            };
            return result;
        }
    }
}
