using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Instrumentation;
using GraphQL.Types;
using GraphQL.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Controllers;

namespace NIT.HopZone.Web.Controllers
{

    [Route("graphql")]
    public class GraphQLController : Controller
    {
        private readonly IDocumentExecuter _documentExecuter;
        private readonly ISchema _schema;
        private readonly IValidationRule _validationRule;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GraphQLController(
            ISchema schema,
            IDocumentExecuter executer,
            IValidationRule validationRule,
            IHttpContextAccessor httpContextAccessor)
        {
            _schema = schema;
            _documentExecuter = executer;
            _validationRule = validationRule;
            _httpContextAccessor = httpContextAccessor;

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {


            //if (query == null) { throw new ArgumentNullException(nameof(query)); }

            var inputs = query.Variables?.ToInputs();

            var executionOptions = new ExecutionOptions
            {
                Schema = _schema,
                Query = query.Query,
                ValidationRules = new List<IValidationRule> { _validationRule },
                UserContext = _httpContextAccessor.HttpContext.User,
                Inputs = inputs,
                ComplexityConfiguration = new GraphQL.Validation.Complexity.ComplexityConfiguration { MaxDepth = 15 }
        };

            try
            {

                var result = await _documentExecuter
                    .ExecuteAsync(executionOptions)
                    .ConfigureAwait(false);

                if (result.Errors?.Count > 0)
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
