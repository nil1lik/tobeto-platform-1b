using Core.Application.Responses;

namespace Application.Features.CatalogPaths.Commands.Update;

public class UpdatedCatalogPathResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int InstructorId { get; set; }
    public DateTime AddedDate { get; set; }
}