using System.Collections.Generic;

namespace Daishi.Tutorials.RobotFactory.Tests
{
    internal interface IBuildRobotPartSupplier
    {
        RobotPartSupplier With(List<RobotPart> parts);
    }
}