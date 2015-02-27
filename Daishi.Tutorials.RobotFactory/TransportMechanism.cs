namespace Daishi.Tutorials.RobotFactory {
    public abstract class TransportMechanism {
        private readonly RobotPart _robotPart;
        private FactoryRoom _factoryRoom;

        public abstract FactoryRoom GetFactoryRoom();

        protected TransportMechanism(RobotPart robotPart) {
            _robotPart = robotPart;
        }

        public void EnterRoom() {
            _factoryRoom = GetFactoryRoom();
            _factoryRoom.AddTransportationMechanism(this);
        }

        public FactoryRoom OffLoadRobotPart() {
            if (_factoryRoom == null) {
                EnterRoom();
            }
            _factoryRoom.AddRobotPart(_robotPart);
            return _factoryRoom;
        }
    }
}