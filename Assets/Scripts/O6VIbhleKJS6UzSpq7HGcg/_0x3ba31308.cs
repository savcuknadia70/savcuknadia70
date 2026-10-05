using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// Model and visuals of the stacked construction: widths, top edge, and the root that
/// sinks by one module height after every lock so the live row stays on screen.
/// </summary>
public sealed class _0x3ba31308 : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _beaconPrefab;
    private const int ShardOrder = -8;
    private float _0x504604c8;
    /// <summary>
    /// Sizes a content sprite to the requested world width through <see cref = "SpriteRenderer.size"/>,
    /// keeping the PNG's own aspect. Sliced draw mode owns the footprint, so the transform scale
    /// stays at 1 and never fights the explicit size.
    /// </summary>
    private Vector2 _0xc298edd9(SpriteRenderer _0x030bc64d, float _0x57c13edb)
    {
        if (_0x030bc64d == null)
        {
            return Vector2.one;
        }

        float _0x5faea479 = 1f;
        if (_0x030bc64d.sprite != null)
        {
            Vector2 _0x9532b156 = _0x030bc64d.sprite.bounds.size;
            if (_0x9532b156.x > 0.0001f && _0x9532b156.y > 0.0001f)
            {
                _0x5faea479 = _0x9532b156.y / _0x9532b156.x;
            }
        }

        Vector2 _0xad93cd17 = new Vector2(_0x57c13edb, _0x57c13edb * _0x5faea479);
        _0x030bc64d.drawMode = SpriteDrawMode.Sliced;
        _0x030bc64d.size = _0xad93cd17;
        _0x030bc64d.transform.localScale = Vector3.one;
        return _0xad93cd17;
    }

    [SerializeField]
    private Transform _effectsRoot;
    [SerializeField]
    private float _shardFallDuration = 0.75f;
    public void _0x761dd9bb(float _0x79a0b70a)
    {
        for (int _0xb5039c70 = 0; _0xb5039c70 < this._0xaee614ac.Count; _0xb5039c70++)
        {
            if (this._0xaee614ac[_0xb5039c70] != null)
            {
                Destroy(this._0xaee614ac[_0xb5039c70].gameObject);
            }
        }

        this._0xaee614ac.Clear();
        if (this._effectsRoot != null)
        {
            for (int _0xea33f90f = this._effectsRoot.childCount - 1; _0xea33f90f >= 0; _0xea33f90f--)
            {
                Destroy(this._effectsRoot.GetChild(_0xea33f90f).gameObject);
            }
        }

        if (this._stackRoot != null)
        {
            DOTween.Kill(this._stackRoot, true);
            this._stackRoot.localPosition = new Vector3(0f, this._0xa2b3b816, 0f);
        }

        this._0xb704823b = _0x79a0b70a;
        this._0x504604c8 = 0f;
        this._0xe96889f4(0, _0x79a0b70a, 0f, this._plinthSprite, PlacedOrder);
    }

    [SerializeField]
    private Sprite _moduleCoreSprite;
    public float _0x8090ed85 => this._0x504604c8;

    private float _0x850b1de2 = 0.42f;
    private float _0xb704823b;
    /// <summary>Drops the cut-away slab so the loss of width is readable at a glance.</summary>
    public void SpawnShard(float width, float _0x75b7b565, float _0x5ea99943)
    {
        if (this._shardPrefab == null || this._effectsRoot == null)
        {
            return;
        }

        SpriteRenderer _0x3deca428 = Instantiate(this._shardPrefab, this._effectsRoot);
        _0x3deca428.transform.localPosition = new Vector3(_0x75b7b565, _0x5ea99943, 0f);
        // A cut-off slab is as tall as a module - a square the width of the cut would
        // reach into the readout above the traverse.
        _0x3deca428.drawMode = SpriteDrawMode.Sliced;
        _0x3deca428.size = new Vector2(Mathf.Max(width, this._0x850b1de2 * 0.6f), this._0x850b1de2);
        _0x3deca428.transform.localScale = Vector3.one;
        _0x3deca428.sortingOrder = ShardOrder;
        _0x3deca428.transform.DOLocalMoveY(_0x3deca428.transform.localPosition.y - 7f, this._shardFallDuration).SetEase(Ease.InQuad);
        _0x3deca428.transform.DORotate(new Vector3(0f, 0f, 140f), this._shardFallDuration, RotateMode.FastBeyond360);
        _0x3deca428.DOFade(0f, this._shardFallDuration).OnComplete(() =>
        {
            if (_0x3deca428 != null)
            {
                Destroy(_0x3deca428.gameObject);
            }
        });
    }

    [SerializeField]
    private float _riseDuration = 0.22f;
    /// <summary>Places a module of the given width and centre on top of the stack.</summary>
    public void _0x9e5f7e0b(int _0x5c54c18c, float width, float _0x8aae0267, int _0x2408cbe8, bool _0xfd771ed5)
    {
        Sprite _0xc0bc44dd = this._moduleCoreSprite;
        if (_0xfd771ed5 || _0x2408cbe8 == 2)
        {
            _0xc0bc44dd = this._moduleGoldSprite;
        }
        else if (_0x2408cbe8 == 1)
        {
            _0xc0bc44dd = this._moduleAccentSprite;
        }

        this._0xe96889f4(_0x5c54c18c, width, _0x8aae0267, _0xc0bc44dd, PlacedOrder);
        this._0xb704823b = width;
        this._0x504604c8 = _0x8aae0267;
        this._0xbfefc3f4(_0x5c54c18c);
    }

    public void _0x6d22bd15(float _0xb7d23c89, float _0xa8e011dd)
    {
        this._0x850b1de2 = _0xb7d23c89;
        this._0xa2b3b816 = _0xa8e011dd;
    }

    private const int BeaconOrder = -10;
    private readonly List<SpriteRenderer> _0xaee614ac = new();
    private const int PlacedOrder = -12;
    [SerializeField]
    private Sprite _moduleAccentSprite;
    private const int SparkOrder = -6;
    /// <summary>Gold burst that marks a flush joint.</summary>
    public void _0x47342739(float _0x54e9d8a7, float _0x857864e1, int _0xb24aeedc)
    {
        if (this._sparkPrefab == null || this._effectsRoot == null)
        {
            return;
        }

        for (int _0xeecdcce7 = 0; _0xeecdcce7 < _0xb24aeedc; _0xeecdcce7++)
        {
            SpriteRenderer _0x4bed55f4 = Instantiate(this._sparkPrefab, this._effectsRoot);
            float _0xefdf63b9 = (_0xeecdcce7 - (_0xb24aeedc - 1) * 0.5f) * this._0x850b1de2 * 0.75f;
            _0x4bed55f4.transform.localPosition = new Vector3(_0x54e9d8a7 + _0xefdf63b9, _0x857864e1, 0f);
            Vector2 _0x4b2ae352 = this._0xc298edd9(_0x4bed55f4, this._0x850b1de2 * 0.8f);
            _0x4bed55f4.size = _0x4b2ae352 * 0.2f;
            _0x4bed55f4.sortingOrder = SparkOrder;
            TweenSize(_0x4bed55f4, _0x4b2ae352, 0.35f).SetEase(Ease.OutBack);
            _0x4bed55f4.DOFade(0f, 0.35f).OnComplete(() =>
            {
                if (_0x4bed55f4 != null)
                {
                    Destroy(_0x4bed55f4.gameObject);
                }
            });
        }
    }

    public void _0x7b06cc5e(int _0xf7b1b9af, float width, float _0x5fa904c7)
    {
        if (this._beaconPrefab == null || this._stackRoot == null)
        {
            return;
        }

        SpriteRenderer _0x0cab506c = Instantiate(this._beaconPrefab, this._stackRoot);
        // Height is a multiple of a module, never derived from the sprite's own (square)
        // aspect: a square sized to the stack width is metres tall and swallows the HUD.
        Vector2 _0x3413c74e = new Vector2(width, this._0x850b1de2 * BeaconHeightScale);
        _0x0cab506c.drawMode = SpriteDrawMode.Sliced;
        _0x0cab506c.size = _0x3413c74e;
        _0x0cab506c.transform.localScale = Vector3.one;
        // Sits ON the last row instead of straddling it.
        _0x0cab506c.transform.localPosition = new Vector3(_0x5fa904c7, (_0xf7b1b9af * this._0x850b1de2) + ((_0x3413c74e.y - this._0x850b1de2) * 0.5f), 0f);
        _0x0cab506c.sortingOrder = BeaconOrder;
        _0x0cab506c.DOFade(0.55f, 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        TweenSize(_0x0cab506c, _0x3413c74e * 1.12f, 0.45f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutSine);
        this._0x504604c8 = _0x5fa904c7;
        this._0xbfefc3f4(_0xf7b1b9af);
    }

    public int _0x708ab6a0 => this._0xaee614ac.Count;

    private float _0xa2b3b816;
    [SerializeField]
    private SpriteRenderer _modulePrefab;
    private void _0xbfefc3f4(int _0x484100d2)
    {
        if (this._stackRoot == null)
        {
            return;
        }

        DOTween.Kill(this._stackRoot, true);
        this._stackRoot.DOLocalMoveY(this._0xa2b3b816 - (_0x484100d2 + 1) * this._0x850b1de2, this._riseDuration).SetEase(Ease.OutQuad);
    }

    [SerializeField]
    private SpriteRenderer _sparkPrefab;
    public float _0x96ab7aa5 => this._0xb704823b;

    private void _0xe96889f4(int _0xbc3a3e4b, float width, float _0x4276d125, Sprite _0x0b6e6730, int _0x5a94c5cd)
    {
        if (this._modulePrefab == null || this._stackRoot == null)
        {
            return;
        }

        SpriteRenderer _0xfed6ab09 = Instantiate(this._modulePrefab, this._stackRoot);
        _0xfed6ab09.sprite = _0x0b6e6730;
        _0xfed6ab09.drawMode = SpriteDrawMode.Sliced;
        _0xfed6ab09.size = new Vector2(width, this._0x850b1de2);
        _0xfed6ab09.sortingOrder = _0x5a94c5cd;
        // Sliced draw mode owns the footprint, so the transform scale stays uniform at 1.
        _0xfed6ab09.transform.localScale = Vector3.one;
        _0xfed6ab09.transform.localPosition = new Vector3(_0x4276d125, _0xbc3a3e4b * this._0x850b1de2, 0f);
        this._0xaee614ac.Add(_0xfed6ab09);
    }

    [SerializeField]
    private Sprite _moduleGoldSprite;
    /// <summary>Beacon height in module heights - keeps the finale inside the play lane.</summary>
    private const float BeaconHeightScale = 1.8f;
    [SerializeField]
    private Transform _stackRoot;
    /// <summary>Tweens <see cref = "SpriteRenderer.size"/> — the scale-free equivalent of DOScale.</summary>
    private static Tweener TweenSize(SpriteRenderer _0xdf63d698, Vector2 _0xe7e8db85, float _0x51c1ccee)
    {
        return DOTween.To(() => _0xdf63d698.size, _0xbf1de590 => _0xdf63d698.size = _0xbf1de590, _0xe7e8db85, _0x51c1ccee).SetTarget(_0xdf63d698);
    }

    [SerializeField]
    private Sprite _plinthSprite;
    public float _0x1ad41950()
    {
        return this._stackRoot == null ? 0f : this._stackRoot.localPosition.y;
    }

    [SerializeField]
    private SpriteRenderer _shardPrefab;
    public float _0xfa5b6655()
    {
        return this._0xa2b3b816;
    }
}