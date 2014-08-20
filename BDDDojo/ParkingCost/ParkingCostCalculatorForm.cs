using System.Windows.Forms;

namespace Rain.BDDDojo.ParkingCost
{
    public partial class ParkingCostCalculatorForm : Form, IParkingCostCalculator
    {
        private readonly ParkingCostCalculatorPresenter _presenter;

        public ParkingCostCalculatorForm()
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
