using UnityEngine;
using UnityEngine.UI;

public class _0xb3cb9acb : MonoBehaviour
{
    private void Start()
    {
        if (this._0x0225ac46)
            this._0x4cf59590.onClick.AddListener(() => _0x146cc450.Instance._0x89cf022e());
        else
            this._0x4cf59590.onClick.AddListener(() => _0x146cc450.Instance._0x52c81cdc(this._0x22a99255));
    }

    private void Awake()
    {
        if (this._0x4cf59590 == null)
            if (!this.TryGetComponent(out this._0x4cf59590))
                this._0x4cf59590 = this.GetComponentInChildren<Button>();
    }

    private bool _0x0225ac46;
    private int _0x22a99255;
    private Button _0x4cf59590;
}