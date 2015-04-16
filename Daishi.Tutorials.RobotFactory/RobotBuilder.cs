namespace Daishi.Tutorials.RobotFactory {
    public abstract class RobotBuilder {
        protected Robot robot;

        public Robot Robot { get { return robot; } }

        public abstract void BuildHead();
        public abstract void BuildTorso();
        public abstract void BuildArms();
        public abstract void BuildLegs();
    }
}