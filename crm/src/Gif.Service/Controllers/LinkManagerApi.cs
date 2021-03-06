/*
 * catalogue-api
 *
 * NHS Digital GP IT Futures Buying Catalog API
 *
 * OpenAPI spec version: 1.0.0-private-beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Gif.Service.Attributes;
using Gif.Service.Contracts;
using Gif.Service.Crm;
using Gif.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Gif.Service.Controllers
{
  /// <summary>
  /// 
  /// </summary>
  public class LinkManagerApiController : Controller
  {
    /// <summary>
    /// Create a link between a Framework and a Solution
    /// </summary>

    private readonly ILinkManagerDatastore _datastore;

    public LinkManagerApiController(ILinkManagerDatastore datastore)
    {
      _datastore = datastore;
    }

  /// <param name="frameworkId">CRM identifier of Framework</param>
  /// <param name="solutionId">CRM identifier of Solution</param>
  /// <response code="200">Success</response>
  /// <response code="404">One entity not found</response>
  /// <response code="412">Link already exists</response>
  [HttpPost]
    [Route("/api/LinkManager/FrameworkSolution/Create/{frameworkId}/{solutionId}")]
    [ValidateModelState]
    [SwaggerOperation("ApiLinkManagerFrameworkSolutionCreateByFrameworkIdBySolutionIdPost")]
    public virtual IActionResult ApiLinkManagerFrameworkSolutionCreateByFrameworkIdBySolutionIdPost([FromRoute][Required]string frameworkId, [FromRoute][Required]string solutionId)
    {
      try
      {
        Guid frameworkIdParsed, solutionIdParsed;
        Guid.TryParse(frameworkId, out frameworkIdParsed);
        Guid.TryParse(solutionId, out solutionIdParsed);

        if (solutionIdParsed == Guid.Empty || frameworkIdParsed == Guid.Empty)
          throw new CrmApiException("Cannot parse strings into Guids", HttpStatusCode.BadRequest);

        _datastore.FrameworkSolutionAssociate(frameworkIdParsed, solutionIdParsed);
      }
      catch (Crm.CrmApiException ex)
      {
        return StatusCode((int)ex.HttpStatus, ex.Message);
      }

      return new ObjectResult(200);
    }
  }
}
