namespace SkyfallAPI.Models.DTO;

public record PaginationResponse<T> (int TotalItems, int TotalPages, int Page, int Size, List<T> Data) where T : class;

