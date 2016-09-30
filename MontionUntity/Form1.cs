using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Advantech.Motion;
using MontionUntity.MontionManager;
using MontionUntity.Utils;

namespace MontionUntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VersionIsOk = GetDevCfgDllDrvVer();
        }

        #region 初始化信息
        private Boolean GetDevCfgDllDrvVer()
        {
            string fileName = "";
            FileVersionInfo myFileVersionInfo;
            string FileVersion = "";
            fileName = Environment.SystemDirectory + "\\ADVMOT.dll";//SystemDirectory指System32 
            myFileVersionInfo = FileVersionInfo.GetVersionInfo(fileName);
            FileVersion = myFileVersionInfo.FileVersion;
            string DetailMessage;
            string[] strSplit = FileVersion.Split(',');
            if (Convert.ToUInt16(strSplit[0]) < 2)
            {

                DetailMessage = "The Driver Version  Is Too Low" + "\r\nYou can update the driver through the driver installation package ";
                DetailMessage = DetailMessage + "\r\nThe Current Driver Version Number is " + FileVersion;
                DetailMessage = DetailMessage + "\r\nYou need to update the driver to 2.0.0.0 version and above";
                MessageBox.Show(DetailMessage, "Home", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        Boolean VersionIsOk = false;
        private DeviceManager dm = new DeviceManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            bool Result;

            if (VersionIsOk == false)
            {
                return;
            }
            // Get the list of available device numbers and names of devices, of which driver has been loaded successfully 
            //If you have two/more board,the device list(m_avaDevs) may be changed when the slot of the boards changed,for example:m_avaDevs[0].szDeviceName to PCI-1245
            //m_avaDevs[1].szDeviceName to PCI-1245L,changing the slot，Perhaps the opposite 
            Result = DeviceManager.GetAvailable();
            if (!Result)
            {
               
                return;
            }
            //If you want to get the device number of fixed equipment，you also can achieve it By adding the API:GetDevNum(UInt32 DevType, UInt32 BoardID, UInt32 MasterRingNo, UInt32 SlaveBoardID),
            //The API is defined and illustrates the way of using in this example,but it is not called,you can copy it to your program and
            //don't need to call Motion.mAcm_GetAvailableDevs(CurAvailableDevs, Motion.MAX_DEVICES, ref deviceCount)
            //GetDevNum(UInt32 DevType, UInt32 BoardID, UInt32 MasterRingNo, UInt32 SlaveBoardID) API Variables are stated below:
            //UInt32 DevType : Set Device Type ID of your motion card plug in PC. (Definition is in ..\Public\AdvMotDev.h)
            //UInt32 BoardID : Set Hardware Board-ID of your motion card plug in PC,you can get it from Utility
            //UInt32 MasterRingNo: PCI-Motion card, Always set to 0
            //UInt32 SlaveBoardID : PCI-Motion card,Always set to 0
            CmbAvailableDevice.Items.Clear();
            for (int i = 0; i < DeviceManager.deviceCount; i++)
            {
                CmbAvailableDevice.Items.Add(DeviceManager.CurAvailableDevs[i].DeviceName);
            }
            if (DeviceManager.deviceCount > 0)
            {
                CmbAvailableDevice.SelectedIndex = 0;
                DeviceManager.CurrentDevice = 0;

                BX_CurrentDeviceNum.Text = "DeviceNum:=" + DeviceManager.CurrentDevice.ToString();
            }
            dm.InitalDeviceInfo();
        }
        #endregion


        private void BX_RefreshDevice_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void BX_openDevice_Click(object sender, EventArgs e)
        {

            ////uint result;

            ////result = MontionManager.ManagerMontion.OpenDevice();
            if (!  dm.WorkDevice[DeviceManager.CurrentDevice].OpenDevice()) {

                return;
            }

            ////result = MontionManager.ManagerMontion.UpdateAsix();
            if (!dm.WorkDevice[DeviceManager.CurrentDevice].UpdateAsix())
            {

                return;
            }
            dm.WorkDevice[DeviceManager.CurrentDevice].InitAxisInfo();
            double cmdPosition = new double();
            cmdPosition = 0;
            for (int i = 0; i < dm.WorkDevice[DeviceManager.CurrentDevice].AxesPerDev; i++)
            {

               // result = MontionManager.ManagerMontion.OpenAxis(i);
                if (!dm.WorkDevice[DeviceManager.CurrentDevice].OpenAxis(i))
                {

                    return;
                }

                CmbAxes.Items.Add(String.Format("{0:d}-Axis", i));
                
                //Set command position for the specified axis
                Motion.mAcm_AxSetCmdPosition(dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[i].m_Axishand, cmdPosition);
                //Set actual position for the specified axis
                Motion.mAcm_AxSetActualPosition(dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[i].m_Axishand, cmdPosition);
                dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[i].m_bInit = true;
            }


          
            CmbAxes.SelectedIndex = 0;
            Device.CurrentAxis = CmbAxes.SelectedIndex;
            this.timer1.Enabled = true;

        }

        private void LoadDefeateConfig(){
        

        }

        private void axisSelected(object sender, EventArgs e)
        {
            Device.CurrentAxis = CmbAxes.SelectedIndex;
         //   MontionManager.ManagerMontion.index = CmbAxes.SelectedIndex;
        }

        private bool _Enable;
        private void BX_Operator_Click(object sender, EventArgs e)
        {
            uint result;
            if (!_Enable)
            {
               // result = dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[Device.CurrentAxis].EnalbleAxis();
                if (!dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[Device.CurrentAxis].EnalbleAxis())
                {

                    return;
                }
                _Enable = true;
                this.BX_Operator.Text = "Off";
            }
            else {

               // result = MontionManager.ManagerMontion.UnalbleAxis();
                if (!dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[Device.CurrentAxis].UnalbleAxis())
                {

                    return;
                }
                _Enable = false;
                this.BX_Operator.Text = "On";
            }
        }

        private void deviceSelected(object sender, EventArgs e)
        {
            DeviceManager.CurrentDevice = CmbAvailableDevice.SelectedIndex;
            BX_CurrentDeviceNum.Text = "DeviceNum:=" + DeviceManager.CurAvailableDevs[0].DeviceNum.ToString();
        }

        private void BX_Positive_Click(object sender, EventArgs e)
        {
            BX_Stop_Click(sender, e);
            dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[Device.CurrentAxis].MoveMode(_model.MoveMode,0, 0, _model.distance);
        }

        private void Negivate_Click(object sender, EventArgs e)
        {
            BX_Stop_Click(sender, e);
            dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[Device.CurrentAxis].MoveMode(_model.MoveMode, 1, 0, _model.distance * (-1));
        }

        private void BX_SetParmerter_Click(object sender, EventArgs e)
        {
            try
            {

                _model = new Model();
                _model.distance = double.Parse(this.BX_Distance.Text.ToString().Trim());
                _model.SpeeedInfo = new SpeedInfoStuct();
                _model.SpeeedInfo.Acc = double.Parse(this.BX_ACC.Text.ToString().Trim());
                _model.SpeeedInfo.Dec = double.Parse(this.BX_Dec.Text.ToString().Trim());
                _model.SpeeedInfo.VelHigh = double.Parse(this.BX_VelHigh.Text.ToString().Trim());
                _model.SpeeedInfo.VelLow = double.Parse(this.BX_Vel.Text.ToString().Trim());

                if (Mode_T.Checked == true)
                {

                    _model.SpeedMode = 1;
                }
                else {

                    _model.SpeedMode = 0;

                }

                if (Mode_P2P.Checked == true) {

                    _model.MoveMode = 0;
                }
                else if (Mode_Continues.Checked == true)
                {

                    _model.MoveMode = 1;
                }
                else {

                    _model.MoveMode = 2;
                }
                if (dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[Device.CurrentAxis].SetBaseParmeter(_model) == true)
                {

                    MessageBox.Show("设置成功");
                }

            }
            catch (Exception ee) { 
            

            }
        }

        private Model _model;

        private void BX_Stop_Click(object sender, EventArgs e)
        {
            dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[Device.CurrentAxis].StopAxis();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager.Count; i++)
                
                dm.WorkDevice[DeviceManager.CurrentDevice].WorkAxisManager[i].SingalDeal();
                  
        }


    }
}
