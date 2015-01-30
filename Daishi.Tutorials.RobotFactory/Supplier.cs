#region Includes

using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public abstract class Supplier {
        public List<RobotPart> RobotParts { get; set; }
    }
}