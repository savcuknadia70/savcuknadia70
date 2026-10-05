using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x7a51889f;

public class _0x8e6d2614 : MonoBehaviour
{
    public List<int> LastPopIndexes = new();
    private void _0x352ef03e()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public static _0x8e6d2614 Instance;
    public int CurrentPopIndex;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0xb617e046(int _0x1f8553a0)
    {
        this.CurrentPopIndex = _0x1f8553a0;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xba44dd8c(true);
        this._0x352ef03e();
        this.Pops[_0x1f8553a0].Show();
        foreach (GameObject _0x99b9a810 in this.GameObjectsToHide)
            _0x99b9a810.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xecd2848e _0xa64a60dd in this.Pops)
            if (_0xa64a60dd != null)
                _0xa64a60dd.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x8e6d2614>();
    }

    private void _0xba44dd8c(bool _0xccde301e = false)
    {
        for (int _0x43b2e003 = 0; _0x43b2e003 < this.Pops.Count; ++_0x43b2e003)
            if (this.Pops[_0x43b2e003] != null && !(_0x43b2e003 == this.CurrentPopIndex && _0xccde301e))
                this.Pops[_0x43b2e003]._0x70c30b88();
    }

    public float ScaleDuration = 0.4f;
    private void _0xfb479d34()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0xef00c6b4()
    {
        this.LastPopIndexes.RemoveAll(_0x34ce9413 => _0x34ce9413 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x47cdbdca();
        else
            this._0xb617e046(this.LastPopIndexes.Last());
    }

    public List<_0xecd2848e> Pops;
    public void _0x47cdbdca()
    {
        this.LastPopIndexes.Clear();
        this._0xba44dd8c();
        foreach (GameObject _0x653b9ddd in this.GameObjectsToHide)
            if (_0x653b9ddd != null)
                _0x653b9ddd.SetActive(true);
        this._0xfb479d34();
    }

    public _0xecd2848e _0x4a216a96(int _0x116e162b)
    {
        return this.Pops[_0x116e162b];
    }
}