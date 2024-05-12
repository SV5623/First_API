using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.API.Data;
using Web.API.Models.Domain;
using Web.API.Models.DTO;

namespace Web.API.Controllers
{
    // https://localhost:1234/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly WebDbContext dbContext;

        public RegionsController(WebDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //GET ALL REGIONS
        //GET: https://localhoust:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regionsDomain = dbContext.Regions.ToList();

            var regionsDto = new List<RegionDto>();
            foreach (var regionDomain in regionsDomain)
            {
                regionsDto.Add(new RegionDto()
                {
                    Id = regionDomain.Id,
                    Code = regionDomain.Code,
                    Name = regionDomain.Name,
                    RegionImageUrl = regionDomain.RegionImageUrl,
                });
            }
            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{id:Guid}")] 
        public IActionResult GetById([FromRoute] Guid id)
        {
           //var region= dbContext.Regions.Find(id);

           var regionDomain = dbContext.Regions.FirstOrDefault(x => x.Id == id);
            if (regionDomain == null)
            {
                return NotFound();
            }
            var regionDto = new RegionDto
            {
                Id = regionDomain.Id,
                Code = regionDomain.Code,
                Name = regionDomain.Name,
                RegionImageUrl = regionDomain.RegionImageUrl
            };

            return Ok(regionDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            var regionDomainModel = new Region
            {
                Code = addRegionRequestDto.Code,
                Name = addRegionRequestDto.Name,
                RegionImageUrl = addRegionRequestDto.RegionImageUrl,
            };
            dbContext.Regions.Add(regionDomainModel);
            dbContext.SaveChanges();

            var regionDto = new RegionDto
            {
                Id = regionDomainModel.Id,
                Code = regionDomainModel.Code,
                Name = regionDomainModel.Name,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };
            return CreatedAtAction(nameof(GetById), new {id = regionDto.Id}, regionDto);
        }

        //DELETE REGION BY ID
        //DELETE: https://localhost:1234/api/regions/{id}
        [HttpDelete("{id:Guid}")]
        public IActionResult Delete(Guid id)
        {
            var region = dbContext.Regions.Find(id);
            if (region == null)
            {
                return NotFound();
            }

            dbContext.Regions.Remove(region);
            dbContext.SaveChanges();

            return NoContent();
        }
        //213
        //UPDATE REGION BY ID
        //PUT: https://localhost:1234/api/regions/{id}
        [HttpPut("{id:Guid}")]
        public IActionResult Update(Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            var region = dbContext.Regions.Find(id);
            if (region == null)
            {
                return NotFound();
            }

            region.Code = updateRegionRequestDto.Code;
            region.Name = updateRegionRequestDto.Name;
            region.RegionImageUrl = updateRegionRequestDto.RegionImageUrl;

            dbContext.SaveChanges();

            return NoContent();
        }
    }
}
