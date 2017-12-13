using System.Collections.Generic;
using WoaW.Models.WorkEfforts.WorkRequirements;

namespace WoaW.Models.WorkEfforts.Generation
{
    public sealed class WorkRequirementFulfilment
    {
        #region attributes
        private List<WorkEffort> _workEfforts;
        private List<WorkRequirement> _requirements;
        #endregion

        #region properties
        public List<WorkEffort> WorkEfforts { get { return _workEfforts; } set { _workEfforts = value; } }
        public List<WorkRequirement> Requirements { get { return _requirements; } set { _requirements = value; } }
        #endregion
    }
}
