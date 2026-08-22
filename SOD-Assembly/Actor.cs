using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class Actor : Controller
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000006")]
	public event Actor.InteractionChanged OnInteractionChanged
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x5D29A0", Offset = "0x5D19A0", VA = "0x1805D29A0")]
		add
		{
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x5D2AA0", Offset = "0x5D1AA0", VA = "0x1805D2AA0")]
		remove
		{
		}
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000007")]
	public event Actor.RoutineChanged OnRoutineChange
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x5D2BA0", Offset = "0x5D1BA0", VA = "0x1805D2BA0")]
		add
		{
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x5D2CA0", Offset = "0x5D1CA0", VA = "0x1805D2CA0")]
		remove
		{
		}
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x5D2DA0", Offset = "0x5D1DA0", VA = "0x1805D2DA0")]
	public void SetInteracting(Interactable other)
	{
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "6")]
	public virtual void OnNewInteraction()
	{
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x5D3390", Offset = "0x5D2390", VA = "0x1805D3390", Slot = "7")]
	public virtual void Teleport(NewNode teleportLocation, Interactable.UsagePoint usagePoint, bool cancelVent = true, bool teleportYPostionOnly = false, bool goalDeactivation = true)
	{
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x5D3BA0", Offset = "0x5D2BA0", VA = "0x1805D3BA0")]
	public float GetCurrentMaxHealth()
	{
		return 0f;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x5D3C00", Offset = "0x5D2C00", VA = "0x1805D3C00", Slot = "8")]
	public virtual void UpdateGameLocation(float feetOffset = 0f, bool forceNodePositionUpdate = false)
	{
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "9")]
	public virtual void OnCityTileChange()
	{
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x5D52E0", Offset = "0x5D42E0", VA = "0x1805D52E0", Slot = "10")]
	public virtual void OnBuildingChange()
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "11")]
	public virtual void OnTileChange()
	{
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x5D54D0", Offset = "0x5D44D0", VA = "0x1805D54D0", Slot = "12")]
	public virtual void OnGameLocationChange(bool enableSocialSightings = true, bool forceDisableLocationMemory = false)
	{
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x5D55F0", Offset = "0x5D45F0", VA = "0x1805D55F0", Slot = "13")]
	public virtual void OnNodeChange()
	{
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x5D5630", Offset = "0x5D4630", VA = "0x1805D5630", Slot = "14")]
	public virtual void OnRoomChange()
	{
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x5D5E70", Offset = "0x5D4E70", VA = "0x1805D5E70", Slot = "15")]
	public virtual void SetOnStreet(bool val)
	{
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x5D5EA0", Offset = "0x5D4EA0", VA = "0x1805D5EA0", Slot = "16")]
	public virtual void AddToKeyring(NewAddress ad, bool gameMessage = true)
	{
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x5D7600", Offset = "0x5D6600", VA = "0x1805D7600", Slot = "17")]
	public virtual void AddToKeyring(NewDoor ac, bool gameMessage = true)
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x5D76B0", Offset = "0x5D66B0", VA = "0x1805D76B0", Slot = "18")]
	public virtual void RemoveFromKeyring(NewAddress ad)
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x5D7950", Offset = "0x5D6950", VA = "0x1805D7950", Slot = "19")]
	public virtual void RemoveFromKeyring(NewDoor ac)
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x5D79B0", Offset = "0x5D69B0", VA = "0x1805D79B0", Slot = "20")]
	public virtual void SetVisible(bool vis, bool force = false)
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x5D8060", Offset = "0x5D7060", VA = "0x1805D8060")]
	public void SetModelParentVisibility(bool val, string debugReason)
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x5D8A60", Offset = "0x5D7A60", VA = "0x1805D8A60", Slot = "21")]
	public virtual void GoToSleep()
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x5D8A80", Offset = "0x5D7A80", VA = "0x1805D8A80", Slot = "22")]
	public virtual void WakeUp(bool forceImmediate = false)
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x5D8AA0", Offset = "0x5D7AA0", VA = "0x1805D8AA0")]
	public void RoutineChange()
	{
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x5D8AA0", Offset = "0x5D7AA0", VA = "0x1805D8AA0")]
	public void OnRoutineEnd()
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x5D8AD0", Offset = "0x5D7AD0", VA = "0x1805D8AD0")]
	public void SetStealthMode(bool newVal)
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x5D8CA0", Offset = "0x5D7CA0", VA = "0x1805D8CA0")]
	public void SetCrouched(bool newVal, bool instant = false)
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x5D9150", Offset = "0x5D8150", VA = "0x1805D9150")]
	public void StealthModeLoop()
	{
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x5D9530", Offset = "0x5D8530", VA = "0x1805D9530", Slot = "23")]
	public virtual void UpdateLightLevel()
	{
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "24")]
	public virtual void OnStealthModeChange()
	{
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "25")]
	public virtual void OnCrouchedChange()
	{
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x5D9540", Offset = "0x5D8540", VA = "0x1805D9540")]
	public void UpdateOverallVisibility()
	{
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x5D96E0", Offset = "0x5D86E0", VA = "0x1805D96E0", Slot = "26")]
	public virtual void SetHiding(bool val, Interactable newHidingPlace)
	{
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x5D96F0", Offset = "0x5D86F0", VA = "0x1805D96F0", Slot = "27")]
	public virtual void RecieveDamage(float amount, Actor fromWho, Vector3 damagePosition, Vector3 damageDirection, SpatterPatternPreset forwardSpatter, SpatterPatternPreset backSpatter, SpatterSimulation.EraseMode spatterErase = SpatterSimulation.EraseMode.useDespawnTime, bool alertSurrounding = true, bool forceRagdoll = false, float forcedRagdollDuration = 0f, float shockMP = 1f, bool enableKill = false, bool allowRecoil = true, float ragdollForceMP = 1f)
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x5D9C70", Offset = "0x5D8C70", VA = "0x1805D9C70", Slot = "28")]
	public virtual void AddHealth(float amount, bool affectedByGameDifficulty = true, bool displayDamageIndicator = false)
	{
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x5D9CB0", Offset = "0x5D8CB0", VA = "0x1805D9CB0", Slot = "29")]
	public virtual void SetHealth(float amount)
	{
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x5D9CF0", Offset = "0x5D8CF0", VA = "0x1805D9CF0", Slot = "30")]
	public virtual void AddNerve(float amount, [Optional] Actor scaredBy)
	{
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x5DA680", Offset = "0x5D9680", VA = "0x1805DA680", Slot = "31")]
	public virtual void SetNerve(float amount)
	{
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x5DA950", Offset = "0x5D9950", VA = "0x1805DA950", Slot = "32")]
	public virtual void OnZeroHealthReached()
	{
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x5DA9D0", Offset = "0x5D99D0", VA = "0x1805DA9D0", Slot = "33")]
	public virtual void ResetHealthToMaximum()
	{
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x5DAA00", Offset = "0x5D9A00", VA = "0x1805DAA00", Slot = "34")]
	public virtual void ResetNerveToMaximum()
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x5DAA20", Offset = "0x5D9A20", VA = "0x1805DAA20", Slot = "35")]
	public virtual void OnZeroNerveReached()
	{
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x5DABA0", Offset = "0x5D9BA0", VA = "0x1805DABA0", Slot = "36")]
	public virtual void SetMaxHealth(float newMax, bool setToMax = false)
	{
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x5DABD0", Offset = "0x5D9BD0", VA = "0x1805DABD0", Slot = "37")]
	public virtual void SetMaxNerve(float newMax, bool setToMax = false)
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x5DAC00", Offset = "0x5D9C00", VA = "0x1805DAC00", Slot = "38")]
	public virtual void SetRecoveryRate(float newRate)
	{
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x5DAC30", Offset = "0x5D9C30", VA = "0x1805DAC30", Slot = "39")]
	public virtual void SetCombatSkill(float newSkill)
	{
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x5DAC60", Offset = "0x5D9C60", VA = "0x1805DAC60", Slot = "40")]
	public virtual void SetCombatHeft(float newHeft)
	{
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x5DAC90", Offset = "0x5D9C90", VA = "0x1805DAC90")]
	public void SetInBed(bool newVal, bool isLowBed, bool useRightSide = false)
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x5DADF0", Offset = "0x5D9DF0", VA = "0x1805DADF0", Slot = "41")]
	public virtual void UpdateCurrentNodeSpace()
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x5DB310", Offset = "0x5DA310", VA = "0x1805DB310", Slot = "42")]
	public virtual void AddReservedNodeSpace(NewNode.NodeSpace newSpace)
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x5DB3C0", Offset = "0x5DA3C0", VA = "0x1805DB3C0", Slot = "43")]
	public virtual void RemoveReservedNodeSpace()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x5DB550", Offset = "0x5DA550", VA = "0x1805DB550", Slot = "44")]
	public virtual void UpdateTrespassing(bool allowEnforcersEverywhere)
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x5DB6E0", Offset = "0x5DA6E0", VA = "0x1805DB6E0", Slot = "45")]
	public virtual void SightingCheck(float fov, bool ignoreLightAndStealth = false)
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x5E0470", Offset = "0x5DF470", VA = "0x1805E0470", Slot = "46")]
	public virtual bool CanISee(Interactable interactable)
	{
		return default(bool);
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002F58 File Offset: 0x00001158
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x5E0DA0", Offset = "0x5DFDA0", VA = "0x1805E0DA0")]
	public bool ActorRaycastCheck(Actor other, float maxRange, out RaycastHit hit, bool drawLine = false, [Optional] Color lineSuccess, [Optional] Color lineFail, [Optional] Color lineNothing, float lineTime = 1f)
	{
		return default(bool);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x5E23D0", Offset = "0x5E13D0", VA = "0x1805E23D0", Slot = "47")]
	public virtual void OnInvestigate(Actor newTarget, int escalation)
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x5E2670", Offset = "0x5E1670", VA = "0x1805E2670", Slot = "48")]
	public virtual void OnAddTrackedTarget(Actor newTarget)
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x5E27A0", Offset = "0x5E17A0", VA = "0x1805E27A0", Slot = "49")]
	public virtual void AddToSeesIllegal(Actor newTarget, float focus)
	{
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x5E2FC0", Offset = "0x5E1FC0", VA = "0x1805E2FC0", Slot = "50")]
	public virtual void RemoveFromSeesIllegal(Actor newTarget, float focus)
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x5E35F0", Offset = "0x5E25F0", VA = "0x1805E35F0", Slot = "51")]
	public virtual void AddPersuedBy(Actor newTarget)
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x5E3800", Offset = "0x5E2800", VA = "0x1805E3800", Slot = "52")]
	public virtual void RemovePersuedBy(Actor newTarget)
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x5E3B30", Offset = "0x5E2B30", VA = "0x1805E3B30")]
	public void HearIllegal(AudioEvent audioEvent, NewNode newInvestigateNode, Vector3 newInvestigatePosition, Actor newTarget, int escLevel)
	{
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x5E3DC0", Offset = "0x5E2DC0", VA = "0x1805E3DC0", Slot = "53")]
	public virtual void ClearSeesIllegal()
	{
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x5E40C0", Offset = "0x5E30C0", VA = "0x1805E40C0", Slot = "54")]
	public virtual void SetEscalation(int newEsc)
	{
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x5E4270", Offset = "0x5E3270", VA = "0x1805E4270")]
	public void SelectedDebug(string str, Actor.HumanDebug debug)
	{
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x5E4410", Offset = "0x5E3410", VA = "0x1805E4410")]
	public void SpottedByPlayer(float graceTimeMultiplier = 1f)
	{
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x5E4B00", Offset = "0x5E3B00", VA = "0x1805E4B00")]
	public void HeardByPlayer()
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x5E5280", Offset = "0x5E4280", VA = "0x1805E5280", Slot = "55")]
	public virtual bool IsTrespassing(NewRoom room, out int trespassEscalation, bool enforcersAllowedEverywhere = true)
	{
		return default(bool);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x5E5290", Offset = "0x5E4290", VA = "0x1805E5290")]
	public void AddLocationOfAuthorty(NewGameLocation newLoc)
	{
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x5E5340", Offset = "0x5E4340", VA = "0x1805E5340")]
	public void RemoveLocationOfAuthority(NewGameLocation newLoc)
	{
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x5E53A0", Offset = "0x5E43A0", VA = "0x1805E53A0", Slot = "56")]
	public virtual void UpdateIllegalStatus()
	{
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x5E53D0", Offset = "0x5E43D0", VA = "0x1805E53D0")]
	public void ListSeesIllegal()
	{
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x5E59B0", Offset = "0x5E49B0", VA = "0x1805E59B0")]
	public void ListWitnessToIllegal()
	{
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x5E5CF0", Offset = "0x5E4CF0", VA = "0x1805E5CF0")]
	public bool HasBeenThrowOutOfWindow()
	{
		return default(bool);
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x5E5E30", Offset = "0x5E4E30", VA = "0x1805E5E30")]
	public Actor()
	{
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x5E6670", Offset = "0x5E5670", VA = "0x1805E6670")]
	private bool <HasBeenThrowOutOfWindow>b__190_0(NewWall item)
	{
		return default(bool);
	}

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isMoving;

	// Token: 0x0400020A RID: 522
	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isRunning;

	// Token: 0x0400020B RID: 523
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool isMachine;

	// Token: 0x0400020C RID: 524
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool isPlayer;

	// Token: 0x0400020D RID: 525
	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isAsleep;

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool isDelayed;

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool isStunned;

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool isDead;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool unreportable;

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool isTrespassing;

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool isOnStreet;

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool seesOthers;

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isSeenByOthers;

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool canListen;

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool visible;

	// Token: 0x04000218 RID: 536
	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool isHome;

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isAtWork;

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool inAirVent;

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool isHiding;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool isInBed;

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool isInLowBed;

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool inConversation;

	// Token: 0x0400021F RID: 543
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool isSpeaking;

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool isHomeless;

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isLitterBug;

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool isOnDuty;

	// Token: 0x04000223 RID: 547
	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool isEnforcer;

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool ownsUmbrella;

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool likesTheRain;

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool forceTarget;

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int debugSeesPlayer;

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float debugLastSeesPlayerChange;

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Dictionary<Actor, float> seesIllegal;

	// Token: 0x0400022A RID: 554
	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HashSet<Actor> seenIllegalThisCheck;

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public HashSet<Actor> witnessesToIllegalActivity;

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public HashSet<Actor> persuedBy;

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool illegalActionActive;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool illegalAreaActive;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int trespassingEscalation;

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool illegalStatus;

	// Token: 0x04000231 RID: 561
	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform lookAtThisTransform;

	// Token: 0x04000232 RID: 562
	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform aimTransform;

	// Token: 0x04000233 RID: 563
	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject modelParent;

	// Token: 0x04000234 RID: 564
	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject distantLOD;

	// Token: 0x04000235 RID: 565
	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<MeshRenderer> meshes;

	// Token: 0x04000236 RID: 566
	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<MeshRenderer> meshesLOD1;

	// Token: 0x04000237 RID: 567
	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public CitizenAnimationController animationController;

	// Token: 0x04000238 RID: 568
	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public SpeechController speechController;

	// Token: 0x04000239 RID: 569
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Transform neckTransform;

	// Token: 0x0400023A RID: 570
	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public InteractablePreset citizenObjectPreset;

	// Token: 0x0400023B RID: 571
	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x0400023C RID: 572
	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[NonSerialized]
	public Interactable leftHandInteractable;

	// Token: 0x0400023D RID: 573
	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[NonSerialized]
	public Interactable rightHandInteractable;

	// Token: 0x0400023E RID: 574
	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public InteractableController interactableController;

	// Token: 0x0400023F RID: 575
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public NewAIController ai;

	// Token: 0x04000240 RID: 576
	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Transform footstepSoundTransform;

	// Token: 0x04000241 RID: 577
	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public OutlineController outline;

	// Token: 0x04000242 RID: 578
	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float currentHealth;

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float maximumHealth;

	// Token: 0x04000244 RID: 580
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float currentHealthNormalized;

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float recoveryRate;

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float combatSkill;

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float combatHeft;

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float currentNerve;

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Actor lastScaredBy;

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public NewGameLocation lastScaredAt;

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float maxNerve;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[NonSerialized]
	public CityTile previousCityTile;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[NonSerialized]
	public CityTile currentCityTile;

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[NonSerialized]
	public NewTile previousTile;

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[NonSerialized]
	public NewTile currentTile;

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[NonSerialized]
	public NewBuilding previousBuilding;

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public NewBuilding currentBuilding;

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[NonSerialized]
	public NewGameLocation previousGameLocation;

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public NewGameLocation currentGameLocation;

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[NonSerialized]
	public NewRoom previousRoom;

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public NewRoom currentRoom;

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[NonSerialized]
	public AirDuctGroup currentDuct;

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[NonSerialized]
	public AirDuctGroup previousDuct;

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public NewNode.NodeSpace currentNodeSpace;

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public HashSet<NewNode.NodeSpace> reservedNodeSpace;

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public NewNode debugPrevNode2;

	// Token: 0x0400025B RID: 603
	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public NewNode debugPrevNode1;

	// Token: 0x0400025C RID: 604
	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public NewNode previousNode;

	// Token: 0x0400025D RID: 605
	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public NewNode currentNode;

	// Token: 0x0400025E RID: 606
	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[NonSerialized]
	public Vector3Int currentNodeCoord;

	// Token: 0x0400025F RID: 607
	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public List<NewDoor> keyring;

	// Token: 0x04000260 RID: 608
	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[NonSerialized]
	public EvidenceWitness evidenceEntry;

	// Token: 0x04000261 RID: 609
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float currentLightLevel;

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	[NonSerialized]
	private float lightLevelTransition;

	// Token: 0x04000263 RID: 611
	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public bool stealthMode;

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E9")]
	public bool isCrouched;

	// Token: 0x04000265 RID: 613
	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	public float appliedStealth;

	// Token: 0x04000266 RID: 614
	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private float currentVisibilityPotential;

	// Token: 0x04000267 RID: 615
	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	public float overallVisibility;

	// Token: 0x04000268 RID: 616
	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public float stealthDistance;

	// Token: 0x04000269 RID: 617
	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	public int escalationLevel;

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public float timeOfLastSightCheck;

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	[NonSerialized]
	public float spottedState;

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[NonSerialized]
	public float spottedGraceTime;

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	public float spotFocusSpeedMultiplier;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public float spotLoseFocusSpeedMultiplier;

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	public float hearingMultiplier;

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public HashSet<NewGameLocation> locationsOfAuthority;

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[NonSerialized]
	public Interactable interactingWith;

	// Token: 0x04000272 RID: 626
	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public float bedCheckRadius;

	// Token: 0x04000273 RID: 627
	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public List<Interactable> inventory;

	// Token: 0x04000274 RID: 628
	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public float stealthSkill;

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	[NonSerialized]
	public float sleepDepth;

	// Token: 0x04000276 RID: 630
	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	[NonSerialized]
	public int awakenPromt;

	// Token: 0x04000277 RID: 631
	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	[NonSerialized]
	public float awakenRegen;

	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public enum HumanDebug
	{
		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		movement,
		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		actions,
		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		attacks,
		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		updates,
		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		misc,
		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		sight
	}

	// Token: 0x0200004B RID: 75
	// (Invoke) Token: 0x06000312 RID: 786
	[Token(Token = "0x200004B")]
	public delegate void InteractionChanged();

	// Token: 0x0200004C RID: 76
	// (Invoke) Token: 0x06000316 RID: 790
	[Token(Token = "0x200004C")]
	public delegate void RoutineChanged();

	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	private sealed class <>c__DisplayClass132_0
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass132_0()
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x600031A")]
		[Address(RVA = "0xDC7460", Offset = "0xDC6460", VA = "0x180DC7460")]
		internal bool <AddToKeyring>b__0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewAddress ad;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Interactable.Passed> <>9__0;
	}

	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xDC7560", Offset = "0xDC6560", VA = "0x180DC7560")]
		internal bool <AddNerve>b__153_0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x600031E")]
		[Address(RVA = "0xDC7590", Offset = "0xDC6590", VA = "0x180DC7590")]
		internal bool <SetNerve>b__154_0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x600031F")]
		[Address(RVA = "0xDC75D0", Offset = "0xDC65D0", VA = "0x180DC75D0")]
		internal bool <SightingCheck>b__169_0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x6000320")]
		[Address(RVA = "0xDC7670", Offset = "0xDC6670", VA = "0x180DC7670")]
		internal bool <SightingCheck>b__169_2(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Actor.<>c <>9;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<MurderController.Murder> <>9__153_0;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<MurderController.Murder> <>9__154_0;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<NewAIGoal> <>9__169_0;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<NewAIGoal> <>9__169_2;
	}

	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	private sealed class <>c__DisplayClass169_0
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass169_0()
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000322")]
		[Address(RVA = "0xDC7710", Offset = "0xDC6710", VA = "0x180DC7710")]
		internal bool <SightingCheck>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human other;
	}
}
