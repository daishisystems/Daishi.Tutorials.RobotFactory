namespace Daishi.Tutorials.RobotFactory {
    public abstract class WorkerDrone {
        public TransportMechanism TransportMechanism { get; private set; }

        public void IdentifyRobotPart(RobotPart robotPart) {
            switch (robotPart.RobotPartCategory) {
                case RobotPartCategory.Assembly:
                    TransportMechanism = new AssemblyRoomTransportMechanism();
                    break;
                case RobotPartCategory.Weapon:
                    TransportMechanism = new ArmouryTransportMechanism();
                    break;
            }
        }
    }
}