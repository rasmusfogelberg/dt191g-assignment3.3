namespace DiscosaurusApi.Controllers
{
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.EntityFrameworkCore;
  using DiscosaurusApi.Models;
  using DiscoSaurusApi.Data;

  [Route("api/albums")]
  [ApiController]
  public class AlbumsController : ControllerBase
  {
    private readonly DiscoSaurusApiDbContext _context;

    public AlbumsController(DiscoSaurusApiDbContext context)
    {
      this._context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Album>>> GetAlbums()
    {
      return await _context.Albums.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Album>> GetAlbum(int id)
    {
      var album = await _context.Albums.FindAsync(id);

      if (album == null)
      {
        return NotFound();
      }

      return album;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutAlbum(int id, Album album)
    {
      if (album is null)
      {
        throw new ArgumentNullException(nameof(album));
      }

      if (!ModelState.IsValid)
      {
        return BadRequest("Invalid object sent to method");
      }

      if (id != album.Id)
      {
        Console.WriteLine($"This is it where it goes to hell {album.Id} {id}");
        return BadRequest("Album ID mismatch");
      }

      _context.Entry(album).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AlbumExists(id))
        {
          return NotFound();
        }
      }
      return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Album>> PostAlbum(Album album)
    {
      _context.Albums.Add(album);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetAlbum", new { id = album.Id }, album);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAlbum(int id)
    {
      var album = await _context.Albums.FindAsync(id);

      if (album == null)
      {
        return NotFound();
      }

      _context.Albums.Remove(album);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool AlbumExists(int id)
    {
      return _context.Albums.Any(album => album.Id == id);
    }
  }
}