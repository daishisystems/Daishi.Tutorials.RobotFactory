#region Includes

using System;
using System.Collections.Generic;

#endregion

namespace Daishi.Tutorials.RobotFactory {
    public abstract class WorkerDrone {
        private TransportMechanism _transportMechanism;
        private readonly List<RobotPart> _robotParts = new List<RobotPart>();

        protected WorkerDrone() {}

        public TransportMechanism GetTransportationMechanism() {
            return _transportMechanism;
        }

        public void IdentifyRobotPart(RobotPart robotPart) {
            switch (robotPart.RobotPartCategory) {
                case RobotPartCategory.Assembly:
                    _transportMechanism = new AssemblyRoomTransportMechanism();
                    break;
                case RobotPartCategory.Weapon:
                    _transportMechanism = new ArmouryTransportMechanism();
                    break;
            }
        }

        public void PickUpRobotPart(RobotPart robotPart) {
            _robotParts.Add(robotPart);
            IdentifyRobotPart(robotPart);
        }

        public FactoryRoom TransportRobotParts() {
            if (_transportMechanism == null) {
                throw new NullReferenceException("No Transportation-Mechanism defined!");
            }
            return _transportMechanism.OffLoadRobotParts(_robotParts);
        }

        public int GetRobotPartCount() {
            return _robotParts.Count;
        }
    }
}