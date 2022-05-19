using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCentral.Shared.Constants;

public enum Genre
{
    [Display(Name = "Show All")]
    None = 0,

    Action = 1,
    Adventure = 2,
    Animation = 3,
    Comedy = 4,
    Crime = 5,
    Documentary = 6,
    Drama = 7,
    Family = 8,
    Fantasy = 9,
    History = 10,
    Horror = 11,
    Music = 12,
    Mystery = 13,
    Romance = 14,

    [Display(Name = "Science Fiction")]
    SciFi = 15,

    Thriller = 16,

    [Display(Name = "TV Movie")]
    TvMovie = 17,
    War = 18,
    Western = 19
}
