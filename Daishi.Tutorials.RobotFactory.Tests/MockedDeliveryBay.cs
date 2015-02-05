namespace Daishi.Tutorials.RobotFactory.Tests
{
    internal class MockedDeliveryBay : DeliveryBay
    {
        public int CountReceivedRobotParts()
        {
            return RobotParts.Count;
        }
    }
}