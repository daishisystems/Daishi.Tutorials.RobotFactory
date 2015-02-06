namespace Daishi.Tutorials.RobotFactory {
    public abstract class RobotPart {
        private readonly RobotPartCategory _robotPartCategory;

        public RobotPartCategory RobotPartCategory { get { return _robotPartCategory; } }

        protected RobotPart(RobotPartCategory robotPartCategory) {
            _robotPartCategory = robotPartCategory;
        }
    }
}