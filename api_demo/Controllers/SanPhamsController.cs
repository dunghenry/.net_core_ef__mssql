using api_demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamsController : ControllerBase
    {


        private readonly DataContext _context;
        public SanPhamsController(DataContext context)
        {
            this._context = context;
        }


        // GET: api/<SanPhamsController>
        [HttpGet]
        public async Task<ActionResult <List<SanPham>>> Get()
        {
            return Ok(await _context.SanPham.ToListAsync());
        }

        // GET api/<SanPhamsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SanPham>> Get(int id)
        {
            var sp = await _context.SanPham.FindAsync(id);

            if(sp == null)
            {
                return BadRequest("SP not found");
            }

            return Ok(sp);
        }

        // POST api/<SanPhamsController>
        [HttpPost]
        public async Task<ActionResult<List<SanPham>>> AddSanPham(SanPham sp)
        {
            _context.SanPham.Add(sp);
            await _context.SaveChangesAsync();
            return Ok(await _context.SanPham.ToListAsync());
        }

        // PUT api/<SanPhamsController>/5
        [HttpPut]
        public async Task<ActionResult<List<SanPham>>> UpdateSanPham(SanPham request)
        {
            var sp = await _context.SanPham.FindAsync(request.Id);

            if (sp == null)
            {
                return BadRequest("SP not found");
            }
            sp.Ten = request.Ten;
            sp.Ma = request.Ma;
            sp.DonGia = request.DonGia;
            sp.MaDanhMuc = request.MaDanhMuc;
            await _context.SaveChangesAsync();
            return Ok(await _context.SanPham.ToListAsync());
        }

        // DELETE api/<SanPhamsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SanPham>>> DeleteSanPham(int id)
        {
            var sp = await _context.SanPham.FindAsync(id);

            if (sp == null)
            {
                return BadRequest("SP not found");
            }
            _context.SanPham.Remove(sp);
            await _context.SaveChangesAsync();
            return Ok(await _context.SanPham.ToListAsync());
        }
    }
}
