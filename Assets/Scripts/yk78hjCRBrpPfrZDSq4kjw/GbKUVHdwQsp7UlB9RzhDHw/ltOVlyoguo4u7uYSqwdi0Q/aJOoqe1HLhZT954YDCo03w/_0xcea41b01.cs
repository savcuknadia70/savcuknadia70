using UnityEngine;
using UnityEngine.UI;

public class _0xcea41b01 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x8e6d2614.Instance._0xef00c6b4();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x8e6d2614.Instance._0x47cdbdca());
        else
            this.Button.onClick.AddListener(() => _0x8e6d2614.Instance._0xb617e046(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
    public int PopToShowIndex;
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}