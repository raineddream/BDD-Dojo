using System.Windows.Forms;

namespace Rain.BDDDojo
{
    public partial class ParkingCostCalculator : Form
    {
        public ParkingCostCalculator()
        {
            InitializeComponent();
        }

        private void ParkingCostCalculator_Load(object sender, System.EventArgs e)
        {
            cbParkingLot.SelectedIndex = GetIndexOfParkingLotChoosingTip();
        }

        private int GetIndexOfParkingLotChoosingTip()
        {
            return cbParkingLot.FindString("Please choose");
        }
    }
}
