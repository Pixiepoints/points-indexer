using Points.Contracts.Point;
using Volo.Abp.Application.Dtos;

namespace Points.Indexer.Plugin.GraphQL;

public class GetPointsSumBySymbolDto : PagedResultRequestDto
{
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string DappName { get; set; }
    public List<string> AddressList { get; set; }
    public bool? HiddenMainDomain { get; set; }
    public IncomeSourceType? Role { get; set; }
}