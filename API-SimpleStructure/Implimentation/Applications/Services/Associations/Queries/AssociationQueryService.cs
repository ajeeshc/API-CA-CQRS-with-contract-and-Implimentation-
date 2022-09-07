

using Contracts.Models.Associations;
using Contracts.Queries;
using Contracts.Repository;

namespace Implimentation.Applications.Services.Associations.Queries
{
    public class AssociationQueryService : IAssociationQueryService
    {
        private readonly IAssociationRepository _associationRepository;
        public AssociationQueryService(IAssociationRepository associationRepository)
        {
            _associationRepository = associationRepository;
        }
        AssociationQueryResult IAssociationQueryService.GetAssociationsDetails(int associationId)
        {
            var entity = _associationRepository.GetAssociationsDetails(associationId);
            var result = new AssociationQueryResult()
            {
                Id = entity.Id,
                Name = entity.Name
            };
            return result;
        }
    }
}
