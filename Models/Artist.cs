using System.ComponentModel.DataAnnotations;

namespace DiscosaurusApi.Models;

public class Artist {
  public int Id { get; set; }

  [Required]
  public string Name { get; set; } = string.Empty;
}