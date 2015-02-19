#region Includes

using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public abstract class TransportMechanism {
        private FactoryRoom _factoryRoom;

        public abstract FactoryRoom GetFactoryRoom();

        public void EnterRoom() {
            _factoryRoom = GetFactoryRoom();
            _factoryRoom.AddTransportationMechanism(this);
        }

        public FactoryRoom OffLoadRobotParts(List<RobotPart> robotParts) {
            if (_factoryRoom == null) {
                EnterRoom();
            }
            _factoryRoom.SetRobotParts(new List<RobotPart>(robotParts));
            robotParts.Clear();

            return _factoryRoom;
        }
    }
}