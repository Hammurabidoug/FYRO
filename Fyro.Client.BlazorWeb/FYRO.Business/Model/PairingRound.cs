using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYRO.Business.Model
{
    public class PairingRound
    {
        public List<HoleScore> Scores { get; }

        public IEnumerable<HoleScore> CompletedScores => this.Scores.Where(x => x.Score > 0);

        public int Score => this.CompletedScores.Sum(x => x.Score);

        public int ParScore => this.CompletedScores.Sum(x => x.Score - x.Hole.Par);

        public int HolesPlayedCount => this.CompletedScores.Count();

        public bool IsRoundComplete => this.HolesPlayedCount == Scores.Count;
    }
}
