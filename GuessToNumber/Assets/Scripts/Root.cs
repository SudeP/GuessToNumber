#pragma warning disable // for name rules
public static class Root
{
    public static AudioSystem audio => AudioSystem.instance;
    public static SceneType scene = SceneType.HeapScene;
}
#pragma warning restore