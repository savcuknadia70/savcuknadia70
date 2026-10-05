using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x318c4bb5 : MonoBehaviour
{
    private static float Linear(float _0x83d6feb7)
    {
        _0x83d6feb7 = Mathf.Clamp01(_0x83d6feb7);
        return _0x83d6feb7 <= 0.03928f ? _0x83d6feb7 / 12.92f : Mathf.Pow((_0x83d6feb7 + 0.055f) / 1.055f, 2.4f);
    }

    private void OnDisable()
    {
        if (this._0xa209678e != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xa209678e);
    }

    private const float TargetRatio = 7f;
    private const float MinRatio = 4.5f;
    private static float Ratio(Color _0xef9afbb2, Color _0x1766f86d)
    {
        float _0x59cb699d = Luminance(_0xef9afbb2);
        float _0x711abe60 = Luminance(_0x1766f86d);
        return (Mathf.Max(_0x59cb699d, _0x711abe60) + 0.05f) / (Mathf.Min(_0x59cb699d, _0x711abe60) + 0.05f);
    }

    private const float MinOutlineWidth = 0.01f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xceaa1ff9 != null)
            return;
        GameObject _0xfd7224e3 = new GameObject(_0xb8444a10._0x4aeae57f(new byte[16] { 97, 88, 69, 118, 90, 91, 65, 71, 84, 70, 65, 114, 64, 84, 71, 81 }, 53));
        _0xfd7224e3.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xfd7224e3);
        _0xceaa1ff9 = _0xfd7224e3.AddComponent<_0x318c4bb5>();
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x8c420701(Object _0xa111737e)
    {
        TMP_Text _0xb6ecad35 = _0xa111737e as TMP_Text;
        if (_0xb6ecad35 != null)
            this._0xc3e2bbe0.Add(_0xb6ecad35);
    }

    private readonly HashSet<TMP_Text> _0xc3e2bbe0 = new HashSet<TMP_Text>();
    private readonly List<TMP_Text> _0x6a1f2eef = new List<TMP_Text>();
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x0f629f95)
    {
        return 0.2126f * Linear(_0x0f629f95.r) + 0.7152f * Linear(_0x0f629f95.g) + 0.0722f * Linear(_0x0f629f95.b);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xa209678e;
    private static _0x318c4bb5 _0xceaa1ff9;
    private static void Fix(TMP_Text _0x01e212d1)
    {
        if (_0x01e212d1 == null || !_0x01e212d1.isActiveAndEnabled)
            return;
        Material _0x802be560 = _0x01e212d1.fontSharedMaterial;
        if (_0x802be560 == null || !_0x802be560.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x802be560.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x802be560.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x1f2f5804 = _0x01e212d1.color;
        if (_0x1f2f5804.a <= 0f)
            return;
        Color _0x28b59955 = _0x802be560.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x1f2f5804, _0x28b59955) >= MinRatio)
            return;
        Color _0x87bf0f52 = Luminance(_0x28b59955) < 0.5f ? Color.white : Color.black;
        Color _0x15d46225;
        if (Ratio(_0x87bf0f52, _0x28b59955) < TargetRatio)
        {
            _0x15d46225 = _0x87bf0f52;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x819f6e81 = 0f;
            float _0xb3921319 = 1f;
            for (int _0x46c040ab = 0; _0x46c040ab < 20; _0x46c040ab++)
            {
                float _0x39894679 = (_0x819f6e81 + _0xb3921319) * 0.5f;
                if (Ratio(Color.Lerp(_0x1f2f5804, _0x87bf0f52, _0x39894679), _0x28b59955) >= TargetRatio)
                    _0xb3921319 = _0x39894679;
                else
                    _0x819f6e81 = _0x39894679;
            }

            _0x15d46225 = Color.Lerp(_0x1f2f5804, _0x87bf0f52, _0xb3921319);
        }

        _0x15d46225.a = _0x1f2f5804.a;
        _0x01e212d1.color = _0x15d46225;
    }

    private void OnEnable()
    {
        if (this._0xa209678e == null)
            this._0xa209678e = _0xad23b9b1 => this._0x8c420701(_0xad23b9b1);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xa209678e);
    }

    private void LateUpdate()
    {
        if (this._0xc3e2bbe0.Count == 0)
            return;
        this._0x6a1f2eef.Clear();
        this._0x6a1f2eef.AddRange(this._0xc3e2bbe0);
        this._0xc3e2bbe0.Clear();
        for (int _0x14715d24 = 0; _0x14715d24 < this._0x6a1f2eef.Count; _0x14715d24++)
            Fix(this._0x6a1f2eef[_0x14715d24]);
    }
}

internal static class _0xb8444a10
{
    internal static string _0x4aeae57f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}