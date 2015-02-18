#region Includes

using NUnit.Framework;

#endregion

namespace Daishi.Tutorials.RobotFactory.Tests {
    [TestFixture]
    internal class WorkerDroneTests {
        [Test]
        public void WorkerDroneIdentifiesRobotPart() {
            var robotPart = new MockedRobotPart(RobotPartCategory.Assembly);
            var workerDrone = new MockedWorkerDrone();

            workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<AssemblyRoomTransportMechanism>(workerDrone.GetTransportationMechanism());

            robotPart = new MockedRobotPart(RobotPartCategory.Weapon);

            workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<ArmouryTransportMechanism>(workerDrone.GetTransportationMechanism());
        }
    }
}