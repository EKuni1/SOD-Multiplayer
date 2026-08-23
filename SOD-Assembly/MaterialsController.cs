using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000381 RID: 897
[Token(Token = "0x2000381")]
public class MaterialsController : MonoBehaviour
{
	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06001401 RID: 5121 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000AB")]
	public static MaterialsController Instance
	{
		[Token(Token = "0x6001401")]
		[Address(RVA = "0x7A7260", Offset = "0x7A6260", VA = "0x1807A7260")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001402")]
	[Address(RVA = "0x7A72C0", Offset = "0x7A62C0", VA = "0x1807A72C0")]
	private void Awake()
	{
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001403")]
	[Address(RVA = "0x7A7650", Offset = "0x7A6650", VA = "0x1807A7650")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001404")]
	[Address(RVA = "0x7A8200", Offset = "0x7A7200", VA = "0x1807A8200")]
	public Material SetMaterialGroup(GameObject model, MaterialGroupPreset preset, Toolbox.MaterialKey key, bool forceUniqueInstance = false, [Optional] MeshRenderer renderer)
	{
		return null;
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001405")]
	[Address(RVA = "0x7A8EA0", Offset = "0x7A7EA0", VA = "0x1807A8EA0")]
	public Material ApplyMaterialKey(GameObject model, Toolbox.MaterialKey key)
	{
		return null;
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001406")]
	[Address(RVA = "0x7A9070", Offset = "0x7A8070", VA = "0x1807A9070")]
	public Material ApplyMaterialKey(MeshRenderer renderer, Toolbox.MaterialKey key)
	{
		return null;
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001407")]
	[Address(RVA = "0x7A9B20", Offset = "0x7A8B20", VA = "0x1807A9B20")]
	public Material GetMaterialFromKey(Toolbox.MaterialKey key)
	{
		return null;
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001408")]
	[Address(RVA = "0x7AA2F0", Offset = "0x7A92F0", VA = "0x1807AA2F0")]
	public Toolbox.MaterialKey GenerateMaterialKey(MaterialGroupPreset.MaterialVariation variation, ColourSchemePreset scheme, NewRoom room, bool useGrubiness, [Optional] NewBuilding building)
	{
		return null;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001409")]
	[Address(RVA = "0x7AABD0", Offset = "0x7A9BD0", VA = "0x1807AABD0")]
	public void ApplyMaterial(GameObject model, Material mat)
	{
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140A")]
	[Address(RVA = "0x7AAE20", Offset = "0x7A9E20", VA = "0x1807AAE20")]
	public void ApplyMaterial(MeshRenderer renderer, Material mat)
	{
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x000098E8 File Offset: 0x00007AE8
	[Token(Token = "0x600140B")]
	[Address(RVA = "0x7AAF60", Offset = "0x7A9F60", VA = "0x1807AAF60")]
	public Color GetColourFromScheme(ColourSchemePreset scheme, MaterialGroupPreset.MaterialColour colourType, NewRoom room, [Optional] NewBuilding building)
	{
		return default(Color);
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600140C")]
	[Address(RVA = "0x7ABCA0", Offset = "0x7AACA0", VA = "0x1807ABCA0")]
	public Material GetFootprintMaterial(FootprintController fc)
	{
		return null;
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140D")]
	[Address(RVA = "0x7AC3E0", Offset = "0x7AB3E0", VA = "0x1807AC3E0")]
	public void PopulateDebugData()
	{
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600140E")]
	[Address(RVA = "0x7ACE70", Offset = "0x7ABE70", VA = "0x1807ACE70")]
	public MaterialsController()
	{
	}

	// Token: 0x0400187D RID: 6269
	[Token(Token = "0x400187D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<Toolbox.MaterialKey, Material> commonMaterialsLibrary;

	// Token: 0x0400187E RID: 6270
	[Token(Token = "0x400187E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dictionary<Toolbox.MaterialKey, List<Material>> uniqueMaterialsLibrary;

	// Token: 0x0400187F RID: 6271
	[Token(Token = "0x400187F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dictionary<MaterialsController.FootprintMaterialKey, Material> footprintMaterialLibrary;

	// Token: 0x04001880 RID: 6272
	[Token(Token = "0x4001880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int materialCount;

	// Token: 0x04001881 RID: 6273
	[Token(Token = "0x4001881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int materialInstancesAvertedByCommonDictionary;

	// Token: 0x04001882 RID: 6274
	[Token(Token = "0x4001882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int useOfBaseMaterials;

	// Token: 0x04001883 RID: 6275
	[Token(Token = "0x4001883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int lightMaterialInstances;

	// Token: 0x04001884 RID: 6276
	[Token(Token = "0x4001884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int footprintMaterials;

	// Token: 0x04001885 RID: 6277
	[Token(Token = "0x4001885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int footprintInstancesAvertedByDictionary;

	// Token: 0x04001886 RID: 6278
	[Token(Token = "0x4001886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material footprintMaterialShoe;

	// Token: 0x04001887 RID: 6279
	[Token(Token = "0x4001887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material footprintMaterialBoot;

	// Token: 0x04001888 RID: 6280
	[Token(Token = "0x4001888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material footprintMaterialHeel;

	// Token: 0x04001889 RID: 6281
	[Token(Token = "0x4001889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Color dirtColour;

	// Token: 0x0400188A RID: 6282
	[Token(Token = "0x400188A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Color bloodColour;

	// Token: 0x0400188B RID: 6283
	[Token(Token = "0x400188B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<MaterialsController.MaterialDebug> commonMaterialsDebug;

	// Token: 0x0400188C RID: 6284
	[Token(Token = "0x400188C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<MaterialsController.MaterialDebug> uniqueMaterialsDebug;

	// Token: 0x0400188D RID: 6285
	[Token(Token = "0x400188D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MaterialsController _instance;

	// Token: 0x0400188E RID: 6286
	[Token(Token = "0x400188E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string MATERIAL_NO_MAT_COLOUR_KEY;

	// Token: 0x0400188F RID: 6287
	[Token(Token = "0x400188F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string MATERIAL_RAIN_WINDOW_GLASS_KEY;

	// Token: 0x04001890 RID: 6288
	[Token(Token = "0x4001890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string MATERIAL_BASE_COLOR_KEY;

	// Token: 0x04001891 RID: 6289
	[Token(Token = "0x4001891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string MATERIAL_COLOR1_KEY;

	// Token: 0x04001892 RID: 6290
	[Token(Token = "0x4001892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string MATERIAL_COLOR2_KEY;

	// Token: 0x04001893 RID: 6291
	[Token(Token = "0x4001893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly string MATERIAL_COLOR3_KEY;

	// Token: 0x04001894 RID: 6292
	[Token(Token = "0x4001894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly string MATERIAL_GRUB_AMOUNT_KEY;

	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	[Serializable]
	public class MaterialDebug
	{
		// Token: 0x06001410 RID: 5136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public MaterialDebug()
		{
		}

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04001896 RID: 6294
		[Token(Token = "0x4001896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toolbox.MaterialKey key;

		// Token: 0x04001897 RID: 6295
		[Token(Token = "0x4001897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material mat;
	}

	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	[Serializable]
	public struct FootprintMaterialKey
	{
		// Token: 0x06001411 RID: 5137 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x7AD640", Offset = "0x7AC640", VA = "0x1807AD640")]
		public bool Equals(MaterialsController.FootprintMaterialKey other)
		{
			return default(bool);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00009918 File Offset: 0x00007B18
		[Token(Token = "0x6001412")]
		[Address(RVA = "0x7AD710", Offset = "0x7AC710", VA = "0x1807AD710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00009930 File Offset: 0x00007B30
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x7AD840", Offset = "0x7AC840", VA = "0x1807AD840", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x6001414")]
		[Address(RVA = "0x7AD930", Offset = "0x7AC930", VA = "0x1807AD930")]
		public static bool operator ==(MaterialsController.FootprintMaterialKey c1, MaterialsController.FootprintMaterialKey c2)
		{
			return default(bool);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x7AD960", Offset = "0x7AC960", VA = "0x1807AD960")]
		public static bool operator !=(MaterialsController.FootprintMaterialKey c1, MaterialsController.FootprintMaterialKey c2)
		{
			return default(bool);
		}

		// Token: 0x04001898 RID: 6296
		[Token(Token = "0x4001898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int type;

		// Token: 0x04001899 RID: 6297
		[Token(Token = "0x4001899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float strength;

		// Token: 0x0400189A RID: 6298
		[Token(Token = "0x400189A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float blood;
	}

	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x6001418")]
		[Address(RVA = "0x7ADA40", Offset = "0x7ACA40", VA = "0x1807ADA40")]
		internal int <PopulateDebugData>b__39_0(MaterialsController.MaterialDebug p1, MaterialsController.MaterialDebug p2)
		{
			return 0;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x7ADA40", Offset = "0x7ACA40", VA = "0x1807ADA40")]
		internal int <PopulateDebugData>b__39_1(MaterialsController.MaterialDebug p1, MaterialsController.MaterialDebug p2)
		{
			return 0;
		}

		// Token: 0x0400189B RID: 6299
		[Token(Token = "0x400189B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly MaterialsController.<>c <>9;

		// Token: 0x0400189C RID: 6300
		[Token(Token = "0x400189C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<MaterialsController.MaterialDebug> <>9__39_0;

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x400189D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<MaterialsController.MaterialDebug> <>9__39_1;
	}
}
