using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace 摄像头控制
{
    /// <summary>
    /// 视频API类
    /// </summary>
    class VideoAPI
    {
        //视频API调用
        [DllImport("avicap32.dll")]
        public static extern IntPtr capCreateCaptureWindowA(byte[] lpszWindowName,
            int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, int nID);
        [DllImport("avicap32.dll")]
        public static extern bool capGetDriverDescriptionA(short wDriver, byte[] lpszName, int cbName, byte[] lpszVer, int cbVer);
        [DllImport("User32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);
        [DllImport("User32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int wMsg, short wParam, int lParam);

        //常量
        public const int WM_user = 0x400;
        public const int WS_child = 0x40000000;
        public const int WS_visible = 0x10000000;
        public const int SWP_noMove = 0x2;
        public const int SWP_noZorder = 0x4;
        public const int WM_cap_driver_connect = WM_user+10;
        public const int WM_cap_driver_disConnect = WM_user + 11;
        public const int WM_cap_set_callBack_frame = WM_user + 5;
        public const int WM_cap_set_preview = WM_user + 50;
        public const int WM_cap_set_previewRate= WM_user + 52;
        public const int WM_cap_set_videoFormat = WM_user + 45;
        public const int WM_cap_start=WM_user;
        public const int WM_cap_saveDib = WM_cap_start+25;
        public const int WM_cap_file_set_capture_fileA = WM_cap_start + 20;
        public const int WM_cap_sequence = WM_cap_start + 62;
        public const int WM_cap_stop = WM_cap_start + 68;

    }

    /// <summary>
    /// 视频类
    /// </summary>
    public class CVideo
    {
        private IntPtr lwndC;//保存无符号句柄
        IntPtr mControlPtr;//保存管理指示器
        int mWidth;
        int mHeight;

        public CVideo(IntPtr handle, int width, int height)
        {
            mControlPtr = handle;
            mWidth = width;
            mHeight = height;
        }

        /// <summary>
        /// 打开视频设备
        /// </summary>
        public void StartWebCam()
        {
            byte[] lpszName = new byte[100];
            byte[] lpszVer = new byte[100];
            VideoAPI.capGetDriverDescriptionA(0, lpszName, 100, lpszVer, 100);
            this.lwndC = VideoAPI.capCreateCaptureWindowA(lpszName, VideoAPI.WS_child | VideoAPI.WS_visible, 0, 0, mWidth, mHeight, mControlPtr, 0);
            if (VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_driver_connect, 0, 0))
            {
                VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_set_previewRate, 100, 0);
                VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_set_preview, true, 0);
            }
        }

        /// <summary>
        /// 关闭视频设备
        /// </summary>
        public void CloseWebCam()
        {
            VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_driver_disConnect, 0, 0);
        }

        /// <summary>
        /// 拍照
        /// </summary>
        /// <param name="hWndC"></param>
        /// <param name="path">要保存bmp文件的路径</param>
        public void GrabImage(IntPtr hWndC,string path)
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(path);//排序
            VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_saveDib, 0, hBmp.ToInt32());
        }

        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="path">要保存录像的路径</param>
        public void StartVideoRecord(string path)
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(path);
            VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_file_set_capture_fileA, 0, hBmp.ToInt32());
            VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_sequence, 0, 0);
        }


        public void StopVideoRecord()
        {
            VideoAPI.SendMessage(lwndC, VideoAPI.WM_cap_stop, 0, 0);
        }
    }
}
