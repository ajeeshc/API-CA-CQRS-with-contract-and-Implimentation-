

using Contracts.Models.Associations;

namespace Contracts.Queries
{
    public interface IAssociationQueryService
    {
        AssociationQueryResult GetAssociationsDetails(int associationId);
    }
}
