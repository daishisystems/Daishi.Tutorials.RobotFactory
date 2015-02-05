using System.Collections.Generic;

namespace Daishi.Tutorials.RobotFactory.Tests
{
    internal class RobotPartSupplierBuilder : IBuildRobotPartSupplier
    {
        public RobotPartSupplier With(List<RobotPart> parts)
        {
            return new RobotPartSupplier {RobotParts = parts};
        }
    }
}