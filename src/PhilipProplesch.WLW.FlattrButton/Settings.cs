using WindowsLive.Writer.Api;

namespace PhilipProplesch.WLW.FlattrButton
{
    public class Settings
    {
        private readonly IProperties _properties;
        private const string FLATTR_ID = "FlattrId";
        private const string COMPACT_MODE = "CompactMode";

        public Settings(IProperties properties)
        {
            _properties = properties;
        }

        public string FlattrId
        {
            get { return _properties.GetString(FLATTR_ID, string.Empty); }
            set { _properties.SetString(FLATTR_ID, value); }
        }

        public bool CompactMode
        {
            get { return _properties.GetBoolean(COMPACT_MODE, false); }
            set { _properties.SetBoolean(COMPACT_MODE, value); }
        }
    }
}
