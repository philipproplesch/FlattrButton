using System.IO;
using System.Threading;
using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace PhilipProplesch.WLW.FlattrButton
{
    [WriterPlugin("97DC180D-8B6F-4787-91AC-8EAC9C4787D0", "Flattr button",
        ImagePath = "flattr.png",
        PublisherUrl = "http://philipproplesch.de/",
        HasEditableOptions = true,
        Description = "Embeds the Flattr button in your blog posts.")]
    public class FlattrHeaderFooterSource : HeaderFooterSource
    {
        private Settings _settings;
        public override void Initialize(IProperties pluginOptions)
        {
            base.Initialize(pluginOptions);
            _settings = new Settings(pluginOptions);
        }

        public override void EditOptions(IWin32Window dialogOwner)
        {
            var configuration = new Configuration(_settings);
            configuration.Show();
        }

        public override bool RequiresPermalink
        {
            get { return true; }
        }

        public override string GeneratePreviewHtml(ISmartContent smartContent, IPublishingContext publishingContext, out Position position)
        {
            return GenerateLink(smartContent, publishingContext, out position);
        }

        public override string GeneratePublishHtml(IWin32Window dialogOwner, ISmartContent smartContent, IPublishingContext publishingContext, bool publish, out Position position)
        {
            return GenerateLink(smartContent, publishingContext, out position);
        }

        private string GenerateLink(ISmartContent smartContent, IPublishingContext publishingContext, out Position position)
        {
            position = Position.Footer;

            string culture = Thread.CurrentThread.CurrentCulture.Name;
            if (culture.Contains("-"))
                culture = culture.Replace("-", "_");

            var stringWriter = new StringWriter();
            stringWriter.WriteLine("<script type=\"text/javascript\">");

            stringWriter.WriteLine("var flattr_uid = '{0}';", _settings.FlattrId);
            stringWriter.WriteLine("var flattr_tle = '{0}';", publishingContext.PostInfo.Title);
            stringWriter.WriteLine("var flattr_dsc = '{0}';", publishingContext.PostInfo.Contents);
            stringWriter.WriteLine("var flattr_cat = 'text';");
            stringWriter.WriteLine("var flattr_lng = '{0}';", culture);
            stringWriter.WriteLine("var flattr_tag = '';");
            stringWriter.WriteLine("var flattr_url = '{0}';", publishingContext.PostInfo.Permalink);
            stringWriter.WriteLine("var flattr_hide = 'false';");

            if (_settings.CompactMode)
                stringWriter.WriteLine("var flattr_btn = 'compact';");

            stringWriter.WriteLine("</script>");
            stringWriter.WriteLine("<script type=\"text/javascript\" src=\"http://api.flattr.com/button/load.js\"></script>");

            return stringWriter.ToString();
        }
    }
}
