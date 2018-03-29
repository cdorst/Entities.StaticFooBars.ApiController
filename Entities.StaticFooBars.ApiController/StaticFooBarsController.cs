// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using DevOps.Code.DataAccess.Interfaces.Repository;
using Entities.StaticFooBars.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Entities.StaticFooBars.ApiController
{
    /// <summary>ASP.NET Core web API controller for StaticFooBar entities</summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StaticFooBarsController : ControllerBase
    {
        /// <summary>Represents the application events logger</summary>
        private readonly ILogger<StaticFooBarsController> _logger;

        /// <summary>Represents repository of StaticFooBar entity data</summary>
        private readonly IRepository<StaticFooBarDbContext, StaticFooBar, int> _repository;

        /// <summary>Constructs an API controller for StaticFooBar entities using the given repository service</summary>
        public StaticFooBarsController(ILogger<StaticFooBarsController> logger, IRepository<StaticFooBarDbContext, StaticFooBar, int> repository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>Handles HTTP GET requests to access StaticFooBar resources at the given ID</summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<StaticFooBar>> Get(int id)
        {
            if (id < 1) return NotFound();
            var resource = await _repository.FindAsync(id);
            if (resource == null) return NotFound();
            return resource;
        }

        /// <summary>Handles HTTP HEAD requests to access StaticFooBar resources at the given ID</summary>
        [HttpHead("{id}")]
        public ActionResult<StaticFooBar> Head(int id) => null;

        /// <summary>Handles HTTP POST requests to save StaticFooBar resources</summary>
        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<ActionResult<StaticFooBar>> Post(StaticFooBar resource)
        {
            var saved = await _repository.AddAsync(resource);
            return CreatedAtAction(nameof(Get), new { id = saved.GetKey() }, saved);
        }
    }
}
