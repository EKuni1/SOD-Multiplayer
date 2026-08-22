using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
public class NewAIController : MonoBehaviour
{
	// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000493")]
	[Address(RVA = "0xA997C0", Offset = "0xA987C0", VA = "0x180A997C0")]
	public void Setup(Human newParent)
	{
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000494")]
	[Address(RVA = "0xA99A70", Offset = "0xA98A70", VA = "0x180A99A70")]
	public void AITick(bool forceUpdatePriorities = false, bool ignoreRepeatDelays = false)
	{
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000495")]
	[Address(RVA = "0xA9D3C0", Offset = "0xA9C3C0", VA = "0x180A9D3C0")]
	public NewAIGoal CreateNewGoal(AIGoalPreset newPreset, float newTrigerTime, float newDuration, [Optional] NewNode newPassedNode, [Optional] Interactable newPassedInteractable, [Optional] NewGameLocation newPassedGameLocation, [Optional] GroupsController.SocialGroup newPassedGroup, [Optional] MurderController.Murder newMurderRef, int newPassedVar = -2)
	{
		return null;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000496")]
	[Address(RVA = "0xA9D6D0", Offset = "0xA9C6D0", VA = "0x180A9D6D0")]
	public NewAIAction CreateNewAction(NewAIGoal newGoal, AIActionPreset newPreset, bool newInsertedAction = false, [Optional] NewRoom newPassedRoom, [Optional] Interactable newPassedInteractable, [Optional] NewNode newForcedNode, [Optional] GroupsController.SocialGroup newPassedGroup, [Optional] List<InteractablePreset> newPassedAcquireItems, bool newForceRun = false, int newInsertedActionPriority = 3, [Optional] NewAIAction newCreatedFor)
	{
		return null;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000497")]
	[Address(RVA = "0xA9D9C0", Offset = "0xA9C9C0", VA = "0x180A9D9C0")]
	public void StatusStatUpdate()
	{
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000498")]
	[Address(RVA = "0xA9EE20", Offset = "0xA9DE20", VA = "0x180A9EE20")]
	public void OnCompleteGoal(NewAIGoal completed)
	{
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000499")]
	[Address(RVA = "0xA9EE90", Offset = "0xA9DE90", VA = "0x180A9EE90")]
	public void SetDesiredTickRate(NewAIController.AITickRate newRate, bool forceUpdate = false)
	{
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049A")]
	[Address(RVA = "0xA9EF40", Offset = "0xA9DF40", VA = "0x180A9EF40")]
	public void UpdateTickRate(bool forceUpdate = false)
	{
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049B")]
	[Address(RVA = "0xA9F1E0", Offset = "0xA9E1E0", VA = "0x180A9F1E0")]
	public void FrequentUpdate()
	{
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049C")]
	[Address(RVA = "0xA9FC20", Offset = "0xA9EC20", VA = "0x180A9FC20")]
	private void MovementSpeedUpdate()
	{
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049D")]
	[Address(RVA = "0xAA16E0", Offset = "0xAA06E0", VA = "0x180AA16E0")]
	private void HearingUpdate()
	{
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049E")]
	[Address(RVA = "0xAA1830", Offset = "0xAA0830", VA = "0x180AA1830")]
	private void StatesUpdate()
	{
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600049F")]
	[Address(RVA = "0xAA1940", Offset = "0xAA0940", VA = "0x180AA1940")]
	public void PersuitUpdate()
	{
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xAA2ED0", Offset = "0xAA1ED0", VA = "0x180AA2ED0")]
	private void MovementUpdate()
	{
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xAA5FB0", Offset = "0xAA4FB0", VA = "0x180AA5FB0")]
	private void SimulateFootprints()
	{
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00003C90 File Offset: 0x00001E90
	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xAA60C0", Offset = "0xAA50C0", VA = "0x180AA60C0")]
	private float GetRotationalLerpValue(Quaternion originalRotation, Quaternion targetRotation, float multiplier, out float angleBetween)
	{
		return 0f;
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xAA61D0", Offset = "0xAA51D0", VA = "0x180AA61D0")]
	private void FacingUpdate()
	{
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xAA7BB0", Offset = "0xAA6BB0", VA = "0x180AA7BB0")]
	private void AttackUpdate()
	{
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xAAA060", Offset = "0xAA9060", VA = "0x180AAA060")]
	public Human GetCurrentKillTarget()
	{
		return null;
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xAAA200", Offset = "0xAA9200", VA = "0x180AAA200")]
	private void KOUpdate()
	{
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xAAB560", Offset = "0xAAA560", VA = "0x180AAB560")]
	public void SetParentPositionToRagdollLimbPosition()
	{
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xAACA50", Offset = "0xAABA50", VA = "0x180AACA50")]
	public void SetUpdateEnabled(bool val)
	{
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xAACCF0", Offset = "0xAABCF0", VA = "0x180AACCF0")]
	public void ClampNeckRotation(bool setNeckAngles = true)
	{
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xAAD110", Offset = "0xAAC110", VA = "0x180AAD110")]
	public void ReachNewPathNode(bool scanForNextNodeFurniture = true)
	{
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xAAF0F0", Offset = "0xAAE0F0", VA = "0x180AAF0F0")]
	public void DoorCheckProcess()
	{
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xAB07D0", Offset = "0xAAF7D0", VA = "0x180AB07D0")]
	public void SetDestinationNode(NewNode newLocation, bool scanForNextNodeFurniture = true)
	{
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xAB22C0", Offset = "0xAB12C0", VA = "0x180AB22C0")]
	private bool DynamicReRoute(NewNode current, NewNode avoidThis, NewNode beyond, out NewNode bestAvoidanceTile)
	{
		return default(bool);
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xAB2DB0", Offset = "0xAB1DB0", VA = "0x180AB2DB0")]
	public void SetFaceTravelDirection()
	{
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xAB2DE0", Offset = "0xAB1DE0", VA = "0x180AB2DE0")]
	public void SetFacingPosition(Vector3 newLookPoint)
	{
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0xAB34F0", Offset = "0xAB24F0", VA = "0x180AB34F0")]
	public void SetFacingDirection(Vector3 newLookDirection)
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0xAB3880", Offset = "0xAB2880", VA = "0x180AB3880")]
	public void SetFacingTransform(Transform newLookAt, Vector3 offset)
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0xAB3D30", Offset = "0xAB2D30", VA = "0x180AB3D30")]
	public void SetLookAtTransform(Transform newTarget, float newRank)
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xAB3F30", Offset = "0xAB2F30", VA = "0x180AB3F30")]
	public void AddTrackedTarget(Actor newTracked)
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xAB4450", Offset = "0xAB3450", VA = "0x180AB4450")]
	private void TrackingSpookCheck(NewAIController.TrackingTarget newTarget, bool seen)
	{
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xAB4ED0", Offset = "0xAB3ED0", VA = "0x180AB4ED0")]
	public void UpdateHumanDrawnWeapon(Human who, bool seen)
	{
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xAB5510", Offset = "0xAB4510", VA = "0x180AB5510")]
	public void UpdateTrackedTargets()
	{
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xAB6560", Offset = "0xAB5560", VA = "0x180AB6560")]
	public void SetTrackTarget(NewAIController.TrackingTarget newTrackingTarget)
	{
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xAB6960", Offset = "0xAB5960", VA = "0x180AB6960")]
	public void OnNewTrackTarget()
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xAB7E40", Offset = "0xAB6E40", VA = "0x180AB7E40")]
	public bool IsMuggingValid(Human target, out string debugReason)
	{
		return default(bool);
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xAB90B0", Offset = "0xAB80B0", VA = "0x180AB90B0")]
	private void RemoveLookAtTargetAt(int index)
	{
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnVisibilityChanged()
	{
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xAB9110", Offset = "0xAB8110", VA = "0x180AB9110")]
	public void SetExpression(CitizenOutfitController.Expression newExpression)
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xAB91B0", Offset = "0xAB81B0", VA = "0x180AB91B0")]
	public void AddDebugAction(string msg)
	{
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xAB9350", Offset = "0xAB8350", VA = "0x180AB9350")]
	public void DebugTeleportPlayerToLocation()
	{
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xAB93E0", Offset = "0xAB83E0", VA = "0x180AB93E0")]
	public void GiveSleep()
	{
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xAB9420", Offset = "0xAB8420", VA = "0x180AB9420")]
	public void RemoveSleep()
	{
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xAB9460", Offset = "0xAB8460", VA = "0x180AB9460")]
	public void GiveFood()
	{
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xAB94A0", Offset = "0xAB84A0", VA = "0x180AB94A0")]
	public void RemoveFood()
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xAB94E0", Offset = "0xAB84E0", VA = "0x180AB94E0")]
	public void GiveDrink()
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xAB9520", Offset = "0xAB8520", VA = "0x180AB9520")]
	public void RemoveDrink()
	{
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xAB9560", Offset = "0xAB8560", VA = "0x180AB9560")]
	public void GiveCaffeine()
	{
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xAB95A0", Offset = "0xAB85A0", VA = "0x180AB95A0")]
	public void RemoveCaffeine()
	{
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0xAB95E0", Offset = "0xAB85E0", VA = "0x180AB95E0")]
	public void GiveFun()
	{
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0xAB9620", Offset = "0xAB8620", VA = "0x180AB9620")]
	public void RemoveFun()
	{
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0xAB9660", Offset = "0xAB8660", VA = "0x180AB9660")]
	public void GiveBladder()
	{
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0xAB96C0", Offset = "0xAB86C0", VA = "0x180AB96C0")]
	public void RemoveBladder()
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0xAB9720", Offset = "0xAB8720", VA = "0x180AB9720")]
	public void GiveHygiene()
	{
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xAB9760", Offset = "0xAB8760", VA = "0x180AB9760")]
	public void RemoveHygiene()
	{
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xAB97A0", Offset = "0xAB87A0", VA = "0x180AB97A0")]
	public void GiveDrunk()
	{
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0xAB97E0", Offset = "0xAB87E0", VA = "0x180AB97E0")]
	public void RemoveDrunk()
	{
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xAB9820", Offset = "0xAB8820", VA = "0x180AB9820")]
	public void MurderButton()
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xAB9940", Offset = "0xAB8940", VA = "0x180AB9940")]
	public void DebugMovement()
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xAB9A60", Offset = "0xAB8A60", VA = "0x180AB9A60")]
	public void Trip()
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xAB9C30", Offset = "0xAB8C30", VA = "0x180AB9C30")]
	public void UpdateProjectedChasePosition()
	{
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xAB9C60", Offset = "0xAB8C60", VA = "0x180AB9C60")]
	public void HearIllegal(AudioEvent audioEvent, NewNode newInvestigateNode, Vector3 newInvestigatePosition, Actor newTarget, int escLevel)
	{
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xABA670", Offset = "0xAB9670", VA = "0x180ABA670")]
	public void Investigate(NewNode newInvestigateNode, Vector3 newInvestigatePosition, Actor newTarget, NewAIController.ReactionState newReactionState, float minimumInvestiationTimeMP, int escalation, bool setHighUrgency = false, float focusTimeMultiplier = 1f, [Optional] Interactable newInvesigationObj)
	{
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xABBCF0", Offset = "0xABACF0", VA = "0x180ABBCF0")]
	public void SetInvestigationUrgency(NewAIController.InvestigationUrgency newUrgency)
	{
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xABBD00", Offset = "0xABAD00", VA = "0x180ABBD00")]
	public void SetPersue(Actor newTarget, bool publicFauxPas, int escalation, bool setHighUrgency, float responseRange = 10f)
	{
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xABC620", Offset = "0xABB620", VA = "0x180ABC620")]
	public void SetPersueTarget(Actor newTarget)
	{
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xABC8B0", Offset = "0xABB8B0", VA = "0x180ABC8B0")]
	public void CancelPersue()
	{
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xABC990", Offset = "0xABB990", VA = "0x180ABC990")]
	public void SetPersuit(bool val)
	{
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xABCA90", Offset = "0xABBA90", VA = "0x180ABCA90")]
	public void SetSeesOnPersuit(bool val)
	{
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0xABCB90", Offset = "0xABBB90", VA = "0x180ABCB90")]
	public void ResetInvestigate()
	{
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0xABD3F0", Offset = "0xABC3F0", VA = "0x180ABD3F0")]
	public void Patrol(NewGameLocation newPatLoc)
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DD")]
	[Address(RVA = "0xABD550", Offset = "0xABC550", VA = "0x180ABD550")]
	public void StartAttack(Actor newAttackTarget)
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0xABDC10", Offset = "0xABCC10", VA = "0x180ABDC10")]
	public void ThrowObject(Actor newAttackTarget)
	{
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004DF")]
	[Address(RVA = "0xABE540", Offset = "0xABD540", VA = "0x180ABE540")]
	public void OnAttackComplete()
	{
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E0")]
	[Address(RVA = "0xABE6F0", Offset = "0xABD6F0", VA = "0x180ABE6F0")]
	public void OnAttackBlock(bool perfect = false)
	{
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E1")]
	[Address(RVA = "0xABEA10", Offset = "0xABDA10", VA = "0x180ABEA10")]
	public void OnAbortAttack()
	{
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E2")]
	[Address(RVA = "0xABECE0", Offset = "0xABDCE0", VA = "0x180ABECE0")]
	private void SetAttackDelay(bool blocked = false, bool blockedPerfect = false)
	{
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E3")]
	[Address(RVA = "0xABEF30", Offset = "0xABDF30", VA = "0x180ABEF30")]
	public void EndAttack()
	{
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0xABF340", Offset = "0xABE340", VA = "0x180ABF340")]
	public void TalkTo(InteractionController.ConversationType convoType = InteractionController.ConversationType.normal)
	{
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0xABF8D0", Offset = "0xABE8D0", VA = "0x180ABF8D0")]
	public void OnReturnFromTalkTo()
	{
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0xAC0160", Offset = "0xABF160", VA = "0x180AC0160")]
	public void SetStunned(bool val)
	{
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0xAC0240", Offset = "0xABF240", VA = "0x180AC0240")]
	public void SetDelayed(float seconds)
	{
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0xAC02E0", Offset = "0xABF2E0", VA = "0x180AC02E0")]
	public void AnswerDoor(NewDoor dc, NewGameLocation where, Actor byWho)
	{
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0xAC0A30", Offset = "0xABFA30", VA = "0x180AC0A30")]
	public void AnswerPhone(Telephone where)
	{
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0xAC0F80", Offset = "0xABFF80", VA = "0x180AC0F80")]
	public void AwakenPrompt()
	{
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0xAC1200", Offset = "0xAC0200", VA = "0x180AC1200")]
	public void DisplayCurrentRoute()
	{
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0xAC14E0", Offset = "0xAC04E0", VA = "0x180AC14E0")]
	public void SetInCombat(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0xAC1770", Offset = "0xAC0770", VA = "0x180AC1770")]
	public void RecalculateWeaponStats()
	{
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EE")]
	[Address(RVA = "0xAC1820", Offset = "0xAC0820", VA = "0x180AC1820")]
	public void SetKO(bool val, [Optional] Vector3 impactPoint, [Optional] Vector3 impactDirection, bool forced = false, float forcedDuration = 0f, bool resetInvesigate = true, float forceMultiplier = 1f)
	{
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0xAC2370", Offset = "0xAC1370", VA = "0x180AC2370")]
	public void SetOutOfBreath(bool val)
	{
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0xAC24A0", Offset = "0xAC14A0", VA = "0x180AC24A0")]
	public void SetRestrained(bool val, float duration)
	{
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0xAC2C00", Offset = "0xAC1C00", VA = "0x180AC2C00")]
	public void SetReactionState(NewAIController.ReactionState newState)
	{
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F2")]
	[Address(RVA = "0xAC2D20", Offset = "0xAC1D20", VA = "0x180AC2D20")]
	public void TriggerReactionIndicator()
	{
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0xAC3BF0", Offset = "0xAC2BF0", VA = "0x180AC3BF0")]
	public void DebugDestinationPosition(string input)
	{
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0xAC3D10", Offset = "0xAC2D10", VA = "0x180AC3D10")]
	public void CancelCombat()
	{
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0xAC3DD0", Offset = "0xAC2DD0", VA = "0x180AC3DD0")]
	public void SetAsVictim(MurderController.Murder newMurder)
	{
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0xAC3F10", Offset = "0xAC2F10", VA = "0x180AC3F10")]
	public void SetAsMurderer(MurderController.Murder newMurderer)
	{
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0xAC4010", Offset = "0xAC3010", VA = "0x180AC4010")]
	public void SetStaticFromAnimation(bool val)
	{
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0xAC4160", Offset = "0xAC3160", VA = "0x180AC4160")]
	public void GetRotationState()
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xAC4850", Offset = "0xAC3850", VA = "0x180AC4850")]
	public void CloseDoorsNormallyAfterLeavingGamelocation(NewGameLocation afterLeaving)
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0xAC48B0", Offset = "0xAC38B0", VA = "0x180AC48B0")]
	public void UpdateCurrentWeapon()
	{
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FB")]
	[Address(RVA = "0xAC4E60", Offset = "0xAC3E60", VA = "0x180AC4E60")]
	public void SetCurrentWeapon(Interactable obj)
	{
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xAC5150", Offset = "0xAC4150", VA = "0x180AC5150")]
	public void UpdateHeldItems(AIActionPreset.ActionStateFlag state)
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xAC7180", Offset = "0xAC6180", VA = "0x180AC7180")]
	public void DespawnRightItem()
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xAC7390", Offset = "0xAC6390", VA = "0x180AC7390")]
	public void DespawnLeftItem()
	{
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xAC75A0", Offset = "0xAC65A0", VA = "0x180AC75A0")]
	public void InstantPersuitCheck(Actor target)
	{
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000500")]
	[Address(RVA = "0xAC7A90", Offset = "0xAC6A90", VA = "0x180AC7A90")]
	public void EnableAI(bool val)
	{
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x63A040", Offset = "0x639040", VA = "0x18063A040")]
	public void SetConfineLocation(NewGameLocation newConfine)
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000502")]
	[Address(RVA = "0xAC7EC0", Offset = "0xAC6EC0", VA = "0x180AC7EC0")]
	public void AddAvoidLocation(NewGameLocation newAvoid)
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000503")]
	[Address(RVA = "0xAC7F70", Offset = "0xAC6F70", VA = "0x180AC7F70")]
	public void RemoveAvoidLocation(NewGameLocation remAvoid)
	{
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000504")]
	[Address(RVA = "0xAC7FD0", Offset = "0xAC6FD0", VA = "0x180AC7FD0")]
	public NewGameLocation CheckConfinedLocation(NewGameLocation desired)
	{
		return null;
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x6000505")]
	[Address(RVA = "0xAC97F0", Offset = "0xAC87F0", VA = "0x180AC97F0")]
	public bool CanIgnoreLockedDoors()
	{
		return default(bool);
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x772080", Offset = "0x771080", VA = "0x180772080")]
	public void AddSpooked(float val)
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000507")]
	[Address(RVA = "0xAC9DC0", Offset = "0xAC8DC0", VA = "0x180AC9DC0")]
	public void IsTrespassingAtActionDestination()
	{
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000508")]
	[Address(RVA = "0xACA180", Offset = "0xAC9180", VA = "0x180ACA180")]
	public void CurrentGoalTriggerTime()
	{
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000509")]
	[Address(RVA = "0xACA450", Offset = "0xAC9450", VA = "0x180ACA450")]
	public void ForceNodeReached()
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050A")]
	[Address(RVA = "0xACA460", Offset = "0xAC9460", VA = "0x180ACA460")]
	public void DestinationCheck()
	{
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050B")]
	[Address(RVA = "0xACA490", Offset = "0xAC9490", VA = "0x180ACA490")]
	public void OpenEvidenceFirstName()
	{
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050C")]
	[Address(RVA = "0xACA5A0", Offset = "0xAC95A0", VA = "0x180ACA5A0")]
	public void OpenEvidenceName()
	{
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050D")]
	[Address(RVA = "0xACA6B0", Offset = "0xAC96B0", VA = "0x180ACA6B0")]
	public void OpenEvidencePhoto()
	{
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050E")]
	[Address(RVA = "0xACA7C0", Offset = "0xAC97C0", VA = "0x180ACA7C0")]
	public void ToggleHumanDebug()
	{
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050F")]
	[Address(RVA = "0xACAA40", Offset = "0xAC9A40", VA = "0x180ACAA40")]
	public void PrintCurrentNodePosition()
	{
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000510")]
	[Address(RVA = "0xACAD70", Offset = "0xAC9D70", VA = "0x180ACAD70")]
	public void ForceUpdateGameLocation()
	{
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000511")]
	[Address(RVA = "0xACADB0", Offset = "0xAC9DB0", VA = "0x180ACADB0")]
	public void DebugNextJobHours()
	{
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000512")]
	[Address(RVA = "0xACB9C0", Offset = "0xACA9C0", VA = "0x180ACB9C0")]
	public NewAIController()
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x6000513")]
	[Address(RVA = "0xACC430", Offset = "0xACB430", VA = "0x180ACC430")]
	private bool <StatusStatUpdate>b__181_0(NewAIController.TrackingTarget item)
	{
		return default(bool);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x6000514")]
	[Address(RVA = "0xACC5F0", Offset = "0xACB5F0", VA = "0x180ACC5F0")]
	private bool <SetParentPositionToRagdollLimbPosition>b__197_0(Objective.ObjectiveTrigger item)
	{
		return default(bool);
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x6000515")]
	[Address(RVA = "0xACC670", Offset = "0xACB670", VA = "0x180ACC670")]
	private bool <DoorCheckProcess>b__201_0(NewAIAction item)
	{
		return default(bool);
	}

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public Human human;

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider capCollider;

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public float delta;

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float prevDelta;

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float nourishment;

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float hydration;

	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float alertness;

	// Token: 0x04000424 RID: 1060
	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float energy;

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float excitement;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float chores;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float hygiene;

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float bladder;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float heat;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float drunk;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float breath;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float idleSound;

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float blink;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int debugSeesPlayer;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float debugLastSeesPlayerChange;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float hearsIllegal;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Actor hearTarget;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<NewAIGoal> goals;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public NewAIGoal currentGoal;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public NewAIAction currentAction;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public NewAIGoal investigationGoal;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[NonSerialized]
	public NewAIGoal patrolGoal;

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[NonSerialized]
	public FurnitureLocation currentFurnitureUser;

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[NonSerialized]
	public NewNode currentFurnitureNode;

	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Interactable nextAIAction;

	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Human kidnapper;

	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public NewGameLocation confineLocation;

	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<NewGameLocation> avoidLocations;

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[NonSerialized]
	public int pathCursor;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[NonSerialized]
	public NewNode currentDestinationNode;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[NonSerialized]
	public Vector3 currentDesitnationNodeCoord;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public Vector3 currentDestinationPositon;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float movementAmount;

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float distanceToNext;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Quaternion lastMovementRotation;

	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool doIMove;

	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float footStepDistanceCounter;

	// Token: 0x04000446 RID: 1094
	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool rightFootNext;

	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	public bool isTripping;

	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
	public bool doorCheck;

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private NewDoor doorCheckDoor;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[NonSerialized]
	public NewDoor openedDoor;

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[NonSerialized]
	private int delayFlag;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private List<NewDoor> doorInteractions;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public bool facingActive;

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public Vector3 facingDirection;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[NonSerialized]
	public Transform faceTransform;

	// Token: 0x04000450 RID: 1104
	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[NonSerialized]
	public Vector3 faceTransformOffset;

	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public Quaternion facingQuat;

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private Quaternion lookingQuatPrevious;

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private Quaternion lookingQuatLastFrame;

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private Quaternion lookingQuatCurrent;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private float lookAroundTimer;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Vector3 lookAroundPosition;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public List<NewAIController.TrackingTarget> trackedTargets;

	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[NonSerialized]
	public NewAIController.TrackingTarget currentTrackTarget;

	// Token: 0x04000459 RID: 1113
	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Transform lookAtTransform;

	// Token: 0x0400045A RID: 1114
	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public float lookAtTransformRank;

	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private Quaternion original;

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private Vector3 dirXZ;

	// Token: 0x0400045D RID: 1117
	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private Vector3 forwardXZ;

	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	private Vector3 dirYZ;

	// Token: 0x0400045F RID: 1119
	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Vector3 forwardYZ;

	// Token: 0x04000460 RID: 1120
	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	[NonSerialized]
	public CitizenOutfitController.ExpressionSetup currentExpression;

	// Token: 0x04000461 RID: 1121
	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public float expressionProgress;

	// Token: 0x04000462 RID: 1122
	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	public bool blinkInProgress;

	// Token: 0x04000463 RID: 1123
	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private float blinkTimer;

	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	public float eyesOpen;

	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public float bargeTimer;

	// Token: 0x04000466 RID: 1126
	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public Actor persuitTarget;

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public NewNode investigateLocation;

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public Vector3 investigatePosition;

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	public Vector3 investigatePositionProjection;

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public Interactable investigateObject;

	// Token: 0x0400046B RID: 1131
	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public Interactable tamperedObject;

	// Token: 0x0400046C RID: 1132
	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public NewAIController.InvestigationUrgency investigationUrgency;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	[NonSerialized]
	public NewAIAction audioFocusAction;

	// Token: 0x0400046E RID: 1134
	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public float lastInvestigate;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private float persuitUpdateTimer;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public bool persuit;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x289")]
	public bool seesOnPersuit;

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
	public float persuitChaseLogicUses;

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public float minimumInvestigationTimeMultiplier;

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public NewAIController.ChaseLogic chaseLogic;

	// Token: 0x04000475 RID: 1141
	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public ReactionIndicatorController reactionIndicator;

	// Token: 0x04000476 RID: 1142
	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public NewAIController.ReactionState reactionState;

	// Token: 0x04000477 RID: 1143
	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public NewGameLocation patrolLocation;

	// Token: 0x04000478 RID: 1144
	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public bool inCombat;

	// Token: 0x04000479 RID: 1145
	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B9")]
	public bool inFleeState;

	// Token: 0x0400047A RID: 1146
	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2BA")]
	public bool staticFromAnimation;

	// Token: 0x0400047B RID: 1147
	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
	public float staticAnimationSafetyTimer;

	// Token: 0x0400047C RID: 1148
	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public bool attackActive;

	// Token: 0x0400047D RID: 1149
	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public Actor attackTarget;

	// Token: 0x0400047E RID: 1150
	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public AttackBarController activeAttackBar;

	// Token: 0x0400047F RID: 1151
	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public float attackTimeout;

	// Token: 0x04000480 RID: 1152
	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
	public float attackProgress;

	// Token: 0x04000481 RID: 1153
	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private int revolverShots;

	// Token: 0x04000482 RID: 1154
	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
	public bool damageColliderCreated;

	// Token: 0x04000483 RID: 1155
	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E5")]
	private bool ejectBrassCreated;

	// Token: 0x04000484 RID: 1156
	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public DamageColliderController damageCollider;

	// Token: 0x04000485 RID: 1157
	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public float attackDelay;

	// Token: 0x04000486 RID: 1158
	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
	private float attackActiveLength;

	// Token: 0x04000487 RID: 1159
	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public bool ko;

	// Token: 0x04000488 RID: 1160
	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F9")]
	public bool isRagdoll;

	// Token: 0x04000489 RID: 1161
	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public RigidbodyDragObject dragController;

	// Token: 0x0400048A RID: 1162
	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public RagdollPositionUpdater ragdollPositionUpdate;

	// Token: 0x0400048B RID: 1163
	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	public float koTime;

	// Token: 0x0400048C RID: 1164
	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	public float koTransitionTimer;

	// Token: 0x0400048D RID: 1165
	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private float getUpDelayTimer;

	// Token: 0x0400048E RID: 1166
	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	public float deadRagdollTimer;

	// Token: 0x0400048F RID: 1167
	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public bool restrained;

	// Token: 0x04000490 RID: 1168
	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x321")]
	public bool outOfBreath;

	// Token: 0x04000491 RID: 1169
	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
	public float restrainTime;

	// Token: 0x04000492 RID: 1170
	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	[NonSerialized]
	public Interactable currentWeapon;

	// Token: 0x04000493 RID: 1171
	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public MurderWeaponPreset currentWeaponPreset;

	// Token: 0x04000494 RID: 1172
	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public float weaponRangeMax;

	// Token: 0x04000495 RID: 1173
	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	public float weaponRefire;

	// Token: 0x04000496 RID: 1174
	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public float weaponAccuracy;

	// Token: 0x04000497 RID: 1175
	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	public float weaponDamage;

	// Token: 0x04000498 RID: 1176
	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public NewAIController.AITickRate desiredTickRate;

	// Token: 0x04000499 RID: 1177
	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
	public NewAIController.AITickRate previousTickRate;

	// Token: 0x0400049A RID: 1178
	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public NewAIController.AITickRate tickRate;

	// Token: 0x0400049B RID: 1179
	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
	public bool dueUpdate;

	// Token: 0x0400049C RID: 1180
	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public float delayedUntil;

	// Token: 0x0400049D RID: 1181
	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
	public float lastUpdated;

	// Token: 0x0400049E RID: 1182
	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	private float lastSnore;

	// Token: 0x0400049F RID: 1183
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
	public float timeSinceLastUpdate;

	// Token: 0x040004A0 RID: 1184
	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public float timeAtCurrentAddress;

	// Token: 0x040004A1 RID: 1185
	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
	private float drunkTripCheckTimer;

	// Token: 0x040004A2 RID: 1186
	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	private int doorCheckProcessTimer;

	// Token: 0x040004A3 RID: 1187
	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	public float lastGameLocationUpdate;

	// Token: 0x040004A4 RID: 1188
	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	private bool visibleMovementAnimationLerpRequired;

	// Token: 0x040004A5 RID: 1189
	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x379")]
	public bool disableTickRateUpdate;

	// Token: 0x040004A6 RID: 1190
	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public Dictionary<AIGoalPreset, float> delayedGoalsForTime;

	// Token: 0x040004A7 RID: 1191
	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	public Dictionary<AIActionPreset, float> delayedActionsForTime;

	// Token: 0x040004A8 RID: 1192
	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public List<NewAIController.QueuedAction> queuedActions;

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	private float lastMuggingTimestamp;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public GameObject spawnedRightItem;

	// Token: 0x040004AB RID: 1195
	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	public GameObject spawnedLeftItem;

	// Token: 0x040004AC RID: 1196
	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	[NonSerialized]
	public NewAIAction customItemSource;

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	public bool usingCarryAnimation;

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3BC")]
	public int combatMode;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	[NonSerialized]
	public InteractablePreset throwItem;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	public bool throwActive;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
	public float throwDelay;

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	public bool dontEverCloseDoors;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	public List<MurderController.Murder> victimsForMurders;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	public List<MurderController.Murder> killerForMurders;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	public bool isConvicted;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E9")]
	private bool usePointBusyRecursion;

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	[NonSerialized]
	public NewGameLocation closeDoorsNormallyAfterLeaving;

	// Token: 0x040004B8 RID: 1208
	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	public List<Interactable> putDownItems;

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	private float drunkIdleTimer;

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
	private float restrainedIdleTimer;

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public Dictionary<Human, float> appliedNerveEffect;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	private bool tickActive;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
	public float spooked;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	public int spookCounter;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
	public float spookForgetCounter;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	private float noPathTimer;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
	private int noPathCorrectionAttempts;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	public List<string> lastActions;

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	public List<string> debugDestinationPosition;

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	public string jobDebug;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	public bool debugMovement;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
	public AudioEvent debugLastHeardIllegalAudio;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
	protected List<AIActionPreset> rem;

	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[Serializable]
	public class TrackingTarget
	{
		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public TrackingTarget()
		{
		}

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor actor;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lastValidSighting;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool priorityTarget;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float attractionRank;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float distance;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceRank;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float fovRank;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float itemRank;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lookAtRank;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool active;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool spookedByItem;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int spookTimer;
	}

	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[Serializable]
	public class ChaseLogic
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000517")]
		[Address(RVA = "0xDD13C0", Offset = "0xDD03C0", VA = "0x180DD13C0")]
		public void UpdateLastSeen()
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000518")]
		[Address(RVA = "0xDD1950", Offset = "0xDD0950", VA = "0x180DD1950")]
		public void GenerateProjectedNode()
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ChaseLogic()
		{
		}

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewAIController ai;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 lastSeenPosition;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NewNode lastSeenNode;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 lastSeenDirection;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public NewNode projectedNode;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 projectedPosition;
	}

	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public enum InvestigationUrgency
	{
		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		walk,
		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		run
	}

	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public enum ReactionState
	{
		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		none,
		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		investigatingSight,
		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		investigatingSound,
		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		persuing,
		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		searching
	}

	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public enum AITickRate
	{
		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		veryLow,
		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		low,
		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		medium,
		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		high,
		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		veryHigh
	}

	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public class QueuedAction
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public QueuedAction()
		{
		}

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable interactable;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractablePreset.InteractionAction actionSetting;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;
	}

	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x600051D")]
		[Address(RVA = "0xDD2D80", Offset = "0xDD1D80", VA = "0x180DD2D80")]
		internal bool <AITick>b__178_2(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x600051E")]
		[Address(RVA = "0xDD2DA0", Offset = "0xDD1DA0", VA = "0x180DD2DA0")]
		internal int <AITick>b__178_0(NewAIGoal p2, NewAIGoal p1)
		{
			return 0;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x600051F")]
		[Address(RVA = "0xDD2D80", Offset = "0xDD1D80", VA = "0x180DD2D80")]
		internal bool <AITick>b__178_1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x6000520")]
		[Address(RVA = "0xDD2E30", Offset = "0xDD1E30", VA = "0x180DD2E30")]
		internal bool <MovementUpdate>b__190_0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x957F40", Offset = "0x956F40", VA = "0x180957F40")]
		internal bool <ReachNewPathNode>b__200_0(Actor item)
		{
			return default(bool);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x957F40", Offset = "0x956F40", VA = "0x180957F40")]
		internal bool <ReachNewPathNode>b__200_1(Actor item)
		{
			return default(bool);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x6000523")]
		[Address(RVA = "0xDD2F60", Offset = "0xDD1F60", VA = "0x180DD2F60")]
		internal int <UpdateTrackedTargets>b__212_0(NewAIController.TrackingTarget a1, NewAIController.TrackingTarget a2)
		{
			return 0;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x6000524")]
		[Address(RVA = "0xDD2FF0", Offset = "0xDD1FF0", VA = "0x180DD2FF0")]
		internal bool <OnNewTrackTarget>b__214_0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x6000525")]
		[Address(RVA = "0xDD3090", Offset = "0xDD2090", VA = "0x180DD3090")]
		internal bool <OnNewTrackTarget>b__214_1(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x6000526")]
		[Address(RVA = "0xDD3130", Offset = "0xDD2130", VA = "0x180DD3130")]
		internal bool <Investigate>b__242_0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x6000527")]
		[Address(RVA = "0xDC7670", Offset = "0xDC6670", VA = "0x180DC7670")]
		internal bool <AnswerPhone>b__263_0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x52E390", Offset = "0x52D390", VA = "0x18052E390")]
		internal bool <AnswerPhone>b__263_1(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewAIController.<>c <>9;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<MurderController.Murder> <>9__178_2;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<NewAIGoal> <>9__178_0;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<MurderController.Murder> <>9__178_1;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<NewAIController.TrackingTarget> <>9__190_0;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Actor> <>9__200_0;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<Actor> <>9__200_1;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Comparison<NewAIController.TrackingTarget> <>9__212_0;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<NewAIAction> <>9__214_0;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<NewAIAction> <>9__214_1;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<NewAIController.TrackingTarget> <>9__242_0;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<NewAIGoal> <>9__263_0;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<NewAIAction> <>9__263_1;
	}

	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	private sealed class <>c__DisplayClass209_0
	{
		// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass209_0()
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x600052A")]
		[Address(RVA = "0xDD3260", Offset = "0xDD2260", VA = "0x180DD3260")]
		internal bool <AddTrackedTarget>b__0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor newTracked;
	}

	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	private sealed class <>c__DisplayClass215_0
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass215_0()
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x600052C")]
		[Address(RVA = "0xDD3410", Offset = "0xDD2410", VA = "0x180DD3410")]
		internal bool <IsMuggingValid>b__0(Acquaintance item)
		{
			return default(bool);
		}

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human target;
	}

	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	private sealed class <>c__DisplayClass262_0
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass262_0()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x80D5B0", Offset = "0x80C5B0", VA = "0x18080D5B0")]
		internal bool <AnswerDoor>b__0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewDoor dc;
	}
}
