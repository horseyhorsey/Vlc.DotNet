﻿using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public string GetVideoCropGeometry(VlcMediaPlayerInstance mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");

            return Utf8InteropStringConverter.Utf8InteropToString(GetInteropDelegate<GetVideoCropGeometry>().Invoke(mediaPlayerInstance));
        }
    }
}
