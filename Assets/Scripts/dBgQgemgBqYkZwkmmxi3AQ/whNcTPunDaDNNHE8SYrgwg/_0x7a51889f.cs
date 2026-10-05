using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x7a51889f
{
    public static class _0xf07bddee
    {
        public static int _0xd4c8ceb5
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x4086b9d2._0x94328821(new byte[5] { 36, 8, 14, 9, 20 }, 103)))
                    PlayerPrefs.SetInt(_0x4086b9d2._0x94328821(new byte[5] { 209, 253, 251, 252, 225 }, 146), 0);
                return PlayerPrefs.GetInt(_0x4086b9d2._0x94328821(new byte[5] { 180, 152, 158, 153, 132 }, 247));
            }

            set
            {
                PlayerPrefs.SetInt(_0x4086b9d2._0x94328821(new byte[5] { 91, 119, 113, 118, 107 }, 24), value);
                _0x1e5d523c.Instance._0x98d634c7();
            }
        }
    }

    public static class _0xa5f1506c
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x3cc76443
    {
        private static readonly _0x3cc76443 _0x5054e0df = new();
        public static readonly _0x3cc76443[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x5054e0df,
            _0x5054e0df,
            _0x5054e0df,
        };
        private int _0x3bdb2f11 => 0;
        private int _0xde209a4e => 10;
        private string _0x6312ae91 => _0x4086b9d2._0x94328821(new byte[4] { 172, 132, 143, 148 }, 225);
        private string _0xc5c2b924 => _0x4086b9d2._0x94328821(new byte[8] { 150, 159, 140, 159, 150, 161, 234, 167 }, 218);

        private int _0xde19188d
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x4086b9d2._0x94328821(new byte[25] { 183, 129, 134, 134, 145, 154, 128, 179, 152, 155, 150, 149, 152, 183, 156, 149, 132, 128, 145, 134, 189, 154, 144, 145, 140 }, 244)))
                    PlayerPrefs.SetInt(_0x4086b9d2._0x94328821(new byte[25] { 233, 223, 216, 216, 207, 196, 222, 237, 198, 197, 200, 203, 198, 233, 194, 203, 218, 222, 207, 216, 227, 196, 206, 207, 210 }, 170), 0);
                return PlayerPrefs.GetInt(_0x4086b9d2._0x94328821(new byte[25] { 97, 87, 80, 80, 71, 76, 86, 101, 78, 77, 64, 67, 78, 97, 74, 67, 82, 86, 71, 80, 107, 76, 70, 71, 90 }, 34));
            }

            set => PlayerPrefs.SetInt(_0x4086b9d2._0x94328821(new byte[25] { 196, 242, 245, 245, 226, 233, 243, 192, 235, 232, 229, 230, 235, 196, 239, 230, 247, 243, 226, 245, 206, 233, 227, 226, 255 }, 135), value);
        }

        public int _0x723297fe
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x6312ae91}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x6312ae91}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x6312ae91}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x6312ae91}CurrentLevelIndex", value);
        }

        public int _0xa9b3634f
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x6312ae91}BestScore"))
                    this._0xa9b3634f = 0;
                return PlayerPrefs.GetInt($"{this._0x6312ae91}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x6312ae91}BestScore", value);
        }

        public bool _0xc797e80d
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x6312ae91}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x6312ae91}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x6312ae91}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x6312ae91}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x072f746b
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x628a7dd7
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x4086b9d2
{
    internal static string _0x94328821(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}