using System;

namespace WalkMeXamariniOSBinding
{
    public enum ABBIAppType : uint
    {
        Native = 10,
        Hybrid = 11,
        Cocos2d = 12,
        Unity = 13,
        Max = 14
    }

    public enum WMStatsEventType : uint
    {
        SessionStarted,
        SessionStop,
        AppTerminated,
        AppEnteredFg,
        AppEnteredBg,
        PromoImp,
        PromoClk,
        StepImp,
        StepClk,
        Goal,
        ViewTransition,
        Users,
        OnboardingItemCompleted
    }


    public enum WMProxyOptionMode : uint
    {
        All = 0,
        Analytics = 1
    }
}
