using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu: records, the objective line, and the sector sheet where the build mode is
/// chosen. Picking a mode answers visibly — highlight, scale, objective line and chip
/// all change, never just one label.
/// </summary>
public sealed class _0xf2549923 : MonoBehaviour
{
    [SerializeField]
    private List<TMP_Text> _modeCardTitles = new();
    private string _0x344f3d53(int _0xbcbe1072)
    {
        if (_0xbcbe1072 == 2)
        {
            return _0xb3d554d8._0xff914672(new byte[32] { 189, 190, 167, 188, 171, 206, 44, 89, 206, 223, 214, 206, 163, 161, 170, 187, 162, 171, 189, 206, 44, 89, 206, 166, 167, 169, 166, 206, 185, 167, 160, 170 }, 238);
        }

        if (_0xbcbe1072 == 1)
        {
            return _0xb3d554d8._0xff914672(new byte[33] { 216, 215, 210, 214, 217, 187, 89, 44, 187, 170, 169, 187, 214, 212, 223, 206, 215, 222, 200, 187, 89, 44, 187, 215, 210, 220, 211, 207, 187, 204, 210, 213, 223 }, 155);
        }

        return _0xb3d554d8._0xff914672(new byte[28] { 179, 180, 178, 169, 193, 35, 86, 193, 215, 193, 172, 174, 165, 180, 173, 164, 178, 193, 35, 86, 193, 175, 174, 193, 182, 168, 175, 165 }, 225);
    }

    [SerializeField]
    private List<RectTransform> _modeCards = new();
    [SerializeField]
    private RectTransform _heroTower;
    /// <summary>Highlight, scale punch, objective line - the choice has to be visible on a screenshot.</summary>
    private void _0x57beba7e(bool _0x1e381a78)
    {
        for (int _0xd72adb69 = 0; _0xd72adb69 < this._modeCardFrames.Count; _0xd72adb69++)
        {
            if (this._modeCardFrames[_0xd72adb69] != null)
            {
                this._modeCardFrames[_0xd72adb69].color = _0xd72adb69 == this._0x871ba174 ? this._cardSelected : this._cardIdle;
            }
        }

        for (int _0xb7300917 = 0; _0xb7300917 < this._modeCardTitles.Count; _0xb7300917++)
        {
            if (this._modeCardTitles[_0xb7300917] != null)
            {
                this._modeCardTitles[_0xb7300917].color = _0xb7300917 == this._0x871ba174 ? this._titleSelected : this._titleIdle;
            }
        }

        for (int _0xa802b271 = 0; _0xa802b271 < this._modeCards.Count; _0xa802b271++)
        {
            if (this._modeCards[_0xa802b271] == null)
            {
                continue;
            }

            float _0xd7d89637 = _0xa802b271 == this._0x871ba174 ? 1.04f : 1f;
            this._modeCards[_0xa802b271].DOKill(true);
            if (_0x1e381a78)
            {
                this._modeCards[_0xa802b271].DOScale(_0xd7d89637, 0.18f).SetEase(Ease.OutBack);
            }
            else
            {
                this._modeCards[_0xa802b271].localScale = new Vector3(_0xd7d89637, _0xd7d89637, 1f);
            }
        }

        if (this._objectiveLabel != null)
        {
            this._objectiveLabel.text = this._0x344f3d53(this._0x871ba174);
            if (_0x1e381a78)
            {
                this._objectiveLabel.transform.DOKill(true);
                this._objectiveLabel.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0f), 0.22f, 1, 0.5f);
            }
        }

        if (this._emptyLabel != null)
        {
            this._emptyLabel.gameObject.SetActive(this._modeButtons.Count == 0);
        }
    }

    [SerializeField]
    private List<Button> _modeButtons = new();
    private void Start()
    {
        this._0x871ba174 = Mathf.Clamp(PlayerPrefs.GetInt(ModeKey, 0), 0, 2);
        if (this._modeButton != null)
        {
            this._modeButton.onClick.AddListener(() => this._0x25816985());
        }

        if (this._modeCloseButton != null)
        {
            this._modeCloseButton.onClick.AddListener(() => this._0x9f8bfe68());
        }

        for (int _0xc082efcc = 0; _0xc082efcc < this._modeButtons.Count; _0xc082efcc++)
        {
            int _0xbb6bcf77 = _0xc082efcc;
            if (this._modeButtons[_0xc082efcc] != null)
            {
                this._modeButtons[_0xc082efcc].onClick.AddListener(() => this._0x2ba5b24a(_0xbb6bcf77));
            }
        }

        if (this._modeSheet != null)
        {
            this._modeSheet._0x0e74c95b();
        }

        this._0x56734d75();
        this._0x57beba7e(false);
        this._0xaa5178ad();
    }

    private void _0x2ba5b24a(int _0x7029ecf9)
    {
        this._0x871ba174 = Mathf.Clamp(_0x7029ecf9, 0, 2);
        PlayerPrefs.SetInt(ModeKey, this._0x871ba174);
        this._0x57beba7e(true);
    }

    [SerializeField]
    private List<Image> _modeCardFrames = new();
    private void _0x56734d75()
    {
        if (this._bestHeightValue != null)
        {
            this._bestHeightValue.text = PlayerPrefs.GetInt(BestHeightKey, 0).ToString();
        }

        if (this._bestStreakValue != null)
        {
            this._bestStreakValue.text = PlayerPrefs.GetInt(BestStreakKey, 0).ToString();
        }
    }

    [SerializeField]
    private _0x7c948d4c _modeSheet;
    [SerializeField]
    private TMP_Text _emptyLabel;
    // Selected card is the brand violet, not the gold of the title that sits on it:
    // gold-on-gold left the chosen sector's name unreadable.
    [SerializeField]
    private Color _cardSelected = new Color(0.353f, 0.384f, 0.851f, 1f);
    [SerializeField]
    private TMP_Text _bestHeightValue;
    [SerializeField]
    private Button _modeCloseButton;
    private static readonly string ModeKey = _0xb3d554d8._0xff914672(new byte[8] { 31, 25, 24, 52, 6, 4, 15, 14 }, 107);
    private void _0x9f8bfe68()
    {
        if (this._modeSheet != null)
        {
            this._modeSheet._0x0e74c95b();
        }
    }

    private static readonly string BestStreakKey = _0xb3d554d8._0xff914672(new byte[15] { 99, 101, 100, 72, 117, 114, 100, 99, 72, 100, 99, 101, 114, 118, 124 }, 23);
    [SerializeField]
    private Color _titleIdle = new Color(0.965f, 0.941f, 0.890f, 1f);
    private void _0xaa5178ad()
    {
        if (this._heroTower == null)
        {
            return;
        }

        this._heroTower.localScale = new Vector3(0.94f, 0.94f, 1f);
        this._heroTower.DOScale(1f, 0.45f).SetEase(Ease.OutBack);
        this._heroTower.localRotation = Quaternion.Euler(0f, 0f, -1.2f);
        this._heroTower.DOLocalRotate(new Vector3(0f, 0f, 1.2f), 3.2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    [SerializeField]
    private Button _modeButton;
    [SerializeField]
    private Color _titleSelected = new Color(0.953f, 0.769f, 0.286f, 1f);
    private void _0x25816985()
    {
        if (this._modeSheet != null)
        {
            this._modeSheet._0x55ddd628();
        }

        this._0x57beba7e(false);
    }

    [SerializeField]
    private TMP_Text _bestStreakValue;
    private static readonly string BestHeightKey = _0xb3d554d8._0xff914672(new byte[15] { 80, 86, 87, 123, 70, 65, 87, 80, 123, 76, 65, 77, 67, 76, 80 }, 36);
    [SerializeField]
    private TMP_Text _objectiveLabel;
    [SerializeField]
    private Color _cardIdle = new Color(0.224f, 0.761f, 0.792f, 0.35f);
    private int _0x871ba174;
}

internal static class _0xb3d554d8
{
    internal static string _0xff914672(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}