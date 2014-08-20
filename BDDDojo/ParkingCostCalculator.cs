using System.Windows.Forms;

namespace Rain.BDDDojo
{
    public partial class ParkingCostCalculator : Form, IParkingCostCalculator
    {
        private readonly ParkingCostCalculatorPresenter _presenter;

        public ParkingCostCalculator()
        {
            InitializeComponent();
            _presenter = new ParkingCostCalculatorPresenter(this);
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
