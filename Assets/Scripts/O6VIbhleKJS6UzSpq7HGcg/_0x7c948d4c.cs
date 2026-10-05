using DG.Tweening;
using UnityEngine;

/// <summary>
/// Shows and hides one overlay this UI owns: <c>_root</c> is switched on and off,
/// <c>_content</c> is the card that slides in. Used instead of touching template
/// panels, because generated code can only manage what it created itself.
/// </summary>
public sealed class _0x7c948d4c : MonoBehaviour
{
    [SerializeField]
    private GameObject _root;
    private float _0xc584a0ed;
    [SerializeField]
    private float _slideFrom = -360f;
    [SerializeField]
    private float _duration = 0.28f;
    [SerializeField]
    private RectTransform _content;
    public void _0x0e74c95b()
    {
        if (this._root == null)
        {
            return;
        }

        this._0x86acce70();
        if (this._content != null)
        {
            this._content.DOKill(true);
            this._content.anchoredPosition = new Vector2(this._content.anchoredPosition.x, this._0xc584a0ed);
        }

        this._root.SetActive(false);
    }

    public void _0xc219f452()
    {
        if (this._0x4fa761ed)
        {
            this._0x0e74c95b();
        }
        else
        {
            this._0x55ddd628();
        }
    }

    public bool _0x4fa761ed => this._root != null && this._root.activeSelf;

    public void _0x55ddd628()
    {
        if (this._root == null)
        {
            return;
        }

        this._0x86acce70();
        this._root.SetActive(true);
        // The overlay shares a parent with the menu's own buttons, and uGUI draws siblings
        // in hierarchy order - without this the last-added sibling (the PLAY button) paints
        // over the sheet AND wins its taps. Raising the sheet puts the scrim on top of them.
        this._root.transform.SetAsLastSibling();
        if (this._content != null)
        {
            this._content.DOKill(true);
            this._content.anchoredPosition = new Vector2(this._content.anchoredPosition.x, this._0xc584a0ed + this._slideFrom);
            this._content.DOAnchorPosY(this._0xc584a0ed, this._duration).SetEase(Ease.OutCubic);
        }
    }

    private bool _0xdc28cf7c;
    private void _0x86acce70()
    {
        if (this._0xdc28cf7c || this._content == null)
        {
            return;
        }

        this._0xc584a0ed = this._content.anchoredPosition.y;
        this._0xdc28cf7c = true;
    }
}