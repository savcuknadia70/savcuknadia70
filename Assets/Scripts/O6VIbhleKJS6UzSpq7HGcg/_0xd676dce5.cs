using UnityEngine;

/// <summary>
/// Two silhouette layers behind the construction. Their offset and tint vary per run so
/// two consecutive attempts never open on the same picture.
/// </summary>
public sealed class _0xd676dce5 : MonoBehaviour
{
    [SerializeField]
    private float _farFactor = 0.08f;
    [SerializeField]
    private Camera _camera;
    private void LateUpdate()
    {
        if (this._stackRoot == null)
        {
            return;
        }

        // The stack sinks by `rise` as the tower grows, which reads as the camera
        // climbing. The backdrop has to sink with it, only slower - adding the offset
        // instead walked the horizon UP into the play field over a long run.
        float _0x2c0868df = this._0x834d814f - this._stackRoot.localPosition.y;
        if (this._farLayer != null)
        {
            Vector3 _0xa60b560d = this._farLayer.transform.localPosition;
            _0xa60b560d.y = this._0xa451d1a7 - _0x2c0868df * this._farFactor;
            this._farLayer.transform.localPosition = _0xa60b560d;
        }

        if (this._nearLayer != null)
        {
            Vector3 _0x329f74b8 = this._nearLayer.transform.localPosition;
            _0x329f74b8.y = this._0x3ba597ed - _0x2c0868df * this._nearFactor;
            this._nearLayer.transform.localPosition = _0x329f74b8;
        }
    }

    private const int NearOrder = -16;
    private float _0x3ba597ed;
    private const int FarOrder = -17;
    [SerializeField]
    private Transform _stackRoot;
    [SerializeField]
    private SpriteRenderer _farLayer;
    private float _0xa451d1a7;
    /// <summary>Re-seeds the horizon so each attempt reads as a different site.</summary>
    public void _0xc61814a8(int _0xa6ce89cd)
    {
        System.Random _0x68f33d6e = new System.Random(_0xa6ce89cd);
        float _0xc6853ae3 = this._camera != null ? this._camera.orthographicSize * this._camera.aspect : 2.3f;
        if (this._farLayer != null)
        {
            this._0x9d645ff9(this._farLayer, (float)_0x68f33d6e.NextDouble(), _0xc6853ae3, 0.34f, 0.55f);
        }

        if (this._nearLayer != null)
        {
            this._0x9d645ff9(this._nearLayer, (float)_0x68f33d6e.NextDouble(), _0xc6853ae3, 0.52f, 0.8f);
        }

        if (this._stackRoot != null)
        {
            this._0x834d814f = this._stackRoot.localPosition.y;
        }

        this._0xa451d1a7 = this._farLayer != null ? this._farLayer.transform.localPosition.y : 0f;
        this._0x3ba597ed = this._nearLayer != null ? this._nearLayer.transform.localPosition.y : 0f;
    }

    private void Awake()
    {
        if (this._camera == null)
        {
            this._camera = Camera.main;
        }

        if (this._farLayer != null)
        {
            this._farLayer.sortingOrder = FarOrder;
            this._0xa451d1a7 = this._farLayer.transform.localPosition.y;
        }

        if (this._nearLayer != null)
        {
            this._nearLayer.sortingOrder = NearOrder;
            this._0x3ba597ed = this._nearLayer.transform.localPosition.y;
        }

        if (this._stackRoot != null)
        {
            this._0x834d814f = this._stackRoot.localPosition.y;
        }
    }

    [SerializeField]
    private SpriteRenderer _nearLayer;
    private float _0x834d814f;
    [SerializeField]
    private float _nearFactor = 0.14f;
    private void _0x9d645ff9(SpriteRenderer _0x22563d18, float _0x4936751f, float _0x03bab857, float _0xa282c344, float _0x113eb35f)
    {
        Vector3 _0xba58bdad = _0x22563d18.transform.localPosition;
        _0xba58bdad.x = (_0x4936751f - 0.5f) * _0x03bab857 * 0.6f;
        _0x22563d18.transform.localPosition = _0xba58bdad;
        // Mirrored through flipX, never through the transform: the layer is Sliced and
        // its footprint lives in SpriteRenderer.size, which a scale would fight.
        _0x22563d18.flipX = _0x4936751f > 0.5f;
        _0x22563d18.transform.localScale = Vector3.one;
        Color _0x70dcdf74 = _0x22563d18.color;
        _0x70dcdf74.a = Mathf.Lerp(_0xa282c344, _0x113eb35f, _0x4936751f);
        _0x22563d18.color = _0x70dcdf74;
    }
}