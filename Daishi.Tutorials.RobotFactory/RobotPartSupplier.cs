namespace Daishi.Tutorials.RobotFactory {
    public class RobotPartSupplier : Supplier {
        public void DeliverRobotParts(FactoryRoom deliveryBay) {
            foreach (var robotPart in RobotParts) {
                deliveryBay.AddRobotPart(robotPart);
            }

            RobotParts.Clear();
        }
    }
}