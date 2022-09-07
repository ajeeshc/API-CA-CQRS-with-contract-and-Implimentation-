using Contracts.Models.Associations;

namespace Contracts.Repository
{
    public interface IAssociationRepository
    {
        AssociatiosEntity GetAssociationsDetails(int associationId);
        AssociatiosEntity AddAssociation(AssociatiosEntity association);
    }
}
