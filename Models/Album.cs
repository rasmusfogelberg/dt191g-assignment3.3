using System.ComponentModel.DataAnnotations;

namespace DiscosaurusApi.Models;

public class Album {
  public int Id { get; set; }
  
  [Required]
  public int ArtistId {get; set; }
  
  [Required]
  public int GenreId {get; set; }

  [Required]
  public string Title { get; set; }

  [Required]
  public int Duration { get; set; }
}