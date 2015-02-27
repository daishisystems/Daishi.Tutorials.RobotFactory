#region Includes

using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public abstract class FactoryRoom {
        private readonly List<TransportMechanism> _transportMechanisms = new List<TransportMechanism>();
        private readonly List<RobotPart> _robotParts;

        protected FactoryRoom() {
            _robotParts = new List<RobotPart>();
        }

        public void AddTransportationMechanism(TransportMechanism transportMechanism) {
            _transportMechanisms.Add(transportMechanism);
        }

        public void AddRobotPart(RobotPart robotPart) {
            _robotParts.Add(robotPart);
        }

        public int GetOccupantCount() {
            return _transportMechanisms != null ? _transportMechanisms.Count : 0;
        }

        public int GetRobotPartCount() {
            return _robotParts != null ? _robotParts.Count : 0;
        }
    }
}