using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x0200099D RID: 2461
	[Token(Token = "0x200099D")]
	public class CombiningInformation
	{
		// Token: 0x060034E1 RID: 13537 RVA: 0x00012660 File Offset: 0x00010860
		[Token(Token = "0x60034E1")]
		[Address(RVA = "0xD64BA0", Offset = "0xD63BA0", VA = "0x180D64BA0")]
		public bool ShouldGenerateMetallicArray()
		{
			return default(bool);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00012678 File Offset: 0x00010878
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0xD64DE0", Offset = "0xD63DE0", VA = "0x180D64DE0")]
		public bool ShouldGenerateSpecularArray()
		{
			return default(bool);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0xD65020", Offset = "0xD64020", VA = "0x180D65020")]
		public bool ShouldGenerateNormalArray()
		{
			return default(bool);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0xD65260", Offset = "0xD64260", VA = "0x180D65260")]
		public bool ShouldGenerateHeightArray()
		{
			return default(bool);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000126C0 File Offset: 0x000108C0
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0xD654A0", Offset = "0xD644A0", VA = "0x180D654A0")]
		public bool ShouldGenerateOcclusionArray()
		{
			return default(bool);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0xD656E0", Offset = "0xD646E0", VA = "0x180D656E0")]
		public bool ShouldGenerateEmissionArray()
		{
			return default(bool);
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x000126F0 File Offset: 0x000108F0
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0xD65920", Offset = "0xD64920", VA = "0x180D65920")]
		public bool ShouldGenerateDetailMaskArray()
		{
			return default(bool);
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0xD65B60", Offset = "0xD64B60", VA = "0x180D65B60")]
		public bool ShouldGenerateDetailAlbedoArray()
		{
			return default(bool);
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0xD65DA0", Offset = "0xD64DA0", VA = "0x180D65DA0")]
		public bool ShouldGenerateDetailNormalArray()
		{
			return default(bool);
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0xD65FE0", Offset = "0xD64FE0", VA = "0x180D65FE0")]
		public CombiningInformation()
		{
		}

		// Token: 0x0400517F RID: 20863
		[Token(Token = "0x400517F")]
		[FieldOffset(Offset = "0x10")]
		public List<CombiningInformation.MaterialEntity> materialEntities;

		// Token: 0x04005180 RID: 20864
		[Token(Token = "0x4005180")]
		[FieldOffset(Offset = "0x18")]
		public CombiningInformation.TextureArrayGroup textureArraysSettings;

		// Token: 0x04005181 RID: 20865
		[Token(Token = "0x4005181")]
		[FieldOffset(Offset = "0x20")]
		public CombiningInformation.DiffuseColorSpace diffuseColorSpace;

		// Token: 0x04005182 RID: 20866
		[Token(Token = "0x4005182")]
		[FieldOffset(Offset = "0x28")]
		public Material[] combinedMaterials;

		// Token: 0x0200099E RID: 2462
		[Token(Token = "0x200099E")]
		public enum DiffuseColorSpace
		{
			// Token: 0x04005184 RID: 20868
			[Token(Token = "0x4005184")]
			NON_LINEAR,
			// Token: 0x04005185 RID: 20869
			[Token(Token = "0x4005185")]
			LINEAR
		}

		// Token: 0x0200099F RID: 2463
		[Token(Token = "0x200099F")]
		public enum CompressionType
		{
			// Token: 0x04005187 RID: 20871
			[Token(Token = "0x4005187")]
			UNCOMPRESSED,
			// Token: 0x04005188 RID: 20872
			[Token(Token = "0x4005188")]
			DXT1,
			// Token: 0x04005189 RID: 20873
			[Token(Token = "0x4005189")]
			ETC2_RGB,
			// Token: 0x0400518A RID: 20874
			[Token(Token = "0x400518A")]
			PVRTC_RGB4,
			// Token: 0x0400518B RID: 20875
			[Token(Token = "0x400518B")]
			ASTC_RGB
		}

		// Token: 0x020009A0 RID: 2464
		[Token(Token = "0x20009A0")]
		public enum CompressionQuality
		{
			// Token: 0x0400518D RID: 20877
			[Token(Token = "0x400518D")]
			LOW,
			// Token: 0x0400518E RID: 20878
			[Token(Token = "0x400518E")]
			MEDIUM,
			// Token: 0x0400518F RID: 20879
			[Token(Token = "0x400518F")]
			HIGH
		}

		// Token: 0x020009A1 RID: 2465
		[Token(Token = "0x20009A1")]
		[Serializable]
		public struct Resolution
		{
			// Token: 0x04005190 RID: 20880
			[Token(Token = "0x4005190")]
			[FieldOffset(Offset = "0x0")]
			public int width;

			// Token: 0x04005191 RID: 20881
			[Token(Token = "0x4005191")]
			[FieldOffset(Offset = "0x4")]
			public int height;
		}

		// Token: 0x020009A2 RID: 2466
		[Token(Token = "0x20009A2")]
		[Serializable]
		public class TextureArrayUserSettings
		{
			// Token: 0x060034EB RID: 13547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034EB")]
			[Address(RVA = "0xD66120", Offset = "0xD65120", VA = "0x180D66120")]
			public TextureArrayUserSettings(CombiningInformation.Resolution resolution, FilterMode filteringMode, CombiningInformation.CompressionType compressionType, CombiningInformation.CompressionQuality compressionQuality = CombiningInformation.CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}

			// Token: 0x04005192 RID: 20882
			[Token(Token = "0x4005192")]
			[FieldOffset(Offset = "0x10")]
			public CombiningInformation.Resolution resolution;

			// Token: 0x04005193 RID: 20883
			[Token(Token = "0x4005193")]
			[FieldOffset(Offset = "0x18")]
			public FilterMode filteringMode;

			// Token: 0x04005194 RID: 20884
			[Token(Token = "0x4005194")]
			[FieldOffset(Offset = "0x1C")]
			public CombiningInformation.CompressionType compressionType;

			// Token: 0x04005195 RID: 20885
			[Token(Token = "0x4005195")]
			[FieldOffset(Offset = "0x20")]
			public CombiningInformation.CompressionQuality compressionQuality;

			// Token: 0x04005196 RID: 20886
			[Token(Token = "0x4005196")]
			[FieldOffset(Offset = "0x24")]
			public int anisotropicFilteringLevel;

			// Token: 0x04005197 RID: 20887
			[Token(Token = "0x4005197")]
			[FieldOffset(Offset = "0x28")]
			public int choiceResolutionW;

			// Token: 0x04005198 RID: 20888
			[Token(Token = "0x4005198")]
			[FieldOffset(Offset = "0x2C")]
			public int choiceResolutionH;

			// Token: 0x04005199 RID: 20889
			[Token(Token = "0x4005199")]
			[FieldOffset(Offset = "0x30")]
			public int choiceFilteringMode;

			// Token: 0x0400519A RID: 20890
			[Token(Token = "0x400519A")]
			[FieldOffset(Offset = "0x34")]
			public int choiceCompressionQuality;

			// Token: 0x0400519B RID: 20891
			[Token(Token = "0x400519B")]
			[FieldOffset(Offset = "0x38")]
			public int choiceCompressionType;
		}

		// Token: 0x020009A3 RID: 2467
		[Token(Token = "0x20009A3")]
		[Serializable]
		public class TextureArrayGroup
		{
			// Token: 0x060034EC RID: 13548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034EC")]
			[Address(RVA = "0xD66150", Offset = "0xD65150", VA = "0x180D66150")]
			public void InitializeDefaultArraySettings(CombiningInformation.Resolution resolution, FilterMode filteringMode, CombiningInformation.CompressionType compressionType, CombiningInformation.CompressionQuality compressionQuality = CombiningInformation.CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}

			// Token: 0x060034ED RID: 13549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034ED")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public TextureArrayGroup()
			{
			}

			// Token: 0x0400519C RID: 20892
			[Token(Token = "0x400519C")]
			[FieldOffset(Offset = "0x10")]
			public CombiningInformation.TextureArrayUserSettings diffuseArraySettings;

			// Token: 0x0400519D RID: 20893
			[Token(Token = "0x400519D")]
			[FieldOffset(Offset = "0x18")]
			public CombiningInformation.TextureArrayUserSettings metallicArraySettings;

			// Token: 0x0400519E RID: 20894
			[Token(Token = "0x400519E")]
			[FieldOffset(Offset = "0x20")]
			public CombiningInformation.TextureArrayUserSettings specularArraySettings;

			// Token: 0x0400519F RID: 20895
			[Token(Token = "0x400519F")]
			[FieldOffset(Offset = "0x28")]
			public CombiningInformation.TextureArrayUserSettings normalArraySettings;

			// Token: 0x040051A0 RID: 20896
			[Token(Token = "0x40051A0")]
			[FieldOffset(Offset = "0x30")]
			public CombiningInformation.TextureArrayUserSettings heightArraySettings;

			// Token: 0x040051A1 RID: 20897
			[Token(Token = "0x40051A1")]
			[FieldOffset(Offset = "0x38")]
			public CombiningInformation.TextureArrayUserSettings occlusionArraySettings;

			// Token: 0x040051A2 RID: 20898
			[Token(Token = "0x40051A2")]
			[FieldOffset(Offset = "0x40")]
			public CombiningInformation.TextureArrayUserSettings emissiveArraySettings;

			// Token: 0x040051A3 RID: 20899
			[Token(Token = "0x40051A3")]
			[FieldOffset(Offset = "0x48")]
			public CombiningInformation.TextureArrayUserSettings detailMaskArraySettings;

			// Token: 0x040051A4 RID: 20900
			[Token(Token = "0x40051A4")]
			[FieldOffset(Offset = "0x50")]
			public CombiningInformation.TextureArrayUserSettings detailAlbedoArraySettings;

			// Token: 0x040051A5 RID: 20901
			[Token(Token = "0x40051A5")]
			[FieldOffset(Offset = "0x58")]
			public CombiningInformation.TextureArrayUserSettings detailNormalArraySettings;
		}

		// Token: 0x020009A4 RID: 2468
		[Token(Token = "0x20009A4")]
		[Serializable]
		public class MaterialProperties
		{
			// Token: 0x060034EE RID: 13550 RVA: 0x00012738 File Offset: 0x00010938
			[Token(Token = "0x60034EE")]
			[Address(RVA = "0xD66770", Offset = "0xD65770", VA = "0x180D66770")]
			public bool IsSameAs(CombiningInformation.MaterialProperties toCompare)
			{
				return default(bool);
			}

			// Token: 0x060034EF RID: 13551 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60034EF")]
			[Address(RVA = "0xD66C20", Offset = "0xD65C20", VA = "0x180D66C20")]
			public static Texture2D NewTexture()
			{
				return null;
			}

			// Token: 0x060034F0 RID: 13552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034F0")]
			[Address(RVA = "0xD66D60", Offset = "0xD65D60", VA = "0x180D66D60")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}

			// Token: 0x060034F1 RID: 13553 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034F1")]
			[Address(RVA = "0xD672F0", Offset = "0xD662F0", VA = "0x180D672F0")]
			public void FillPropertiesFromMaterial(Material material, CombiningInformation combineInfo)
			{
			}

			// Token: 0x060034F2 RID: 13554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034F2")]
			[Address(RVA = "0xD67AD0", Offset = "0xD66AD0", VA = "0x180D67AD0")]
			public MaterialProperties()
			{
			}

			// Token: 0x040051A6 RID: 20902
			[Token(Token = "0x40051A6")]
			[FieldOffset(Offset = "0x10")]
			public bool foldOut;

			// Token: 0x040051A7 RID: 20903
			[Token(Token = "0x40051A7")]
			[FieldOffset(Offset = "0x14")]
			public int texArrIndex;

			// Token: 0x040051A8 RID: 20904
			[Token(Token = "0x40051A8")]
			[FieldOffset(Offset = "0x18")]
			public int matIndex;

			// Token: 0x040051A9 RID: 20905
			[Token(Token = "0x40051A9")]
			[FieldOffset(Offset = "0x20")]
			public string materialName;

			// Token: 0x040051AA RID: 20906
			[Token(Token = "0x40051AA")]
			[FieldOffset(Offset = "0x28")]
			public Material originalMaterial;

			// Token: 0x040051AB RID: 20907
			[Token(Token = "0x40051AB")]
			[FieldOffset(Offset = "0x30")]
			public Color albedoTint;

			// Token: 0x040051AC RID: 20908
			[Token(Token = "0x40051AC")]
			[FieldOffset(Offset = "0x40")]
			public Vector4 uvTileOffset;

			// Token: 0x040051AD RID: 20909
			[Token(Token = "0x40051AD")]
			[FieldOffset(Offset = "0x50")]
			public float normalIntensity;

			// Token: 0x040051AE RID: 20910
			[Token(Token = "0x40051AE")]
			[FieldOffset(Offset = "0x54")]
			public float occlusionIntensity;

			// Token: 0x040051AF RID: 20911
			[Token(Token = "0x40051AF")]
			[FieldOffset(Offset = "0x58")]
			public float smoothnessIntensity;

			// Token: 0x040051B0 RID: 20912
			[Token(Token = "0x40051B0")]
			[FieldOffset(Offset = "0x5C")]
			public float glossMapScale;

			// Token: 0x040051B1 RID: 20913
			[Token(Token = "0x40051B1")]
			[FieldOffset(Offset = "0x60")]
			public float metalIntensity;

			// Token: 0x040051B2 RID: 20914
			[Token(Token = "0x40051B2")]
			[FieldOffset(Offset = "0x64")]
			public Color emissionColor;

			// Token: 0x040051B3 RID: 20915
			[Token(Token = "0x40051B3")]
			[FieldOffset(Offset = "0x74")]
			public Vector4 detailUVTileOffset;

			// Token: 0x040051B4 RID: 20916
			[Token(Token = "0x40051B4")]
			[FieldOffset(Offset = "0x84")]
			public float alphaCutoff;

			// Token: 0x040051B5 RID: 20917
			[Token(Token = "0x40051B5")]
			[FieldOffset(Offset = "0x88")]
			public Color specularColor;

			// Token: 0x040051B6 RID: 20918
			[Token(Token = "0x40051B6")]
			[FieldOffset(Offset = "0x98")]
			public float detailNormalScale;

			// Token: 0x040051B7 RID: 20919
			[Token(Token = "0x40051B7")]
			[FieldOffset(Offset = "0x9C")]
			public float heightIntensity;

			// Token: 0x040051B8 RID: 20920
			[Token(Token = "0x40051B8")]
			[FieldOffset(Offset = "0xA0")]
			public float uvSec;

			// Token: 0x040051B9 RID: 20921
			[Token(Token = "0x40051B9")]
			[FieldOffset(Offset = "0xA4")]
			public int alphaMode;

			// Token: 0x040051BA RID: 20922
			[Token(Token = "0x40051BA")]
			[FieldOffset(Offset = "0xA8")]
			public bool specularWorkflow;
		}

		// Token: 0x020009A5 RID: 2469
		[Token(Token = "0x20009A5")]
		[Serializable]
		public class MeshData
		{
			// Token: 0x060034F3 RID: 13555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034F3")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public MeshData()
			{
			}

			// Token: 0x040051BB RID: 20923
			[Token(Token = "0x40051BB")]
			[FieldOffset(Offset = "0x10")]
			public List<MeshFilter> meshFilters;

			// Token: 0x040051BC RID: 20924
			[Token(Token = "0x40051BC")]
			[FieldOffset(Offset = "0x18")]
			public List<MeshRenderer> meshRenderers;

			// Token: 0x040051BD RID: 20925
			[Token(Token = "0x40051BD")]
			[FieldOffset(Offset = "0x20")]
			public List<SkinnedMeshRenderer> skinnedMeshRenderers;

			// Token: 0x040051BE RID: 20926
			[Token(Token = "0x40051BE")]
			[FieldOffset(Offset = "0x28")]
			public Material[] originalMaterials;

			// Token: 0x040051BF RID: 20927
			[Token(Token = "0x40051BF")]
			[FieldOffset(Offset = "0x30")]
			public Mesh[] outputMeshes;

			// Token: 0x040051C0 RID: 20928
			[Token(Token = "0x40051C0")]
			[FieldOffset(Offset = "0x38")]
			public Matrix4x4[] outputMatrices;
		}

		// Token: 0x020009A6 RID: 2470
		[Token(Token = "0x20009A6")]
		[Serializable]
		public class CombineMetaData
		{
			// Token: 0x060034F4 RID: 13556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034F4")]
			[Address(RVA = "0xD67C40", Offset = "0xD66C40", VA = "0x180D67C40")]
			public CombineMetaData()
			{
			}

			// Token: 0x040051C1 RID: 20929
			[Token(Token = "0x40051C1")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			// Token: 0x040051C2 RID: 20930
			[Token(Token = "0x40051C2")]
			[FieldOffset(Offset = "0x18")]
			public CombiningInformation.MaterialProperties materialProperties;

			// Token: 0x040051C3 RID: 20931
			[Token(Token = "0x40051C3")]
			[FieldOffset(Offset = "0x20")]
			public CombiningInformation.MaterialProperties tempMaterialProperties;

			// Token: 0x040051C4 RID: 20932
			[Token(Token = "0x40051C4")]
			[FieldOffset(Offset = "0x28")]
			public List<CombiningInformation.MeshData> meshesData;
		}

		// Token: 0x020009A7 RID: 2471
		[Token(Token = "0x20009A7")]
		[Serializable]
		public class MaterialEntity
		{
			// Token: 0x060034F5 RID: 13557 RVA: 0x00012750 File Offset: 0x00010950
			[Token(Token = "0x60034F5")]
			[Address(RVA = "0xD67D10", Offset = "0xD66D10", VA = "0x180D67D10")]
			public bool HasAnyTextures()
			{
				return default(bool);
			}

			// Token: 0x060034F6 RID: 13558 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034F6")]
			[Address(RVA = "0xD68520", Offset = "0xD67520", VA = "0x180D68520")]
			public MaterialEntity()
			{
			}

			// Token: 0x040051C5 RID: 20933
			[Token(Token = "0x40051C5")]
			[FieldOffset(Offset = "0x10")]
			public List<CombiningInformation.CombineMetaData> combinedMats;

			// Token: 0x040051C6 RID: 20934
			[Token(Token = "0x40051C6")]
			[FieldOffset(Offset = "0x18")]
			public int textArrIndex;

			// Token: 0x040051C7 RID: 20935
			[Token(Token = "0x40051C7")]
			[FieldOffset(Offset = "0x20")]
			public Texture2D diffuseMap;

			// Token: 0x040051C8 RID: 20936
			[Token(Token = "0x40051C8")]
			[FieldOffset(Offset = "0x28")]
			public Texture2D metallicMap;

			// Token: 0x040051C9 RID: 20937
			[Token(Token = "0x40051C9")]
			[FieldOffset(Offset = "0x30")]
			public Texture2D specularMap;

			// Token: 0x040051CA RID: 20938
			[Token(Token = "0x40051CA")]
			[FieldOffset(Offset = "0x38")]
			public Texture2D normalMap;

			// Token: 0x040051CB RID: 20939
			[Token(Token = "0x40051CB")]
			[FieldOffset(Offset = "0x40")]
			public Texture2D heightMap;

			// Token: 0x040051CC RID: 20940
			[Token(Token = "0x40051CC")]
			[FieldOffset(Offset = "0x48")]
			public Texture2D occlusionMap;

			// Token: 0x040051CD RID: 20941
			[Token(Token = "0x40051CD")]
			[FieldOffset(Offset = "0x50")]
			public Texture2D emissionMap;

			// Token: 0x040051CE RID: 20942
			[Token(Token = "0x40051CE")]
			[FieldOffset(Offset = "0x58")]
			public Texture2D detailMaskMap;

			// Token: 0x040051CF RID: 20943
			[Token(Token = "0x40051CF")]
			[FieldOffset(Offset = "0x60")]
			public Texture2D detailAlbedoMap;

			// Token: 0x040051D0 RID: 20944
			[Token(Token = "0x40051D0")]
			[FieldOffset(Offset = "0x68")]
			public Texture2D detailNormalMap;
		}
	}
}
