#region Includes

using System;
using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public abstract class WorkerDrone {
        private readonly List<TransportMechanism> _transportMechanisms;

        protected WorkerDrone() {
            _transportMechanisms = new List<TransportMechanism>();
        }

        public TransportMechanism IdentifyRobotPart(RobotPart robotPart) {
            switch (robotPart.RobotPartCategory) {
                case RobotPartCategory.Assembly:
                    return new AssemblyRoomTransportMechanism((Assembly) robotPart);
                case RobotPartCategory.Weapon:
                    return new ArmouryTransportMechanism((Weapon) robotPart);
            }
            throw new NotImplementedException("I can't identify this component!");
        }

        public void PickUpRobotPart(RobotPart robotPart) {
            var transportMechanism = IdentifyRobotPart(robotPart);
            _transportMechanisms.Add(transportMechanism);
        }

        public void TransportRobotParts() {
            foreach (var transportMechanism in _transportMechanisms) {
                transportMechanism.OffLoadRobotPart();
            }

            _transportMechanisms.Clear();

            var deliveryBayTransportMechanism = new DeliveryBayTransportMechanism();
            _transportMechanisms.Add(deliveryBayTransportMechanism);

            deliveryBayTransportMechanism.EnterRoom();
        }

        public int GetRobotPartCount() {
            return _transportMechanisms.Count;
        }

        public List<TransportMechanism> GetTransportationMechanisms() {
            return _transportMechanisms;
        }
    }
}