#region Includes

using NUnit.Framework;

#endregion

namespace Daishi.Tutorials.RobotFactory.Tests {
    [TestFixture]
    internal class RobotBuilderTests {
        [Test]
        public void RobotBuilderBuildsBasicRobot() {
            var robotBuilder = new BasicRobotBuilder();
            robotBuilder.BuildHead();
            robotBuilder.BuildTorso();
            robotBuilder.BuildArms();
            robotBuilder.BuildLegs();

            Assert.IsInstanceOf<BasicHead>(robotBuilder.Robot.Head);
            Assert.IsInstanceOf<BasicTorso>(robotBuilder.Robot.Torso);
            Assert.IsInstanceOf<BasicLeftArm>(robotBuilder.Robot.LeftArm);
            Assert.IsInstanceOf<BasicRightArm>(robotBuilder.Robot.RightArm);
            Assert.IsInstanceOf<BasicLeftLeg>(robotBuilder.Robot.LeftLeg);
            Assert.IsInstanceOf<BasicRightLeg>(robotBuilder.Robot.RightLeg);
        }
    }
}