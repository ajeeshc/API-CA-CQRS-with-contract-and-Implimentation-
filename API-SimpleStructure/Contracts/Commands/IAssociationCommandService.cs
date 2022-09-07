

using Contracts.Models.Associations;

namespace Contracts.Commands
{
    public interface IAssociationCommandService
    {
        AssociationCommandResult AddAssociation(AssociationsRequest request);
    }
}
