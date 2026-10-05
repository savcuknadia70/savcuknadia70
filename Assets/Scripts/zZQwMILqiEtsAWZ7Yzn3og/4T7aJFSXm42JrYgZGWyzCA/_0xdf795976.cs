using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xdf795976 : MonoBehaviour
{
    private static readonly List<_0xdf795976> _0xf1567529 = new();
    private static UnityEvent _0xaab12e3c = new();
    private void Update()
    {
        if (_0xf1567529.Count == 0 || _0xf1567529[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x39ac7f49)
            OrientationChanged();
        if (Screen.safeArea != _0xe2c8f216)
            SafeAreaChanged();
        if (Screen.width != _0x88d56f7d.x || Screen.height != _0x88d56f7d.y)
            ResolutionChanged();
    }

    private static void OrientationChanged()
    {
        _0x39ac7f49 = Screen.orientation;
        _0x88d56f7d.x = Screen.width;
        _0x88d56f7d.y = Screen.height;
        _0xe2c8f216 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xaab12e3c.Invoke();
    }

    private void Awake()
    {
        if (!_0xf1567529.Contains(this))
            _0xf1567529.Add(this);
        this._0xd91c276a = this.GetComponent<Canvas>();
        this._0x2de9b8e5 = this.GetComponent<CanvasScaler>();
        if (this._0x2de9b8e5 != null)
            this._0xdb178561 = this._0x2de9b8e5.referenceResolution;
        this._0x97d47012 = this.GetComponent<RectTransform>();
        this._0x9e8d1ae4 = this.transform.Find(_0x730a0ef2._0x542c4651(new byte[8] { 93, 111, 104, 107, 79, 124, 107, 111 }, 14)) as RectTransform;
        if (!_0xb7b3b2ef)
        {
            _0x39ac7f49 = Screen.orientation;
            _0x88d56f7d.x = Screen.width;
            _0x88d56f7d.y = Screen.height;
            _0xe2c8f216 = Screen.safeArea;
            _0xb7b3b2ef = true;
        }

        this._0x3635d491();
    }

    private Vector2 _0xdb178561;
    private RectTransform _0x97d47012;
    private void Start()
    {
    }

    private static ScreenOrientation _0x39ac7f49 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x9e8d1ae4;
    private static Vector2 _0x88d56f7d = Vector2.zero;
    private Canvas _0xd91c276a;
    private CanvasScaler _0x2de9b8e5;
    private static void SafeAreaChanged()
    {
        _0xe2c8f216 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void ResolutionChanged()
    {
        _0x88d56f7d.x = Screen.width;
        _0x88d56f7d.y = Screen.height;
        _0xe2c8f216 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xaab12e3c.Invoke();
    }

    private void OnDestroy()
    {
        if (_0xf1567529 != null && _0xf1567529.Contains(this))
            _0xf1567529.Remove(this);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0xc67d2916 = 0; _0xc67d2916 < _0xf1567529.Count; _0xc67d2916++)
            _0xf1567529[_0xc67d2916]._0x3635d491();
    }

    private void _0x3635d491()
    {
        if (this._0x9e8d1ae4 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xc0bfbe2a = Screen.safeArea;
        Vector2 _0xc95a5a00 = _0xc0bfbe2a.position;
        Vector2 _0x7626e067 = _0xc0bfbe2a.position + _0xc0bfbe2a.size;
        _0xc95a5a00.x /= screenWidth;
        _0xc95a5a00.y /= screenHeight;
        _0x7626e067.x /= screenWidth;
        _0x7626e067.y /= screenHeight;
        this._0x9e8d1ae4.anchorMin = _0xc95a5a00;
        this._0x9e8d1ae4.anchorMax = _0x7626e067;
        this._0x9e8d1ae4.offsetMin = Vector2.zero;
        this._0x9e8d1ae4.offsetMax = Vector2.zero;
        if (this._0x2de9b8e5 == null)
            return;
        Vector2 _0xf2bc5c51 = _0x7626e067 - _0xc95a5a00;
        float _0xa83724fd = 2f - _0xf2bc5c51.x;
        float _0x059a5a37 = 2f - _0xf2bc5c51.y;
        this._0x2de9b8e5.referenceResolution = this._0xdb178561 * new Vector2(_0xa83724fd, _0x059a5a37);
    }

    private static Rect _0xe2c8f216 = Rect.zero;
    private static bool _0xb7b3b2ef;
}

internal static class _0x730a0ef2
{
    internal static string _0x542c4651(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}