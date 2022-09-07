using Contracts.Models.Associations;
using Contracts.Repository;
using Implimentation.Applications.Common.Errors;

namespace Implimentation.Infrastructure.Associations
{
    public class AssociationRepository : IAssociationRepository
    {
        public static readonly List<AssociatiosEntity> associatiosEntities = new();

        AssociatiosEntity IAssociationRepository.AddAssociation(AssociatiosEntity association)
        {
            associatiosEntities.Add(association);
            return association;
        }

        AssociatiosEntity IAssociationRepository.GetAssociationsDetails(int associationId)
        {
            //throw new CustomErrorException();
            return associatiosEntities.SingleOrDefault(x => x.Id == associationId);
        }
    }
}
