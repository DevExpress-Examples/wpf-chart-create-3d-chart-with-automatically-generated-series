using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Resources;
using System.Xml.Linq;

namespace Chart3D_Lesson3 {
    public class IrisesViewModel {
        public ObservableCollection<IrisData> Irises { get; set; }
        public IrisesViewModel() {
            this.Irises = DataLoader.GetIrises("/Data/IrisDataSet.xml");
        }
    }
    static class DataLoader {
        public static ObservableCollection<IrisData> GetIrises(string filepath) {
            ObservableCollection<IrisData> irisDataSet = new ObservableCollection<IrisData>();
            Uri uri = new Uri(filepath, UriKind.RelativeOrAbsolute);
            StreamResourceInfo info = Application.GetResourceStream(uri);
            XDocument document = XDocument.Load(info.Stream);
            if (document == null) return irisDataSet;
            foreach (XElement element in document.Element("IrisDataSet").Elements("IrisData")) {
                double sepalLength = Convert.ToDouble(element.Element("SepalLength").Value);
                double sepalWidth = Convert.ToDouble(element.Element("SepalWidth").Value);
                double petalLength = Convert.ToDouble(element.Element("PetalLength").Value);
                double petalWidth = Convert.ToDouble(element.Element("PetalWidth").Value);
                string species = element.Element("Species").Value.ToString();
                irisDataSet.Add(new IrisData(species, sepalWidth, sepalLength, petalWidth, petalLength));
            }
            return irisDataSet;
        }
    }
}