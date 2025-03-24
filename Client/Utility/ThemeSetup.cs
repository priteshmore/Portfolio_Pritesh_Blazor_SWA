using BlazorApp.Client.Theme;
using BlazorApp.Client.Theme.Enum;
using MudBlazor;

namespace BlazorApp.Client.Utility
{
    public class ThemeSetup
    {
        public MudTheme CurrentTheme { get; set; }

        public ThemeSelector SelectedTheme { get; set; } = ThemeSelector.Default;

        public ThemeSetup()
        {
            //CurrentTheme = GetTheme();
        }

        #region New Theme

        public MudTheme GetTheme(ThemeSelector enTheme )
        {
            MudTheme objTheme = null;


            switch (enTheme)
            {
                case ThemeSelector.Default:
                    objTheme = new Red();
                    break;
                case ThemeSelector.Skyblue:
                    objTheme = new SkyBlue();
                    break;
                default:
                    objTheme = new Red();
                    break;
            }

            return objTheme;
        }
        #endregion
    }
}
