﻿namespace mRemoteNG.Messages.MessageWriters
{
    public class MessageTypeFilteringOptions : IMessageTypeFilteringOptions
    {
        public bool AllowDebugMessages { get; set; }
        public bool AllowInfoMessages { get; set; }
        public bool AllowWarningMessages { get; set; }
        public bool AllowErrorMessages { get; set; }
    }
}
