#region Includes

using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public class MechSupplier : Supplier {
        public void DeliverRobotParts(DeliveryBay deliveryBay) {
            deliveryBay.RobotParts = new List<RobotPart>(RobotParts);
            RobotParts.Clear();
        }
    }
}