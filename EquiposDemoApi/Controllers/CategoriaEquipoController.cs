using EquiposDemoApi.Data;
using EquiposDemoApi.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EquiposDemoApi.Controllers;

// https://localhost:7192/api/CategoriaEquipo
[Route("api/[controller]")]
[ApiController]
public class CategoriaEquipoController : ControllerBase
{
    private readonly EquiposDbContext _context;

    // Inyeccion de Dependencia. Traer servicios mediante el constructor.
    public CategoriaEquipoController(EquiposDbContext context)
    {
        _context = context;
    }

    [HttpGet] // Leyendo datos de la Db
    public async Task<List<CategoriaEquipo>> ObtenerListadoCategoriaEquipos()
    {
        return await _context.CategoriasEquipos.ToListAsync();
    }

    [HttpPost] // Crear una nueva categoria en la Db
    public async Task<ActionResult> CrearCategoriaEquipo(CategoriaEquipo categoria)
    {
        // Estamos agregando una nueva categoria.
        _context.CategoriasEquipos.Add(categoria);
        // Salva los cambios a la Db
        var result = await _context.SaveChangesAsync();

        if (result <= 0)
        {
            // Si hubo un error retornamos en 400 BadRequest
            return BadRequest();
        }
        else
        {
            // Si todo salio bien retornamos un 200 OK
            return Ok();
        }
    }
}
