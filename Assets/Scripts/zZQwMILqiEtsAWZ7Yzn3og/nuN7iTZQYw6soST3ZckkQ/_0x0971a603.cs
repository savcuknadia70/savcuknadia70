using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0971a603 : MonoBehaviour
{
    private Image _0x1d4eae42;
    private void _0x947d29d9()
    {
        if (this._0x1d4eae42.canvasRenderer.GetColor() != this._0xb5298832.canvasRenderer.GetColor())
            this._0xb5298832.canvasRenderer.SetColor(this._0x1d4eae42.canvasRenderer.GetColor());
    }

    private void Update()
    {
        this._0x947d29d9();
    }

    private TMP_Text _0xb5298832;
}