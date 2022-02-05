using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHeap : CacheBehaviour<SceneHeap>
{
    [SerializeField] KeyValueData<bool, Sprite>[] buttonAudioSourceSprites;
    private void OnEnable()
    {
        // Scene load manage event import
        SceneManager.sceneLoaded += OperationCompletedLoadScene;
    }

    private void OnDisable()
    {
        // Scene load manage event export
        SceneManager.sceneLoaded -= OperationCompletedLoadScene;
    }

    private void Start()
    {
        DontDestroyOnLoad(
            Tags
                .canvasHeap
                .Tag()
        );

        //Load first Scene
        LoadScene(SceneType.HomeScene);
    }

    private void OperationCompletedLoadScene(Scene scene, LoadSceneMode loadSceneMode)
    {
        //Home Scene OnLoad set any proccess
        if (Root.scene == SceneType.HomeScene)
        {
            Tags
                .canvasHome
                .Tag()
                .Then<Canvas>()
                .worldCamera = gameObject.Then<Camera>();

            GameObject buttonAudio = Tags
                .audioSourceEnabled
                .Tag();

            buttonAudio
                .Then<Image>()
                .enabled = true;

            SetButtonAudioSourceSprite();
        }
    }

    private void SetButtonAudioSourceSprite()
    {
        KeyValueData<bool, Sprite> spiteData = buttonAudioSourceSprites
            .FirstOrDefault(x => x.key == Storage.GetAudioSourceEnabled());

        Tags
            .audioSourceEnabled
            .Tag()
            .Then<Image>()
            .sprite = spiteData.value;
    }

    /// <summary>
    /// Load new Scene (singeleton)
    /// </summary>
    /// <param name="sceneType"></param>
    public void LoadScene(SceneType sceneType)
    {
        Root.scene = sceneType;

        SceneManager.LoadSceneAsync(sceneType.ToString(), new LoadSceneParameters
        {
            loadSceneMode = LoadSceneMode.Single,
            localPhysicsMode = LocalPhysicsMode.Physics2D
        });
    }

    /// <summary>
    /// Right-Top button = Active or Inactive sounds
    /// </summary>
    public void ButtonOnClickSound()
    {
        Storage.SetAudioSourceEnabled(!Storage.GetAudioSourceEnabled());

        SetButtonAudioSourceSprite();
    }
}