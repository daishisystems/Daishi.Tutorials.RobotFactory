#region Includes

using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public abstract class FactoryRoom {
        private readonly List<TransportMechanism> _transportMechanisms = new List<TransportMechanism>();
        private List<RobotPart> _robotParts;

        public void AddTransportationMechanism(TransportMechanism transportMechanism) {
            _transportMechanisms.Add(transportMechanism);
        }

        public void SetRobotParts(List<RobotPart> robotParts) {
            _robotParts = robotParts;
        }

        public int GetOccupantCount() {
            return _transportMechanisms != null ? _transportMechanisms.Count : 0;
        }

        public int GetRobotPartCount() {
            return _robotParts != null ? _robotParts.Count : 0;
        }
    }
}