using AutoMapper;
using MongoORM4NetCore;
using MongoORM4NetCore.Interfaces;
using ohmnba.apiModels.ScoreBoard;
using oohmnba.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ohmnba
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Game, GameViewModel>().AfterMap(MapApiToViewModel);
        }

        private void MapApiToViewModel(Game game, GameViewModel gameViewModel)
        {
            var teamCrud = new Crud<entities.Team>();
            var all = teamCrud.GetAll().ToList();
            var homeTeam = all.FirstOrDefault(x => x.TeamId == game.HTeam.TeamId);
            var awayTeam = all.FirstOrDefault(x => x.TeamId == game.VTeam.TeamId);
            gameViewModel.AwayTeamName = awayTeam.FullName;
            gameViewModel.AwayTeamTriCode = awayTeam.Tricode;

            gameViewModel.HomeTeamName = homeTeam.FullName;
            gameViewModel.HomeTeamTriCode = homeTeam.Tricode;

            gameViewModel.AwayTeamScore = game.VTeam.Score;
            gameViewModel.HomeTeamScore = game.HTeam.Score;

            gameViewModel.PeriodScores = PreparePeriodScores(game.HTeam.Linescore, game.VTeam.Linescore).ToList();

            TimeZone curTimeZone = TimeZone.CurrentTimeZone;
            DateTimeOffset t = TimeZoneInfo.ConvertTime(game.StartTimeUtc, TimeZoneInfo.Local);
            gameViewModel.StartDate = DateTime.Parse(t.ToString());
        
        }

        private IEnumerable<PeriodScore> PreparePeriodScores(Linescore[] homeLineScore, Linescore[] visitorLineScore)
        {
            for (int i = 0; i < homeLineScore.Length; i++)
            {
                yield return new PeriodScore
                {
                    HomeTeamScore = homeLineScore[i].Score,
                    AwayTeamScore = visitorLineScore[i].Score
                };
            }
        }
    }
}
