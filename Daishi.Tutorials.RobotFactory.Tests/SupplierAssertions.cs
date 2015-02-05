namespace Daishi.Tutorials.RobotFactory.Tests
{
    internal static class SupplierAssertions
    {
        public static int CountDeliveredRobotParts(this RobotPartSupplier supplier)
        {
            return supplier.RobotParts.Count;
        }
    }
}