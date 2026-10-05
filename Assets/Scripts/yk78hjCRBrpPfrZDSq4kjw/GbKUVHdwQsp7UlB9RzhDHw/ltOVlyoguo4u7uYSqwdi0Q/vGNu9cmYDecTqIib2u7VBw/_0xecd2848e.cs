using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xecd2848e : MonoBehaviour
{
    public static void HideAllPops()
    {
        _0x8e6d2614.Instance._0x47cdbdca();
    }

    public GameObject Content;
    public float scaleDuration = 0.4f;
    private bool _0xb5dd2035 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentHeaderText;
    public Ease ease = Ease.OutSine;
    private void _0x8543a6cd()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x8543a6cd();
    }

    public TMP_Text ContentAdditionalText;
    public bool IsOnlyYScale;
    public bool IsScaledDownOnAwake = true;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public Image ContentImage;
    public void _0x70c30b88()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public TMP_Text ContentMainText;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }
}