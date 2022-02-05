/// <summary>
/// audioClip types for AudioSystem
/// </summary>
public enum AudioType
{
    None,
    Click,
    Win,
    Lose
}
public enum SceneType
{
    None,
    HeapScene,
    HomeScene,
    NewGameScene,
    JoinGameScene,
    GameScene
}
public static class Tags
{
    public const string audioSourceEnabled = "audioSourceEnabled";
    public const string canvasHeap = "canvasHeap";
    public const string canvasHome = "canvasHome";
}