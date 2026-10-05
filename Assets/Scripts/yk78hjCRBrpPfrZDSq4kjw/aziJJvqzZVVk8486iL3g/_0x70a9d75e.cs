using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x70a9d75e : MonoBehaviour
{
    public void _0x18ca7d55()
    {
        if (!this.IsGameEnd)
        {
            this._0xb3707fa8();
            _0x1e5d523c.IsAfterLevelComplete = true;
            _0x1e5d523c.IsAfterLevelFailed = false;
            _0xecd2848e _0xac3525e4 = _0x8e6d2614.Instance._0x4a216a96(_0x7a51889f._0xa5f1506c.WIN).GetComponent<_0xecd2848e>();
            if (_0xdda4a249.Instance.IsCheckScoreEnabled)
                _0xac3525e4.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xee838e65}";
            else
                _0xac3525e4.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xdda4a249.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x7a51889f._0xf07bddee._0xd4c8ceb5)
                    _0x7a51889f._0xf07bddee._0xd4c8ceb5 = this.ScoreCurrent;
                _0xac3525e4.ContentAdditionalText.text = $"{_0x7a51889f._0xf07bddee._0xd4c8ceb5}";
            }
            else
            {
                _0xac3525e4.ContentAdditionalText.text = $"{this._0xf41f0d15}";
                _0x7a51889f._0xf07bddee._0xd4c8ceb5 += this._0xf41f0d15;
            }

            if (_0xdda4a249.Instance.IsLevelIncrementOnWin)
                ++_0x1e5d523c._0x2b639aa9._0x723297fe;
            _0x8e6d2614.Instance._0xb617e046(_0x7a51889f._0xa5f1506c.WIN);
        }
    }

    public List<TMP_Text> TimerText = new();
    public List<Button> PauseButtons = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x5d14c0ee()
    {
        _0x1e5d523c.Instance._0x56411c3c(true);
        _0x1e5d523c.Instance.LoadSceneByIndex(_0x7a51889f._0x628a7dd7.SCENE_0);
    }

    private static _0x70a9d75e _0xbdfa31cf;
    private void Awake()
    {
        _0xbdfa31cf = this.gameObject.GetComponent<_0x70a9d75e>();
    }

    [HideInInspector]
    public int ScoreCurrent;
    public void _0xa6d8dd97(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x93f438db();
            this._0xaebd78ff();
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> SubtitleText = new();
    private int _0xee838e65 => this.CustomTargetScore + _0x1e5d523c._0x2b639aa9._0x723297fe * 10;

    public void _0xcbf3aa93()
    {
        if (_0xdda4a249.Instance.IsOnlyWinGameEndEnabled)
            this._0x18ca7d55();
        if (!this.IsGameEnd)
        {
            this._0xb3707fa8();
            _0x1e5d523c.IsAfterLevelComplete = false;
            _0x1e5d523c.IsAfterLevelFailed = true;
            _0xecd2848e _0x1d3f69dc = _0x8e6d2614.Instance._0x4a216a96(_0x7a51889f._0xa5f1506c.LOSE).GetComponent<_0xecd2848e>();
            if (_0xdda4a249.Instance.IsCheckScoreEnabled)
                _0x1d3f69dc.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xee838e65}";
            else
                _0x1d3f69dc.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x1d3f69dc.ContentAdditionalText.text = $"{0}";
            _0x7a51889f._0xf07bddee._0xd4c8ceb5 += 0;
            _0x8e6d2614.Instance._0xb617e046(_0x7a51889f._0xa5f1506c.LOSE);
        }
    }

    public int CustomTargetScore = 10;
    private int _0xcd7b534d => this.CustomTimeInitial + _0x1e5d523c._0x2b639aa9._0x723297fe * 10;

    [HideInInspector]
    public int TimeLeft;
    private void _0xeb817f5d()
    {
        this.TimerText.ForEach(_0x5020d1a7 => _0x5020d1a7.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xafc54458._0xaf6a60e4(new byte[6] { 255, 255, 206, 168, 225, 225 }, 146)));
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xcd7b534d;
        this.CurrentGameIndex = _0x1e5d523c.Instance._0x47b53557;
        foreach (Button _0xfbb2a9ef in this.HomeButtons)
            _0xfbb2a9ef.onClick.AddListener(() =>
            {
                this._0x5d14c0ee();
            });
        foreach (Button _0xcd3ff6fe in this.PauseButtons)
            _0xcd3ff6fe.onClick.AddListener(() =>
            {
                _0x1e5d523c.Instance._0x56411c3c(false);
                _0x8e6d2614.Instance._0xb617e046(_0x7a51889f._0xa5f1506c.PAUSE);
            });
        this._0x93f438db();
        this.LevelNumberText.ForEach(_0x5020d1a7 => _0x5020d1a7.text = $"LVL {_0x1e5d523c._0x2b639aa9._0x723297fe + 1}");
        if (_0xdda4a249.Instance.IsTimerEnabled)
        {
            this._0xeb817f5d();
            this.StartCoroutine(this._0xcf58ebef());
        }
    }

    private void _0xeeb626f4()
    {
        if (this.ScoreCurrent >= this._0xee838e65)
            this._0x18ca7d55();
        else
            this._0xcbf3aa93();
    }

    private void _0xaebd78ff()
    {
        if (this.ScoreCurrent > _0x1e5d523c._0x2b639aa9._0xa9b3634f)
            _0x1e5d523c._0x2b639aa9._0xa9b3634f = this.ScoreCurrent;
        if (_0xdda4a249.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xee838e65)
                this._0x18ca7d55();
    }

    private void _0xb3707fa8()
    {
        this.IsGameEnd = true;
        _0x1e5d523c.IsAfterLevelComplete = true;
    }

    private void _0x93f438db()
    {
        if (_0xdda4a249.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x5020d1a7 => _0x5020d1a7.text = $"{this.ScoreCurrent}/{this._0xee838e65}");
        else
            this.ScoreText.ForEach(_0x5020d1a7 => _0x5020d1a7.text = $"{this.ScoreCurrent}");
    }

    private IEnumerator _0xcf58ebef()
    {
        this._0xeb817f5d();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x1e5d523c.Instance._0x47b53557 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x1e5d523c.Instance._0x5c41302d)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xeb817f5d();
            }
        }

        if (!this.IsGameEnd)
            this._0xcbf3aa93();
    }

    public List<Button> HomeButtons = new();
    public List<TMP_Text> ScoreText = new();
    public int CustomTimeInitial = 30;
    private int _0xf41f0d15 => this.ScoreCurrent;
}

internal static class _0xafc54458
{
    internal static string _0xaf6a60e4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}