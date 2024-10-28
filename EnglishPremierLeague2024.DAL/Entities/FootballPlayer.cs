using System;
using System.Collections.Generic;

namespace EnglishPremierLeague2024.DAL.Entities;

public partial class FootballPlayer
{
    public string FootballPlayerId { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Achievements { get; set; } = null!;

    public DateTime? Birthday { get; set; }

    public string PlayerExperiences { get; set; } = null!;

    public string Nomination { get; set; } = null!;

    public string? FootballClubId { get; set; }

    public virtual FootballClub? FootballClub { get; set; }

    public override string ToString()
    {
        return $"FootballPlayerId: {FootballPlayerId}, FullName: {FullName}, Achievements: {Achievements}, Birthday: {Birthday}, PlayerExperiences: {PlayerExperiences}, Nomination: {Nomination}, FootballClubId: {FootballClubId}";
    }
}
