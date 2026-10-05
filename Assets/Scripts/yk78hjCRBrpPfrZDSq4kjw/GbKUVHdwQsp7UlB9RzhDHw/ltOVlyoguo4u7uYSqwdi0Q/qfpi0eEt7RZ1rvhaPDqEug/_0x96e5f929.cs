using TMPro;
using UnityEngine;
using static _0x7a51889f;

public class _0x96e5f929 : MonoBehaviour
{
    public void _0xd6044ed1()
    {
        this.MoneyCountText.text = _0xf07bddee._0xd4c8ceb5.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x1d4af54a;
            if (this.gameObject.TryGetComponent(out _0x1d4af54a))
                this.MoneyCountText = _0x1d4af54a;
        }

        this._0xd6044ed1();
    }
}