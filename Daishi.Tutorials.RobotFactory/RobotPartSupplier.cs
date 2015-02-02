#region Includes

using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public class RobotPartSupplier : Supplier {
        public void DeliverRobotParts(DeliveryBay deliveryBay) {
            deliveryBay.RobotParts = new List<RobotPart>(RobotParts);
            RobotParts.Clear();
        }
    }
}