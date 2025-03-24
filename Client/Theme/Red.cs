using MudBlazor;

namespace BlazorApp.Client.Theme
{
    public class Red : MudTheme
    {
        public Red()
        {
            // Dark theme palette with red tones
            PaletteDark objDark = new()
            {
                Primary = "#F44336",  // Vibrant Red
                Surface = "#1E1E2D",  // Dark Grey
                Background = "#121212",  // Very Dark Background
                BackgroundGray = "#2C2C3C",  // Darker Gray for secondary backgrounds
                AppbarText = "#E0E0E0",  // Light Grey Text for AppBar
                AppbarBackground = "rgba(18, 18, 18, 0.9)",  // Dark semi-transparent background for app bar
                DrawerBackground = "#181818",  // Dark Drawer Background
                ActionDefault = "#BDBDBD",  // Default Action Color (Light Gray)
                ActionDisabled = "#9E9E9E",  // Disabled Action Color
                ActionDisabledBackground = "#616161",  // Disabled Background Color
                TextPrimary = "#E0E0E0",  // Light Grey Text
                TextSecondary = "#B0B0B0",  // Secondary Light Text
                TextDisabled = "#BDBDBD",  // Disabled Text
                DrawerIcon = "#E0E0E0",  // Light Icon Color for Drawer
                DrawerText = "#E0E0E0",  // Light Text Color for Drawer
                GrayLight = "#424242",  // Light Gray for Sections
                GrayLighter = "#616161",  // Lighter Gray for Background Sections
                Info = "#FF4081",  // Vibrant Pink for Info
                Success = "#4CAF50",  // Green for Success
                Warning = "#FFEB3B",  // Yellow for Warning
                Error = "#F44336",  // Red for Error
                LinesDefault = "#3E3E3E",  // Default Line Color
                TableLines = "#616161",  // Table Lines
                Divider = "#424242",  // Divider Color
                OverlayLight = "#00000080",  // Light Overlay for Dark Mode
            };

            // Light theme palette with soft red tones
            PaletteLight ObjLight = new()
            {
                Primary = "#FF1744",  // Vibrant Red
                Surface = "#FFCDD2",  // Light Red Surface
                Background = "#FFEBEE",  // Soft Light Red Background
                BackgroundGray = "#FFCCCB",  // Soft Pinkish Gray for secondary backgrounds
                AppbarText = "#212121",  // Dark Text for AppBar
                AppbarBackground = "rgba(255, 255, 255, 0.9)",  // Light semi-transparent background for app bar
                DrawerBackground = "#FFCDD2",  // Light Red Drawer Background
                ActionDefault = "#616161",  // Default Action Color (Dark Gray)
                ActionDisabled = "#BDBDBD",  // Disabled Action Color
                ActionDisabledBackground = "#E0E0E0",  // Disabled Background Color
                TextPrimary = "#212121",  // Dark Text for Primary Text
                TextSecondary = "#757575",  // Dark Gray for Secondary Text
                TextDisabled = "#BDBDBD",  // Disabled Text
                DrawerIcon = "#212121",  // Dark Icon Color for Drawer
                DrawerText = "#212121",  // Dark Text Color for Drawer
                GrayLight = "#BDBDBD",  // Light Gray for Sections
                GrayLighter = "#E0E0E0",  // Lighter Gray for Background Sections
                Info = "#FF4081",  // Vibrant Pink for Info
                Success = "#00C853",  // Bright Green for Success
                Warning = "#FF9100",  // Bright Orange for Warning
                Error = "#D50000",  // Bright Red for Error
                LinesDefault = "#BDBDBD",  // Default Line Color
                TableLines = "#E0E0E0",  // Table Lines
                Divider = "#BDBDBD",  // Divider Color
                OverlayLight = "#FFFFFF80",  // Light Overlay for Light Mode
            };

            // Assign the updated palettes to the theme
            PaletteLight = ObjLight;
            PaletteDark = objDark;
        }
    }


}
