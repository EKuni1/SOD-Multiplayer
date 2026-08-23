using System;
using System.Collections.Generic;
using System.IO;
using FMOD.Studio;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UI;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
public class SessionData : MonoBehaviour
{
	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006D")]
	public static SessionData Instance
	{
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x5622E0", Offset = "0x5612E0", VA = "0x1805622E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1400000E RID: 14
	// (add) Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400000E")]
	public event SessionData.OnPauseUnPause OnPauseChange
	{
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x562320", Offset = "0x561320", VA = "0x180562320")]
		add
		{
		}
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x562420", Offset = "0x561420", VA = "0x180562420")]
		remove
		{
		}
	}

	// Token: 0x1400000F RID: 15
	// (add) Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000B45 RID: 2885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400000F")]
	public event SessionData.WeatherChange OnWeatherChange
	{
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x562520", Offset = "0x561520", VA = "0x180562520")]
		add
		{
		}
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x562620", Offset = "0x561620", VA = "0x180562620")]
		remove
		{
		}
	}

	// Token: 0x14000010 RID: 16
	// (add) Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000010")]
	public event SessionData.HourChange OnHourChange
	{
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x562720", Offset = "0x561720", VA = "0x180562720")]
		add
		{
		}
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x562820", Offset = "0x561820", VA = "0x180562820")]
		remove
		{
		}
	}

	// Token: 0x14000011 RID: 17
	// (add) Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000011")]
	public event SessionData.TutorialNotificationChange OnTutorialNotificationChange
	{
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x562920", Offset = "0x561920", VA = "0x180562920")]
		add
		{
		}
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x562A20", Offset = "0x561A20", VA = "0x180562A20")]
		remove
		{
		}
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x562B20", Offset = "0x561B20", VA = "0x180562B20")]
	private void Awake()
	{
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x5642D0", Offset = "0x5632D0", VA = "0x1805642D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x564AE0", Offset = "0x563AE0", VA = "0x180564AE0")]
	private void Start()
	{
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x565690", Offset = "0x564690", VA = "0x180565690")]
	public void SetupTelevisionChannels()
	{
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x565A90", Offset = "0x564A90", VA = "0x180565A90")]
	public void StartTestScene()
	{
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x5668B0", Offset = "0x5658B0", VA = "0x1805668B0")]
	public void SetGameTime(int newYear, int newMonth, int newDate, int newDay, float newStartingTime, int newLeapYearCycle)
	{
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x566E10", Offset = "0x565E10", VA = "0x180566E10")]
	public void SetGameTime(float newGameTime, int newLeapYearCycle)
	{
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x567140", Offset = "0x566140", VA = "0x180567140")]
	public void UpdateSkyboxGraidentTargets()
	{
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x567670", Offset = "0x566670", VA = "0x180567670")]
	public void SetTimeSpeed(SessionData.TimeSpeed newTimeSpeed)
	{
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00006BE8 File Offset: 0x00004DE8
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x567A50", Offset = "0x566A50", VA = "0x180567A50")]
	public float GetGameSpeedMotionBlurModifier()
	{
		return 0f;
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x567AB0", Offset = "0x566AB0", VA = "0x180567AB0")]
	public void SetSceneProfile(SessionData.SceneProfile newProfile, bool immediate = false)
	{
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x567F40", Offset = "0x566F40", VA = "0x180567F40")]
	private void Update()
	{
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x56B6E0", Offset = "0x56A6E0", VA = "0x18056B6E0")]
	public void UpdateGameTimerText()
	{
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x56B810", Offset = "0x56A810", VA = "0x18056B810")]
	public void EndDemo()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x56BAD0", Offset = "0x56AAD0", VA = "0x18056BAD0")]
	public void ExecuteSyncPhysics(SessionData.PhysicsSyncType syncType)
	{
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x56BBB0", Offset = "0x56ABB0", VA = "0x18056BBB0")]
	public void ExecuteWeatherChange()
	{
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x56C490", Offset = "0x56B490", VA = "0x18056C490")]
	public void ExecuteWetnessChange()
	{
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x56C780", Offset = "0x56B780", VA = "0x18056C780")]
	public void ExecuteWindChange()
	{
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x56C7D0", Offset = "0x56B7D0", VA = "0x18056C7D0")]
	public Material GetWeatherAffectedMaterial(Material inputMat, MeshRenderer inputRenderer)
	{
		return null;
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x56CA90", Offset = "0x56BA90", VA = "0x18056CA90")]
	public void ExecuteLightningStrike()
	{
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x56E730", Offset = "0x56D730", VA = "0x18056E730")]
	public void SetSceneVisuals(float newDecimalClock)
	{
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x570A40", Offset = "0x56FA40", VA = "0x180570A40")]
	public void SetEnablePause(bool val)
	{
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x570A60", Offset = "0x56FA60", VA = "0x180570A60")]
	public void ParseTimeData(float newTime, out float decimalHourOut, out int dayIntOut, out int dateIntOut, out int monthIntOut, out int yearIntOut, out SessionData.WeekDay dayEnumOut, out SessionData.Month monthEnumOut, out int leapCycleOut)
	{
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x570CF0", Offset = "0x56FCF0", VA = "0x180570CF0")]
	public void ParseTimeData(float newTime, out float decimalHourOut, out int dayIntOut, out int dateIntOut, out int monthIntOut, out int yearIntOut)
	{
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x570FE0", Offset = "0x56FFE0", VA = "0x180570FE0")]
	public void ParseTimeData(float newTime, out float decimalHourOut, out SessionData.WeekDay dayEnumOut, out int dateIntOut, out SessionData.Month monthEnumOut, out int yearIntOut)
	{
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00006C00 File Offset: 0x00004E00
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x571180", Offset = "0x570180", VA = "0x180571180")]
	public float ParseGameTime(float decimalHourIn, int dateIntIn, int monthIntIn, int yearIntIn, out int dayCount, out int leapYear)
	{
		return 0f;
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00006C18 File Offset: 0x00004E18
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x571440", Offset = "0x570440", VA = "0x180571440")]
	public float FloatDecimal24H(float time)
	{
		return 0f;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00006C30 File Offset: 0x00004E30
	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x5714A0", Offset = "0x5704A0", VA = "0x1805714A0")]
	public float FloatMinutes24H(float newTime)
	{
		return 0f;
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00006C48 File Offset: 0x00004E48
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x571540", Offset = "0x570540", VA = "0x180571540")]
	public float FloatMinutes12H(float newTime)
	{
		return 0f;
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x571600", Offset = "0x570600", VA = "0x180571600")]
	public string DecimalToClockString(float newTime, bool useZeroHoursMethod)
	{
		return null;
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x571640", Offset = "0x570640", VA = "0x180571640")]
	public string DecimalToTimeLengthString(float newTime)
	{
		return null;
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x5717D0", Offset = "0x5707D0", VA = "0x1805717D0")]
	public string GameTimeToClock24String(float newGameTime, bool useZeroHoursMethod)
	{
		return null;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x571860", Offset = "0x570860", VA = "0x180571860")]
	public string GameTimeToClock12String(float newGameTime, bool useZeroHoursMethod)
	{
		return null;
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x571A20", Offset = "0x570A20", VA = "0x180571A20")]
	public string MinutesToClockString(float formatted, bool useZeroHoursMethod)
	{
		return null;
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x571C10", Offset = "0x570C10", VA = "0x180571C10")]
	public string CurrentTimeString(bool useZeroHoursMethod, bool use12HourClock = false)
	{
		return null;
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x571C70", Offset = "0x570C70", VA = "0x180571C70")]
	public string ShortDateString(float newGameTime, bool shortenYear)
	{
		return null;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x5720C0", Offset = "0x5710C0", VA = "0x1805720C0")]
	public string CurrentShortDateString(bool shortenYear)
	{
		return null;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x5720E0", Offset = "0x5710E0", VA = "0x1805720E0")]
	public string LongDateString(float newGameTime, bool includeDay, bool shortenDay, bool includeMonth, bool shortenMonth, bool includeDate, bool includeYear, bool shortenYear, bool useCommas)
	{
		return null;
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x572700", Offset = "0x571700", VA = "0x180572700")]
	public string CurrentLongDateString(bool includeDay, bool shortenDay, bool includeMonth, bool shortenMonth, bool includeDate, bool includeYear, bool shortenYear, bool useCommas)
	{
		return null;
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x5717D0", Offset = "0x5707D0", VA = "0x1805717D0")]
	public string TimeString(float newGameTime, bool useZeroHoursMethod)
	{
		return null;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x572770", Offset = "0x571770", VA = "0x180572770")]
	public string TimeStringOnDay(float newGameTime, bool useZeroHoursMethod, bool shortenDay)
	{
		return null;
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x5729F0", Offset = "0x5719F0", VA = "0x1805729F0")]
	public string TimeAndDate(float newGameTime, bool useZeroHoursMethod, bool shortenDay, bool shortenYear)
	{
		return null;
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x572A90", Offset = "0x571A90", VA = "0x180572A90")]
	public string OnDay(int newDay, bool shortenDay)
	{
		return null;
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00006C60 File Offset: 0x00004E60
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x572CD0", Offset = "0x571CD0", VA = "0x180572CD0")]
	public float GetNextOrPreviousGameTimeForThisHour(ref List<SessionData.WeekDay> days, float startHour, float endHour)
	{
		return 0f;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00006C78 File Offset: 0x00004E78
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x572D10", Offset = "0x571D10", VA = "0x180572D10")]
	public float GetNextOrPreviousGameTimeForThisHour(float forThisGameTime, float forThisDecimalHour, SessionData.WeekDay forThisWeekday, ref List<SessionData.WeekDay> validWeekDays, float startDecimalHour, float endDecimalHour)
	{
		return 0f;
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00006C90 File Offset: 0x00004E90
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x572F40", Offset = "0x571F40", VA = "0x180572F40")]
	public float GetTimeDifference(float time1, float time2)
	{
		return 0f;
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00006CA8 File Offset: 0x00004EA8
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x572F50", Offset = "0x571F50", VA = "0x180572F50")]
	public bool CompareTimes(float time1, float time2)
	{
		return default(bool);
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00006CC0 File Offset: 0x00004EC0
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x573050", Offset = "0x572050", VA = "0x180573050")]
	public SessionData.WeekDay WeekdayFromInt(int weekInt)
	{
		return SessionData.WeekDay.monday;
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x00006CD8 File Offset: 0x00004ED8
	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x573050", Offset = "0x572050", VA = "0x180573050")]
	public SessionData.Month MonthFromInt(int monthInt)
	{
		return SessionData.Month.jan;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x573060", Offset = "0x572060", VA = "0x180573060")]
	public void SetWeather(float newRain, float newWind, float newSnow, float newLightning, float newFog, float newTransitionSpeed = 0.1f, bool updateInstantly = false)
	{
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x5734F0", Offset = "0x5724F0", VA = "0x1805734F0")]
	public void UpdateWatchText()
	{
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x573840", Offset = "0x572840", VA = "0x180573840")]
	public void UpdateWatchDay()
	{
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x574080", Offset = "0x573080", VA = "0x180574080")]
	public void TogglePause(bool openDesktopMode = true)
	{
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x5740C0", Offset = "0x5730C0", VA = "0x1805740C0")]
	public void PauseGame(bool showPauseText, bool delayOverride = false, bool openDesktopMode = true)
	{
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x574C10", Offset = "0x573C10", VA = "0x180574C10")]
	public void ResumeGame()
	{
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x575BE0", Offset = "0x574BE0", VA = "0x180575BE0")]
	public void SetDisplayTutorialText(bool val)
	{
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x575F60", Offset = "0x574F60", VA = "0x180575F60")]
	public void TutorialTrigger(string str, bool isSilent = false)
	{
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x5762F0", Offset = "0x5752F0", VA = "0x1805762F0")]
	public void UpdateTutorialNotifications()
	{
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x5763D0", Offset = "0x5753D0", VA = "0x1805763D0")]
	public void ExecuteUnloadPipes()
	{
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x576790", Offset = "0x575790", VA = "0x180576790")]
	public void OnSceneExit()
	{
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x5767E0", Offset = "0x5757E0", VA = "0x1805767E0")]
	public void DebugPreviousOrLastTime()
	{
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x5768A0", Offset = "0x5758A0", VA = "0x1805768A0")]
	public SessionData()
	{
	}

	// Token: 0x04000B29 RID: 2857
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x18")]
	public bool isFloorEdit;

	// Token: 0x04000B2A RID: 2858
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x19")]
	public bool isDialogEdit;

	// Token: 0x04000B2B RID: 2859
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x1A")]
	public bool isCityEdit;

	// Token: 0x04000B2C RID: 2860
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x1B")]
	public bool isTestScene;

	// Token: 0x04000B2D RID: 2861
	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x1C")]
	public bool dirtyScene;

	// Token: 0x04000B2E RID: 2862
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x1D")]
	public bool isDecorEdit;

	// Token: 0x04000B2F RID: 2863
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x1E")]
	public bool enableUserPause;

	// Token: 0x04000B30 RID: 2864
	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x1F")]
	public bool enableFirstPersonMap;

	// Token: 0x04000B31 RID: 2865
	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x20")]
	public bool play;

	// Token: 0x04000B32 RID: 2866
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x21")]
	public bool enableTutorialText;

	// Token: 0x04000B33 RID: 2867
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x28")]
	public HashSet<string> tutorialTextTriggered;

	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x30")]
	public bool startedGame;

	// Token: 0x04000B35 RID: 2869
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x34")]
	public int pauseUnpauseDelay;

	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x38")]
	private float drunkOscillatorX;

	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x3C")]
	private float drunkOscillatorY;

	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 drunkOscillation;

	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x48")]
	private float shiverOscillatorX;

	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x4C")]
	private float shiverOscillatorY;

	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x50")]
	private float shiverProgress;

	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 shiverOscillation;

	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x5C")]
	private float drunkLensProgress;

	// Token: 0x04000B3E RID: 2878
	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x60")]
	private float headacheProgress;

	// Token: 0x04000B3F RID: 2879
	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x64")]
	private int sunShadowFrameCounter;

	// Token: 0x04000B40 RID: 2880
	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x68")]
	public float gameTime;

	// Token: 0x04000B41 RID: 2881
	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0x70")]
	public double gameTimeDouble;

	// Token: 0x04000B42 RID: 2882
	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0x78")]
	public double gameTimePassedThisFrame;

	// Token: 0x04000B43 RID: 2883
	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0x80")]
	private int prevHour;

	// Token: 0x04000B44 RID: 2884
	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x88")]
	private double watchChangeCounter;

	// Token: 0x04000B45 RID: 2885
	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x90")]
	public float decimalClock;

	// Token: 0x04000B46 RID: 2886
	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x98")]
	public double decimalClockDouble;

	// Token: 0x04000B47 RID: 2887
	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0xA0")]
	public SessionData.TimeSpeed currentTimeSpeed;

	// Token: 0x04000B48 RID: 2888
	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0xA4")]
	public float currentTimeMultiplier;

	// Token: 0x04000B49 RID: 2889
	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0xA8")]
	public float behaviourDelay;

	// Token: 0x04000B4A RID: 2890
	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0xAC")]
	public SessionData.TimeOfDay timeOfDay;

	// Token: 0x04000B4B RID: 2891
	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0xB0")]
	public int dayInt;

	// Token: 0x04000B4C RID: 2892
	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0xB4")]
	public SessionData.WeekDay day;

	// Token: 0x04000B4D RID: 2893
	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0xB8")]
	public int dateInt;

	// Token: 0x04000B4E RID: 2894
	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0xBC")]
	public SessionData.Month month;

	// Token: 0x04000B4F RID: 2895
	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0xC0")]
	public int monthInt;

	// Token: 0x04000B50 RID: 2896
	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0xC8")]
	public List<int> daysInMonths;

	// Token: 0x04000B51 RID: 2897
	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0xD0")]
	public int yearInt;

	// Token: 0x04000B52 RID: 2898
	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0xD4")]
	public int publicYear;

	// Token: 0x04000B53 RID: 2899
	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0xD8")]
	public int leapYearCycle;

	// Token: 0x04000B54 RID: 2900
	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0xDC")]
	public float gameTimeLimit;

	// Token: 0x04000B55 RID: 2901
	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0xE0")]
	public float currentRain;

	// Token: 0x04000B56 RID: 2902
	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0xE4")]
	public float desiredRain;

	// Token: 0x04000B57 RID: 2903
	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0xE8")]
	public float currentWind;

	// Token: 0x04000B58 RID: 2904
	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0xEC")]
	public float desiredWind;

	// Token: 0x04000B59 RID: 2905
	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0xF0")]
	public float currentSnow;

	// Token: 0x04000B5A RID: 2906
	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0xF4")]
	public float desiredSnow;

	// Token: 0x04000B5B RID: 2907
	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0xF8")]
	public float currentLightning;

	// Token: 0x04000B5C RID: 2908
	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0xFC")]
	public float desiredLightning;

	// Token: 0x04000B5D RID: 2909
	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x100")]
	public float currentFog;

	// Token: 0x04000B5E RID: 2910
	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x104")]
	public float desiredFog;

	// Token: 0x04000B5F RID: 2911
	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0x108")]
	public float transitionSpeed;

	// Token: 0x04000B60 RID: 2912
	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x10C")]
	public float weatherChangeTimer;

	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x110")]
	private float monthTempMultiplier;

	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x114")]
	public float temperature;

	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x118")]
	public float lightningTimer;

	// Token: 0x04000B64 RID: 2916
	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x11C")]
	public Vector3 windDirection;

	// Token: 0x04000B65 RID: 2917
	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x128")]
	public float windForce;

	// Token: 0x04000B66 RID: 2918
	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x12C")]
	public float dayProgress;

	// Token: 0x04000B67 RID: 2919
	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x130")]
	public RainSheetController nearRainSheet;

	// Token: 0x04000B68 RID: 2920
	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x138")]
	public RainSheetController farRainSheet;

	// Token: 0x04000B69 RID: 2921
	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x140")]
	public Vector2 nearRainAlpha1Threshold;

	// Token: 0x04000B6A RID: 2922
	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x148")]
	public Vector2 nearRainAlpha2Threshold;

	// Token: 0x04000B6B RID: 2923
	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x150")]
	public Vector2 nearRainSpeedThreshold;

	// Token: 0x04000B6C RID: 2924
	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x158")]
	public Vector2 nearRainXTile1Threshold;

	// Token: 0x04000B6D RID: 2925
	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x160")]
	public Vector2 nearRainXTile2Threshold;

	// Token: 0x04000B6E RID: 2926
	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x168")]
	public Vector2 farRainAlpha1Threshold;

	// Token: 0x04000B6F RID: 2927
	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x170")]
	public Vector2 farRainAlpha2Threshold;

	// Token: 0x04000B70 RID: 2928
	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x178")]
	public Vector2 farRainSpeedThreshold;

	// Token: 0x04000B71 RID: 2929
	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x180")]
	public Vector2 farRainXTile1Threshold;

	// Token: 0x04000B72 RID: 2930
	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x188")]
	public Vector2 farRainXTile2Threshold;

	// Token: 0x04000B73 RID: 2931
	[Token(Token = "0x4000B73")]
	[FieldOffset(Offset = "0x190")]
	public Vector2 particalRainCountThreshold;

	// Token: 0x04000B74 RID: 2932
	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x198")]
	public Vector2 particalSnowCountThreshold;

	// Token: 0x04000B75 RID: 2933
	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x1A0")]
	public float cityWetness;

	// Token: 0x04000B76 RID: 2934
	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x1A4")]
	public float citySnow;

	// Token: 0x04000B77 RID: 2935
	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x1A8")]
	public List<SessionData.WetMaterial> wetMaterials;

	// Token: 0x04000B78 RID: 2936
	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x1B0")]
	public Dictionary<Material, SessionData.WetMaterial> weatherMaterialsReference;

	// Token: 0x04000B79 RID: 2937
	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x1B8")]
	public List<CustomPassVolume> customPasses;

	// Token: 0x04000B7A RID: 2938
	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x1C0")]
	public Dictionary<GameObject, WallFrontagePreset> rainyWindowFrontageObjects;

	// Token: 0x04000B7B RID: 2939
	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x1C8")]
	public float autoPauseTimer;

	// Token: 0x04000B7C RID: 2940
	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x1CC")]
	public float autoResetTimer;

	// Token: 0x04000B7D RID: 2941
	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x1D0")]
	private float lightswitchPulse;

	// Token: 0x04000B7E RID: 2942
	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x1D4")]
	private bool lightswitchPulseMode;

	// Token: 0x04000B7F RID: 2943
	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x1D8")]
	public SessionData.SceneProfile currentProfile;

	// Token: 0x04000B80 RID: 2944
	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x1E0")]
	[NonSerialized]
	public CityControls.PPProfile currentSceneProfile;

	// Token: 0x04000B81 RID: 2945
	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x1E8")]
	[NonSerialized]
	public CityControls.PPProfile desiredSceneProfile;

	// Token: 0x04000B82 RID: 2946
	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x1F0")]
	public Volume globalVolume;

	// Token: 0x04000B83 RID: 2947
	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x1F8")]
	public GradientSky gradientSky;

	// Token: 0x04000B84 RID: 2948
	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x200")]
	public Fog volFog;

	// Token: 0x04000B85 RID: 2949
	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x208")]
	public DepthOfField dof;

	// Token: 0x04000B86 RID: 2950
	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x210")]
	public Vignette vignette;

	// Token: 0x04000B87 RID: 2951
	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x218")]
	public MotionBlur motionBlur;

	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x220")]
	public FilmGrain grain;

	// Token: 0x04000B89 RID: 2953
	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x228")]
	public Tonemapping toneMapping;

	// Token: 0x04000B8A RID: 2954
	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x230")]
	public Bloom bloom;

	// Token: 0x04000B8B RID: 2955
	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x238")]
	public ChromaticAberration chromaticAberration;

	// Token: 0x04000B8C RID: 2956
	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x240")]
	public LiftGammaGain lgg;

	// Token: 0x04000B8D RID: 2957
	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x248")]
	public ColorAdjustments colour;

	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x250")]
	public LensDistortion lensDistort;

	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x258")]
	public Exposure exposure;

	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x260")]
	public ChannelMixer channelMixer;

	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x268")]
	public ScreenSpaceReflection ssReflection;

	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x270")]
	public int skyboxGradientIndex;

	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x278")]
	public SessionData.SkyboxGradient fromSkyboxColours;

	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x280")]
	public SessionData.SkyboxGradient toSkyboxColours;

	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x288")]
	public List<Elevator> activeElevators;

	// Token: 0x04000B96 RID: 2966
	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x290")]
	public List<InteractableController> particleSystems;

	// Token: 0x04000B97 RID: 2967
	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x298")]
	public Material broadcastMaterial;

	// Token: 0x04000B98 RID: 2968
	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x2A0")]
	public List<SessionData.TelevisionChannel> televisionChannels;

	// Token: 0x04000B99 RID: 2969
	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x2A8")]
	public TextMeshProUGUI pauseText;

	// Token: 0x04000B9A RID: 2970
	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObject pauseLensFlare;

	// Token: 0x04000B9B RID: 2971
	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x2B8")]
	public Image pauseButtonImg;

	// Token: 0x04000B9C RID: 2972
	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x2C0")]
	public Image normalSpeedButtonImg;

	// Token: 0x04000B9D RID: 2973
	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x2C8")]
	public Image fastSpeedButtonImg;

	// Token: 0x04000B9E RID: 2974
	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x2D0")]
	public Image veryFastSpeedButtonImg;

	// Token: 0x04000B9F RID: 2975
	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x2D8")]
	public TextMeshPro newWatchTimeText;

	// Token: 0x04000BA0 RID: 2976
	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x2E0")]
	public TextMeshPro newWatchDateText;

	// Token: 0x04000BA1 RID: 2977
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x2E8")]
	public TextMeshProUGUI clockText;

	// Token: 0x04000BA2 RID: 2978
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x2F0")]
	public TextMeshProUGUI dayText;

	// Token: 0x04000BA3 RID: 2979
	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x2F8")]
	public Image pauseButtonIcon;

	// Token: 0x04000BA4 RID: 2980
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x300")]
	public Sprite pauseIcon;

	// Token: 0x04000BA5 RID: 2981
	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x308")]
	public Sprite playIcon;

	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x310")]
	public NewNode startingNode;

	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x318")]
	[NonSerialized]
	private AudioController.LoopingSoundInfo interfaceActiveAudio;

	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x320")]
	public Vector2 debugDecimalRange;

	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x328")]
	public List<SessionData.WeekDay> debugDayList;

	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x330")]
	public Action UnloadPipes;

	// Token: 0x04000BAB RID: 2987
	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x338")]
	public List<PipeConstructor.PipeGroup> pipesToUnload;

	// Token: 0x04000BAC RID: 2988
	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x0")]
	private static SessionData _instance;

	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public enum TimeSpeed
	{
		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		slow,
		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		normal,
		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		fast,
		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		veryFast,
		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		simulation
	}

	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	public enum TimeOfDay
	{
		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		morning,
		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		afternoon,
		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		evening
	}

	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public enum WeekDay
	{
		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		monday,
		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		tuesday,
		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		wednesday,
		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		thursday,
		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		friday,
		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		saturday,
		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		sunday
	}

	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	public enum Month
	{
		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		jan,
		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		feb,
		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		mar,
		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		apr,
		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		may,
		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		jun,
		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		jul,
		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		aug,
		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		sep,
		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		oct,
		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		nov,
		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		dec
	}

	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	[Serializable]
	public class WetMaterial
	{
		// Token: 0x06000B88 RID: 2952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x577260", Offset = "0x576260", VA = "0x180577260")]
		public WetMaterial()
		{
		}

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x10")]
		public Material mat;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x18")]
		public Material instancedMat;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x20")]
		public List<MeshRenderer> affectedRenderers;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x28")]
		public bool affectRain;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 rainMinMax;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x34")]
		public float rainMultiplier;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x38")]
		public bool affectCityWetness;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 cityWetnessMinMax;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x44")]
		public float cityWetnessMultiplier;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x48")]
		public bool cityWetnessLogScale;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x49")]
		public bool affectCitySnow;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x4C")]
		public Vector2 citySnowMinMax;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x54")]
		public float citySnowMultiplier;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x58")]
		public bool affectCoatMask;

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x5C")]
		public Vector2 coatMaskMinMax;

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x64")]
		public float coatMaskMultiplier;

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x68")]
		public bool affectWind;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0x6C")]
		public Vector2 windMinMax;

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x74")]
		public float windMultiplier;
	}

	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	public enum SceneProfile
	{
		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		outdoors,
		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		indoors,
		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		grimey,
		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		clean,
		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4000BE8")]
		corporate,
		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		cbd,
		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		chinatown,
		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		industrial,
		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		residential,
		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		warm
	}

	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	[Serializable]
	public class SkyboxGradient : IEnumerator<object>
	{
		// Token: 0x06000B89 RID: 2953 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x577390", Offset = "0x576390", VA = "0x180577390", Slot = "4")]
		public int CompareTo(SessionData.SkyboxGradient otherObject)
		{
			return 0;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x577410", Offset = "0x576410", VA = "0x180577410")]
		public SkyboxGradient()
		{
		}

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x10")]
		public float time;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x14")]
		public Color skyColour;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x24")]
		public Color fogAlbedo;

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x34")]
		public Color ambientLightTop;

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x44")]
		public Color ambientLightMiddle;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x54")]
		public Color ambientLightBottom;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x64")]
		public Color ambientLightingColour;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x74")]
		public Color fogColour;

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x84")]
		public Color seaEmission;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x94")]
		public Color smokeEmission;
	}

	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	public class TelevisionChannel
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x5774F0", Offset = "0x5764F0", VA = "0x1805774F0")]
		public void ProcessTelevisionBroadcast()
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x577EA0", Offset = "0x576EA0", VA = "0x180577EA0")]
		private void ProcessDynamicShow()
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x579550", Offset = "0x578550", VA = "0x180579550")]
		public BroadcastPreset.DynamicClip GetNextClip()
		{
			return null;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x579600", Offset = "0x578600", VA = "0x180579600")]
		public BroadcastPreset.DynamicClipEvent GetEvent()
		{
			return null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x57B070", Offset = "0x57A070", VA = "0x18057B070")]
		public TelevisionChannel()
		{
		}

		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x10")]
		public BroadcastSchedule currentBroadcastSchedule;

		// Token: 0x04000BF9 RID: 3065
		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x18")]
		public BroadcastPreset currentShow;

		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x20")]
		public Material broadcastMaterialInstanced;

		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x28")]
		public int currentScheduleIndex;

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x2C")]
		public float currentShowProgressSeconds;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x30")]
		public float currentShowImageProgress;

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x38")]
		private EventDescription currentShowEventDescription;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x40")]
		private int currentShowAudioLength;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x44")]
		private int currentShowImageLength;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x48")]
		private int currentImageIndex;

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x4C")]
		public float crowdParam;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x50")]
		public bool dynamicShowActive;

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x58")]
		public BroadcastPreset.DynamicClip currentDynamicClip;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x60")]
		public BroadcastPreset.DynamicClipEvent currentDynamicEvent;

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x68")]
		public AudioEvent currentDynamicAudio;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x70")]
		public float currentClipProgressSeconds;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x74")]
		public int currentClipAudioLength;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x78")]
		private EventDescription currentClipEventDescription;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x80")]
		public int clipIndex;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x88")]
		public List<BroadcastPreset.DynamicShowParam> appliedParameters;

		// Token: 0x020001D5 RID: 469
		[Token(Token = "0x20001D5")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B90")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06000B91 RID: 2961 RVA: 0x00006D08 File Offset: 0x00004F08
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
			internal bool <ProcessDynamicShow>b__0(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x04000C0C RID: 3084
			[Token(Token = "0x4000C0C")]
			[FieldOffset(Offset = "0x10")]
			public BroadcastPreset.DynamicShowParam apply;
		}

		// Token: 0x020001D6 RID: 470
		[Token(Token = "0x20001D6")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x00006D20 File Offset: 0x00004F20
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
			internal bool <GetEvent>b__0(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x04000C0D RID: 3085
			[Token(Token = "0x4000C0D")]
			[FieldOffset(Offset = "0x10")]
			public BroadcastPreset.DynamicShowParam test;
		}

		// Token: 0x020001D7 RID: 471
		[Token(Token = "0x20001D7")]
		private sealed class <>c__DisplayClass23_1
		{
			// Token: 0x06000B94 RID: 2964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass23_1()
			{
			}

			// Token: 0x06000B95 RID: 2965 RVA: 0x00006D38 File Offset: 0x00004F38
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
			internal bool <GetEvent>b__1(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x04000C0E RID: 3086
			[Token(Token = "0x4000C0E")]
			[FieldOffset(Offset = "0x10")]
			public BroadcastPreset.DynamicShowParam test;
		}

		// Token: 0x020001D8 RID: 472
		[Token(Token = "0x20001D8")]
		private sealed class <>c__DisplayClass23_2
		{
			// Token: 0x06000B96 RID: 2966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass23_2()
			{
			}

			// Token: 0x06000B97 RID: 2967 RVA: 0x00006D50 File Offset: 0x00004F50
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
			internal bool <GetEvent>b__2(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x04000C0F RID: 3087
			[Token(Token = "0x4000C0F")]
			[FieldOffset(Offset = "0x10")]
			public BroadcastPreset.DynamicShowParam test;
		}

		// Token: 0x020001D9 RID: 473
		[Token(Token = "0x20001D9")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000B99 RID: 2969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B99")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x06000B9A RID: 2970 RVA: 0x00006D68 File Offset: 0x00004F68
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
			internal bool <GetEvent>b__23_3(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000B9B RID: 2971 RVA: 0x00006D80 File Offset: 0x00004F80
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x477740", Offset = "0x476740", VA = "0x180477740")]
			internal bool <GetEvent>b__23_4(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000B9C RID: 2972 RVA: 0x00006D98 File Offset: 0x00004F98
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x57B200", Offset = "0x57A200", VA = "0x18057B200")]
			internal bool <GetEvent>b__23_5(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000B9D RID: 2973 RVA: 0x00006DB0 File Offset: 0x00004FB0
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x57B220", Offset = "0x57A220", VA = "0x18057B220")]
			internal bool <GetEvent>b__23_6(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x00006DC8 File Offset: 0x00004FC8
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
			internal bool <GetEvent>b__23_7(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000B9F RID: 2975 RVA: 0x00006DE0 File Offset: 0x00004FE0
			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x477740", Offset = "0x476740", VA = "0x180477740")]
			internal bool <GetEvent>b__23_8(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x00006DF8 File Offset: 0x00004FF8
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x57B200", Offset = "0x57A200", VA = "0x18057B200")]
			internal bool <GetEvent>b__23_9(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA1 RID: 2977 RVA: 0x00006E10 File Offset: 0x00005010
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x57B220", Offset = "0x57A220", VA = "0x18057B220")]
			internal bool <GetEvent>b__23_10(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA2 RID: 2978 RVA: 0x00006E28 File Offset: 0x00005028
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
			internal bool <GetEvent>b__23_11(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x00006E40 File Offset: 0x00005040
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x477740", Offset = "0x476740", VA = "0x180477740")]
			internal bool <GetEvent>b__23_12(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA4 RID: 2980 RVA: 0x00006E58 File Offset: 0x00005058
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
			internal bool <GetEvent>b__23_13(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA5 RID: 2981 RVA: 0x00006E70 File Offset: 0x00005070
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x477740", Offset = "0x476740", VA = "0x180477740")]
			internal bool <GetEvent>b__23_14(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x00006E88 File Offset: 0x00005088
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
			internal bool <GetEvent>b__23_15(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x06000BA7 RID: 2983 RVA: 0x00006EA0 File Offset: 0x000050A0
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x477740", Offset = "0x476740", VA = "0x180477740")]
			internal bool <GetEvent>b__23_16(BroadcastPreset.DynamicShowParam item)
			{
				return default(bool);
			}

			// Token: 0x04000C10 RID: 3088
			[Token(Token = "0x4000C10")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SessionData.TelevisionChannel.<>c <>9;

			// Token: 0x04000C11 RID: 3089
			[Token(Token = "0x4000C11")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_3;

			// Token: 0x04000C12 RID: 3090
			[Token(Token = "0x4000C12")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_4;

			// Token: 0x04000C13 RID: 3091
			[Token(Token = "0x4000C13")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_5;

			// Token: 0x04000C14 RID: 3092
			[Token(Token = "0x4000C14")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_6;

			// Token: 0x04000C15 RID: 3093
			[Token(Token = "0x4000C15")]
			[FieldOffset(Offset = "0x28")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_7;

			// Token: 0x04000C16 RID: 3094
			[Token(Token = "0x4000C16")]
			[FieldOffset(Offset = "0x30")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_8;

			// Token: 0x04000C17 RID: 3095
			[Token(Token = "0x4000C17")]
			[FieldOffset(Offset = "0x38")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_9;

			// Token: 0x04000C18 RID: 3096
			[Token(Token = "0x4000C18")]
			[FieldOffset(Offset = "0x40")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_10;

			// Token: 0x04000C19 RID: 3097
			[Token(Token = "0x4000C19")]
			[FieldOffset(Offset = "0x48")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_11;

			// Token: 0x04000C1A RID: 3098
			[Token(Token = "0x4000C1A")]
			[FieldOffset(Offset = "0x50")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_12;

			// Token: 0x04000C1B RID: 3099
			[Token(Token = "0x4000C1B")]
			[FieldOffset(Offset = "0x58")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_13;

			// Token: 0x04000C1C RID: 3100
			[Token(Token = "0x4000C1C")]
			[FieldOffset(Offset = "0x60")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_14;

			// Token: 0x04000C1D RID: 3101
			[Token(Token = "0x4000C1D")]
			[FieldOffset(Offset = "0x68")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_15;

			// Token: 0x04000C1E RID: 3102
			[Token(Token = "0x4000C1E")]
			[FieldOffset(Offset = "0x70")]
			public static Predicate<BroadcastPreset.DynamicShowParam> <>9__23_16;
		}
	}

	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	public enum PhysicsSyncType
	{
		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		now,
		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		onPlayerMovement,
		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		both
	}

	// Token: 0x020001DB RID: 475
	// (Invoke) Token: 0x06000BA9 RID: 2985
	[Token(Token = "0x20001DB")]
	public delegate void OnPauseUnPause(bool openDesktopMode);

	// Token: 0x020001DC RID: 476
	// (Invoke) Token: 0x06000BAD RID: 2989
	[Token(Token = "0x20001DC")]
	public delegate void WeatherChange();

	// Token: 0x020001DD RID: 477
	// (Invoke) Token: 0x06000BB1 RID: 2993
	[Token(Token = "0x20001DD")]
	public delegate void HourChange();

	// Token: 0x020001DE RID: 478
	// (Invoke) Token: 0x06000BB5 RID: 2997
	[Token(Token = "0x20001DE")]
	public delegate void TutorialNotificationChange();

	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	private sealed class <>c__DisplayClass169_0
	{
		// Token: 0x06000BB8 RID: 3000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass169_0()
		{
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <SetSceneProfile>b__0(CityControls.PPProfile item)
		{
			return default(bool);
		}

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x10")]
		public SessionData.SceneProfile newProfile;
	}

	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x57B480", Offset = "0x57A480", VA = "0x18057B480")]
		internal bool <Update>b__170_0(FileInfo item)
		{
			return default(bool);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x57B540", Offset = "0x57A540", VA = "0x18057B540")]
		internal bool <SetDisplayTutorialText>b__214_0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SessionData.<>c <>9;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<FileInfo> <>9__170_0;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<PlayerPrefsController.GameSetting> <>9__214_0;
	}
}
