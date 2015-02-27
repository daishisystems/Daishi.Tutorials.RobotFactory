namespace Daishi.Tutorials.RobotFactory {
    public class ArmouryTransportMechanism : TransportMechanism {
        public ArmouryTransportMechanism(Weapon weapon) : base(weapon) {}

        public override FactoryRoom GetFactoryRoom() {
            return new Armoury();
        }
    }
}