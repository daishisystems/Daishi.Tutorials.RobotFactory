namespace Daishi.Tutorials.RobotFactory {
    public abstract class Robot {
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public Arm LeftArm { get; set; }
        public Arm RightArm { get; set; }
        public Leg LeftLeg { get; set; }
        public Leg RightLeg { get; set; }
    }
}