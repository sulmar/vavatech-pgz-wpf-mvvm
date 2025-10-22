namespace WpfApp.Controls;

public static class FeatureFlagService
{
    private static readonly HashSet<string> _enabledFlags = new()
    {
#if FEATURE_EXPORT
        "EXPORT",
#endif

#if FEATURE_ADMIN   
        "ADMIN",
#endif

#if FEATURE_DASHBOARD   
        "DASHBOARD",
#endif

    };

    public static bool IsEnabled(string feature) => _enabledFlags.Contains(feature);
   
}
