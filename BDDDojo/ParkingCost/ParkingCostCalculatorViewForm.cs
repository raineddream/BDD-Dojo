using System.Windows.Forms;

namespace Rain.BDDDojo.ParkingCost
{
    public partial class ParkingCostCalculatorViewForm : Form, IParkingCostCalculatorView
    {
        private readonly ParkingCostCalculatorPresenter _presenter;

        public ParkingCostCalculatorViewForm()
        {
            InitializeComponent();
            _presenter = new ParkingCostCalculatorPresenter(this);
        }

        public void GiveParkingCost(double cost)
        {
            MessageBox.Show(string.Format("You should pay: ${0:0.00}", cost), @"Parking Cost");
        }

        private void ParkingCostCalculator_Load(object sender, System.EventArgs e)
        {
            cbParkingLot.SelectedIndex = GetIndexOfParkingLotChoosingTip();
        }

        private int GetIndexOfParkingLotChoosingTip()
        {
            return cbParkingLot.FindString("Please choose");
        }

        private void btnCalculateCharge_Click(object sender, System.EventArgs e)
        {
            _presenter.CalculateCost(ParkingType.ValetParking, 30);
        }
    }
}
