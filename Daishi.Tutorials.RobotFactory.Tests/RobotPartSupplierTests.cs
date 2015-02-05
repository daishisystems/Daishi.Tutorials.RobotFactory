#region Includes

using System.Collections.Generic;
using NUnit.Framework;

#endregion

namespace Daishi.Tutorials.RobotFactory.Tests
{
    [TestFixture]
    internal class RobotPartSupplierTests
    {
        [Test]
        public void RobotPartSupplierDeliversRobotParts()
        {
            var mechSupplier = Build.RobotPartSupplier.With(new List<RobotPart>
                {
                    new MockedRobotPart(),
                    new MockedRobotPart()
                });

            var deliveryBay = new MockedDeliveryBay();

            mechSupplier.DeliverRobotParts(deliveryBay);

            Assert.AreEqual(2, deliveryBay.CountReceivedRobotParts());
            Assert.AreEqual(0, mechSupplier.CountDeliveredRobotParts());
        }
    }
}