using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RehberWebApi.Models.Context;
using RehberWebApi.Models.Dtos;
using RehberWebApi.Models.Entities;

namespace RehberWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RehbersController : ControllerBase
    {
        private readonly RehberDbContext _context; // instance olusturalım kullanabilmek için 
        private readonly IMapper _mapper;

        public RehbersController(RehberDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(RehberDto rehberDto)
        {
            Rehber rehber = _mapper.Map<Rehber>(rehberDto);

            await _context.Rehbers.AddAsync(rehber);
            await _context.SaveChangesAsync();

            return Ok("Kayıt İşlemi başarılı.");

        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Put (int id,RehberDto rehberDto)
        {
            Rehber? rehber = await _context.Rehbers.FindAsync(id);
            if (rehber == null)
            { 
                return NotFound("Rehber bulunamadı.");
            }
            rehber.Firma = rehberDto.Firma;
            rehber.Ad = rehberDto.Ad;
            rehber.Soyad = rehberDto.Soyad;
            await _context.SaveChangesAsync();
            return Ok("Güncellme İşlemi Başarılı");

        }
        [HttpDelete("{id}")]
         public async Task<IActionResult> Delete (int id)
        {
            Rehber? rehber = await _context.Rehbers.FindAsync (id);
            if (rehber == null)
            {
                return NotFound("Rehber bulunamadı.");
            }
            _context.Rehbers.Remove(rehber);
            await _context.SaveChangesAsync();

            return Ok("Silme işlemi başarılı");
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Rehber> rehbers = await _context.Rehbers.Include(p=> p.İletisimBilgileri).ToListAsync();
            return Ok(rehbers);
        }

    }

}
