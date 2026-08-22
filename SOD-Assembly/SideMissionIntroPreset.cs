using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200088B RID: 2187
[Token(Token = "0x200088B")]
public class SideMissionIntroPreset : SoCustomComparison
{
	// Token: 0x060029F6 RID: 10742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029F6")]
	[Address(RVA = "0xCB31F0", Offset = "0xCB21F0", VA = "0x180CB31F0")]
	public SideMissionIntroPreset()
	{
	}

	// Token: 0x040042FF RID: 17151
	[Token(Token = "0x40042FF")]
	[FieldOffset(Offset = "0x20")]
	public int rewardModifier;

	// Token: 0x04004300 RID: 17152
	[Token(Token = "0x4004300")]
	[FieldOffset(Offset = "0x28")]
	public List<SideMissionIntroPreset.SideMissionObjectiveBlock> blocks;

	// Token: 0x0200088C RID: 2188
	[Token(Token = "0x200088C")]
	public enum SideMissionElementType
	{
		// Token: 0x04004302 RID: 17154
		[Token(Token = "0x4004302")]
		playerCallsNumber,
		// Token: 0x04004303 RID: 17155
		[Token(Token = "0x4004303")]
		acquireInformation,
		// Token: 0x04004304 RID: 17156
		[Token(Token = "0x4004304")]
		askStaff,
		// Token: 0x04004305 RID: 17157
		[Token(Token = "0x4004305")]
		spawnItems,
		// Token: 0x04004306 RID: 17158
		[Token(Token = "0x4004306")]
		photoOfItemLocation,
		// Token: 0x04004307 RID: 17159
		[Token(Token = "0x4004307")]
		openedBriefcase,
		// Token: 0x04004308 RID: 17160
		[Token(Token = "0x4004308")]
		postSubmission,
		// Token: 0x04004309 RID: 17161
		[Token(Token = "0x4004309")]
		playerHasCamera,
		// Token: 0x0400430A RID: 17162
		[Token(Token = "0x400430A")]
		setGooseChaseCall,
		// Token: 0x0400430B RID: 17163
		[Token(Token = "0x400430B")]
		setMeeting,
		// Token: 0x0400430C RID: 17164
		[Token(Token = "0x400430C")]
		handDossier,
		// Token: 0x0400430D RID: 17165
		[Token(Token = "0x400430D")]
		setupHomeInvestigation,
		// Token: 0x0400430E RID: 17166
		[Token(Token = "0x400430E")]
		submitToPoster,
		// Token: 0x0400430F RID: 17167
		[Token(Token = "0x400430F")]
		setHomeMeeting,
		// Token: 0x04004310 RID: 17168
		[Token(Token = "0x4004310")]
		setGooseChaseCallIndoorOnly,
		// Token: 0x04004311 RID: 17169
		[Token(Token = "0x4004311")]
		tailBriefcase,
		// Token: 0x04004312 RID: 17170
		[Token(Token = "0x4004312")]
		playerHasItemInPossession,
		// Token: 0x04004313 RID: 17171
		[Token(Token = "0x4004313")]
		leaveItemAtSecretLocation,
		// Token: 0x04004314 RID: 17172
		[Token(Token = "0x4004314")]
		destroyItem,
		// Token: 0x04004315 RID: 17173
		[Token(Token = "0x4004315")]
		playerHasHandcuffs,
		// Token: 0x04004316 RID: 17174
		[Token(Token = "0x4004316")]
		telephoneSubmission,
		// Token: 0x04004317 RID: 17175
		[Token(Token = "0x4004317")]
		placeItemInPosterMailbox,
		// Token: 0x04004318 RID: 17176
		[Token(Token = "0x4004318")]
		placeItemOfTypeInPosterMailbox
	}

	// Token: 0x0200088D RID: 2189
	[Token(Token = "0x200088D")]
	[Serializable]
	public class SideMissionObjectiveBlock
	{
		// Token: 0x060029F7 RID: 10743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0xCB32C0", Offset = "0xCB22C0", VA = "0x180CB32C0")]
		public SideMissionObjectiveBlock()
		{
		}

		// Token: 0x04004319 RID: 17177
		[Token(Token = "0x4004319")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400431A RID: 17178
		[Token(Token = "0x400431A")]
		[FieldOffset(Offset = "0x18")]
		public SideMissionIntroPreset.SideMissionElementType elementType;

		// Token: 0x0400431B RID: 17179
		[Token(Token = "0x400431B")]
		[FieldOffset(Offset = "0x20")]
		public string dialogReference;

		// Token: 0x0400431C RID: 17180
		[Token(Token = "0x400431C")]
		[FieldOffset(Offset = "0x28")]
		public JobPreset.JobTag tagReference;

		// Token: 0x0400431D RID: 17181
		[Token(Token = "0x400431D")]
		[FieldOffset(Offset = "0x30")]
		public List<JobPreset.StartingSpawnItem> spawnItems;

		// Token: 0x0400431E RID: 17182
		[Token(Token = "0x400431E")]
		[FieldOffset(Offset = "0x38")]
		public bool enableUpdateWhileTalking;

		// Token: 0x0400431F RID: 17183
		[Token(Token = "0x400431F")]
		[FieldOffset(Offset = "0x3C")]
		public float objectiveDelay;

		// Token: 0x04004320 RID: 17184
		[Token(Token = "0x4004320")]
		[FieldOffset(Offset = "0x40")]
		public List<InteractablePreset> validItems;

		// Token: 0x04004321 RID: 17185
		[Token(Token = "0x4004321")]
		[FieldOffset(Offset = "0x48")]
		public List<FurniturePreset> validFurniture;

		// Token: 0x04004322 RID: 17186
		[Token(Token = "0x4004322")]
		[FieldOffset(Offset = "0x50")]
		public List<JobPreset.DifficultyTag> disableOnDifficulties;

		// Token: 0x04004323 RID: 17187
		[Token(Token = "0x4004323")]
		[FieldOffset(Offset = "0x58")]
		public List<SideMissionIntroPreset> onlyCompativleWithIntros;

		// Token: 0x04004324 RID: 17188
		[Token(Token = "0x4004324")]
		[FieldOffset(Offset = "0x60")]
		public List<SideMissionHandInPreset> onlyCompatibleWithHandIns;

		// Token: 0x04004325 RID: 17189
		[Token(Token = "0x4004325")]
		[FieldOffset(Offset = "0x68")]
		public List<JobPreset.JobTag> triggerFailIfItemDestroyed;
	}
}
