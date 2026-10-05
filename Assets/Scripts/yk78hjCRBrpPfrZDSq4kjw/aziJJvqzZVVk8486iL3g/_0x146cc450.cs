using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x7a51889f;

public class _0x146cc450 : MonoBehaviour
{
    public void _0x947dae0d(int _0x49760041)
    {
        if (_0x49760041 == _0x072f746b.SPLASH && _0x1e5d523c.Instance._0x47b53557 != _0x628a7dd7.SCENE_0)
            _0x31ad5810.Instance._0x39ccf4df();
        if (_0x1e5d523c.Instance._0x47b53557 != _0x628a7dd7.SCENE_0)
        {
            if (_0x49760041 == _0x072f746b.SPLASH || _0x49760041 == _0x072f746b.TUTORIAL0)
                _0x1e5d523c.Instance._0x56411c3c(false);
            else if (_0x49760041 == _0x072f746b.DEFAULT)
                _0x1e5d523c.Instance._0x56411c3c(true);
        }
    }

    public int CurrentPanelIndex;
    private void _0x35e0ccc7()
    {
        this._0x46027eaa(_0x072f746b.SPLASH);
        if (_0x1e5d523c.Instance._0x47b53557 == _0x628a7dd7.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x31ad5810.Instance.DefaultAnimationTime);
        }
    }

    public List<_0xea2eac66> Panels;
    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x146cc450>();
    }

    private void _0xee9ea7a5(int _0x46238a20)
    {
        if (_0x46238a20 == _0x072f746b.SPLASH)
            _0x31ad5810.Instance._0x51dad0e4();
        if (_0x1e5d523c.Instance._0x47b53557 == _0x628a7dd7.SCENE_0)
        {
        }
    }

    public bool IsShowSplashOnStart = true;
    private _0xea2eac66 _0x2b1f6dae(int _0xfedb883c)
    {
        return this.Panels[_0xfedb883c];
    }

    public static _0x146cc450 Instance;
    private void _0x46027eaa(int _0x0cf9cfba)
    {
        this._0x9978820a(_0x0cf9cfba);
        this._0xee9ea7a5(_0x0cf9cfba);
        this.CurrentPanelIndex = _0x0cf9cfba;
        this.Panels[_0x0cf9cfba]._0x31186054();
    }

    private void _0x89dec89c(int _0x3b76f594)
    {
        this.LastPanelIndexes.Add(_0x3b76f594);
        this.CurrentPanelIndex = _0x3b76f594;
        for (int _0xdd5a3508 = 0; _0xdd5a3508 < this.Panels.Count; _0xdd5a3508++)
            if (_0xdd5a3508 != _0x3b76f594 && this.Panels[_0xdd5a3508] != null)
                this.Panels[_0xdd5a3508]._0x41e94d5b();
    }

    private void Start()
    {
        this._0x35e0ccc7();
    }

    private void _0x9978820a(int _0xf7753e82)
    {
        this.LastPanelIndexes.Add(_0xf7753e82);
        this.CurrentPanelIndex = _0xf7753e82;
        for (int _0x443b68a8 = 0; _0x443b68a8 < this.Panels.Count; _0x443b68a8++)
            if (_0x443b68a8 != _0xf7753e82 && this.Panels[_0x443b68a8] != null)
                this.Panels[_0x443b68a8]._0x41e94d5b();
    }

    private void SwitchSplash()
    {
        if (_0xdda4a249.Instance.IsTutorialEnabled && !_0x1e5d523c._0x2b639aa9._0xc797e80d)
            this._0x52c81cdc(_0x072f746b.TUTORIAL0);
        else
            this._0x52c81cdc(_0x072f746b.DEFAULT);
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x89cf022e()
    {
        this.LastPanelIndexes.RemoveAll(_0x34ce9413 => _0x34ce9413 == this.CurrentPanelIndex);
        int _0x020a11a2 = this.LastPanelIndexes.Last();
        this._0xee9ea7a5(_0x020a11a2);
        this._0x89dec89c(_0x020a11a2);
        this.CurrentPanelIndex = _0x020a11a2;
        this.Panels[_0x020a11a2].Show();
    }

    public float StaticBlurMaterialInitialValue;
    public void _0x52c81cdc(int _0x20debbda)
    {
        this._0x9978820a(_0x20debbda);
        this._0xee9ea7a5(_0x20debbda);
        this.CurrentPanelIndex = _0x20debbda;
        this.Panels[_0x20debbda].Show();
    }
}