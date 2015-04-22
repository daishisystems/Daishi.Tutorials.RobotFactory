#region Includes

using NUnit.Framework;

#endregion

namespace Daishi.Tutorials.RobotFactory.Tests {
    [TestFixture]
    internal class RobotBuilderTests {
        [Test]
        public void RobotBuilderBuildsBasicRobot() {
            var basicRobotBuilder = new BasicRobotBuilder();

            basicRobotBuilder.BuildHead();
            basicRobotBuilder.BuildTorso();
            basicRobotBuilder.BuildArms();
            basicRobotBuilder.BuildLegs();

            Assert.IsInstanceOf<BasicHead>(basicRobotBuilder.Robot.Head);
            Assert.IsInstanceOf<BasicTorso>(basicRobotBuilder.Robot.Torso);
            Assert.IsInstanceOf<BasicLeftArm>(basicRobotBuilder.Robot.LeftArm);
            Assert.IsInstanceOf<BasicRightArm>(basicRobotBuilder.Robot.RightArm);
            Assert.IsInstanceOf<BasicLeftLeg>(basicRobotBuilder.Robot.LeftLeg);
            Assert.IsInstanceOf<BasicRightLeg>(basicRobotBuilder.Robot.RightLeg);
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

        [Test]
        public void RobotConstructorConstructsRobot() {
            var robotConstructor = new RobotConstructor();
            var basicRobotBuilder = new BasicRobotBuilder();

            robotConstructor.Construct(basicRobotBuilder);

            Assert.IsInstanceOf<BasicHead>(basicRobotBuilder.Robot.Head);
            Assert.IsInstanceOf<BasicTorso>(basicRobotBuilder.Robot.Torso);
            Assert.IsInstanceOf<BasicLeftArm>(basicRobotBuilder.Robot.LeftArm);
            Assert.IsInstanceOf<BasicRightArm>(basicRobotBuilder.Robot.RightArm);
            Assert.IsInstanceOf<BasicLeftLeg>(basicRobotBuilder.Robot.LeftLeg);
            Assert.IsInstanceOf<BasicRightLeg>(basicRobotBuilder.Robot.RightLeg);
        }
    }
}