 
namespace Core.Application.Requests;
public class PageRequestWithUserId
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int UserId { get; set; }
}
