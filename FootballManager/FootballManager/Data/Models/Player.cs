namespace FootballManager.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;
    public class Player
    {
        [Key]
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(FullNameMaxLength)]
        public string FullName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string Position { get; set; }

        [Required]
        [MaxLength(SpeedandEnduranceMaxValue)]
        public byte Speed { get; set; }

        [Required]
        [MaxLength(SpeedandEnduranceMaxValue)]
        public byte Endurance { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public IEnumerable<UserPlayer> UserPlayers { get; set; } = new List<UserPlayer>();
    }
}
