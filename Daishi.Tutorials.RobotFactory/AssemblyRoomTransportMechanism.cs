namespace Daishi.Tutorials.RobotFactory {
    public class AssemblyRoomTransportMechanism : TransportMechanism {
        public override FactoryRoom GetFactoryRoom() {
            return new AssemblyRoom();
        }
    }
}