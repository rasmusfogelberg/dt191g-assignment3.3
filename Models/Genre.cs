using System.ComponentModel.DataAnnotations;

namespace DiscosaurusApi.Models;

public class Genre {
  public int Id { get; set; }

  [Required]
  public string Name { get; set; } = string.Empty;
}