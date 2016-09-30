using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Advantech.Motion;
using System.Windows.Forms;

namespace MontionUntity.Utils
{
    class Utils
    {

        public static  void ShowMessages(string DetailMessage, uint errorCode)
        {
            StringBuilder ErrorMsg = new StringBuilder("", 100);
            //Get the error message according to error code returned from API
            Boolean res = Motion.mAcm_GetErrorMessage(errorCode, ErrorMsg, 100);
            string ErrorMessage = "";
            if (res)
                ErrorMessage = ErrorMsg.ToString();
            MessageBox.Show(DetailMessage + "\r\nError Message:" + ErrorMessage, "Home", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Assert(uint Result)
        {
            if (Result != (uint)ErrorCode.SUCCESS)
            {
                string strTemp = "Open Device Failed With Error Code: [0x" + Convert.ToString(Result, 16) + "]";
                ShowMessages(strTemp, Result);
                return false;
            }

            return true;
        }
    }
}
