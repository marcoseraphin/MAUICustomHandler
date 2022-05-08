using System;
using Android.Content.Res;

namespace NextMAUIApp
{
    public partial class CustomEntryHandler
    {
        static partial void CustomHandle()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry.BackgroundColor), (h, v) =>
            {
                if (v is CustomEntryHandler)
                {
                    h.PlatformView.SetBackgroundColor(Android.Graphics.Color.Green);
                }
            });
        }
    }
}

