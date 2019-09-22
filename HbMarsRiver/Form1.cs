using HbMarsRiver.Abstract;
using HbMarsRiver.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HbMarsRiverMetinD
{
    public partial class Form1 : Form
    {
        private readonly IVehicle _vehicle;
        public Form1(IVehicle vehicle)
        {
            this._vehicle = vehicle;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            FillCombobox();
            
            base.OnLoad(e);
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AreaXDim.Text) || string.IsNullOrEmpty(txt_AreaYDim.Text))
                MessageBox.Show("Alan Kordinat uzunluğu giriniz.!!!!");
            else if (string.IsNullOrEmpty(txt_AreaXDim.Text) || string.IsNullOrEmpty(txt_AreaYDim.Text))
                MessageBox.Show("Aracın kordinatını eksiksiz giriniz.!!!!");
            else
            {
                this._vehicle.Area.XDimLength = int.Parse(txt_AreaXDim.Text);
                this._vehicle.Area.YDimLength = int.Parse(txt_AreaYDim.Text);

                int xCoordinate = int.Parse(txt_VehicleXDim.Text);
                int yCoordinate = int.Parse(txt_VehicleYDim.Text);
                if (this._vehicle.Area.XDimLength < xCoordinate || this._vehicle.Area.YDimLength < yCoordinate)
                    MessageBox.Show("Araçın konumu alandan büyük olamaz.!!!!!");
                else
                {
                    _vehicle.Coordinate.XCoordinate = xCoordinate;
                    _vehicle.Coordinate.YCoordinate = yCoordinate;
                    _vehicle.Direction = (HbMarsRiver.Abstract.IDirection)ddl_Direction.SelectedValue;

                    MessageBox.Show("Araç Ve Alan Oluşturuldu");
                    HideDirectionButtons(true);
                    CreateStation();
                }
            }
           
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            _vehicle.Direction = _vehicle.Direction.TurnRight();
            CreateStation();
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            _vehicle.Direction = _vehicle.Direction.TurnLeft();
            CreateStation();
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            if (_vehicle.Direction.IsAwail(this._vehicle.Area, _vehicle.Coordinate))
            {
                _vehicle.Direction.Move(_vehicle.Coordinate);
                CreateStation();
            }
            else
                lbl_LastStationMessage.Text = string.Format("Araç alan dışına çıkmaz");
        }

        private void txt_AreaXDim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumeric(e.KeyChar))
                e.Handled = true;
            else
                HideDirectionButtons(false);

        }

        private void txt_AreaYDim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumeric(e.KeyChar))
                e.Handled = true;
            else
                HideDirectionButtons(false);
        }

        private void txt_VehicleXDim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumeric(e.KeyChar))
                e.Handled = true;
            else
                HideDirectionButtons(false);
        }

        private void txt_VehicleYDim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumeric(e.KeyChar))
                e.Handled = true;
            else
                HideDirectionButtons(false);
        }

        private void ddl_Direction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_Create_Click(sender, e);
        }

        private void CreateStation()
        {
            lbl_LastStationMessage.Text = string.Format("Araçın X : {0}  Y : {1} konumunda {2}  Yönünde ", _vehicle.Coordinate.XCoordinate, _vehicle.Coordinate.YCoordinate, _vehicle.Direction.Direction);
        }

        private void FillCombobox()
        {
            List<Combobox> source = new List<Combobox>();
            source.Add(new Combobox() { Value = new North(), Display = "Kuzey" });
            source.Add(new Combobox() { Value = new South(), Display = "Güney" });
            source.Add(new Combobox() { Value = new East(), Display = "Doğu" });
            source.Add(new Combobox() { Value = new West(), Display = "Batı" });

            ddl_Direction.DataSource = source;
            ddl_Direction.DisplayMember = "Display";
            ddl_Direction.ValueMember = "Value";
        }

        private void HideDirectionButtons(bool val = false)
        {
            btn_Left.Visible = val;
            btn_Right.Visible = val;
            btn_Move.Visible = val;
            lbl_LastStation.Visible = val;
            lbl_LastStationMessage.Visible = val;
        }

        private bool IsNumeric(char value)
        {
            return !char.IsControl(value) && !char.IsDigit(value);
        }
    }
}
