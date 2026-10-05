using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x31ad5810 : MonoBehaviour
{
    public GameObject Background;
    public void _0xc5b81a8a()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x4aaab2f0?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x9e2980c8 = false;
    }

    public float FirstAnimationTime = 10.0f;
    public static _0x31ad5810 Instance;
    public Slider AnimationSlider;
    private void _0x4b76b8fc()
    {
        this.AnimationSlider.value = 0.05f;
        _0x9e2980c8 = !_0x9e2980c8;
        this._0x4aaab2f0 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xe1fdf190 => this.AnimationSlider.value = _0xe1fdf190, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x08e537a8._0x979cb192?._0x10a1de56();
        });
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x7a51889f._0x628a7dd7.SCENE_0 && !_0x9e2980c8)
        {
            this._0x4b76b8fc();
        }
        else
        {
            this._0x39ccf4df();
        }
    }

    public void _0x39ccf4df()
    {
        this._0x51dad0e4();
        bool _0xe701156e = _0x9e2980c8;
        this._0x4aaab2f0 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xe1fdf190 => this.AnimationSlider.value = _0xe1fdf190, _0xe701156e ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x9e2980c8 = !_0x9e2980c8;
    }

    public void _0xc87bda49()
    {
        this._0x4aaab2f0?.Play();
    }

    public GameObject Error;
    public GameObject Content;
    private Sequence _0x4aaab2f0;
    private static bool _0x9e2980c8 = false;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x31ad5810>();
    }

    public void _0x866f473e()
    {
        this._0x4aaab2f0?.Pause();
    }

    public float DefaultAnimationTime = 0.4f;
    public void _0x51dad0e4()
    {
        this._0x4aaab2f0?.Kill();
        this.AnimationSlider.value = _0x9e2980c8 ? this.SecondPassSliderValue : 0.05f;
    }

    public float SecondPassSliderValue = 0.5f;
}