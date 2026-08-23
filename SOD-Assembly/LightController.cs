using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x0200011F RID: 287
[Token(Token = "0x200011F")]
public class LightController : MonoBehaviour
{
	// Token: 0x06000830 RID: 2096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000830")]
	[Address(RVA = "0x4B0B00", Offset = "0x4AFB00", VA = "0x1804B0B00")]
	public void Setup(NewRoom newRoom, Interactable newInteractable, Interactable.LightConfiguration configData, LightingPreset newPreset, int lightZoneSize = -1, [Optional] Transform newCeilingFan)
	{
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x4B2E20", Offset = "0x4B1E20", VA = "0x1804B2E20")]
	public void UpdateFadeDistances()
	{
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000832")]
	[Address(RVA = "0x4B30C0", Offset = "0x4B20C0", VA = "0x1804B30C0")]
	public void SetColour(Color newCol)
	{
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000833")]
	[Address(RVA = "0x4B33D0", Offset = "0x4B23D0", VA = "0x1804B33D0")]
	public void SetIntensity(float newInt)
	{
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000834")]
	[Address(RVA = "0x4B36F0", Offset = "0x4B26F0", VA = "0x1804B36F0")]
	public void SetShadows(bool val)
	{
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000835")]
	[Address(RVA = "0x4B3EA0", Offset = "0x4B2EA0", VA = "0x1804B3EA0")]
	public void SetVolumetrics(bool val)
	{
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000836")]
	[Address(RVA = "0x4B40B0", Offset = "0x4B30B0", VA = "0x1804B40B0")]
	public void SetVolumentricAtmosphere(float newVal)
	{
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000837")]
	[Address(RVA = "0x4B4120", Offset = "0x4B3120", VA = "0x1804B4120")]
	public void SetFlicker(bool val)
	{
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000838")]
	[Address(RVA = "0x4B4380", Offset = "0x4B3380", VA = "0x1804B4380")]
	private void Update()
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000839")]
	[Address(RVA = "0x4B4D10", Offset = "0x4B3D10", VA = "0x1804B4D10")]
	public void SetOn(bool val, bool forceInstant = false)
	{
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083A")]
	[Address(RVA = "0x4B56B0", Offset = "0x4B46B0", VA = "0x1804B56B0")]
	public void SetUnscrewed(bool val, bool forceInstance = false)
	{
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x4B56F0", Offset = "0x4B46F0", VA = "0x1804B56F0")]
	public void SetClosedBreaker(bool val, bool forceInstance = false)
	{
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x4B5700", Offset = "0x4B4700", VA = "0x1804B5700")]
	private void OnEnable()
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x4B5700", Offset = "0x4B4700", VA = "0x1804B5700")]
	private void OnDisable()
	{
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x4B5710", Offset = "0x4B4710", VA = "0x1804B5710")]
	public void UpdateLight()
	{
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x4B64F0", Offset = "0x4B54F0", VA = "0x1804B64F0")]
	public void SetCulled(bool val, bool respectTimer)
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x4B6970", Offset = "0x4B5970", VA = "0x1804B6970")]
	public void CullToggle()
	{
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x4B6990", Offset = "0x4B5990", VA = "0x1804B6990")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x4B6D90", Offset = "0x4B5D90", VA = "0x1804B6D90")]
	public LightController()
	{
	}

	// Token: 0x0400085C RID: 2140
	[Token(Token = "0x400085C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isSetup;

	// Token: 0x0400085D RID: 2141
	[Token(Token = "0x400085D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public NewRoom room;

	// Token: 0x0400085E RID: 2142
	[Token(Token = "0x400085E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x0400085F RID: 2143
	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LightingPreset preset;

	// Token: 0x04000860 RID: 2144
	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isOn;

	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool isUnscrewed;

	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool closedBreaker;

	// Token: 0x04000863 RID: 2147
	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	public bool isCulled;

	// Token: 0x04000864 RID: 2148
	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float lightState;

	// Token: 0x04000865 RID: 2149
	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Light lightComponent;

	// Token: 0x04000866 RID: 2150
	[Token(Token = "0x4000866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HDAdditionalLightData hdrpLightData;

	// Token: 0x04000867 RID: 2151
	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color lightColour;

	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color flickerColour;

	// Token: 0x04000869 RID: 2153
	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Color emissionColour;

	// Token: 0x0400086A RID: 2154
	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float intensity;

	// Token: 0x0400086B RID: 2155
	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float cullingTimer;

	// Token: 0x0400086C RID: 2156
	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public MeshRenderer rend;

	// Token: 0x0400086D RID: 2157
	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Material mat;

	// Token: 0x0400086E RID: 2158
	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool useVolumetrics;

	// Token: 0x0400086F RID: 2159
	[Token(Token = "0x400086F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool useShadows;

	// Token: 0x04000870 RID: 2160
	[Token(Token = "0x4000870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	public bool flicker;

	// Token: 0x04000871 RID: 2161
	[Token(Token = "0x4000871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float flickerColourMultiplier;

	// Token: 0x04000872 RID: 2162
	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float pulseSpeed;

	// Token: 0x04000873 RID: 2163
	[Token(Token = "0x4000873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float flickerState;

	// Token: 0x04000874 RID: 2164
	[Token(Token = "0x4000874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool flickerSwitch;

	// Token: 0x04000875 RID: 2165
	[Token(Token = "0x4000875")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	private bool flickerInterval;

	// Token: 0x04000876 RID: 2166
	[Token(Token = "0x4000876")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float interval;

	// Token: 0x04000877 RID: 2167
	[Token(Token = "0x4000877")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float intervalTime;

	// Token: 0x04000878 RID: 2168
	[Token(Token = "0x4000878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform ceilingFan;

	// Token: 0x04000879 RID: 2169
	[Token(Token = "0x4000879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool ceilingFanOn;

	// Token: 0x0400087A RID: 2170
	[Token(Token = "0x400087A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float ceilingFanSpeed;

	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000844 RID: 2116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x4DA1F0", Offset = "0x4D91F0", VA = "0x1804DA1F0")]
		internal bool <SetOn>b__40_0(SessionData.TelevisionChannel item)
		{
			return default(bool);
		}

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly LightController.<>c <>9;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<SessionData.TelevisionChannel> <>9__40_0;
	}
}
