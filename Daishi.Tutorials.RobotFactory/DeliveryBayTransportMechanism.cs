namespace Daishi.Tutorials.RobotFactory {
    public class DeliveryBayTransportMechanism : TransportMechanism {
        public DeliveryBayTransportMechanism() : base(null) {}

        public override FactoryRoom GetFactoryRoom() {
            return new DeliveryBay();
        }
    }
}