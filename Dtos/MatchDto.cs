using WorldCupResultsWithBlazorWASM.Dtos;

namespace WorldCupResultsWithBlazorWASM;

public class MatchDto
{
    public DateTime utcDate { get; set; }
    public string? status { get; set; }
    public string? stage { get; set; }
    public string? group { get; set; }
    public TeamDto? homeTeam { get; set; }
    public TeamDto? awayTeam { get; set; }
    public ScoreDto? score { get; set; }
}


//  "": "2022-11-23T10:00:00Z",
//             "": "FINISHED",
//             "matchday": 1,
//             "": "GROUP_STAGE",
//             "": "GROUP_F",
//             "lastUpdated": "2023-08-31T15:20:01Z",
//             "": {
//                 "id": 815,
//                 "name": "Morocco",
//                 "shortName": "Morocco",
//                 "tla": "MAR",
//                 "crest": "https://crests.football-data.org/morocco.svg"
//             },
//             "": {
//                 "id": 799,
//                 "name": "Croatia",
//                 "shortName": "Croatia",
//                 "tla": "CRO",
//                 "crest": "https://crests.football-data.org/799.svg"
//             },
//             "": {
//                 "winner": "DRAW",
//                 "duration": "REGULAR",
//                 "fullTime": {
//                     "home": 0,
//                     "away": 0
//                 },
//                 "halfTime": {
//                     "home": 0,
//                     "away": 0
//                 }
//             },