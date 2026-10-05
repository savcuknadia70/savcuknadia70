using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xd7e7680b : MonoBehaviour
{
    private Touch? _0x52075d1c(Bounds _0xbe07d1d9, TouchPhase _0x516867e6)
    {
        if (!_0x1e5d523c.Instance._0x5c41302d)
            return null;
        foreach (Touch _0xad14dc71 in Touch.activeTouches)
            if (_0xad14dc71.phase == _0x516867e6)
            {
                Vector3 _0x6fc88da7 = Camera.main.ScreenToWorldPoint(_0xad14dc71.screenPosition);
                Vector3 _0x1924c70a = new(_0x6fc88da7.x, _0x6fc88da7.y, _0xbe07d1d9.center.z);
                if (_0xbe07d1d9.Contains(_0x1924c70a) && this._0xd23afb03(_0xad14dc71))
                    return _0xad14dc71;
            }

        return null;
    }

    private static _0xd7e7680b _0xfe10a665;
    private Touch? _0x9d3d13a4(Bounds _0xc3de7258)
    {
        if (!_0x1e5d523c.Instance._0x5c41302d)
            return null;
        foreach (Touch _0x46cb3436 in Touch.activeTouches)
            if (!_0x46cb3436.ended)
            {
                Vector3 _0x9420ffab = Camera.main.ScreenToWorldPoint(_0x46cb3436.screenPosition);
                Vector3 _0x1e8a6696 = new(_0x9420ffab.x, _0x9420ffab.y, _0xc3de7258.center.z);
                if (_0xc3de7258.Contains(_0x1e8a6696) && this._0xd23afb03(_0x46cb3436))
                    return _0x46cb3436;
            }

        return null;
    }

    private Touch? _0xe5e3ba08(Bounds _0xf3707679)
    {
        if (!_0x1e5d523c.Instance._0x5c41302d)
            return null;
        foreach (Touch _0xf8a8ffb1 in Touch.activeTouches)
            if (_0xf8a8ffb1.ended)
            {
                Vector3 _0x0906d24c = Camera.main.ScreenToWorldPoint(_0xf8a8ffb1.screenPosition);
                Vector3 _0x70028d06 = new(_0x0906d24c.x, _0x0906d24c.y, _0xf3707679.center.z);
                if (_0xf3707679.Contains(_0x70028d06) && this._0xd23afb03(_0xf8a8ffb1))
                    return _0xf8a8ffb1;
            }

        return null;
    }

    private bool _0x9645d0ff(Touch? _0x528bcfef, Bounds _0x46f6a3d6, TouchPhase _0x2e5344b8)
    {
        if (!_0x1e5d523c.Instance._0x5c41302d)
        {
            _0x528bcfef = null;
            return false;
        }

        if (_0x528bcfef != null)
            if (_0x528bcfef.Value.phase == _0x2e5344b8)
            {
                Vector3 _0x6fc69712 = Camera.main.ScreenToWorldPoint(_0x528bcfef.Value.screenPosition);
                Vector3 _0xde56188c = new(_0x6fc69712.x, _0x6fc69712.y, _0x46f6a3d6.center.z);
                if (_0x46f6a3d6.Contains(_0xde56188c) && this._0xd23afb03(_0x528bcfef.Value))
                    return true;
            }

        return false;
    }

    private bool _0xd23afb03(Touch? _0x36dc4072)
    {
        if (!_0x36dc4072.HasValue)
            return false;
        Vector3 _0x24f13b92 = Camera.main.ScreenToWorldPoint(_0x36dc4072.Value.screenPosition);
        Vector3 _0xe255481a = _0x24f13b92;
        _0xe255481a.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xe255481a))
            return true;
        _0x36dc4072 = null;
        return false;
    }

    private Touch? _0xb8c38244()
    {
        if (!_0x1e5d523c.Instance._0x5c41302d)
            return null;
        foreach (Touch _0x2259a78c in Touch.activeTouches)
            if (_0x2259a78c.ended)
                if (this._0xd23afb03(_0x2259a78c))
                    return _0x2259a78c;
        return null;
    }

    private Touch? _0xd499cab8()
    {
        if (!_0x1e5d523c.Instance._0x5c41302d)
            return null;
        foreach (Touch _0xf4280db6 in Touch.activeTouches)
            if (!_0xf4280db6.ended)
                if (this._0xd23afb03(_0xf4280db6))
                    return _0xf4280db6;
        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private void _0x93fa1c5f(Touch? _0x17eb565a)
    {
        if (!_0x1e5d523c.Instance._0x5c41302d)
        {
            _0x17eb565a = null;
            return;
        }

        int _0x19f7e1f7 = _0x17eb565a.Value.touchId;
        _0x17eb565a = Touch.activeTouches.FirstOrDefault(_0xd62781f3 => _0xd62781f3.touchId == _0x19f7e1f7);
        if (!this._0xd23afb03(_0x17eb565a.Value))
            _0x17eb565a = null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xfe10a665 = this.gameObject.GetComponent<_0xd7e7680b>();
    }
}