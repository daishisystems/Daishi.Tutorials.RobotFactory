#region Includes

using System.Linq;
using NUnit.Framework;

#endregion

namespace Daishi.Tutorials.RobotFactory.Tests {
    [TestFixture]
    internal class WorkerDroneTests {
        [Test]
        public void WorkerDroneIdentifiesRobotPart() {
            RobotPart robotPart = new MockedAssembly();
            var workerDrone = new MockedWorkerDrone();

            var transportMechanism = workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<AssemblyRoomTransportMechanism>(transportMechanism);

            robotPart = new MockedWeapon();

            transportMechanism = workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<ArmouryTransportMechanism>(transportMechanism);
        }

        [Test]
        public void WorkerDronePicksUpRobotPart() {
            RobotPart robotPart = new MockedAssembly();
            WorkerDrone workerDrone = new MockedWorkerDrone();

            workerDrone.PickUpRobotPart(robotPart);
            Assert.AreEqual(1, workerDrone.GetRobotPartCount());
        }

        [Test]
        public void WorkerDroneOffLoadsRobotParts() {
            WorkerDrone workerDrone = new MockedWorkerDrone();
            RobotPart robotPart = new MockedAssembly();

            workerDrone.PickUpRobotPart(robotPart);
            workerDrone.TransportRobotParts();

            Assert.AreEqual(1, workerDrone.GetRobotPartCount());
            robotPart = new MockedWeapon();

            workerDrone.PickUpRobotPart(robotPart);
            workerDrone.TransportRobotParts();

            Assert.AreEqual(1, workerDrone.GetRobotPartCount());
        }

        [Test]
        public void WorkerDroneReturnsToDeliveryBayAfterDeliveringRobotParts() {
            WorkerDrone workerDrone = new MockedWorkerDrone();

            var randomAssembly = new MockedAssembly();
            var randomWeapon = new MockedWeapon();

            workerDrone.PickUpRobotPart(randomAssembly);
            workerDrone.PickUpRobotPart(randomWeapon);

            workerDrone.TransportRobotParts();
            Assert.True(workerDrone.GetTransportationMechanisms().Any());

            var transportMechanism = workerDrone.GetTransportationMechanisms().First();
            Assert.IsInstanceOf<DeliveryBayTransportMechanism>(transportMechanism);
        }
    }
}