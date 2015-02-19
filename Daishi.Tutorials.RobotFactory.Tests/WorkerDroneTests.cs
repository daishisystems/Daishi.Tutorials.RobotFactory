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

        [Test]
        public void WorkerDronePicksUpRobotPart() {
            RobotPart robotPart = new MockedRobotPart(RobotPartCategory.Assembly);
            WorkerDrone workerDrone = new MockedWorkerDrone();

            workerDrone.PickUpRobotPart(robotPart);
            Assert.AreEqual(1, workerDrone.GetRobotPartCount());
        }

        [Test]
        public void WorkerDroneOffLoadsRobotParts() {
            WorkerDrone workerDrone = new MockedWorkerDrone();
            RobotPart robotPart = new MockedRobotPart(RobotPartCategory.Assembly);

            workerDrone.PickUpRobotPart(robotPart);
            var factoryRoom = workerDrone.TransportRobotParts();

            Assert.AreEqual(0, workerDrone.GetRobotPartCount());
            Assert.AreEqual(1, factoryRoom.GetRobotPartCount());
            Assert.IsInstanceOf<AssemblyRoom>(factoryRoom);

            robotPart = new MockedRobotPart(RobotPartCategory.Weapon);

            workerDrone.PickUpRobotPart(robotPart);
            factoryRoom = workerDrone.TransportRobotParts();

            Assert.AreEqual(0, workerDrone.GetRobotPartCount());
            Assert.AreEqual(1, factoryRoom.GetRobotPartCount());
            Assert.IsInstanceOf<Armoury>(factoryRoom);
        }
    }
}