using System;
namespace NextMAUIApp
{
    public partial class CustomEntryHandler
    {
        static partial void CustomHandle()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IEntry.Background), (h, v) =>
            {
                if (v is CustomEntryHandler)
                {
                    h.PlatformView.BackgroundColor = UIKit.UIColor.LightGray;
                }
            });
        }
    }
}

