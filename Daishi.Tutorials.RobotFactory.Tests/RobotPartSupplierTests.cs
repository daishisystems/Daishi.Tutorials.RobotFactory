#region Includes

using System.Collections.Generic;
using NUnit.Framework;

#endregion

namespace Daishi.Tutorials.RobotFactory.Tests {
    [TestFixture]
    internal class RobotPartSupplierTests {
        [Test]
        public void RobotPartSupplierDeliversRobotParts() {
            var mechSupplier = new RobotPartSupplier {
                RobotParts = new List<RobotPart> {
                    new MockedRobotPart(),
                    new MockedRobotPart()
                }
            };

            var deliveryBay = new MockedDeliveryBay();
            mechSupplier.DeliverRobotParts(deliveryBay);

            Assert.AreEqual(2, deliveryBay.RobotParts.Count);
            Assert.AreEqual(0, mechSupplier.RobotParts.Count);
        }
    }
}