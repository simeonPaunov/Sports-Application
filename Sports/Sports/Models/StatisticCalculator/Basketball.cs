﻿using Sports.Interfaces;

namespace Sports.Models.StatisticCalculator
{
    public class Basketball : IStatisticCalculator
    {
        public void CalculateStatisticsTeam1(List<Result> team1Matches, List<Statistic> statisticsTeam1, Result result, double teamMatches, double teamMatchesWithWins, string sport)
        {
            if (sport == "Basketball")
            {
                foreach (var team1 in statisticsTeam1)
                {
                    if (team1.StatisticType.Name == "Matches Played")
                    {
                        if (team1Matches.Any())
                        {
                            team1.Value += 1;
                        }
                        else
                        {
                            team1.Value += 1;
                        }
                    }

                    if (team1.StatisticType.Name == "Wins")
                    {
                        if (result.Team1Result > result.Team2Result)
                        {
                            team1.Value += 1;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }

                    if (team1.StatisticType.Name == "Losses")
                    {
                        if (result.Team1Result < result.Team2Result)
                        {
                            team1.Value += 1;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }

                    if (team1.StatisticType.Name == "Total Basketball Points")
                    {
                        if (result.Team1Result != 0)
                        {
                            team1.Value += result.Team1Result;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }

                    if (team1.StatisticType.Name == "Win Percentage")
                    {
                        double team1Value = 0;

                        if (result.Team1Result > result.Team2Result)
                        {
                            teamMatchesWithWins += 1;
                        }

                        teamMatches += 1;

                        team1Value = (teamMatchesWithWins / teamMatches) * 100;

                        double team1ValueRounded = Math.Round(team1Value);

                        team1.Value = (int)team1ValueRounded;
                    }

                    if (team1.StatisticType.Name == "Points")
                    {
                        if (result.Team1Result > result.Team2Result)
                        {
                            team1.Value += 2;
                        }
                        else if (result.Team1Result == result.Team2Result)
                        {
                            team1.Value += 1;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }
                }
            }
        }

        public void DeleteStatisticsTeam1(List<Result> team1Matches, List<Statistic> statisticsTeam1, Result result, double teamMatches, double teamMatchesWithWins, string sport)
        {
            if (sport == "Basketball")
            {
                foreach (var team1 in statisticsTeam1)
                {
                    if (team1.StatisticType.Name == "Matches Played")
                    {
                        if (team1Matches.Any())
                        {
                            team1.Value -= 1;
                        }
                        else
                        {
                            team1.Value -= 1;
                        }
                    }

                    if (team1.StatisticType.Name == "Wins")
                    {
                        if (result.Team1Result > result.Team2Result)
                        {
                            team1.Value -= 1;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }

                    if (team1.StatisticType.Name == "Losses")
                    {
                        if (result.Team1Result < result.Team2Result)
                        {
                            team1.Value -= 1;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }

                    if (team1.StatisticType.Name == "Total Basketball Points")
                    {
                        if (result.Team1Result != 0)
                        {
                            team1.Value -= result.Team1Result;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }

                    if (team1.StatisticType.Name == "Win Percentage")
                    {
                        double team1Value = 0;

                        if (result.Team1Result > result.Team2Result)
                        {
                            teamMatchesWithWins -= 1;
                        }

                        teamMatches -= 1;

                        if (teamMatches > 0)
                        {
                            team1Value = (teamMatchesWithWins / teamMatches) * 100;
                        }
                        else
                        {
                            team1Value = 0;
                        }

                        double team1ValueRounded = Math.Round(team1Value);

                        team1.Value = (int)team1ValueRounded;
                    }

                    if (team1.StatisticType.Name == "Points")
                    {
                        if (result.Team1Result > result.Team2Result)
                        {
                            team1.Value -= 2;
                        }
                        else if (result.Team1Result == result.Team2Result)
                        {
                            team1.Value -= 1;
                        }
                        else
                        {
                            team1.Value += 0;
                        }
                    }
                }
            }
        }

        public void CalculateStatisticsTeam2(List<Result> team2Matches, List<Statistic> statisticsTeam2, Result result, double teamMatches, double teamMatchesWithWins, string sport)
        {
            if (sport == "Basketball")
            {
                foreach (var team2 in statisticsTeam2)
                {
                    if (team2.StatisticType.Name == "Matches Played")
                    {
                        if (team2Matches.Any())
                        {
                            team2.Value += 1;
                        }
                        else
                        {
                            team2.Value += 1;
                        }
                    }

                    if (team2.StatisticType.Name == "Wins")
                    {
                        if (result.Team2Result > result.Team1Result)
                        {
                            team2.Value += 1;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }

                    if (team2.StatisticType.Name == "Losses")
                    {
                        if (result.Team2Result < result.Team1Result)
                        {
                            team2.Value += 1;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }

                    if (team2.StatisticType.Name == "Total Basketball Points")
                    {
                        if (result.Team2Result != 0)
                        {
                            team2.Value += result.Team2Result;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }

                    if (team2.StatisticType.Name == "Win Percentage")
                    {
                        double team1Value = 0;

                        if (result.Team2Result > result.Team1Result)
                        {
                            teamMatchesWithWins += 1;
                        }

                        teamMatches += 1;

                        team1Value = (teamMatchesWithWins / teamMatches) * 100;

                        double team1ValueRounded = Math.Round(team1Value);

                        team2.Value = (int)team1ValueRounded;
                    }

                    if (team2.StatisticType.Name == "Points")
                    {
                        if (result.Team2Result > result.Team1Result)
                        {
                            team2.Value += 2;
                        }
                        else if (result.Team2Result == result.Team1Result)
                        {
                            team2.Value += 1;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }
                }
            }
        }

        public void DeleteStatisticsTeam2(List<Result> team2Matches, List<Statistic> statisticsTeam2, Result result, double teamMatches, double teamMatchesWithWins, string sport)
        {
            if (sport == "Basketball")
            {
                foreach (var team2 in statisticsTeam2)
                {
                    if (team2.StatisticType.Name == "Matches Played")
                    {
                        if (team2Matches.Any())
                        {
                            team2.Value -= 1;
                        }
                        else
                        {
                            team2.Value -= 1;
                        }
                    }

                    if (team2.StatisticType.Name == "Wins")
                    {
                        if (result.Team2Result > result.Team1Result)
                        {
                            team2.Value -= 1;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }

                    if (team2.StatisticType.Name == "Losses")
                    {
                        if (result.Team2Result < result.Team1Result)
                        {
                            team2.Value -= 1;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }

                    if (team2.StatisticType.Name == "Total Basketball Points")
                    {
                        if (result.Team2Result != 0)
                        {
                            team2.Value -= result.Team2Result;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }

                    if (team2.StatisticType.Name == "Win Percentage")
                    {
                        double team1Value = 0;

                        if (result.Team2Result > result.Team1Result)
                        {
                            teamMatchesWithWins -= 1;
                        }

                        teamMatches -= 1;

                        if (teamMatches > 0)
                        {
                            team1Value = (teamMatchesWithWins / teamMatches) * 100;
                        }
                        else
                        {
                            team1Value = 0;
                        }

                        double team1ValueRounded = Math.Round(team1Value);

                        team2.Value = (int)team1ValueRounded;
                    }

                    if (team2.StatisticType.Name == "Points")
                    {
                        if (result.Team2Result > result.Team1Result)
                        {
                            team2.Value -= 2;
                        }
                        else if (result.Team2Result == result.Team1Result)
                        {
                            team2.Value -= 1;
                        }
                        else
                        {
                            team2.Value += 0;
                        }
                    }
                }
            }
        }
    }
}