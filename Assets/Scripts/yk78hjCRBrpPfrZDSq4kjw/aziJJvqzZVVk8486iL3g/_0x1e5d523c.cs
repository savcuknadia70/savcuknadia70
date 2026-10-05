using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x7a51889f;

public class _0x1e5d523c : MonoBehaviour
{
    public Transform Environment;
    public void _0x98d634c7()
    {
        foreach (_0x96e5f929 _0x464345a2 in this.MoneyCountContainers)
            _0x464345a2._0xd6044ed1();
    }

    public static bool IsAfterLevelComplete;
    private static _0x3cc76443 GAME_INDEX_SETTINGS(int _0xec6c691b)
    {
        return _0x3cc76443.ALL_SCENES_SETTING_SINGLETONS[_0xec6c691b];
    }

    private IEnumerator _0x3f85e8b9(int _0xbc865304)
    {
        _0x146cc450.Instance._0x52c81cdc(_0x072f746b.SPLASH);
        AsyncOperation _0x3f173d74 = SceneManager.LoadSceneAsync(_0xbc865304);
        while (!_0x3f173d74.isDone)
            yield return null;
    }

    public void _0x93e5a822()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public bool _0x5c41302d { get; private set; }
    private static _0x3cc76443 _0xf82b7975 => _0x3cc76443.ALL_SCENES_SETTING_SINGLETONS[0];

    private void _0x4a9c1325()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x628a7dd7.SCENE_0);
    }

    public static _0x3cc76443 _0x2b639aa9 => _0x3cc76443.ALL_SCENES_SETTING_SINGLETONS[Instance._0x47b53557];

    public void _0x56411c3c(bool _0x3d5518df)
    {
        this._0x5c41302d = _0x3d5518df;
        this._0xfbb62a4e(!this._0x5c41302d);
        Physics2D.simulationMode = this._0x5c41302d ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xb6925207(this.EnvironmentWithTweensToToggle);
    }

    private static void MakeGrid(List<RectTransform> _0xe8fe404f, AspectRatioFitter _0x1dac9921, float _0x4e77d4a8, int _0xe4c63e98, int _0xa082ddb2)
    {
        _0x1dac9921.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x1dac9921.aspectRatio = _0x4e77d4a8;
        foreach (RectTransform _0xe9dd3985 in _0xe8fe404f)
        {
            int _0xdc918ed3 = _0xe9dd3985.transform.GetSiblingIndex();
            _0xe9dd3985.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xdc918ed3 % _0xe4c63e98) * (1f / _0xe4c63e98), (_0xa082ddb2 - (Mathf.FloorToInt((float)_0xdc918ed3 / _0xe4c63e98) % _0xa082ddb2 + 1f)) * (1f / _0xa082ddb2));
            _0xe9dd3985.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xdc918ed3 % _0xe4c63e98 + 1f) * (1f / _0xe4c63e98), (_0xa082ddb2 - Mathf.FloorToInt((float)_0xdc918ed3 / _0xe4c63e98) % _0xa082ddb2) * (1f / _0xa082ddb2));
            _0xe9dd3985.offsetMin = Vector2.zero;
            _0xe9dd3985.offsetMax = Vector2.zero;
        }
    }

    private void _0xb6925207(Transform _0x64737b4b)
    {
        Transform[] _0x26baaecf = _0x64737b4b.GetComponentsInChildren<Transform>();
        foreach (Transform _0x3240684d in _0x26baaecf)
            if (_0x3240684d != null && DOTween.IsTweening(_0x3240684d))
            {
                if (this._0x5c41302d)
                    DOTween.Play(_0x3240684d);
                else
                    DOTween.Pause(_0x3240684d);
            }
    }

    public static bool IsAfterLevelFailed = false;
    public int _0x47b53557 => SceneManager.GetActiveScene().buildIndex;

    [HideInInspector]
    public List<_0x96e5f929> MoneyCountContainers = new();
    public Transform EnvironmentWithTweensToToggle;
    private void Start()
    {
        if (this._0x47b53557 != _0x628a7dd7.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x628a7dd7.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x2b639aa9._0xc797e80d = false;
            _0x8e6d2614.Instance._0x47cdbdca();
            _0x146cc450.Instance._0x52c81cdc(_0x072f746b.TUTORIAL0);
        });
    }

    public void _0xe41c2230()
    {
        _0x2b639aa9._0xc797e80d = true;
    }

    private void _0xfbb62a4e(bool _0xf646d9f2)
    {
        Rigidbody2D[] _0x44c47dd7 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x449c79a8 in _0x44c47dd7)
            if (_0xf646d9f2)
                _0x449c79a8.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x449c79a8.constraints = RigidbodyConstraints2D.None;
    }

    private IEnumerator _0x6ec8b2ff(string _0x66656326)
    {
        _0x146cc450.Instance._0x52c81cdc(_0x072f746b.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xc4283bdd = SceneManager.LoadSceneAsync(_0x66656326);
        while (!_0xc4283bdd.isDone)
            yield return null;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x1e5d523c>();
        this.RootGameObject = GameObject.FindWithTag(_0xb3045c08._0x2842923a(new byte[4] { 231, 218, 218, 193 }, 181));
        if (this._0x47b53557 == _0x628a7dd7.SCENE_0)
            this._0x56411c3c(true);
        else
            this._0x56411c3c(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x96e5f929>(true).ToList();
    }

    public Button ShowResetTutorialButton;
    public Canvas MainCanvas;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static _0x1e5d523c Instance;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void LoadSceneByIndex(int _0xc85e3fa3)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x3f85e8b9(_0xc85e3fa3));
    }

    public Button DeleteProgressDataButton;
}

internal static class _0xb3045c08
{
    internal static string _0x2842923a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}