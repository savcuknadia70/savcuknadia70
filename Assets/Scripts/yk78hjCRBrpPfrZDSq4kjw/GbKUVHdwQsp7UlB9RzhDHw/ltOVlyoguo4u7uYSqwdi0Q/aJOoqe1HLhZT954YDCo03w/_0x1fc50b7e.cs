using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x1fc50b7e : MonoBehaviour
{
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x1e5d523c.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x1e5d523c.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public Button Button;
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}