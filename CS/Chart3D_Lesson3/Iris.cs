namespace Chart3D_Lesson3 {
    public class IrisData {
        public string Species { get; private set; }
        public double SepalWidth { get; private set; }
        public double SepalLength { get; private set; }
        public double PetalWidth { get; private set; }
        public double PetalLength { get; private set; }
        public IrisData(
            string species,
            double sepalWidth,
            double sepalLength,
            double petalWidth,
            double petalLength
        ) {
            Species = species;
            SepalWidth = sepalWidth;
            SepalLength = sepalLength;
            PetalWidth = petalWidth;
            PetalLength = petalLength;
        }
    }
}