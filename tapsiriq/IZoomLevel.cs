using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq
{
    interface IZoomLevel
    {
        int ZoomLevel
        { get; set; }

        void ZoomIn();
        void ZoomOut();

    }
}
