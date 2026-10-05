using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xb6de01a4 : MonoBehaviour
{
    private static void ResolutionChanged()
    {
        _0xea822f65.x = Screen.width;
        _0xea822f65.y = Screen.height;
        _0xf21263ed.Invoke();
    }

    private static ScreenOrientation _0xbefb547a = ScreenOrientation.LandscapeLeft;
    private static UnityEvent _0xf21263ed = new();
    private static readonly List<_0xb6de01a4> _0x741c0452 = new();
    private static Vector2 _0xea822f65 = Vector2.zero;
    private RectTransform _0x51d5455b;
    private static void OrientationChanged()
    {
        _0xbefb547a = Screen.orientation;
        _0xea822f65.x = Screen.width;
        _0xea822f65.y = Screen.height;
        _0xf21263ed.Invoke();
    }

    private void Update()
    {
        if (_0x741c0452[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xbefb547a)
            OrientationChanged();
        if (Screen.safeArea != _0x0639cbb2)
            SafeAreaChanged();
        if (Screen.width != _0xea822f65.x || Screen.height != _0xea822f65.y)
            ResolutionChanged();
    }

    private static bool _0x1f5081f6;
    private RectTransform _0xf4aed375;
    private static void SafeAreaChanged()
    {
        _0x0639cbb2 = Screen.safeArea;
        for (int _0xb6ea5816 = 0; _0xb6ea5816 < _0x741c0452.Count; _0xb6ea5816++)
            _0x741c0452[_0xb6ea5816]._0xf4c4b567();
    }

    private static Rect _0x0639cbb2 = Rect.zero;
    private void _0xf4c4b567()
    {
        if (this._0x51d5455b == null)
            return;
        Rect _0x34df1dc1 = Screen.safeArea;
        Vector2 _0x34e058ce = _0x34df1dc1.position;
        Vector2 _0x9a5f7f64 = _0x34df1dc1.position + _0x34df1dc1.size;
        _0x34e058ce.x /= this._0x9b2d6870.pixelRect.width;
        _0x34e058ce.y /= this._0x9b2d6870.pixelRect.height;
        _0x9a5f7f64.x /= this._0x9b2d6870.pixelRect.width;
        _0x9a5f7f64.y /= this._0x9b2d6870.pixelRect.height;
        this._0x51d5455b.anchorMin = _0x34e058ce;
        this._0x51d5455b.anchorMax = _0x9a5f7f64;
    }

    private void Awake()
    {
        if (!_0x741c0452.Contains(this))
            _0x741c0452.Add(this);
        this._0x9b2d6870 = this.GetComponent<Canvas>();
        this._0xf4aed375 = this.GetComponent<RectTransform>();
        this._0x51d5455b = this.transform.Find(_0x1aade7a2._0x1fe703d3(new byte[8] { 34, 16, 23, 20, 48, 3, 20, 16 }, 113)) as RectTransform;
        if (!_0x1f5081f6)
        {
            _0xbefb547a = Screen.orientation;
            _0xea822f65.x = Screen.width;
            _0xea822f65.y = Screen.height;
            _0x0639cbb2 = Screen.safeArea;
            _0x1f5081f6 = true;
        }

        this._0xf4c4b567();
    }

    private void OnDestroy()
    {
        if (_0x741c0452 != null && _0x741c0452.Contains(this))
            _0x741c0452.Remove(this);
    }

    private Canvas _0x9b2d6870;
}

internal static class _0x1aade7a2
{
    internal static string _0x1fe703d3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}