using UnityEngine;

public class _0xdda4a249 : MonoBehaviour
{
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelIncrementOnWin;
    public static _0xdda4a249 Instance;
    public bool IsCheckScoreEnabled;
    public bool IsBestScoreEnabled;
    public bool IsStoryEnabled;
    private void _0xad12be80()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    private void _0x7f71d7de()
    {
    }

    public bool IsLevelSelectorEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsTimerEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xdda4a249>();
            DontDestroyOnLoad(this.gameObject);
            this._0xad12be80();
        }
        else
        {
            this._0x7f71d7de();
            Destroy(this.gameObject);
        }
    }
}