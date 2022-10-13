using Asp_Net_Core_6_Web_Api_Setup.Data;
using Dot6.API.Crud.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_Core_6_Web_Api_Setup.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        ApplicationDbContext _db;
        public CrudController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<CrudTable> GetApi()
        {

            var data = _db.CrudTables.ToList();
            //var data = new List<CrudTable>();
            return data;
        }
    }
}
