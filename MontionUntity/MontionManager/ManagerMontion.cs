using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Advantech.Motion;
using MontionUntity.Utils;

namespace MontionUntity.MontionManager2
{
    class ManagerMontion
    {


        public static int  GetAvailable() {

           return  Motion.mAcm_GetAvailableDevs(CurAvailableDevs, Motion.MAX_DEVICES, ref deviceCount);
        }
        public static uint   OpenDevice() {

            return  Motion.mAcm_DevOpen(DeviceNum, ref m_DeviceHandle);
            
        }

        public static uint UpdateAsix()
        {

            return Motion.mAcm_GetU32Property(m_DeviceHandle, (uint)PropertyID.FT_DevAxesCount, ref AxesPerDev);

        }
        public static uint OpenAxis(int index)
        {

            return Motion.mAcm_AxOpen(m_DeviceHandle, (UInt16)index, ref m_Axishand[index]);
        }
        public static uint EnalbleAxis() {

            return Motion.mAcm_AxSetSvOn(m_Axishand[index], 1);
        }
        public static uint UnalbleAxis()
        {

            return Motion.mAcm_AxSetSvOn(m_Axishand[index], 0);
        }

        public static SpeedInfoStuct GetSpeedInfo()
        {
             double axvellow = new double();
             speedInfo = new SpeedInfoStuct();

             ///获取当前最小速度
             if(Utils.Utils.Assert( Motion.mAcm_GetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxVelLow, ref axvellow))){

                 speedInfo.VelLow = axvellow;
                 speedInfo.flag = true;
             }
             else
             {

                 speedInfo.flag = false;
             }

             ///获取当前最大速度
             if (Utils.Utils.Assert(Motion.mAcm_GetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxVelHigh, ref axvellow)))
             {

                 speedInfo.VelHigh = axvellow;
                 speedInfo.flag = true;
             }
             else
             {

                 speedInfo.flag = false;
             }

             ///获取当前加速度
             if (Utils.Utils.Assert(Motion.mAcm_GetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxAcc, ref axvellow)))
             {

                 speedInfo.Acc = axvellow;
                 speedInfo.flag = true;
             }
             else
             {

                 speedInfo.flag = false;
             }


             ///获取当前减速度
             if (Utils.Utils.Assert(Motion.mAcm_GetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxDec, ref axvellow)))
             {

                 speedInfo.Dec = axvellow;
                 speedInfo.flag = true;
             }
             else {

                 speedInfo.flag = false;
             }





             return speedInfo;
        }


        private static bool SetSpeedInfo(SpeedInfoStuct si)
        {
          
       

            ///获取当前最小速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxVelLow, si.VelLow)))
            {

             
              

                return  false;
            }

            ///获取当前最大速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxVelHigh, si.VelHigh)))
            {

            
           

                return  false;
            }

            ///获取当前加速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxAcc, si.Acc)))
            {

              
           

                return  false;
            }


            ///获取当前减速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxDec, si.Dec)))
            {

            
            
                return  false;
            }





            return true;
        }
        private static bool SetSpeedRelInfo(SpeedInfoStuct si)
        {



            ///获取当前最小速度
            if (!Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_RbVelLow, si.VelLow)))
            {




                return false;
            }

            ///获取当前最大速度
            if (Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_RbVelHigh, si.VelHigh)))
            {




                return false;
            }

            ///获取当前加速度
            if (Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_RbAcc, si.Acc)))
            {


                return false;
            }


            ///获取当前减速度
            if (Utils.Utils.Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_RbDec, si.Dec)))
            {



                return false;
            }





            return true;
        }


        public static bool SetBaseParmeter(Model model) {

            bool flag = SetSpeedInfo(model.SpeeedInfo);

            if (flag == true) {

               return  SetSpeedMode(model.SpeedMode);
            }

            return false;
        }

        public static bool SetSpeedMode(int AxJerk)
        {

            
            switch (AxJerk)
            {
                case 0: return Utils.Utils .Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxJerk, AxJerk));
                case 1: return   Utils.Utils .Assert(Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxJerk, AxJerk));

            }
            return false;
        }

        public static uint SetSpeedRBMode(int AxJerk)
        {

            switch (AxJerk)
            {
                case 0: Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_RbJerk, AxJerk); break;
                case 1: Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_RbJerk, AxJerk); break;

            }
            return 0;
        }
        
        
        public static uint MoveMode(int model, ushort dir, int moveAbs, double position = 0)
        {

            switch (model)
            {
                case 0: Motion.mAcm_AxJog(m_Axishand[index], dir); Motion.mAcm_AxMoveRel(m_Axishand[index], position); ; break;
                case 1: Motion.mAcm_AxMoveVel(m_Axishand[index],dir); break;
                case 2: Motion.mAcm_SetF64Property(m_Axishand[index], (uint)PropertyID.PAR_AxJerk, model); break;
//Motion.mAcm_AxMoveVel(m_Axishand[index],dir);
            }
            return 0;
        }

        public static bool StopAxis() {

           
            return Utils.Utils.Assert(Motion.mAcm_AxStopDec(m_Axishand[index]));
        }


        public static List<DeviceAxis> m_ActiveDevice = new List<DeviceAxis>();
        public static SpeedInfoStuct speedInfo;
        public static DEV_LIST[] CurAvailableDevs = new DEV_LIST[Motion.MAX_DEVICES];
        public static uint deviceCount = 0;
        public static uint DeviceNum = 0;
        public static IntPtr m_DeviceHandle = IntPtr.Zero;
        public static IntPtr[] m_Axishand = new IntPtr[32];
        public static uint m_ulAxisCount = 0;
        public static bool m_bInit = false;
        public static bool m_bServoOn = false;
        public static uint AxesPerDev = new uint();
        public static int index;


    }

    public struct DeviceAxis {

        public uint DeviceNum;
        public List<IntPtr> AxisActList;
    }
  
}
