using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Blanks the filler copy that ships on template panels this game does not dress
/// (the tutorial group, PANELS.TUTORIAL0..TUTORIAL6), so no template filler can reach
/// a build. Only labels handed in explicitly are touched - nothing is found by name.
/// </summary>
public sealed class _0xfc12186c : MonoBehaviour
{
    private void Awake()
    {
        for (int _0xf5d75d84 = 0; _0xf5d75d84 < this._labelsToBlank.Count; _0xf5d75d84++)
        {
            if (this._labelsToBlank[_0xf5d75d84] != null)
            {
                this._labelsToBlank[_0xf5d75d84].text = string.Empty;
            }
        }
    }

    [SerializeField]
    private List<TMP_Text> _labelsToBlank = new();
}