using Mechanism.Wpf.Core.Skinning;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Mechanism.Wpf.Styles.Shale
{
    public class ShaleSkinAssemblyInfo : SkinAssemblyInfo
    {
        public ShaleSkinAssemblyInfo()
        {
            SettingsPage = new ShaleSettingsPage(this);
        }

        public bool HaveSettingsChanged = false;

        public bool UseLightTheme = true;

        public double Hue = ShaleAccents.Sunlight.Hue;
        public double Saturation = ShaleAccents.Sunlight.Saturation;

        public ShaleAccent Accent = new ShaleAccent(ShaleAccents.Sunlight.Hue, ShaleAccents.Sunlight.Saturation);

        /*public virtual bool GetHaveSettingsChanged()
        {
            return HaveSettingsChanged;
        }*/

        /*public virtual Page GetSettingsPage()
        {
            if (_page == null)
                _page = new ShaleSettingsPage(this);

            return _page;
        }*/

        public override ResourceDictionary GetSkinDictionary()
        {
            ResourceDictionary dictionary = new ResourceDictionary()
            {
                Source = new Uri("/Mechanism.Wpf.Styles.Shale;component/Themes/Shale.xaml", UriKind.Relative)
            };

            if (UseLightTheme)
                dictionary.MergedDictionaries[0].Source = new Uri("/Mechanism.Wpf.Styles.Shale;component/Themes/Colors/BaseLight.xaml", UriKind.Relative);
            else
                dictionary.MergedDictionaries[0].Source = new Uri("/Mechanism.Wpf.Styles.Shale;component/Themes/Colors/BaseDark.xaml", UriKind.Relative);

            Accent.Hue = Hue;
            Accent.Saturation = Saturation;

            dictionary.MergedDictionaries[1] = Accent.Dictionary;

            HaveSettingsChanged = false;
            return dictionary;
        }

        public override void LoadSkinSettings(string inputDirectory)
        {
            Debug.WriteLine("SHALE SETTINGS LOADING NOT YET IMPLEMENTED");
        }

        public override void SaveSkinSettings(string outputDirectory)
        {
            Debug.WriteLine("SHALE SETTINGS SAVING NOT YET IMPLEMENTED");
        }

        public override void ResetSkinSettings()
        {
            Debug.WriteLine("SHALE SETTINGS RESET NOT YET IMPLEMENTED");
        }

        /*string ISkinInfo.SkinName
        {
            get => "Shale";
        }*/
    }
}
