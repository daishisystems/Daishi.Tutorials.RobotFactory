#region Includes

using System.Collections.Generic;
using NUnit.Framework;

#endregion

namespace Daishi.Tutorials.RobotFactory.Tests {
    [TestFixture]
    internal class SupplierTests {
        [Test]
        public void SupplierDeliversRobotParts() {
            var mechSupplier = new MechSupplier {
                RobotParts = new List<RobotPart> {
                    new MockedRobotPart(),
                    new MockedRobotPart()
                }
            };

            var deliveryBay = new DeliveryBay();
            mechSupplier.DeliverRobotParts(deliveryBay);

            Assert.AreEqual(2, deliveryBay.RobotParts.Count);
            Assert.AreEqual(0, mechSupplier.RobotParts.Count);
        }
    }
}