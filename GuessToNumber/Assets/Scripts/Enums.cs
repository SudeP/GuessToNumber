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
/// <summary>
/// All Scenes
/// </summary>
public enum SceneType
{
    None,
    HeapScene,
    HomeScene,
    NewGameScene,
    JoinGameScene,
    GameScene
}
/// <summary>
/// GameObjec Tags
/// </summary>
public static class Tags
{
    public const string audioSourceEnabled = "audioSourceEnabled";
    public const string canvasHeap = "canvasHeap";
    public const string canvasHome = "canvasHome";
}