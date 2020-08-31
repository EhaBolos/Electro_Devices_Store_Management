using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    interface Camera
    {
        camModels CamModel
        {
            get;
        }
        int CamPixels
        {
            get;
        }
        float Zoom
        {
            get;
        }
        int F
        {
            get;
        }
        float CamPrice
        {
            get;
        }
        string CameraToString();
    }
}
