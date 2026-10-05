using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x35b26bbe : MonoBehaviour
{
    private Vector3 _0xcb929636 { get; set; }
    private Vector3 _0xc010fdfc { get; set; }
    private Vector3 _0x85d76407 { get; set; }

    private void Awake()
    {
        this._0xcc0a42d5 = this.GetComponent<Camera>();
        _0xf91b1e07 = this;
        this._0xf93404e1();
    }

    private Vector3 _0xfe1c81c8 { get; set; }
    private Vector3 _0x7fd7500a { get; set; }

    public enum _0xa54d50c9
    {
        Landscape,
        Portrait
    }

    private new Camera _0xcc0a42d5;
    private void _0xf93404e1()
    {
        float _0x35007128, _0x9c601987, _0x0ee519f6, _0xeef6bb2c;
        if (this._0xfbf92447 == _0xa54d50c9.Landscape)
            this._0xcc0a42d5.orthographicSize = 1f / this._0xcc0a42d5.aspect * this._0x2266ca2c / 2f;
        else
            this._0xcc0a42d5.orthographicSize = this._0x2266ca2c / 2f;
        this._0xdadf3528 = 2f * this._0xcc0a42d5.orthographicSize;
        this._0xde73be7f = this._0xdadf3528 * this._0xcc0a42d5.aspect;
        float _0xcc135833 = this._0xcc0a42d5.transform.position.x;
        float _0x1ae139df = this._0xcc0a42d5.transform.position.y;
        _0x35007128 = _0xcc135833 - this._0xde73be7f / 2;
        _0x9c601987 = _0xcc135833 + this._0xde73be7f / 2;
        _0x0ee519f6 = _0x1ae139df + this._0xdadf3528 / 2;
        _0xeef6bb2c = _0x1ae139df - this._0xdadf3528 / 2;
        this._0x7cbd0bfb = new Vector3(_0x35007128, _0xeef6bb2c, 0);
        this._0xfe1c81c8 = new Vector3(_0xcc135833, _0xeef6bb2c, 0);
        this._0xa5ac1746 = new Vector3(_0x9c601987, _0xeef6bb2c, 0);
        this._0x37e873a0 = new Vector3(_0x35007128, _0x1ae139df, 0);
        this._0xc010fdfc = new Vector3(_0xcc135833, _0x1ae139df, 0);
        this._0x85d76407 = new Vector3(_0x9c601987, _0x1ae139df, 0);
        this._0x7fd7500a = new Vector3(_0x35007128, _0x0ee519f6, 0);
        this._0x1d5281d6 = new Vector3(_0xcc135833, _0x0ee519f6, 0);
        this._0xcb929636 = new Vector3(_0x9c601987, _0x0ee519f6, 0);
    }

    private Color _0x15a2eb41 = Color.white;
    private static _0x35b26bbe _0xf91b1e07;
    private Vector3 _0x37e873a0 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x15a2eb41;
        Matrix4x4 _0xc4846559 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xcc0a42d5.orthographic)
        {
            float _0x6f4bdcf1 = this._0xcc0a42d5.farClipPlane - this._0xcc0a42d5.nearClipPlane;
            float _0xaa9c3f05 = (this._0xcc0a42d5.farClipPlane + this._0xcc0a42d5.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xaa9c3f05), new Vector3(this._0xcc0a42d5.orthographicSize * 2 * this._0xcc0a42d5.aspect, this._0xcc0a42d5.orthographicSize * 2, _0x6f4bdcf1));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xcc0a42d5.fieldOfView, this._0xcc0a42d5.farClipPlane, this._0xcc0a42d5.nearClipPlane, this._0xcc0a42d5.aspect);
        }

        Gizmos.matrix = _0xc4846559;
    }

    //public bool executeInUpdate;
    private float _0xde73be7f { get; set; }

    private float _0x2266ca2c = 1;
    private Vector3 _0xa5ac1746 { get; set; }
    private float _0xdadf3528 { get; set; }
    private Vector3 _0x7cbd0bfb { get; set; }
    private Vector3 _0x1d5281d6 { get; set; }

    private _0xa54d50c9 _0xfbf92447 = _0xa54d50c9.Portrait;
}