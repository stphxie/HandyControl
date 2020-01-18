﻿// ReSharper disable InconsistentNaming

namespace HandyControl.Tools.Interop
{
    internal enum SM
    {
        CXSCREEN = 0,
        CYSCREEN = 1,
        CXVSCROLL = 2,
        CYHSCROLL = 3,
        CYCAPTION = 4,
        CXBORDER = 5,
        CYBORDER = 6,
        CXFIXEDFRAME = 7,
        CYFIXEDFRAME = 8,
        CYVTHUMB = 9,
        CXHTHUMB = 10,
        CXICON = 11,
        CYICON = 12,
        CXCURSOR = 13,
        CYCURSOR = 14,
        CYMENU = 15,
        CXFULLSCREEN = 16,
        CYFULLSCREEN = 17,
        CYKANJIWINDOW = 18,
        MOUSEPRESENT = 19,
        CYVSCROLL = 20,
        CXHSCROLL = 21,
        DEBUG = 22,
        SWAPBUTTON = 23,
        CXMIN = 28,
        CYMIN = 29,
        CXSIZE = 30,
        CYSIZE = 31,
        CXFRAME = 32,
        CXSIZEFRAME = CXFRAME,
        CYFRAME = 33,
        CYSIZEFRAME = CYFRAME,
        CXMINTRACK = 34,
        CYMINTRACK = 35,
        CXDOUBLECLK = 36,
        CYDOUBLECLK = 37,
        CXICONSPACING = 38,
        CYICONSPACING = 39,
        MENUDROPALIGNMENT = 40,
        PENWINDOWS = 41,
        DBCSENABLED = 42,
        CMOUSEBUTTONS = 43,
        SECURE = 44,
        CXEDGE = 45,
        CYEDGE = 46,
        CXMINSPACING = 47,
        CYMINSPACING = 48,
        CXSMICON = 49,
        CYSMICON = 50,
        CYSMCAPTION = 51,
        CXSMSIZE = 52,
        CYSMSIZE = 53,
        CXMENUSIZE = 54,
        CYMENUSIZE = 55,
        ARRANGE = 56,
        CXMINIMIZED = 57,
        CYMINIMIZED = 58,
        CXMAXTRACK = 59,
        CYMAXTRACK = 60,
        CXMAXIMIZED = 61,
        CYMAXIMIZED = 62,
        NETWORK = 63,
        CLEANBOOT = 67,
        CXDRAG = 68,
        CYDRAG = 69,
        SHOWSOUNDS = 70,
        CXMENUCHECK = 71,
        CYMENUCHECK = 72,
        SLOWMACHINE = 73,
        MIDEASTENABLED = 74,
        MOUSEWHEELPRESENT = 75,
        XVIRTUALSCREEN = 76,
        YVIRTUALSCREEN = 77,
        CXVIRTUALSCREEN = 78,
        CYVIRTUALSCREEN = 79,
        CMONITORS = 80,
        SAMEDISPLAYFORMAT = 81,
        IMMENABLED = 82,
        CXFOCUSBORDER = 83,
        CYFOCUSBORDER = 84,
        TABLETPC = 86,
        MEDIACENTER = 87,
        REMOTESESSION = 0x1000,
        REMOTECONTROL = 0x2001
    }

    internal enum CacheSlot
    {
        DpiX,

        FocusBorderWidth,
        FocusBorderHeight,
        HighContrast,
        MouseVanish,

        DropShadow,
        FlatMenu,
        WorkAreaInternal,
        WorkArea,

        IconMetrics,

        KeyboardCues,
        KeyboardDelay,
        KeyboardPreference,
        KeyboardSpeed,
        SnapToDefaultButton,
        WheelScrollLines,
        MouseHoverTime,
        MouseHoverHeight,
        MouseHoverWidth,

        MenuDropAlignment,
        MenuFade,
        MenuShowDelay,

        ComboBoxAnimation,
        ClientAreaAnimation,
        CursorShadow,
        GradientCaptions,
        HotTracking,
        ListBoxSmoothScrolling,
        MenuAnimation,
        SelectionFade,
        StylusHotTracking,
        ToolTipAnimation,
        ToolTipFade,
        UIEffects,

        MinimizeAnimation,
        Border,
        CaretWidth,
        ForegroundFlashCount,
        DragFullWindows,
        NonClientMetrics,

        ThinHorizontalBorderHeight,
        ThinVerticalBorderWidth,
        CursorWidth,
        CursorHeight,
        ThickHorizontalBorderHeight,
        ThickVerticalBorderWidth,
        MinimumHorizontalDragDistance,
        MinimumVerticalDragDistance,
        FixedFrameHorizontalBorderHeight,
        FixedFrameVerticalBorderWidth,
        FocusHorizontalBorderHeight,
        FocusVerticalBorderWidth,
        FullPrimaryScreenWidth,
        FullPrimaryScreenHeight,
        HorizontalScrollBarButtonWidth,
        HorizontalScrollBarHeight,
        HorizontalScrollBarThumbWidth,
        IconWidth,
        IconHeight,
        IconGridWidth,
        IconGridHeight,
        MaximizedPrimaryScreenWidth,
        MaximizedPrimaryScreenHeight,
        MaximumWindowTrackWidth,
        MaximumWindowTrackHeight,
        MenuCheckmarkWidth,
        MenuCheckmarkHeight,
        MenuButtonWidth,
        MenuButtonHeight,
        MinimumWindowWidth,
        MinimumWindowHeight,
        MinimizedWindowWidth,
        MinimizedWindowHeight,
        MinimizedGridWidth,
        MinimizedGridHeight,
        MinimumWindowTrackWidth,
        MinimumWindowTrackHeight,
        PrimaryScreenWidth,
        PrimaryScreenHeight,
        WindowCaptionButtonWidth,
        WindowCaptionButtonHeight,
        ResizeFrameHorizontalBorderHeight,
        ResizeFrameVerticalBorderWidth,
        SmallIconWidth,
        SmallIconHeight,
        SmallWindowCaptionButtonWidth,
        SmallWindowCaptionButtonHeight,
        VirtualScreenWidth,
        VirtualScreenHeight,
        VerticalScrollBarWidth,
        VerticalScrollBarButtonHeight,
        WindowCaptionHeight,
        KanjiWindowHeight,
        MenuBarHeight,
        VerticalScrollBarThumbHeight,
        IsImmEnabled,
        IsMediaCenter,
        IsMenuDropRightAligned,
        IsMiddleEastEnabled,
        IsMousePresent,
        IsMouseWheelPresent,
        IsPenWindows,
        IsRemotelyControlled,
        IsRemoteSession,
        ShowSounds,
        IsSlowMachine,
        SwapButtons,
        IsTabletPC,
        VirtualScreenLeft,
        VirtualScreenTop,

        PowerLineStatus,

        IsGlassEnabled,
        UxThemeName,
        UxThemeColor,
        WindowCornerRadius,
        WindowGlassColor,
        WindowGlassBrush,
        WindowNonClientFrameThickness,
        WindowResizeBorderThickness,

        NumSlots
    }

    internal static class Win32Constant
    {
        internal const int MAX_PATH = 260;
        internal const int INFOTIPSIZE = 1024;
        internal const int TRUE = 1;
        internal const int FALSE = 0;
    }
}