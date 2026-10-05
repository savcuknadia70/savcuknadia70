using UnityEngine;
using UnityEngine.UI;

public class _0x8b8e67aa : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x1e5d523c.Instance._0x56411c3c(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}