using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xea2eac66 : MonoBehaviour
{
    public TMP_Text HeaderText;
    private void _0xdfe26887()
    {
        if (this.OuterBackground != null)
        {
            Image _0x4f30b0e9 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x4f30b0e9, true);
            _0x4f30b0e9.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private bool _0xa0e28b84 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0xbd4022cb()
    {
        if (this.OuterBackground != null)
        {
            Image _0xdb4a7bb8 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xdb4a7bb8, true);
            _0xdb4a7bb8.DOFade(0f, this.ScaleDuration);
        }
    }

    public GameObject OuterBackground;
    public GameObject Content;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xdfe26887();
    }

    public void Show()
    {
        this._0xae45fb60();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x146cc450.Instance._0x947dae0d(_0x146cc450.Instance.CurrentPanelIndex);
            });
        }
    }

    public bool IsScaledDownOnAwake = true;
    public float ScaleDuration = 0.4f;
    public Ease Ease = Ease.OutSine;
    public void _0x41e94d5b()
    {
        this._0xbd4022cb();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public TMP_Text MainText;
    private void _0xae45fb60()
    {
        if (this.OuterBackground != null)
        {
            Image _0x2af45676 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x2af45676, true);
            _0x2af45676.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0x252d0f8d()
    {
        if (this.OuterBackground != null)
        {
            Image _0x17f825f9 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x17f825f9, true);
            _0x17f825f9.DOFade(1f, 0f);
        }
    }

    public void _0x31186054()
    {
        this._0x252d0f8d();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x146cc450.Instance._0x947dae0d(_0x146cc450.Instance.CurrentPanelIndex);
    }
}