using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Advantech.Motion;
using MontionUntity.Utils;

namespace MontionUntity.MontionManager
{
    class DeviceManager
    {

        public static bool GetAvailable()
        {

            return Utils.Utils.Assert( (uint)Motion.mAcm_GetAvailableDevs(CurAvailableDevs, Motion.MAX_DEVICES, ref deviceCount));
        }

        public  void InitalDeviceInfo() {

            WorkDevice = new List<Device>();
            for (int i = 0; i < deviceCount; i++) {

                Device d = new Device();
                d.DeviceName = CurAvailableDevs[i].DeviceName;
                d.DeviceNum = CurAvailableDevs[i].DeviceNum;
                d.NumofSubDevice = CurAvailableDevs[i].NumofSubDevice;
                
                WorkDevice.Add(d);
                
            }
        }

        public static DEV_LIST[] CurAvailableDevs = new DEV_LIST[Motion.MAX_DEVICES];
        public static uint deviceCount = 0;

        public static int CurrentDevice;
        public  List<Device> WorkDevice;
    }



    class Device {

        public List<AxisManager> WorkAxisManager;
        public  uint AxesPerDev = new uint();
        public static int CurrentAxis;
        public string DeviceName;
        public uint DeviceNum;
        public short NumofSubDevice;
        public IntPtr m_DeviceHandle;



        public  bool OpenDevice()
        {

            return Utils.Utils.Assert( Motion.mAcm_DevOpen(DeviceNum, ref m_DeviceHandle));

        }

        public bool UpdateAsix()
        {

            return Utils.Utils.Assert(Motion.mAcm_GetU32Property(m_DeviceHandle, (uint)PropertyID.FT_DevAxesCount, ref AxesPerDev));

        }
        public void InitAxisInfo() {

            WorkAxisManager = new List<AxisManager>();
            for (int i = 0; i < AxesPerDev; i++) {
                AxisManager am = new AxisManager();
                WorkAxisManager.Add(am);
            }

        }

        public bool OpenAxis(int index)
        {
            
            return Utils.Utils.Assert(Motion.mAcm_AxOpen(m_DeviceHandle, (UInt16)index, ref WorkAxisManager[index].m_Axishand));
        }

    }

    class AxisManager {

        public IntPtr m_Axishand;
        private bool _IsOn;
        public bool m_bInit;
        public  bool EnalbleAxis()
        {
            _IsOn = Utils.Utils.Assert(Motion.mAcm_AxSetSvOn(m_Axishand, 1));
            return _IsOn;
        }
        public bool UnalbleAxis()
        {

            _IsOn = Utils.Utils.Assert(Motion.mAcm_AxSetSvOn(m_Axishand, 0))?false:true;
            return Utils.Utils.Assert(Motion.mAcm_AxSetSvOn(m_Axishand, 0));
        }
        private  bool SetSpeedInfo(SpeedInfoStuct si)
        {



            ///获取当前最小速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand, (uint)PropertyID.PAR_AxVelLow, si.VelLow)))
            {




                return false;
            }

            ///获取当前最大速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand, (uint)PropertyID.PAR_AxVelHigh, si.VelHigh)))
            {




                return false;
            }

            ///获取当前加速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand, (uint)PropertyID.PAR_AxAcc, si.Acc)))
            {




                return false;
            }


            ///获取当前减速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand, (uint)PropertyID.PAR_AxDec, si.Dec)))
            {



                return false;
            }





            return true;
        }

        public  bool SetBaseParmeter(Model model)
        {

            bool flag = SetSpeedInfo(model.SpeeedInfo);

            if (flag == true)
            {

                return SetSpeedMode(model.SpeedMode);
            }

            return false;
        }

        public  bool SetSpeedMode(int AxJerk)
        {


            switch (AxJerk)
            {
                case 0: return Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand, (uint)PropertyID.PAR_AxJerk, AxJerk));
                case 1: return Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand, (uint)PropertyID.PAR_AxJerk, AxJerk));

            }
            return false;
        }

        public  uint MoveMode(int model, ushort dir, int moveAbs, double position = 0)
        {

            switch (model)
            {
                case 0:  Motion.mAcm_AxMoveRel(m_Axishand, position); ; break;
                case 1: Motion.mAcm_AxMoveVel(m_Axishand, dir); break;
                case 2: Motion.mAcm_SetF64Property(m_Axishand, (uint)PropertyID.PAR_AxJerk, model); break;
                //Motion.mAcm_AxMoveVel(m_Axishand[index],dir);
            }
            return 0;
        }

        public  bool StopAxis()
        {


            return Utils.Utils.Assert(Motion.mAcm_AxStopDec(m_Axishand));
        }

        public bool SingalDeal() {
            
            if (m_bInit)
            {
                UInt32 IOStatus = new UInt32();
                uint Result = Motion.mAcm_AxGetMotionIO(m_Axishand, ref IOStatus);
                if (Result == (uint)ErrorCode.SUCCESS)
                {
                    GetMotionIOStatus(IOStatus);
                }
                //Get current command position of the specified axis
                ////Motion.mAcm_AxGetCmdPosition(m_Axishand[CmbAxes.SelectedIndex], ref CurCmd);
                ////textBoxCmd.Text = Convert.ToString(CurCmd);
                //////Get actual position of the specified axis
                ////Motion.mAcm_AxGetActualPosition(m_Axishand[CmbAxes.SelectedIndex], ref ActCmd);
                ////textBoxAct.Text = Convert.ToString(ActCmd);
                //////Get the Axis's current state		
                ////Motion.mAcm_AxGetState(m_Axishand[CmbAxes.SelectedIndex], ref AxState);
                ////textBoxCurState.Text = ((AxisState)AxState).ToString();
            }
            return false;
        }
        ////信号处理
        private void GetMotionIOStatus(uint IOStatus)
        {
            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_EZ) > 0)//ALM
            {
               
            }
            else
            {
            }

            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_ORG) > 0)//ORG
            {
               
            }
            else
            {
                
            }

            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_LMTP) > 0)//+EL
            {
               
                Utils.Utils.Assert( Motion.mAcm_AxResetError(m_Axishand)); 
                System.Windows.Forms.MessageBox.Show("恢复命令");
            }
            else
            {
               
            }

            if ((IOStatus & (uint)Ax_Motion_IO.AX_MOTION_IO_LMTN) > 0)//-EL
            {
              
            }
            else
            {
               
            }
        }


    }
}
