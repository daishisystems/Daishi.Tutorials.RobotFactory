namespace Daishi.Tutorials.RobotFactory {
    public class CaterpillarRobotBuilder : RobotBuilder {
        public CaterpillarRobotBuilder() {
            robot = new CaterpillarRobot();
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
            robot.LeftLeg = new Caterpillar();
            robot.RightLeg = new Caterpillar();
        }
    }
}