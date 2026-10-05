using UnityEngine;
using UnityEngine.UI;

public class _0xa5d2795f : MonoBehaviour
{
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x146cc450.Instance._0x52c81cdc(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x1e5d523c.Instance._0xe41c2230());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x146cc450.Instance._0x52c81cdc(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x146cc450.Instance._0x52c81cdc(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x1e5d523c.Instance._0xe41c2230());
        }
    }

    public int EndTutorialPanelIndex = 1;
    public Button TutorialEndButton;
    public bool IsTutorialEndPanel;
    public int NextTutorialPanelIndex;
    public Button NextTutorialButton;
}