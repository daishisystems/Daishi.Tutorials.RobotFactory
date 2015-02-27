namespace Daishi.Tutorials.RobotFactory {
    public class AssemblyRoomTransportMechanism : TransportMechanism {
        public AssemblyRoomTransportMechanism(Assembly assembly) : base(assembly) {}

        public override FactoryRoom GetFactoryRoom() {
            return new AssemblyRoom();
        }
    }
}