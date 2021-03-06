﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

using NFX.Graphics;

namespace NFX.PAL.Graphics
{
  /// <summary>
  /// Provides functions for working with Images
  /// </summary>
  public interface IPALGraphics
  {
    bool CanvasOwnsAssets { get;}

    IPALImage CreateImage(string fileName);
    IPALImage CreateImage(byte[] data);
    IPALImage CreateImage(Stream stream);
    IPALImage CreateImage(Size size, Size resolution, ImagePixelFormat pixFormat);
  }
}
