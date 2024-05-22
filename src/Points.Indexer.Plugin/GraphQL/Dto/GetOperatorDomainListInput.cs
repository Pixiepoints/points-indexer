using Volo.Abp.Application.Dtos;

namespace Points.Indexer.Plugin.GraphQL.Dto;

public class GetOperatorDomainListInput : PagedResultRequestDto
{
    public List<string> AddressList { get; set; }
    public string DappId { get; set; }  
}