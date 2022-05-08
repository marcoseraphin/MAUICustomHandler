using System;
namespace NextMAUIApp
{
    public partial class CustomEntryHandler : Entry
    {
        public static void Handle()
        {
            CustomHandle();
        }

        static partial void CustomHandle();
    }
}

