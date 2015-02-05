namespace Daishi.Tutorials.RobotFactory.Tests
{
    internal static class Build
    {
        public static readonly IBuildRobotPartSupplier RobotPartSupplier = new RobotPartSupplierBuilder();
    }
}