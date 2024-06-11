using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace App.Models;

[PrimaryKey(nameof(CharacterId),nameof(TitleId))]
public class CharacterTitle
{
    public DateTime AcquiredAt { get; set; }


    public int CharacterId { get; set; }
    public int TitleId { get; set; }


    [ForeignKey(nameof(CharacterId))]
    public Character Character { get; set; } = null!;


    [ForeignKey(nameof(TitleId))]
    public Title Title { get; set; } = null!;
}