using WoaW.Models.Parties.Root;

namespace WoaW.Models.WorkEfforts.Assignments
{
    public class PartySkill
    {
        #region properties
        public float YearsEcpirience { get; set; }
        public float Raiting{ get; set; }

        public Party Party { get; set; }
        public SkillType SkillType { get; set; }
        #endregion
    }
}
