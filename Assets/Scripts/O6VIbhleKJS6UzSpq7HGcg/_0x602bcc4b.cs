using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Owns one of the three template pops (pause / win / lose): its wording, its result
/// rows, its close icon and every button on it. Nothing here is looked up by name.
/// </summary>
public sealed class _0x602bcc4b : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _mainText;
    /// <summary>
    /// Watches the pop's own Content for the moment it is switched on.
    /// This component lives on the pop ROOT, and the template only ever activates that
    /// root once (PopsController.Start) - Show()/Hide() toggle Content instead. So OnEnable
    /// fires exactly once, at scene load, when the run has not started: hooking it left
    /// every pop frozen on the numbers of a run that had placed nothing ("HEIGHT 0 / 6"
    /// behind a HUD reading 3 / 6) and left the pause freeze on a one-shot that the
    /// template ShowPopButton never re-triggers. Content IS toggled on every open, so the
    /// rising edge below is the one signal that fires for all paths into the pop.
    /// </summary>
    private void Update()
    {
        bool _0xdea4a147 = this._content != null && this._content.activeInHierarchy;
        if (_0xdea4a147 == this._0x1b7bbee9)
        {
            return;
        }

        this._0x1b7bbee9 = _0xdea4a147;
        if (!_0xdea4a147)
        {
            return;
        }

        // The pause pop is opened by the template ShowPopButton, which only shows the pop -
        // it never stops the run. Freezing here means the traverse halts whichever way the
        // pop is opened, and ResumeFromPop/OnClose put it back.
        if (this._kind == PauseKind && _0x1e5d523c.Instance != null)
        {
            _0x1e5d523c.Instance._0x56411c3c(false);
        }

        this._0x7965365f();
    }

    [SerializeField]
    private TMP_Text _menuLabel;
    private bool _0x1b7bbee9;
    [SerializeField]
    private Image _illustration;
    /// <summary>Applies the project-wide TMP contract: no engine wrapping, autosize on, readable floor.</summary>
    private void _0x4c6e4a75(TMP_Text _0x8a5ebab7, string _0x0924a9e1)
    {
        if (_0x8a5ebab7 == null)
        {
            return;
        }

        _0x8a5ebab7.textWrappingMode = TextWrappingModes.NoWrap;
        _0x8a5ebab7.overflowMode = TextOverflowModes.Overflow;
        _0x8a5ebab7.enableAutoSizing = true;
        _0x8a5ebab7.fontSizeMin = 24f;
        if (_0x8a5ebab7.fontSizeMax < 32f)
        {
            _0x8a5ebab7.fontSizeMax = 64f;
        }

        _0x8a5ebab7.text = _0x0924a9e1;
    }

    [SerializeField]
    private _0x7a5f674d _run;
    [SerializeField]
    private Button _primaryButton;
    private void _0xe865c739()
    {
        if (_0x1e5d523c.Instance != null)
        {
            _0x1e5d523c.Instance._0x56411c3c(true);
            _0x1e5d523c.Instance.LoadSceneByIndex(_0x7a51889f._0x628a7dd7.SCENE_0);
        }
    }

    private const int PauseKind = 0;
    [SerializeField]
    private Image _closeIcon;
    [SerializeField]
    private TMP_Text _resultLabelA;
    [SerializeField]
    private TMP_Text _resultValueA;
    [SerializeField]
    private TMP_Text _resultLabelB;
    private void _0x96f35936()
    {
        if (this._run == null)
        {
            return;
        }

        if (this._kind == PauseKind)
        {
            this._run._0xc439811c();
            return;
        }

        this._run._0xab1611e4();
    }

    [SerializeField]
    private GameObject _content;
    private const int WinKind = 1;
    private void _0xd813d2d9()
    {
        if (this._closeIcon != null && this._closeSprite != null)
        {
            this._closeIcon.sprite = this._closeSprite;
            this._closeIcon.preserveAspect = true;
            this._closeIcon.color = Color.white;
            this._closeIcon.gameObject.SetActive(true);
        }

        if (this._illustration != null && this._illustrationSprite != null)
        {
            this._illustration.sprite = this._illustrationSprite;
            this._illustration.preserveAspect = true;
            this._illustration.gameObject.SetActive(true);
        }

        if (this._kind == PauseKind)
        {
            this._0x4c6e4a75(this._resultLabelA, _0xec8b2fc5._0xd66e1aba(new byte[8] { 62, 56, 61, 61, 34, 63, 57, 62 }, 109));
            this._0x4c6e4a75(this._resultLabelB, _0xec8b2fc5._0xd66e1aba(new byte[6] { 113, 106, 117, 102, 119, 112 }, 35));
            this._0x4c6e4a75(this._primaryLabel, _0xec8b2fc5._0xd66e1aba(new byte[6] { 241, 230, 240, 246, 238, 230 }, 163));
            this._0x4c6e4a75(this._menuLabel, _0xec8b2fc5._0xd66e1aba(new byte[4] { 163, 171, 160, 187 }, 238));
        }
        else if (this._kind == WinKind)
        {
            this._0x4c6e4a75(this._resultLabelA, _0xec8b2fc5._0xd66e1aba(new byte[11] { 97, 102, 112, 119, 3, 107, 102, 106, 100, 107, 119 }, 35));
            this._0x4c6e4a75(this._resultLabelB, _0xec8b2fc5._0xd66e1aba(new byte[6] { 144, 139, 148, 135, 150, 145 }, 194));
            this._0x4c6e4a75(this._primaryLabel, _0xec8b2fc5._0xd66e1aba(new byte[11] { 28, 11, 23, 18, 26, 126, 31, 25, 31, 23, 16 }, 94));
            this._0x4c6e4a75(this._menuLabel, _0xec8b2fc5._0xd66e1aba(new byte[4] { 113, 121, 114, 105 }, 60));
        }
        else
        {
            this._0x4c6e4a75(this._resultLabelA, _0xec8b2fc5._0xd66e1aba(new byte[11] { 9, 14, 24, 31, 107, 3, 14, 2, 12, 3, 31 }, 75));
            this._0x4c6e4a75(this._resultLabelB, _0xec8b2fc5._0xd66e1aba(new byte[6] { 134, 157, 130, 145, 128, 135 }, 212));
            this._0x4c6e4a75(this._primaryLabel, _0xec8b2fc5._0xd66e1aba(new byte[5] { 79, 88, 73, 79, 68 }, 29));
            this._0x4c6e4a75(this._menuLabel, _0xec8b2fc5._0xd66e1aba(new byte[4] { 35, 43, 32, 59 }, 110));
        }
    }

    [SerializeField]
    private TMP_Text _primaryLabel;
    [SerializeField]
    private TMP_Text _headerText;
    private void Start()
    {
        this._0xd813d2d9();
        if (this._primaryButton != null)
        {
            this._primaryButton.onClick.AddListener(() => this._0x96f35936());
        }

        if (this._menuButton != null)
        {
            this._menuButton.onClick.AddListener(() => this._0xe865c739());
        }

        if (this._closeButton != null)
        {
            this._closeButton.onClick.AddListener(() => this._0x843d1f39());
        }
    }

    /// <summary>0 = pause, 1 = win, 2 = lose.</summary>
    [SerializeField]
    private int _kind;
    [SerializeField]
    private Sprite _closeSprite;
    /// <summary>Fills the pop with the numbers of the run that just ended.</summary>
    public void _0x7965365f()
    {
        if (this._run == null)
        {
            return;
        }

        if (this._kind == PauseKind)
        {
            this._0x4c6e4a75(this._headerText, _0xec8b2fc5._0xd66e1aba(new byte[12] { 246, 236, 241, 224, 133, 234, 235, 133, 237, 234, 233, 225 }, 165));
            this._0x4c6e4a75(this._mainText, $"HEIGHT {this._run._0x49d8176a} / {this._run._0x150c5303}");
            this._0x4c6e4a75(this._resultValueA, $"{this._run._0x8095957a} / {this._run._0xcf0c5cd9}");
        }
        else if (this._kind == WinKind)
        {
            this._0x4c6e4a75(this._headerText, _0xec8b2fc5._0xd66e1aba(new byte[16] { 4, 31, 7, 21, 2, 112, 4, 31, 0, 0, 21, 20, 112, 31, 5, 4 }, 80));
            this._0x4c6e4a75(this._mainText, $"HEIGHT {this._run._0x49d8176a} / {this._run._0x150c5303}\nPERFECT {this._run._0x8cf33892}");
            this._0x4c6e4a75(this._resultValueA, $"{this._run._0x537e1264}");
        }
        else
        {
            this._0x4c6e4a75(this._headerText, _0xec8b2fc5._0xd66e1aba(new byte[11] { 180, 182, 189, 172, 181, 188, 217, 181, 182, 170, 173 }, 249));
            this._0x4c6e4a75(this._mainText, $"HEIGHT {this._run._0x49d8176a} / {this._run._0x150c5303}\nPERFECT {this._run._0x8cf33892}");
            this._0x4c6e4a75(this._resultValueA, $"{this._run._0x537e1264}");
        }

        if (this._content != null)
        {
            this._content.transform.DOKill(true);
            this._content.transform.DOPunchScale(new Vector3(0.04f, 0.04f, 0f), 0.3f, 1, 0.5f);
        }
    }

    [SerializeField]
    private Button _closeButton;
    [SerializeField]
    private Sprite _illustrationSprite;
    private void _0x843d1f39()
    {
        if (this._kind == PauseKind)
        {
            if (this._run != null)
            {
                this._run._0xc439811c();
            }

            return;
        }

        if (this._run != null)
        {
            this._run._0xab1611e4();
        }
    }

    [SerializeField]
    private Button _menuButton;
}

internal static class _0xec8b2fc5
{
    internal static string _0xd66e1aba(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}