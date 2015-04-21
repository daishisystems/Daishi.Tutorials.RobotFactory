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

        [Test]
        public void RobotBuilderBuildsRobotWithCaterpillars() {
            var caterpillarRobotBuilder = new CaterpillarRobotBuilder();

            caterpillarRobotBuilder.BuildHead();
            caterpillarRobotBuilder.BuildTorso();
            caterpillarRobotBuilder.BuildArms();
            caterpillarRobotBuilder.BuildLegs();

            Assert.IsInstanceOf<BasicHead>(caterpillarRobotBuilder.Robot.Head);
            Assert.IsInstanceOf<BasicTorso>(caterpillarRobotBuilder.Robot.Torso);
            Assert.IsInstanceOf<BasicLeftArm>(caterpillarRobotBuilder.Robot.LeftArm);
            Assert.IsInstanceOf<BasicRightArm>(caterpillarRobotBuilder.Robot.RightArm);
            Assert.IsInstanceOf<Caterpillar>(caterpillarRobotBuilder.Robot.LeftLeg);
            Assert.IsInstanceOf<Caterpillar>(caterpillarRobotBuilder.Robot.RightLeg);
        }
    }
}