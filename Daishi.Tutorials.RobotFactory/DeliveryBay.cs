﻿#region Includes

using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public class DeliveryBay : FactoryRoom {
        public List<RobotPart> RobotParts { get; set; }
    }
}