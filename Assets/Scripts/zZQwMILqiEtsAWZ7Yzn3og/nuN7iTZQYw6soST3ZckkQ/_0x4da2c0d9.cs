using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x4da2c0d9 : MonoBehaviour
{
    private float _0xa2491f7e = 4;
    private void Update()
    {
        int _0xee97137e = 1;
        if (this._0xb69cc8af.Count > 0)
        {
            string _0x0d0215bd = this._0xf60b225d.text;
            foreach (string _0x9e98f19b in this._0xb69cc8af)
                while (_0x0d0215bd.Contains(_0x9e98f19b))
                    _0x0d0215bd = _0x0d0215bd.Replace(_0x9e98f19b, "");
            _0xee97137e = _0x0d0215bd.Length;
        }
        else
        {
            _0xee97137e = this._0xf60b225d.text.Length;
        }

        float _0x06cd36ca = Mathf.Clamp(this._0x7f1599f7 + this._0x44d3138b * _0xee97137e, this._0x19cd9232, this._0xa2491f7e);
        if (!Mathf.Approximately(this._0x6308212c.aspectRatio, _0x06cd36ca))
            this._0x6308212c.aspectRatio = _0x06cd36ca;
    }

    private AspectRatioFitter _0x6308212c;
    private float _0x19cd9232 = 1.5f;
    private float _0x44d3138b = 0.6f;
    private List<string> _0xb69cc8af = new();
    private float _0x7f1599f7;
    private TMP_Text _0xf60b225d;
}