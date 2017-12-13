using System;
using WoaW.Models.WorkEfforts.Assignments;

namespace WoaW.Models.WorkEfforts.Standards
{
    public sealed class WorkEffortSkillStandard
    {
        #region properties
        public uint EstimatedNumberofPeople { get; set; }
        public TimeSpan EstimatedDuration { get; set; }
        public float EstimatedCost { get; set; }

        public SkillType SkillType{ get; set; }
        #endregion
    }
}
