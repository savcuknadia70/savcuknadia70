using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds the per-attempt layout of a run. Everything the player sees and reacts to
/// (sweep side, tempo, starting width, colour order, wind profile, bonus markers)
/// comes from a seeded System.Random, never from hard-coded coordinates.
/// </summary>
public sealed class _0x6568d0fb : MonoBehaviour
{
    public int _0xeb582b14 => this._0x53bef63d;

    private float _0xbc1c27ad;
    public float _0x614d9842 => this._0x13c946c9;

    private readonly List<float> _0x4ec16252 = new();
    [SerializeField]
    private float _baseWidthMin = 0.94f;
    [SerializeField]
    private int _maxAttempts = 20;
    public float _0x2a9cbde9 => this._0x03e895e8;

    private float _0x03e895e8 = 1f;
    public float _0xb39ab9b6 => this._0xaf30da7c;
    public float _0x038e753f => this._0xbc1c27ad;

    /// <summary>Generates a plan, verifies it is playable and falls back to a fixed one if not.</summary>
    public void _0xc08e284d(int _0x3af40a0c, int _0xdafb4e5f, int _0x9e1e89a5, int _0x7f56fa79, float _0x1f948985, float _0xf43ebd19, float _0x42ed0104)
    {
        this._0x53bef63d = (_0x3af40a0c * 7919) ^ (_0xdafb4e5f * 104729);
        System.Random _0x947bf37d = new System.Random(this._0x53bef63d);
        bool _0xe03feb0a = false;
        for (int _0xf57ef742 = 0; _0xf57ef742 < this._maxAttempts && !_0xe03feb0a; _0xf57ef742++)
        {
            this._0xa1d747e6(_0x947bf37d, _0x9e1e89a5, _0x7f56fa79);
            _0xe03feb0a = this._0x0027272e(_0x1f948985, _0xf43ebd19, _0x42ed0104);
        }

        if (!_0xe03feb0a)
        {
            this._0xd6686222(_0x9e1e89a5);
        }

        {
#if B_LOGS
            {
                Debug.Log($"[run] seed={this._0x53bef63d} modules={_0x9e1e89a5} wind={this._0xaf30da7c:0.00} playable={_0xe03feb0a}");
            }
#endif
        }
    }

    [SerializeField]
    private float _baseWidthMax = 1.06f;
    /// <summary>
    /// A plan is playable when the traverse still reaches across the tower top on both
    /// sides and the wind peak cannot make a perfect lock unreachable.
    /// </summary>
    private bool _0x0027272e(float _0x6a7232c4, float _0xcbae78bf, float _0xf903044c)
    {
        if (this._0xb929c2ab.Count == 0 || this._0x4ec16252.Count == 0 || this._0x9fbce828.Count < 3)
        {
            return false;
        }

        if (_0xcbae78bf < _0xf903044c * 0.7f)
        {
            return false;
        }

        if (this._0xaf30da7c >= _0x6a7232c4 * 2f)
        {
            return false;
        }

        return this._0x03e895e8 > 0.5f;
    }

    [SerializeField]
    private float _halfPeriodMin = 0.88f;
    public bool _0xfcfa6985(int _0xa2333705)
    {
        return this._0x6e8e8422.Contains(_0xa2333705);
    }

    private void _0xd6686222(int _0xf5d9d44c)
    {
        this._0xb929c2ab.Clear();
        this._0x4ec16252.Clear();
        this._0x9fbce828.Clear();
        this._0x6e8e8422.Clear();
        for (int _0x58ba9561 = 0; _0x58ba9561 <= _0xf5d9d44c; _0x58ba9561++)
        {
            this._0xb929c2ab.Add(_0x58ba9561 % 2 == 0 ? -1 : 1);
            this._0x4ec16252.Add(1f);
        }

        this._0x9fbce828.Add(0);
        this._0x9fbce828.Add(1);
        this._0x9fbce828.Add(2);
        this._0x03e895e8 = 1f;
        this._0xbc1c27ad = 0f;
        this._0xaf30da7c = 0f;
        this._0x13c946c9 = 0.7f;
        this._0x6e8e8422.Add(Mathf.Max(1, _0xf5d9d44c / 2));
    }

    private readonly List<int> _0x9fbce828 = new();
    public float _0x7fa54c62(int _0xce943edc)
    {
        if (this._0x4ec16252.Count == 0)
        {
            return 1f;
        }

        return this._0x4ec16252[_0xce943edc % this._0x4ec16252.Count];
    }

    private void _0xa1d747e6(System.Random _0x807b57ba, int _0xf1f17dfa, int _0x002907a9)
    {
        this._0xb929c2ab.Clear();
        this._0x4ec16252.Clear();
        this._0x9fbce828.Clear();
        this._0x6e8e8422.Clear();
        for (int _0xc4796a61 = 0; _0xc4796a61 <= _0xf1f17dfa; _0xc4796a61++)
        {
            this._0xb929c2ab.Add(_0x807b57ba.Next(0, 2) == 0 ? -1 : 1);
            this._0x4ec16252.Add(Mathf.Lerp(this._halfPeriodMin, this._halfPeriodMax, (float)_0x807b57ba.NextDouble()));
        }

        List<int> _0x82c0b69c = new List<int>
        {
            0,
            1,
            2
        };
        while (_0x82c0b69c.Count > 0)
        {
            int _0x13dc1986 = _0x807b57ba.Next(0, _0x82c0b69c.Count);
            this._0x9fbce828.Add(_0x82c0b69c[_0x13dc1986]);
            _0x82c0b69c.RemoveAt(_0x13dc1986);
        }

        this._0x03e895e8 = Mathf.Lerp(this._baseWidthMin, this._baseWidthMax, (float)_0x807b57ba.NextDouble());
        this._0xbc1c27ad = (float)_0x807b57ba.NextDouble() * 6.2831855f;
        this._0x13c946c9 = 0.55f + (float)_0x807b57ba.NextDouble() * 0.35f;
        this._0xaf30da7c = _0x002907a9 <= 0 ? 0f : _0x002907a9 * 0.045f * (0.7f + (float)_0x807b57ba.NextDouble() * 0.6f);
        int _0xbd0edd0a = Mathf.Max(1, _0xf1f17dfa - 1);
        for (int _0x078babed = 0; _0x078babed < 2 && _0x078babed < _0xbd0edd0a; _0x078babed++)
        {
            int _0x582db994 = 1 + _0x807b57ba.Next(0, _0xbd0edd0a);
            if (!this._0x6e8e8422.Contains(_0x582db994))
            {
                this._0x6e8e8422.Add(_0x582db994);
            }
        }
    }

    private readonly List<int> _0xb929c2ab = new();
    private readonly List<int> _0x6e8e8422 = new();
    public int _0x9dc22a13(int _0x73081b71)
    {
        if (this._0x9fbce828.Count == 0)
        {
            return 0;
        }

        return this._0x9fbce828[_0x73081b71 % this._0x9fbce828.Count];
    }

    private float _0x13c946c9 = 0.7f;
    private int _0x53bef63d;
    [SerializeField]
    private float _halfPeriodMax = 1.12f;
    public int _0x86b6732a(int _0x8f4dc705)
    {
        if (this._0xb929c2ab.Count == 0)
        {
            return 1;
        }

        return this._0xb929c2ab[_0x8f4dc705 % this._0xb929c2ab.Count];
    }

    private float _0xaf30da7c;
}