/*
 * catalogue-api
 *
 * NHS Digital GP IT Futures Buying Catalog API
 *
 * OpenAPI spec version: 1.0.0-private-beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Gif.Service.Attributes;
using Gif.Service.Contracts;
using Gif.Service.Crm;
using Gif.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.ComponentModel.DataAnnotations;
using ZNetCS.AspNetCore.Authentication.Basic;

namespace Gif.Service.Controllers
{
  /// <summary>
  /// 
  /// </summary>
  [Authorize(AuthenticationSchemes = BasicAuthenticationDefaults.AuthenticationScheme + ",Bearer")]
  public class OrganisationsApiController : Controller
  {
    /// <summary>
    /// Retrieve an Organisation for the given Contact
    /// </summary>

    private readonly IOrganisationsDatastore _datastore;

    public OrganisationsApiController(IOrganisationsDatastore datastore)
    {
      _datastore = datastore;
    }

    /// <param name="contactId">CRM identifier of Contact</param>
    /// <response code="200">Success</response>
    /// <response code="404">Organisation not found</response>
    [HttpGet]
    [Route("/api/Organisations/ByContact/{contactId}")]
    [ValidateModelState]
    [SwaggerOperation("ApiOrganisationsByContactByContactIdGet")]
    [SwaggerResponse(statusCode: 200, type: typeof(Organisation), description: "Success")]
    public virtual IActionResult ApiOrganisationsByContactByContactIdGet([FromRoute][Required]string contactId)
    {
      try
      {
        var organisation = _datastore.ByContact(contactId);

        if (organisation == null || organisation?.Id == Guid.Empty)
          return StatusCode(404);

        return new ObjectResult(organisation);
      }
      catch (CrmApiException ex)
      {
        return StatusCode((int)ex.HttpStatus, ex.Message);
      }
    }

    /// <summary>
    /// Retrieve an Organisation for the given Id
    /// </summary>

    /// <param name="organisationId">CRM identifier of Organisation</param>
    /// <response code="200">Success</response>
    /// <response code="404">Organisation not found</response>
    [HttpGet]
    [Route("/api/Organisations/ById/{organisationId}")]
    [ValidateModelState]
    [SwaggerOperation("ApiOrganisationsByOrganisationIdGet")]
    [SwaggerResponse(statusCode: 200, type: typeof(Organisation), description: "Success")]
    public virtual IActionResult ApiOrganisationsByOrganisationIdGet([FromRoute][Required]string organisationId)
    {
      try
      {
        var organisation = _datastore.ById(organisationId);

        if (organisation == null || organisation?.Id == Guid.Empty)
          return StatusCode(404);

        return new ObjectResult(organisation);
      }
      catch (CrmApiException ex)
      {
        return StatusCode((int)ex.HttpStatus, ex.Message);
      }
    }
  }
}
