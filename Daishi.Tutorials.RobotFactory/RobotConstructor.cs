namespace Daishi.Tutorials.RobotFactory {
    public class RobotConstructor {
        public void Construct(RobotBuilder robotBuilder) {
            robotBuilder.BuildHead();
            robotBuilder.BuildTorso();
            robotBuilder.BuildArms();
            robotBuilder.BuildLegs();
        }
    }
}