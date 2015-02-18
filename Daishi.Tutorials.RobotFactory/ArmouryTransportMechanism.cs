namespace Daishi.Tutorials.RobotFactory {
    public class ArmouryTransportMechanism : TransportMechanism {
        public override FactoryRoom GetFactoryRoom() {
            return new Armoury();
        }
    }
}