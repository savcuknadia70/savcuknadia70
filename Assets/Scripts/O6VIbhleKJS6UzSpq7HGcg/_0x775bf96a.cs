using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The in-run readout: height, streak, supports, wind chip and the segment altimeter.
/// The altimeter lives alone in its own gutter so it never shares an x-band with text.
/// </summary>
public sealed class _0x775bf96a : MonoBehaviour
{
    private int _0x758260ca = -1;
    private readonly List<Image> _0x0cebf5f7 = new();
    [SerializeField]
    private Image _segmentPrefab;
    [SerializeField]
    private RectTransform _altimeterGutter;
    private void _0x343d847f(int height)
    {
        for (int _0x7c334d4f = 0; _0x7c334d4f < this._0x0cebf5f7.Count; _0x7c334d4f++)
        {
            if (this._0x0cebf5f7[_0x7c334d4f] == null)
            {
                continue;
            }

            this._0x0cebf5f7[_0x7c334d4f].color = _0x7c334d4f < height ? this._segmentFilled : this._segmentEmpty;
        }
    }

    public void _0xf8f0ced7(int height, int _0x1345f10c, int _0x38fe749b, int _0xd53e94c3, int _0xc1d2f61a, int _0xba36da47)
    {
        if (this._heightLabel != null)
        {
            this._heightLabel.text = $"HEIGHT {height} / {_0x1345f10c}";
            this._heightLabel.transform.DOKill(true);
            this._heightLabel.transform.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.18f, 1, 0.5f);
        }

        if (this._streakLabel != null)
        {
            this._streakLabel.text = _0x38fe749b > 0 ? $"STREAK x{_0x38fe749b}" : _0xffbed3cd._0x510fc768(new byte[9] { 176, 183, 177, 166, 162, 168, 195, 155, 211 }, 227);
        }

        if (this._supportsLabel != null)
        {
            this._supportsLabel.text = $"SUPPORTS {_0xd53e94c3} / {_0xc1d2f61a}";
        }

        if (this._windChip != null)
        {
            this._windChip.SetActive(_0xba36da47 > 0);
        }

        if (this._windLabel != null && _0xba36da47 > 0)
        {
            this._windLabel.text = $"WIND {_0xba36da47}";
        }

        this._0x1b38e867(_0x1345f10c);
        this._0x343d847f(height);
    }

    [SerializeField]
    private Color _segmentEmpty = new Color(0.118f, 0.129f, 0.259f, 1f);
    [SerializeField]
    private TMP_Text _heightLabel;
    /// <summary>Short red callout used for a missed drop, a grace retry or the emergency brace.</summary>
    public void _0x1c6e7a9e(string _0x6751e357)
    {
        if (this._flashLabel == null)
        {
            return;
        }

        this._flashLabel.text = _0x6751e357;
        this._flashLabel.color = this._textDanger;
        this._flashLabel.gameObject.SetActive(true);
        this._flashLabel.transform.DOKill(true);
        this._flashLabel.transform.DOShakePosition(0.2f, 14f, 18, 90f, false, true);
        DOVirtual.DelayedCall(1.3f, () =>
        {
            if (this._flashLabel != null)
            {
                this._flashLabel.text = string.Empty;
                this._flashLabel.color = this._textNormal;
            }
        });
    }

    [SerializeField]
    private float _segmentSize = 26f;
    private void _0x1b38e867(int _0x0fc7ae7d)
    {
        if (this._altimeterGutter == null || this._segmentPrefab == null || this._0x758260ca == _0x0fc7ae7d)
        {
            return;
        }

        for (int _0xb557785b = this._0x0cebf5f7.Count - 1; _0xb557785b >= 0; _0xb557785b--)
        {
            if (this._0x0cebf5f7[_0xb557785b] != null)
            {
                Destroy(this._0x0cebf5f7[_0xb557785b].gameObject);
            }
        }

        this._0x0cebf5f7.Clear();
        this._0x758260ca = _0x0fc7ae7d;
        float _0x1a52aa62 = this._segmentPitch;
        float _0xd6dc0532 = (_0x0fc7ae7d - 1) * _0x1a52aa62;
        if (_0xd6dc0532 > 620f && _0x0fc7ae7d > 1)
        {
            _0x1a52aa62 = 620f / (_0x0fc7ae7d - 1);
            _0xd6dc0532 = 620f;
        }

        for (int _0xf9627bc3 = 0; _0xf9627bc3 < _0x0fc7ae7d; _0xf9627bc3++)
        {
            Image _0x91017892 = Instantiate(this._segmentPrefab, this._altimeterGutter);
            RectTransform _0xf21eee60 = _0x91017892.rectTransform;
            _0xf21eee60.anchorMin = new Vector2(0.5f, 0.5f);
            _0xf21eee60.anchorMax = new Vector2(0.5f, 0.5f);
            _0xf21eee60.pivot = new Vector2(0.5f, 0.5f);
            _0xf21eee60.sizeDelta = new Vector2(this._segmentSize, this._segmentSize * 0.55f);
            _0xf21eee60.anchoredPosition = new Vector2(0f, -_0xd6dc0532 * 0.5f + _0xf9627bc3 * _0x1a52aa62);
            _0x91017892.color = this._segmentEmpty;
            this._0x0cebf5f7.Add(_0x91017892);
        }
    }

    [SerializeField]
    private Color _segmentFilled = new Color(0.224f, 0.761f, 0.792f, 1f);
    [SerializeField]
    private TMP_Text _streakLabel;
    [SerializeField]
    private TMP_Text _windLabel;
    [SerializeField]
    private Color _textNormal = new Color(0.965f, 0.941f, 0.890f, 1f);
    [SerializeField]
    private TMP_Text _supportsLabel;
    [SerializeField]
    private float _segmentPitch = 34f;
    [SerializeField]
    private TMP_Text _flashLabel;
    [SerializeField]
    private GameObject _windChip;
    [SerializeField]
    private Color _textDanger = new Color(0.914f, 0.353f, 0.384f, 1f);
}

internal static class _0xffbed3cd
{
    internal static string _0x510fc768(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}