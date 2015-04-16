namespace Daishi.Tutorials.RobotFactory {
    public class BasicRobotBuilder : RobotBuilder {
        public BasicRobotBuilder() {
            this.robot = new BasicRobot();
        }

        public override void BuildHead() {
            robot.Head = new BasicHead();
        }

        public override void BuildTorso() {
            robot.Torso = new BasicTorso();
        }

        public override void BuildArms() {
            robot.LeftArm = new BasicLeftArm();
            robot.RightArm = new BasicRightArm();
        }

        public override void BuildLegs() {
            robot.LeftLeg = new BasicLeftLeg();
            robot.RightLeg = new BasicRightLeg();
        }
    }
}