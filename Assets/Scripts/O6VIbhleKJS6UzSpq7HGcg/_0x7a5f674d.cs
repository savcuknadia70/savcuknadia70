using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Drives one construction run: the module travelling the traverse, the lock, the cut,
/// the supports budget and the win / lose hand-off to the template pops.
/// Every size is derived from the scene camera, never from a literal.
/// </summary>
public sealed class _0x7a5f674d : MonoBehaviour
{
    /// <summary>Starts a fresh attempt with a newly generated, verified layout.</summary>
    public void _0xedbb3cf9()
    {
        this._0x22dafd33();
        this._0xa4096192();
        this._0xeef77e32++;
        this._0xaf68281c = 0;
        this._0x6dfd1aa7 = 0;
        this._0x4c037ece = 0;
        this._0x0257a495 = 0;
        this._0xd2a9b026 = this._0x82dc6c8c;
        this._0xc1e46957 = 0f;
        this._0x6a6656ae = 0f;
        this._0x3e760014 = false;
        this._0xf4f59314 = false;
        this._0x22531d89 = false;
        float _0x69bfa9bd = Mathf.Max(0.1f, 2f * this._0xde7a2373 - 2f * this._sweepPad - this._0xf41ffe59);
        this._planGenerator._0xc08e284d(this._0xcee2abb1, this._0xeef77e32, this._0x3dbd76c7, this._0x92f27b6e, this._0xf41ffe59 * this._perfectEpsFraction, _0x69bfa9bd, this._0xf41ffe59);
        float _0xf5c84a0e = this._0xf41ffe59 * this._planGenerator._0x2a9cbde9;
        this._stack._0x6d22bd15(this._0x959990ed, this._0xdfbf0c60);
        this._stack._0x761dd9bb(_0xf5c84a0e);
        if (this._skyline != null)
        {
            this._skyline._0xc61814a8(this._planGenerator._0xeb582b14);
        }

        this._0xfe69d283();
        this._0xd2110e41();
        this._0xe319c3bb = true;
    }

    private float _0x959990ed;
    [SerializeField]
    private float _earliestLoseSeconds = 20f;
    [SerializeField]
    private float _minWidthFraction = 0.18f;
    private void _0x9ba859ed()
    {
        float _0x6e526a27 = -this._0xde7a2373 + this._0x96b1f93e * 0.5f + this._sweepPad;
        float _0x78e761c1 = this._0xde7a2373 - this._0x96b1f93e * 0.5f - this._sweepPad;
        float _0xec8fcf0a = Mathf.Max(0.01f, _0x78e761c1 - _0x6e526a27);
        float _0x269c2a73 = _0xec8fcf0a / this._0x473b0383;
        float _0x17442441 = _0x6e526a27 + Mathf.PingPong(this._0x6a6656ae * _0x269c2a73, _0xec8fcf0a);
        if (this._planGenerator._0xb39ab9b6 > 0f)
        {
            float _0x83f1b7e1 = Mathf.Sin(this._0xc1e46957 * this._planGenerator._0x614d9842 + this._planGenerator._0x038e753f);
            _0x17442441 += _0x83f1b7e1 * this._planGenerator._0xb39ab9b6;
        }

        _0x17442441 = Mathf.Clamp(_0x17442441, _0x6e526a27, _0x78e761c1);
        this._activeModule.transform.position = new Vector3(_0x17442441, this._0xdfbf0c60, 0f);
    }

    [SerializeField]
    private _0x3ba31308 _stack;
    private static readonly string ModeKey = _0xa23e3ac9._0x9b66b7a5(new byte[8] { 235, 237, 236, 192, 242, 240, 251, 250 }, 159);
    private int _0x82dc6c8c = 3;
    /// <summary>Fixes the travelling module over the tower top. Wired from DROP and the play field.</summary>
    public void _0xbf9fe127()
    {
        if (!this._0xe319c3bb || this._0xf4f59314 || this._0x22531d89)
        {
            return;
        }

        if (_0x1e5d523c.Instance != null && !_0x1e5d523c.Instance._0x5c41302d)
        {
            return;
        }

        this._0x22531d89 = true;
        float _0xf7717854 = this._activeModule.transform.position.x;
        float _0xc2ebb0f7 = this._stack._0x96ab7aa5;
        float _0x819b454e = this._stack._0x8090ed85;
        float _0x77aee96f = _0xf7717854 - _0x819b454e;
        float _0x1e9ec411 = _0xc2ebb0f7 * this._perfectEpsFraction;
        float _0x926b7fc4 = (this._0x96b1f93e + _0xc2ebb0f7) * 0.5f;
        if (Mathf.Abs(_0x77aee96f) >= _0x926b7fc4)
        {
            this._0x58480b5d(_0xf7717854);
            return;
        }

        if (Mathf.Abs(_0x77aee96f) <= _0x1e9ec411)
        {
            this._0xb3094ee8(_0x819b454e, _0xc2ebb0f7);
            return;
        }

        this._0x93bfc072(_0xf7717854, _0x77aee96f, _0x819b454e, _0xc2ebb0f7);
    }

    public void _0xc439811c()
    {
        if (_0x1e5d523c.Instance != null)
        {
            _0x1e5d523c.Instance._0x56411c3c(true);
        }

        _0x8e6d2614.Instance._0x47cdbdca();
    }

    [SerializeField]
    private _0xd676dce5 _skyline;
    private static readonly string BestHeightKey = _0xa23e3ac9._0x9b66b7a5(new byte[15] { 7, 1, 0, 44, 17, 22, 0, 7, 44, 27, 22, 26, 20, 27, 7 }, 115);
    private int _0x92f27b6e;
    private bool _0xf4f59314;
    [SerializeField]
    private Sprite _moduleCoreSprite;
    private int _0xcee2abb1;
    public int _0x537e1264 => PlayerPrefs.GetInt(BestHeightKey, 0);

    [SerializeField]
    private int _graceModules = 3;
    public void _0xab1611e4()
    {
        if (_0x1e5d523c.Instance != null)
        {
            _0x1e5d523c.Instance._0x56411c3c(true);
        }

        _0x8e6d2614.Instance._0x47cdbdca();
        this._0xedbb3cf9();
    }

    public int _0x49d8176a => this._0xaf68281c;

    [SerializeField]
    private float _perfectEpsFraction = 0.06f;
    private Sprite _0x8242a8c0(int _0x75aaafd6)
    {
        if (_0x75aaafd6 == 2)
        {
            return this._moduleGoldSprite;
        }

        if (_0x75aaafd6 == 1)
        {
            return this._moduleAccentSprite;
        }

        return this._moduleCoreSprite;
    }

    [SerializeField]
    private float _perfectRecovery = 0.06f;
    public int _0x5c9f67a5 => PlayerPrefs.GetInt(BestStreakKey, 0);

    private void _0x7d9b6397()
    {
        this._0x200cff5a();
        DOVirtual.DelayedCall(this._lockHold, () =>
        {
            if (this._0xf4f59314)
            {
                return;
            }

            this._0xfe69d283();
            this._0x22531d89 = false;
        });
    }

    private float _0xf41ffe59;
    private int _0x3dbd76c7 = 6;
    [SerializeField]
    private SpriteRenderer _activeModule;
    private void _0xfe69d283()
    {
        if (this._activeModule == null)
        {
            return;
        }

        int _0x34b08de1 = this._0xaf68281c + 1;
        this._0x96b1f93e = this._stack._0x96ab7aa5;
        this._activeModule.gameObject.SetActive(true);
        this._activeModule.sprite = this._0x8242a8c0(this._planGenerator._0x9dc22a13(_0x34b08de1));
        this._activeModule.drawMode = SpriteDrawMode.Sliced;
        this._activeModule.size = new Vector2(this._0x96b1f93e, this._0x959990ed);
        this._activeModule.sortingOrder = ActiveOrder;
        this._activeModule.transform.localScale = Vector3.one;
        this._0x473b0383 = Mathf.Max(0.3f, 1.15f * this._planGenerator._0x7fa54c62(_0x34b08de1) * this._0x5d774302());
        this._0x6a6656ae = this._planGenerator._0x86b6732a(_0x34b08de1) > 0 ? 0f : this._0x473b0383;
        this._0x9ba859ed();
        this._0x22531d89 = false;
    }

    private float _0x6deb975b = 5f;
    private const int ActiveOrder = -11;
    private int _0x0257a495;
    private void _0xe5906e73(float width, float _0x221560fe, bool _0x894947fa)
    {
        bool _0xa2e786cd = _0x894947fa || this._planGenerator._0xfcfa6985(this._0xaf68281c);
        bool _0x87c6ff09 = this._0xaf68281c >= this._0x3dbd76c7;
        if (_0x87c6ff09)
        {
            this._stack._0x7b06cc5e(this._0xaf68281c, width, _0x221560fe);
        }
        else
        {
            this._stack._0x9e5f7e0b(this._0xaf68281c, width, _0x221560fe, this._planGenerator._0x9dc22a13(this._0xaf68281c), _0xa2e786cd);
        }

        this._0xd2110e41();
        if (_0x87c6ff09)
        {
            this._0x200cff5a();
            DOVirtual.DelayedCall(0.9f, () => this._0x0516288a(true));
            return;
        }

        this._0x7d9b6397();
    }

    private static readonly string BestStreakKey = _0xa23e3ac9._0x9b66b7a5(new byte[15] { 135, 129, 128, 172, 145, 150, 128, 135, 172, 128, 135, 129, 150, 146, 152 }, 243);
    public int _0xcf0c5cd9 => this._0x82dc6c8c;

    [SerializeField]
    private Button _dropButton;
    private float _0x96b1f93e;
    public int _0x8095957a => this._0xd2a9b026;

    [SerializeField]
    private Sprite _moduleAccentSprite;
    [SerializeField]
    private Camera _camera;
    public int _0x150c5303 => this._0x3dbd76c7;

    [SerializeField]
    private float _boardWidthFraction = 0.60f;
    private float _0x473b0383 = 1.15f;
    private bool _0x22531d89;
    private float _0xc1e46957;
    [SerializeField]
    private float _moduleHeightFraction = 0.084f;
    private void _0x200cff5a()
    {
        if (this._activeModule != null)
        {
            this._activeModule.gameObject.SetActive(false);
        }
    }

    [SerializeField]
    private _0x775bf96a _hud;
    private int _0x4c037ece;
    [SerializeField]
    private float _sweepPad = 0.08f;
    private void _0x22dafd33()
    {
        this._0xcee2abb1 = Mathf.Clamp(PlayerPrefs.GetInt(ModeKey, 0), 0, 2);
        if (this._0xcee2abb1 == 2)
        {
            this._0x3dbd76c7 = 18;
            this._0x92f27b6e = 2;
            this._0x82dc6c8c = 2;
        }
        else if (this._0xcee2abb1 == 1)
        {
            this._0x3dbd76c7 = 12;
            this._0x92f27b6e = 1;
            this._0x82dc6c8c = 3;
        }
        else
        {
            this._0x3dbd76c7 = 6;
            this._0x92f27b6e = 0;
            this._0x82dc6c8c = 3;
        }
    }

    private void _0x93bfc072(float _0xbd7fd739, float _0x50c8ead6, float _0xa48afc7a, float _0x8ea69d18)
    {
        float _0xe5191e1c = Mathf.Max(_0xbd7fd739 - this._0x96b1f93e * 0.5f, _0xa48afc7a - _0x8ea69d18 * 0.5f);
        float _0xa8f4cff8 = Mathf.Min(_0xbd7fd739 + this._0x96b1f93e * 0.5f, _0xa48afc7a + _0x8ea69d18 * 0.5f);
        float width = Mathf.Max(this._0x5a667c08, _0xa8f4cff8 - _0xe5191e1c);
        float _0x160a7790 = (_0xe5191e1c + _0xa8f4cff8) * 0.5f;
        float _0x9e413dd6 = _0x50c8ead6 > 0f ? _0xa8f4cff8 + Mathf.Abs(_0x50c8ead6) * 0.5f : _0xe5191e1c - Mathf.Abs(_0x50c8ead6) * 0.5f;
        this._0xaf68281c++;
        this._0x6dfd1aa7 = 0;
        this._stack.SpawnShard(Mathf.Abs(_0x50c8ead6), _0x9e413dd6, this._0xdfbf0c60);
        this._0xe5906e73(width, _0x160a7790, false);
    }

    [SerializeField]
    private Sprite _moduleGoldSprite;
    [SerializeField]
    private _0x6568d0fb _planGenerator;
    private void _0xd2110e41()
    {
        if (this._hud != null)
        {
            this._hud._0xf8f0ced7(this._0xaf68281c, this._0x3dbd76c7, this._0x6dfd1aa7, this._0xd2a9b026, this._0x82dc6c8c, this._0x92f27b6e);
        }
    }

    private void _0xa4096192()
    {
        this._0x6deb975b = this._camera != null ? this._camera.orthographicSize : 5f;
        float _0x21029885 = this._camera != null ? this._camera.aspect : 9f / 19.5f;
        this._0xde7a2373 = this._0x6deb975b * _0x21029885;
        this._0xf41ffe59 = 2f * this._0xde7a2373 * this._boardWidthFraction;
        this._0x959990ed = this._0x6deb975b * this._moduleHeightFraction;
        this._0x5a667c08 = 2f * this._0xde7a2373 * this._minWidthFraction;
        this._0xdfbf0c60 = this._0x6deb975b * this._rowHeightFraction;
    }

    private float _0xde7a2373 = 2.3f;
    private bool _0xe319c3bb;
    private void _0xb3094ee8(float _0xfc69fa43, float _0xfbe2dd35)
    {
        float width = Mathf.Min(this._0xf41ffe59, _0xfbe2dd35 + this._perfectRecovery);
        this._0xaf68281c++;
        this._0x6dfd1aa7++;
        this._0x0257a495++;
        if (this._0x6dfd1aa7 > this._0x4c037ece)
        {
            this._0x4c037ece = this._0x6dfd1aa7;
        }

        this._stack._0x47342739(_0xfc69fa43, this._0xdfbf0c60, 4);
        this._0xe5906e73(width, _0xfc69fa43, true);
    }

    [SerializeField]
    private float _rowHeightFraction = 0.44f;
    private void _0x58480b5d(float _0x92bc92f2)
    {
        this._stack.SpawnShard(this._0x96b1f93e, _0x92bc92f2, this._0xdfbf0c60);
        this._0x6dfd1aa7 = 0;
        bool _0x5fec2a79 = this._0xaf68281c < this._graceModules;
        bool _0xafa1a132 = false;
        if (!_0x5fec2a79)
        {
            this._0xd2a9b026--;
        }

        if (this._0xd2a9b026 <= 0 && this._0xc1e46957 < this._earliestLoseSeconds && !this._0x3e760014)
        {
            // Keeps a run alive long enough to be seen; spent once per attempt.
            this._0x3e760014 = true;
            this._0xd2a9b026 = 1;
            _0xafa1a132 = true;
        }

        this._hud._0x1c6e7a9e(_0x5fec2a79 ? _0xa23e3ac9._0x9b66b7a5(new byte[8] { 62, 41, 65, 45, 32, 37, 43, 34 }, 108) : _0xafa1a132 ? _0xa23e3ac9._0x9b66b7a5(new byte[15] { 203, 195, 203, 220, 201, 203, 192, 205, 215, 174, 204, 220, 207, 205, 203 }, 142) : _0xa23e3ac9._0x9b66b7a5(new byte[12] { 241, 247, 242, 242, 237, 240, 246, 130, 238, 237, 241, 246 }, 162));
        this._0xd2110e41();
        if (this._0xd2a9b026 <= 0)
        {
            this._0x0516288a(false);
            return;
        }

        this._0x7d9b6397();
    }

    private void Awake()
    {
        if (this._camera == null)
        {
            this._camera = Camera.main;
        }

        this._0x22dafd33();
        this._0xa4096192();
    }

    private void Start()
    {
        if (this._dropButton != null)
        {
            this._dropButton.onClick.AddListener(() => this._0xbf9fe127());
        }

        if (this._tapFieldButton != null)
        {
            this._tapFieldButton.onClick.AddListener(() => this._0xbf9fe127());
        }

        this._0xedbb3cf9();
    }

    private float _0xdfbf0c60;
    private float _0x5d774302()
    {
        if (this._0xcee2abb1 == 2)
        {
            return 0.62f / 1.15f;
        }

        if (this._0xcee2abb1 == 1)
        {
            return 0.85f / 1.15f;
        }

        return 1f;
    }

    private float _0x6a6656ae;
    public int _0x8cf33892 => this._0x0257a495;

    private int _0xeef77e32;
    private void _0x0516288a(bool _0x61316325)
    {
        if (this._0xf4f59314)
        {
            return;
        }

        this._0xf4f59314 = true;
        this._0xe319c3bb = false;
        this._0x200cff5a();
        if (this._0xaf68281c > this._0x537e1264)
        {
            PlayerPrefs.SetInt(BestHeightKey, this._0xaf68281c);
        }

        if (this._0x4c037ece > this._0x5c9f67a5)
        {
            PlayerPrefs.SetInt(BestStreakKey, this._0x4c037ece);
        }

        if (_0x61316325)
        {
            _0x7a51889f._0xf07bddee._0xd4c8ceb5 += this._0xaf68281c * 5 + this._0x0257a495 * 10;
        }

        {
#if B_LOGS
            {
                Debug.Log($"[run] finished won={_0x61316325} height={this._0xaf68281c} perfect={this._0x0257a495} time={this._0xc1e46957:0.0}");
            }
#endif
        }

        if (_0x1e5d523c.Instance != null)
        {
            _0x1e5d523c.Instance._0x56411c3c(false);
        }

        _0x8e6d2614.Instance._0xb617e046(_0x61316325 ? _0x7a51889f._0xa5f1506c.WIN : _0x7a51889f._0xa5f1506c.LOSE);
    }

    private float _0x5a667c08;
    private int _0xaf68281c;
    private int _0xd2a9b026 = 3;
    [SerializeField]
    private Button _tapFieldButton;
    [SerializeField]
    private float _lockHold = 0.12f;
    private bool _0x3e760014;
    private void Update()
    {
        if (!this._0xe319c3bb || this._0xf4f59314 || this._0x22531d89)
        {
            return;
        }

        if (_0x1e5d523c.Instance != null && !_0x1e5d523c.Instance._0x5c41302d)
        {
            return;
        }

        this._0xc1e46957 += Time.deltaTime;
        this._0x6a6656ae += Time.deltaTime;
        this._0x9ba859ed();
    }

    private int _0x6dfd1aa7;
}

internal static class _0xa23e3ac9
{
    internal static string _0x9b66b7a5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}