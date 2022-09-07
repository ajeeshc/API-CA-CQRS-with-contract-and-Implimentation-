using API_SimpleStructure.Filters;
using Contracts.Commands;
using Contracts.Models.Associations;
using Contracts.Queries;
using Microsoft.AspNetCore.Mvc;

namespace API_SimpleStructure.Controllers
{
    [ApiController]
   
    public class AssociationController : ControllerBase
    {
        private readonly IAssociationCommandService _associationCommandService;
        private readonly IAssociationQueryService _associationQueryService;


        public AssociationController(IAssociationCommandService associationCommandService, IAssociationQueryService associationQueryService)
        {
            _associationCommandService = associationCommandService;
            _associationQueryService = associationQueryService;
        }


        [HttpGet("Association/{ID}")]
        public IActionResult GetAssociation(int Id)
        {
            var result = _associationQueryService.GetAssociationsDetails(Id);

            var response = new AssociationsResponse()
            {
                Id = result.Id
            };

            return Ok(response);
        }

        [HttpPost("Association")]
        [CustomFilter]
        public IActionResult AddAssociation(AssociationsRequest request)
        {
            var result = _associationCommandService.AddAssociation(request);
            var response = new AssociationsResponse()
            {
                Id = result.Id
            };
            return Ok(response);
        }
    }
}
