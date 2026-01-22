using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FPT.Aptech;

public class DemoDeploy
{
    private readonly ILogger<DemoDeploy> _logger;

    public DemoDeploy(ILogger<DemoDeploy> logger)
    {
        _logger = logger;
    }

    [Function("DemoDeploy")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}