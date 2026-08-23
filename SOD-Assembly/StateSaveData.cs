using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004E4 RID: 1252
[Token(Token = "0x20004E4")]
[Serializable]
public class StateSaveData
{
	// Token: 0x06001B87 RID: 7047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x9BCF30", Offset = "0x9BBF30", VA = "0x1809BCF30")]
	public StateSaveData()
	{
	}

	// Token: 0x040022D9 RID: 8921
	[Token(Token = "0x40022D9")]
	[FieldOffset(Offset = "0x10")]
	public string build;

	// Token: 0x040022DA RID: 8922
	[Token(Token = "0x40022DA")]
	[FieldOffset(Offset = "0x18")]
	public string cityShare;

	// Token: 0x040022DB RID: 8923
	[Token(Token = "0x40022DB")]
	[FieldOffset(Offset = "0x20")]
	public List<string> instanceIDs;

	// Token: 0x040022DC RID: 8924
	[Token(Token = "0x40022DC")]
	[FieldOffset(Offset = "0x28")]
	public List<string> compositionData;

	// Token: 0x040022DD RID: 8925
	[Token(Token = "0x40022DD")]
	[FieldOffset(Offset = "0x30")]
	public int dynamicPrintsCount;

	// Token: 0x040022DE RID: 8926
	[Token(Token = "0x40022DE")]
	[FieldOffset(Offset = "0x34")]
	public int sceneCaptureCount;

	// Token: 0x040022DF RID: 8927
	[Token(Token = "0x40022DF")]
	[FieldOffset(Offset = "0x38")]
	public int sceneCapMax;

	// Token: 0x040022E0 RID: 8928
	[Token(Token = "0x40022E0")]
	[FieldOffset(Offset = "0x40")]
	public string saveTime;

	// Token: 0x040022E1 RID: 8929
	[Token(Token = "0x40022E1")]
	[FieldOffset(Offset = "0x48")]
	public float gameTime;

	// Token: 0x040022E2 RID: 8930
	[Token(Token = "0x40022E2")]
	[FieldOffset(Offset = "0x4C")]
	public float timeLimit;

	// Token: 0x040022E3 RID: 8931
	[Token(Token = "0x40022E3")]
	[FieldOffset(Offset = "0x50")]
	public int leapCycle;

	// Token: 0x040022E4 RID: 8932
	[Token(Token = "0x40022E4")]
	[FieldOffset(Offset = "0x54")]
	public int fingerprintLoop;

	// Token: 0x040022E5 RID: 8933
	[Token(Token = "0x40022E5")]
	[FieldOffset(Offset = "0x58")]
	public int assignCaptureID;

	// Token: 0x040022E6 RID: 8934
	[Token(Token = "0x40022E6")]
	[FieldOffset(Offset = "0x5C")]
	public int assignMessageThreadID;

	// Token: 0x040022E7 RID: 8935
	[Token(Token = "0x40022E7")]
	[FieldOffset(Offset = "0x60")]
	public int assignGroupID;

	// Token: 0x040022E8 RID: 8936
	[Token(Token = "0x40022E8")]
	[FieldOffset(Offset = "0x64")]
	public int assignStickNote;

	// Token: 0x040022E9 RID: 8937
	[Token(Token = "0x40022E9")]
	[FieldOffset(Offset = "0x68")]
	public int assignInteractableID;

	// Token: 0x040022EA RID: 8938
	[Token(Token = "0x40022EA")]
	[FieldOffset(Offset = "0x6C")]
	public int assignCaseID;

	// Token: 0x040022EB RID: 8939
	[Token(Token = "0x40022EB")]
	[FieldOffset(Offset = "0x70")]
	public int assignMurderID;

	// Token: 0x040022EC RID: 8940
	[Token(Token = "0x40022EC")]
	[FieldOffset(Offset = "0x74")]
	public int gameLength;

	// Token: 0x040022ED RID: 8941
	[Token(Token = "0x40022ED")]
	[FieldOffset(Offset = "0x78")]
	public float currentRain;

	// Token: 0x040022EE RID: 8942
	[Token(Token = "0x40022EE")]
	[FieldOffset(Offset = "0x7C")]
	public float desiredRain;

	// Token: 0x040022EF RID: 8943
	[Token(Token = "0x40022EF")]
	[FieldOffset(Offset = "0x80")]
	public float currentWind;

	// Token: 0x040022F0 RID: 8944
	[Token(Token = "0x40022F0")]
	[FieldOffset(Offset = "0x84")]
	public float desiredWind;

	// Token: 0x040022F1 RID: 8945
	[Token(Token = "0x40022F1")]
	[FieldOffset(Offset = "0x88")]
	public float currentSnow;

	// Token: 0x040022F2 RID: 8946
	[Token(Token = "0x40022F2")]
	[FieldOffset(Offset = "0x8C")]
	public float desiredSnow;

	// Token: 0x040022F3 RID: 8947
	[Token(Token = "0x40022F3")]
	[FieldOffset(Offset = "0x90")]
	public float currentLightning;

	// Token: 0x040022F4 RID: 8948
	[Token(Token = "0x40022F4")]
	[FieldOffset(Offset = "0x94")]
	public float desiredLightning;

	// Token: 0x040022F5 RID: 8949
	[Token(Token = "0x40022F5")]
	[FieldOffset(Offset = "0x98")]
	public float currentFog;

	// Token: 0x040022F6 RID: 8950
	[Token(Token = "0x40022F6")]
	[FieldOffset(Offset = "0x9C")]
	public float desiredFog;

	// Token: 0x040022F7 RID: 8951
	[Token(Token = "0x40022F7")]
	[FieldOffset(Offset = "0xA0")]
	public float cityWetness;

	// Token: 0x040022F8 RID: 8952
	[Token(Token = "0x40022F8")]
	[FieldOffset(Offset = "0xA4")]
	public float citySnow;

	// Token: 0x040022F9 RID: 8953
	[Token(Token = "0x40022F9")]
	[FieldOffset(Offset = "0xA8")]
	public float weatherChange;

	// Token: 0x040022FA RID: 8954
	[Token(Token = "0x40022FA")]
	[FieldOffset(Offset = "0xB0")]
	public List<SideJob> basicJobs;

	// Token: 0x040022FB RID: 8955
	[Token(Token = "0x40022FB")]
	[FieldOffset(Offset = "0xB8")]
	public List<SideJobAffair> affairJobs;

	// Token: 0x040022FC RID: 8956
	[Token(Token = "0x40022FC")]
	[FieldOffset(Offset = "0xC0")]
	public List<SideJobSabotage> sabotageJobs;

	// Token: 0x040022FD RID: 8957
	[Token(Token = "0x40022FD")]
	[FieldOffset(Offset = "0xC8")]
	public List<SideJobStolenItem> stolenItemJobs;

	// Token: 0x040022FE RID: 8958
	[Token(Token = "0x40022FE")]
	[FieldOffset(Offset = "0xD0")]
	public List<SideJobMissingPerson> missingPersonJobs;

	// Token: 0x040022FF RID: 8959
	[Token(Token = "0x40022FF")]
	[FieldOffset(Offset = "0xD8")]
	public List<SideJobRevenge> revengeJobs;

	// Token: 0x04002300 RID: 8960
	[Token(Token = "0x4002300")]
	[FieldOffset(Offset = "0xE0")]
	public List<SideJobStealBriefcase> briefcaseJobs;

	// Token: 0x04002301 RID: 8961
	[Token(Token = "0x4002301")]
	[FieldOffset(Offset = "0xE8")]
	public int jobDiffLevel;

	// Token: 0x04002302 RID: 8962
	[Token(Token = "0x4002302")]
	[FieldOffset(Offset = "0xEC")]
	public int chapter;

	// Token: 0x04002303 RID: 8963
	[Token(Token = "0x4002303")]
	[FieldOffset(Offset = "0xF0")]
	public int chapterPart;

	// Token: 0x04002304 RID: 8964
	[Token(Token = "0x4002304")]
	[FieldOffset(Offset = "0xF8")]
	public StateSaveData.ChaperStateSave chapterSaveState;

	// Token: 0x04002305 RID: 8965
	[Token(Token = "0x4002305")]
	[FieldOffset(Offset = "0x100")]
	public bool mapPathActive;

	// Token: 0x04002306 RID: 8966
	[Token(Token = "0x4002306")]
	[FieldOffset(Offset = "0x101")]
	public bool mapPathNodeSpecific;

	// Token: 0x04002307 RID: 8967
	[Token(Token = "0x4002307")]
	[FieldOffset(Offset = "0x104")]
	public Vector3Int mapPathNode;

	// Token: 0x04002308 RID: 8968
	[Token(Token = "0x4002308")]
	[FieldOffset(Offset = "0x110")]
	public List<Case> activeCases;

	// Token: 0x04002309 RID: 8969
	[Token(Token = "0x4002309")]
	[FieldOffset(Offset = "0x118")]
	public List<Case> archivedCases;

	// Token: 0x0400230A RID: 8970
	[Token(Token = "0x400230A")]
	[FieldOffset(Offset = "0x120")]
	public int activeCase;

	// Token: 0x0400230B RID: 8971
	[Token(Token = "0x400230B")]
	[FieldOffset(Offset = "0x128")]
	public List<GameplayController.Footprint> footprints;

	// Token: 0x0400230C RID: 8972
	[Token(Token = "0x400230C")]
	[FieldOffset(Offset = "0x130")]
	public List<GameplayController.History> history;

	// Token: 0x0400230D RID: 8973
	[Token(Token = "0x400230D")]
	[FieldOffset(Offset = "0x138")]
	public List<GameplayController.Passcode> passcodes;

	// Token: 0x0400230E RID: 8974
	[Token(Token = "0x400230E")]
	[FieldOffset(Offset = "0x140")]
	public List<GameplayController.PhoneNumber> numbers;

	// Token: 0x0400230F RID: 8975
	[Token(Token = "0x400230F")]
	[FieldOffset(Offset = "0x148")]
	public List<GameplayController.EnforcerCall> enforcerCalls;

	// Token: 0x04002310 RID: 8976
	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x150")]
	public List<StateSaveData.CrimeSceneCleanup> crimeSceneCleanup;

	// Token: 0x04002311 RID: 8977
	[Token(Token = "0x4002311")]
	[FieldOffset(Offset = "0x158")]
	public List<GameplayController.HotelGuest> hotelGuests;

	// Token: 0x04002312 RID: 8978
	[Token(Token = "0x4002312")]
	[FieldOffset(Offset = "0x160")]
	public List<StateSaveData.BrokenWindowSave> brokenWindows;

	// Token: 0x04002313 RID: 8979
	[Token(Token = "0x4002313")]
	[FieldOffset(Offset = "0x168")]
	public NewspaperController.NewspaperState newspaperState;

	// Token: 0x04002314 RID: 8980
	[Token(Token = "0x4002314")]
	[FieldOffset(Offset = "0x170")]
	public string playerFirstName;

	// Token: 0x04002315 RID: 8981
	[Token(Token = "0x4002315")]
	[FieldOffset(Offset = "0x178")]
	public string playerSurname;

	// Token: 0x04002316 RID: 8982
	[Token(Token = "0x4002316")]
	[FieldOffset(Offset = "0x180")]
	public Human.Gender playerGender;

	// Token: 0x04002317 RID: 8983
	[Token(Token = "0x4002317")]
	[FieldOffset(Offset = "0x184")]
	public Human.Gender partnerGender;

	// Token: 0x04002318 RID: 8984
	[Token(Token = "0x4002318")]
	[FieldOffset(Offset = "0x188")]
	public Color playerSkinColour;

	// Token: 0x04002319 RID: 8985
	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0x198")]
	public int playerBirthDay;

	// Token: 0x0400231A RID: 8986
	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0x19C")]
	public int playerBirthMonth;

	// Token: 0x0400231B RID: 8987
	[Token(Token = "0x400231B")]
	[FieldOffset(Offset = "0x1A0")]
	public int playerBirthYear;

	// Token: 0x0400231C RID: 8988
	[Token(Token = "0x400231C")]
	[FieldOffset(Offset = "0x1A4")]
	public int residence;

	// Token: 0x0400231D RID: 8989
	[Token(Token = "0x400231D")]
	[FieldOffset(Offset = "0x1A8")]
	public List<int> apartmentsOwned;

	// Token: 0x0400231E RID: 8990
	[Token(Token = "0x400231E")]
	[FieldOffset(Offset = "0x1B0")]
	public bool accidentCover;

	// Token: 0x0400231F RID: 8991
	[Token(Token = "0x400231F")]
	[FieldOffset(Offset = "0x1B8")]
	public List<int> foodH;

	// Token: 0x04002320 RID: 8992
	[Token(Token = "0x4002320")]
	[FieldOffset(Offset = "0x1C0")]
	public List<int> sanitary;

	// Token: 0x04002321 RID: 8993
	[Token(Token = "0x4002321")]
	[FieldOffset(Offset = "0x1C8")]
	public List<int> ops;

	// Token: 0x04002322 RID: 8994
	[Token(Token = "0x4002322")]
	[FieldOffset(Offset = "0x1D0")]
	public List<int> knowsPasswords;

	// Token: 0x04002323 RID: 8995
	[Token(Token = "0x4002323")]
	[FieldOffset(Offset = "0x1D8")]
	public List<GameplayController.LoanDebt> debt;

	// Token: 0x04002324 RID: 8996
	[Token(Token = "0x4002324")]
	[FieldOffset(Offset = "0x1E0")]
	public int carried;

	// Token: 0x04002325 RID: 8997
	[Token(Token = "0x4002325")]
	[FieldOffset(Offset = "0x1E4")]
	public bool tutorial;

	// Token: 0x04002326 RID: 8998
	[Token(Token = "0x4002326")]
	[FieldOffset(Offset = "0x1E8")]
	public List<string> tutTextTriggered;

	// Token: 0x04002327 RID: 8999
	[Token(Token = "0x4002327")]
	[FieldOffset(Offset = "0x1F0")]
	public List<FirstPersonItemController.InventorySlot> firstPersonItems;

	// Token: 0x04002328 RID: 9000
	[Token(Token = "0x4002328")]
	[FieldOffset(Offset = "0x1F8")]
	public List<StateSaveData.ScannedObjPrint> scannedPrints;

	// Token: 0x04002329 RID: 9001
	[Token(Token = "0x4002329")]
	[FieldOffset(Offset = "0x200")]
	public Vector3 playerPos;

	// Token: 0x0400232A RID: 9002
	[Token(Token = "0x400232A")]
	[FieldOffset(Offset = "0x20C")]
	public Quaternion playerRot;

	// Token: 0x0400232B RID: 9003
	[Token(Token = "0x400232B")]
	[FieldOffset(Offset = "0x21C")]
	public int money;

	// Token: 0x0400232C RID: 9004
	[Token(Token = "0x400232C")]
	[FieldOffset(Offset = "0x220")]
	public int lockpicks;

	// Token: 0x0400232D RID: 9005
	[Token(Token = "0x400232D")]
	[FieldOffset(Offset = "0x224")]
	public int socCredit;

	// Token: 0x0400232E RID: 9006
	[Token(Token = "0x400232E")]
	[FieldOffset(Offset = "0x228")]
	public List<string> socCreditPerks;

	// Token: 0x0400232F RID: 9007
	[Token(Token = "0x400232F")]
	[FieldOffset(Offset = "0x230")]
	public float health;

	// Token: 0x04002330 RID: 9008
	[Token(Token = "0x4002330")]
	[FieldOffset(Offset = "0x234")]
	public float nourishment;

	// Token: 0x04002331 RID: 9009
	[Token(Token = "0x4002331")]
	[FieldOffset(Offset = "0x238")]
	public float hydration;

	// Token: 0x04002332 RID: 9010
	[Token(Token = "0x4002332")]
	[FieldOffset(Offset = "0x23C")]
	public float alertness;

	// Token: 0x04002333 RID: 9011
	[Token(Token = "0x4002333")]
	[FieldOffset(Offset = "0x240")]
	public float energy;

	// Token: 0x04002334 RID: 9012
	[Token(Token = "0x4002334")]
	[FieldOffset(Offset = "0x244")]
	public float hygiene;

	// Token: 0x04002335 RID: 9013
	[Token(Token = "0x4002335")]
	[FieldOffset(Offset = "0x248")]
	public float heat;

	// Token: 0x04002336 RID: 9014
	[Token(Token = "0x4002336")]
	[FieldOffset(Offset = "0x24C")]
	public float drunk;

	// Token: 0x04002337 RID: 9015
	[Token(Token = "0x4002337")]
	[FieldOffset(Offset = "0x250")]
	public float sick;

	// Token: 0x04002338 RID: 9016
	[Token(Token = "0x4002338")]
	[FieldOffset(Offset = "0x254")]
	public float headache;

	// Token: 0x04002339 RID: 9017
	[Token(Token = "0x4002339")]
	[FieldOffset(Offset = "0x258")]
	public float wet;

	// Token: 0x0400233A RID: 9018
	[Token(Token = "0x400233A")]
	[FieldOffset(Offset = "0x25C")]
	public float brokenLeg;

	// Token: 0x0400233B RID: 9019
	[Token(Token = "0x400233B")]
	[FieldOffset(Offset = "0x260")]
	public float bruised;

	// Token: 0x0400233C RID: 9020
	[Token(Token = "0x400233C")]
	[FieldOffset(Offset = "0x264")]
	public float blackEye;

	// Token: 0x0400233D RID: 9021
	[Token(Token = "0x400233D")]
	[FieldOffset(Offset = "0x268")]
	public float blackedOut;

	// Token: 0x0400233E RID: 9022
	[Token(Token = "0x400233E")]
	[FieldOffset(Offset = "0x26C")]
	public float numb;

	// Token: 0x0400233F RID: 9023
	[Token(Token = "0x400233F")]
	[FieldOffset(Offset = "0x270")]
	public float poisoned;

	// Token: 0x04002340 RID: 9024
	[Token(Token = "0x4002340")]
	[FieldOffset(Offset = "0x274")]
	public float bleeding;

	// Token: 0x04002341 RID: 9025
	[Token(Token = "0x4002341")]
	[FieldOffset(Offset = "0x278")]
	public float wellRested;

	// Token: 0x04002342 RID: 9026
	[Token(Token = "0x4002342")]
	[FieldOffset(Offset = "0x27C")]
	public float starchAddiction;

	// Token: 0x04002343 RID: 9027
	[Token(Token = "0x4002343")]
	[FieldOffset(Offset = "0x280")]
	public float syncDiskInstall;

	// Token: 0x04002344 RID: 9028
	[Token(Token = "0x4002344")]
	[FieldOffset(Offset = "0x284")]
	public float blinded;

	// Token: 0x04002345 RID: 9029
	[Token(Token = "0x4002345")]
	[FieldOffset(Offset = "0x288")]
	public bool crouched;

	// Token: 0x04002346 RID: 9030
	[Token(Token = "0x4002346")]
	[FieldOffset(Offset = "0x290")]
	public List<UpgradesController.Upgrades> upgrades;

	// Token: 0x04002347 RID: 9031
	[Token(Token = "0x4002347")]
	[FieldOffset(Offset = "0x298")]
	public List<string> sabotaged;

	// Token: 0x04002348 RID: 9032
	[Token(Token = "0x4002348")]
	[FieldOffset(Offset = "0x2A0")]
	public List<string> booksRead;

	// Token: 0x04002349 RID: 9033
	[Token(Token = "0x4002349")]
	[FieldOffset(Offset = "0x2A8")]
	public List<SceneRecorder.SceneCapture> playerSavedCaptures;

	// Token: 0x0400234A RID: 9034
	[Token(Token = "0x400234A")]
	[FieldOffset(Offset = "0x2B0")]
	public List<SpeechController.QueueElement> speech;

	// Token: 0x0400234B RID: 9035
	[Token(Token = "0x400234B")]
	[FieldOffset(Offset = "0x2B8")]
	public List<int> keyring;

	// Token: 0x0400234C RID: 9036
	[Token(Token = "0x400234C")]
	[FieldOffset(Offset = "0x2C0")]
	public List<int> keyringInt;

	// Token: 0x0400234D RID: 9037
	[Token(Token = "0x400234D")]
	[FieldOffset(Offset = "0x2C8")]
	public List<StateSaveData.FakeTelephone> fakeTelephone;

	// Token: 0x0400234E RID: 9038
	[Token(Token = "0x400234E")]
	[FieldOffset(Offset = "0x2D0")]
	public int hideInteractable;

	// Token: 0x0400234F RID: 9039
	[Token(Token = "0x400234F")]
	[FieldOffset(Offset = "0x2D4")]
	public int hideRef;

	// Token: 0x04002350 RID: 9040
	[Token(Token = "0x4002350")]
	[FieldOffset(Offset = "0x2D8")]
	public int phoneInteractable;

	// Token: 0x04002351 RID: 9041
	[Token(Token = "0x4002351")]
	[FieldOffset(Offset = "0x2DC")]
	public int computerInteractable;

	// Token: 0x04002352 RID: 9042
	[Token(Token = "0x4002352")]
	[FieldOffset(Offset = "0x2E0")]
	public int duct;

	// Token: 0x04002353 RID: 9043
	[Token(Token = "0x4002353")]
	[FieldOffset(Offset = "0x2E4")]
	public Vector3 storedTransPos;

	// Token: 0x04002354 RID: 9044
	[Token(Token = "0x4002354")]
	[FieldOffset(Offset = "0x2F0")]
	public List<StateSaveData.BuildingStateSav> buildings;

	// Token: 0x04002355 RID: 9045
	[Token(Token = "0x4002355")]
	[FieldOffset(Offset = "0x2F8")]
	public List<StateSaveData.CompanyStateSave> companies;

	// Token: 0x04002356 RID: 9046
	[Token(Token = "0x4002356")]
	[FieldOffset(Offset = "0x300")]
	public List<StateSaveData.MessageThreadSave> messageThreads;

	// Token: 0x04002357 RID: 9047
	[Token(Token = "0x4002357")]
	[FieldOffset(Offset = "0x308")]
	public bool pgLoop;

	// Token: 0x04002358 RID: 9048
	[Token(Token = "0x4002358")]
	[FieldOffset(Offset = "0x30C")]
	public int currentMurderer;

	// Token: 0x04002359 RID: 9049
	[Token(Token = "0x4002359")]
	[FieldOffset(Offset = "0x310")]
	public int currentVictim;

	// Token: 0x0400235A RID: 9050
	[Token(Token = "0x400235A")]
	[FieldOffset(Offset = "0x314")]
	public int currentActiveCase;

	// Token: 0x0400235B RID: 9051
	[Token(Token = "0x400235B")]
	[FieldOffset(Offset = "0x318")]
	public string murderPreset;

	// Token: 0x0400235C RID: 9052
	[Token(Token = "0x400235C")]
	[FieldOffset(Offset = "0x320")]
	public string chosenMO;

	// Token: 0x0400235D RID: 9053
	[Token(Token = "0x400235D")]
	[FieldOffset(Offset = "0x328")]
	public List<int> previousMurderers;

	// Token: 0x0400235E RID: 9054
	[Token(Token = "0x400235E")]
	[FieldOffset(Offset = "0x330")]
	public float pauseBetweenMurders;

	// Token: 0x0400235F RID: 9055
	[Token(Token = "0x400235F")]
	[FieldOffset(Offset = "0x334")]
	public float pauseForKidnapperKill;

	// Token: 0x04002360 RID: 9056
	[Token(Token = "0x4002360")]
	[FieldOffset(Offset = "0x338")]
	public bool murderRoutineActive;

	// Token: 0x04002361 RID: 9057
	[Token(Token = "0x4002361")]
	[FieldOffset(Offset = "0x33C")]
	public int maxMurderDiffLevel;

	// Token: 0x04002362 RID: 9058
	[Token(Token = "0x4002362")]
	[FieldOffset(Offset = "0x340")]
	public int currentVictimSite;

	// Token: 0x04002363 RID: 9059
	[Token(Token = "0x4002363")]
	[FieldOffset(Offset = "0x344")]
	public bool victimSiteIsStreet;

	// Token: 0x04002364 RID: 9060
	[Token(Token = "0x4002364")]
	[FieldOffset(Offset = "0x345")]
	public bool triggerCoverUpCall;

	// Token: 0x04002365 RID: 9061
	[Token(Token = "0x4002365")]
	[FieldOffset(Offset = "0x346")]
	public bool playerAcceptedCoverUp;

	// Token: 0x04002366 RID: 9062
	[Token(Token = "0x4002366")]
	[FieldOffset(Offset = "0x347")]
	public bool triggerCoverUpSuccess;

	// Token: 0x04002367 RID: 9063
	[Token(Token = "0x4002367")]
	[FieldOffset(Offset = "0x348")]
	public List<MurderController.Murder> murders;

	// Token: 0x04002368 RID: 9064
	[Token(Token = "0x4002368")]
	[FieldOffset(Offset = "0x350")]
	public List<MurderController.Murder> iaMurders;

	// Token: 0x04002369 RID: 9065
	[Token(Token = "0x4002369")]
	[FieldOffset(Offset = "0x358")]
	public List<StateSaveData.EvidenceStateSave> evidence;

	// Token: 0x0400236A RID: 9066
	[Token(Token = "0x400236A")]
	[FieldOffset(Offset = "0x360")]
	public List<string> timeEvidence;

	// Token: 0x0400236B RID: 9067
	[Token(Token = "0x400236B")]
	[FieldOffset(Offset = "0x368")]
	public List<string> dateEvidence;

	// Token: 0x0400236C RID: 9068
	[Token(Token = "0x400236C")]
	[FieldOffset(Offset = "0x370")]
	public List<string> customStrings;

	// Token: 0x0400236D RID: 9069
	[Token(Token = "0x400236D")]
	[FieldOffset(Offset = "0x378")]
	public List<SpatterSimulation> spatter;

	// Token: 0x0400236E RID: 9070
	[Token(Token = "0x400236E")]
	[FieldOffset(Offset = "0x380")]
	public List<CitySaveData.FurnitureClusterObjectCitySave> furnitureStorage;

	// Token: 0x0400236F RID: 9071
	[Token(Token = "0x400236F")]
	[FieldOffset(Offset = "0x388")]
	public List<StateSaveData.AirDuctExplorationSave> airDuctExploration;

	// Token: 0x04002370 RID: 9072
	[Token(Token = "0x4002370")]
	[FieldOffset(Offset = "0x390")]
	public bool freeHealthCareFlag;

	// Token: 0x04002371 RID: 9073
	[Token(Token = "0x4002371")]
	[FieldOffset(Offset = "0x394")]
	public int notTheAnswerFlag;

	// Token: 0x04002372 RID: 9074
	[Token(Token = "0x4002372")]
	[FieldOffset(Offset = "0x398")]
	public int privateSlyFlag;

	// Token: 0x04002373 RID: 9075
	[Token(Token = "0x4002373")]
	[FieldOffset(Offset = "0x3A0")]
	public List<string> allConnectedReference;

	// Token: 0x04002374 RID: 9076
	[Token(Token = "0x4002374")]
	[FieldOffset(Offset = "0x3A8")]
	public bool pacifistFlag;

	// Token: 0x04002375 RID: 9077
	[Token(Token = "0x4002375")]
	[FieldOffset(Offset = "0x3A9")]
	public bool notAScratchFlag;

	// Token: 0x04002376 RID: 9078
	[Token(Token = "0x4002376")]
	[FieldOffset(Offset = "0x3B0")]
	public List<int> spareNoOneReference;

	// Token: 0x04002377 RID: 9079
	[Token(Token = "0x4002377")]
	[FieldOffset(Offset = "0x3B8")]
	public SnailController.SnailSaveData snail;

	// Token: 0x04002378 RID: 9080
	[Token(Token = "0x4002378")]
	[FieldOffset(Offset = "0x3C0")]
	public List<StateSaveData.FloorStateSave> floors;

	// Token: 0x04002379 RID: 9081
	[Token(Token = "0x4002379")]
	[FieldOffset(Offset = "0x3C8")]
	public List<StateSaveData.AddressStateSave> addresses;

	// Token: 0x0400237A RID: 9082
	[Token(Token = "0x400237A")]
	[FieldOffset(Offset = "0x3D0")]
	public List<StateSaveData.GuestPassStateSave> guestPasses;

	// Token: 0x0400237B RID: 9083
	[Token(Token = "0x400237B")]
	[FieldOffset(Offset = "0x3D8")]
	public List<StateSaveData.RoomStateSave> rooms;

	// Token: 0x0400237C RID: 9084
	[Token(Token = "0x400237C")]
	[FieldOffset(Offset = "0x3E0")]
	public List<MetaObject> metas;

	// Token: 0x0400237D RID: 9085
	[Token(Token = "0x400237D")]
	[FieldOffset(Offset = "0x3E8")]
	public List<Interactable> interactables;

	// Token: 0x0400237E RID: 9086
	[Token(Token = "0x400237E")]
	[FieldOffset(Offset = "0x3F0")]
	public List<int> removedCityData;

	// Token: 0x0400237F RID: 9087
	[Token(Token = "0x400237F")]
	[FieldOffset(Offset = "0x3F8")]
	public List<StateSaveData.CitizenStateSave> citizens;

	// Token: 0x04002380 RID: 9088
	[Token(Token = "0x4002380")]
	[FieldOffset(Offset = "0x400")]
	public List<StateSaveData.DoorStateSave> doors;

	// Token: 0x020004E5 RID: 1253
	[Token(Token = "0x20004E5")]
	[Serializable]
	public class CrimeSceneCleanup
	{
		// Token: 0x06001B88 RID: 7048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CrimeSceneCleanup()
		{
		}

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x10")]
		public bool isStreet;

		// Token: 0x04002382 RID: 9090
		[Token(Token = "0x4002382")]
		[FieldOffset(Offset = "0x14")]
		public int id;
	}

	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	[Serializable]
	public class BrokenWindowSave
	{
		// Token: 0x06001B89 RID: 7049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public BrokenWindowSave()
		{
		}

		// Token: 0x04002383 RID: 9091
		[Token(Token = "0x4002383")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 pos;

		// Token: 0x04002384 RID: 9092
		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x1C")]
		public float brokenAt;
	}

	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	[Serializable]
	public class ScannedObjPrint
	{
		// Token: 0x06001B8A RID: 7050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ScannedObjPrint()
		{
		}

		// Token: 0x04002385 RID: 9093
		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x10")]
		public int objID;

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x18")]
		public List<int> prints;
	}

	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	[Serializable]
	public class ChaperStateSave
	{
		// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x9BF020", Offset = "0x9BE020", VA = "0x1809BF020")]
		public void AddData(string reference, int integer)
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x9BF170", Offset = "0x9BE170", VA = "0x1809BF170")]
		public void AddData(string reference, float floatP)
		{
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x9BF320", Offset = "0x9BE320", VA = "0x1809BF320")]
		public void AddData(string reference, string str)
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x9BF460", Offset = "0x9BE460", VA = "0x1809BF460")]
		public void AddData(string reference, bool b)
		{
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x9BF470", Offset = "0x9BE470", VA = "0x1809BF470")]
		public bool GetDataBool(string reference)
		{
			return default(bool);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x9BF490", Offset = "0x9BE490", VA = "0x1809BF490")]
		public int GetDataInt(string reference)
		{
			return 0;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x9BF6A0", Offset = "0x9BE6A0", VA = "0x1809BF6A0")]
		public float GetDataFloat(string reference)
		{
			return 0f;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x9BF870", Offset = "0x9BE870", VA = "0x1809BF870")]
		public string GetDataString(string reference)
		{
			return null;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x9BF9D0", Offset = "0x9BE9D0", VA = "0x1809BF9D0")]
		public ChaperStateSave()
		{
		}

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x10")]
		public List<StateSaveData.ChapterSaveData> data;

		// Token: 0x020004E9 RID: 1257
		[Token(Token = "0x20004E9")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06001B94 RID: 7060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B94")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x0000CB40 File Offset: 0x0000AD40
			[Token(Token = "0x6001B95")]
			[Address(RVA = "0x51E980", Offset = "0x51D980", VA = "0x18051E980")]
			internal bool <GetDataInt>b__0(StateSaveData.ChapterSaveData item)
			{
				return default(bool);
			}

			// Token: 0x04002388 RID: 9096
			[Token(Token = "0x4002388")]
			[FieldOffset(Offset = "0x10")]
			public string reference;
		}

		// Token: 0x020004EA RID: 1258
		[Token(Token = "0x20004EA")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06001B96 RID: 7062 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B96")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x0000CB58 File Offset: 0x0000AD58
			[Token(Token = "0x6001B97")]
			[Address(RVA = "0x51E980", Offset = "0x51D980", VA = "0x18051E980")]
			internal bool <GetDataFloat>b__0(StateSaveData.ChapterSaveData item)
			{
				return default(bool);
			}

			// Token: 0x04002389 RID: 9097
			[Token(Token = "0x4002389")]
			[FieldOffset(Offset = "0x10")]
			public string reference;
		}

		// Token: 0x020004EB RID: 1259
		[Token(Token = "0x20004EB")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06001B98 RID: 7064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B98")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06001B99 RID: 7065 RVA: 0x0000CB70 File Offset: 0x0000AD70
			[Token(Token = "0x6001B99")]
			[Address(RVA = "0x51E980", Offset = "0x51D980", VA = "0x18051E980")]
			internal bool <GetDataString>b__0(StateSaveData.ChapterSaveData item)
			{
				return default(bool);
			}

			// Token: 0x0400238A RID: 9098
			[Token(Token = "0x400238A")]
			[FieldOffset(Offset = "0x10")]
			public string reference;
		}
	}

	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20004EC")]
	[Serializable]
	public class ChapterSaveData
	{
		// Token: 0x06001B9A RID: 7066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ChapterSaveData()
		{
		}

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x10")]
		public string reference;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x18")]
		public string data;
	}

	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	[Serializable]
	public class EvidenceStateSave
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x9BFAA0", Offset = "0x9BEAA0", VA = "0x1809BFAA0")]
		public EvidenceStateSave()
		{
		}

		// Token: 0x0400238D RID: 9101
		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0x18")]
		public string dds;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x20")]
		public bool found;

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0x28")]
		public List<StateSaveData.EvidenceDataKeyTie> keyTies;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0x30")]
		public List<Evidence.Discovery> discovery;

		// Token: 0x04002392 RID: 9106
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0x38")]
		public bool fs;

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x40")]
		public string n;

		// Token: 0x04002394 RID: 9108
		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0x48")]
		public List<Evidence.CustomName> customName;

		// Token: 0x04002395 RID: 9109
		[Token(Token = "0x4002395")]
		[FieldOffset(Offset = "0x50")]
		public List<EvidenceMultiPage.MultiPageContent> mpContent;
	}

	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	[Serializable]
	public class EvidenceDataKeyTie
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x9BFD40", Offset = "0x9BED40", VA = "0x1809BFD40")]
		public EvidenceDataKeyTie()
		{
		}

		// Token: 0x04002396 RID: 9110
		[Token(Token = "0x4002396")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey key;

		// Token: 0x04002397 RID: 9111
		[Token(Token = "0x4002397")]
		[FieldOffset(Offset = "0x18")]
		public List<Evidence.DataKey> tied;
	}

	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	[Serializable]
	public class FakeTelephone
	{
		// Token: 0x06001B9D RID: 7069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public FakeTelephone()
		{
		}

		// Token: 0x04002398 RID: 9112
		[Token(Token = "0x4002398")]
		[FieldOffset(Offset = "0x10")]
		public int number;

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x18")]
		public TelephoneController.CallSource source;
	}

	// Token: 0x020004F0 RID: 1264
	[Token(Token = "0x20004F0")]
	[Serializable]
	public class BuildingStateSav
	{
		// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x9BFE10", Offset = "0x9BEE10", VA = "0x1809BFE10")]
		public BuildingStateSav()
		{
		}

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x14")]
		public bool alarmActive;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x18")]
		public float alarmTimer;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x1C")]
		public NewBuilding.AlarmTargetMode targetMode;

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x20")]
		public float targetModeSetAt;

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x28")]
		public List<int> targets;

		// Token: 0x040023A0 RID: 9120
		[Token(Token = "0x40023A0")]
		[FieldOffset(Offset = "0x30")]
		public float wanted;

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x38")]
		public List<StateSaveData.ElevatorStateSave> elevators;

		// Token: 0x040023A2 RID: 9122
		[Token(Token = "0x40023A2")]
		[FieldOffset(Offset = "0x40")]
		public List<TelephoneController.PhoneCall> callLog;

		// Token: 0x040023A3 RID: 9123
		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x48")]
		public List<GameplayController.LostAndFound> lostAndFound;
	}

	// Token: 0x020004F1 RID: 1265
	[Token(Token = "0x20004F1")]
	[Serializable]
	public class ElevatorStateSave
	{
		// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ElevatorStateSave()
		{
		}

		// Token: 0x040023A4 RID: 9124
		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0x10")]
		public int tileID;

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x14")]
		public float yPos;

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x18")]
		public int floor;
	}

	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	[Serializable]
	public class FloorStateSave
	{
		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public FloorStateSave()
		{
		}

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040023A8 RID: 9128
		[Token(Token = "0x40023A8")]
		[FieldOffset(Offset = "0x14")]
		public bool alarmLockdown;
	}

	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	[Serializable]
	public class AddressStateSave
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x9C0010", Offset = "0x9BF010", VA = "0x1809C0010")]
		public AddressStateSave()
		{
		}

		// Token: 0x040023A9 RID: 9129
		[Token(Token = "0x40023A9")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040023AA RID: 9130
		[Token(Token = "0x40023AA")]
		[FieldOffset(Offset = "0x14")]
		public int sale;

		// Token: 0x040023AB RID: 9131
		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x18")]
		public List<NewAddress.Vandalism> vandalism;

		// Token: 0x040023AC RID: 9132
		[Token(Token = "0x40023AC")]
		[FieldOffset(Offset = "0x20")]
		public bool alarmActive;

		// Token: 0x040023AD RID: 9133
		[Token(Token = "0x40023AD")]
		[FieldOffset(Offset = "0x24")]
		public float alarmTimer;

		// Token: 0x040023AE RID: 9134
		[Token(Token = "0x40023AE")]
		[FieldOffset(Offset = "0x28")]
		public NewBuilding.AlarmTargetMode targetMode;

		// Token: 0x040023AF RID: 9135
		[Token(Token = "0x40023AF")]
		[FieldOffset(Offset = "0x2C")]
		public float targetModeSetAt;

		// Token: 0x040023B0 RID: 9136
		[Token(Token = "0x40023B0")]
		[FieldOffset(Offset = "0x30")]
		public List<int> targets;

		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		[FieldOffset(Offset = "0x38")]
		public List<NewGameLocation.TrespassEscalation> escalation;

		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		[FieldOffset(Offset = "0x40")]
		public float loiter;
	}

	// Token: 0x020004F4 RID: 1268
	[Token(Token = "0x20004F4")]
	[Serializable]
	public class CompanyStateSave
	{
		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x9C0210", Offset = "0x9BF210", VA = "0x1809C0210")]
		public CompanyStateSave()
		{
		}

		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		[FieldOffset(Offset = "0x18")]
		public List<Company.SalesRecord> sales;
	}

	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	[Serializable]
	public class GuestPassStateSave
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public GuestPassStateSave()
		{
		}

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040023B6 RID: 9142
		[Token(Token = "0x40023B6")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 guestPassUntil;
	}

	// Token: 0x020004F6 RID: 1270
	[Token(Token = "0x20004F6")]
	[Serializable]
	public class RoomStateSave
	{
		// Token: 0x06001BA4 RID: 7076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x9C02E0", Offset = "0x9BF2E0", VA = "0x1809C02E0")]
		public RoomStateSave()
		{
		}

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[FieldOffset(Offset = "0x14")]
		public int ex;

		// Token: 0x040023B9 RID: 9145
		[Token(Token = "0x40023B9")]
		[FieldOffset(Offset = "0x18")]
		public bool ml;

		// Token: 0x040023BA RID: 9146
		[Token(Token = "0x40023BA")]
		[FieldOffset(Offset = "0x1C")]
		public float gl;

		// Token: 0x040023BB RID: 9147
		[Token(Token = "0x40023BB")]
		[FieldOffset(Offset = "0x20")]
		public int fID;

		// Token: 0x040023BC RID: 9148
		[Token(Token = "0x40023BC")]
		[FieldOffset(Offset = "0x24")]
		public int iID;

		// Token: 0x040023BD RID: 9149
		[Token(Token = "0x40023BD")]
		[FieldOffset(Offset = "0x28")]
		public List<CitySaveData.RoomCitySave> decorOverride;

		// Token: 0x040023BE RID: 9150
		[Token(Token = "0x40023BE")]
		[FieldOffset(Offset = "0x30")]
		public List<StateSaveData.ChangedLightswitch> ls;
	}

	// Token: 0x020004F7 RID: 1271
	[Token(Token = "0x20004F7")]
	[Serializable]
	public class CitizenStateSave
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x9C0300", Offset = "0x9BF300", VA = "0x1809C0300")]
		public CitizenStateSave()
		{
		}

		// Token: 0x040023BF RID: 9151
		[Token(Token = "0x40023BF")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040023C0 RID: 9152
		[Token(Token = "0x40023C0")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 pos;

		// Token: 0x040023C1 RID: 9153
		[Token(Token = "0x40023C1")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion rot;

		// Token: 0x040023C2 RID: 9154
		[Token(Token = "0x40023C2")]
		[FieldOffset(Offset = "0x30")]
		public int trespassingEscalation;

		// Token: 0x040023C3 RID: 9155
		[Token(Token = "0x40023C3")]
		[FieldOffset(Offset = "0x34")]
		public ClothesPreset.OutfitCategory currentOutfit;

		// Token: 0x040023C4 RID: 9156
		[Token(Token = "0x40023C4")]
		[FieldOffset(Offset = "0x38")]
		public float nourishment;

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0x3C")]
		public float hydration;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0x40")]
		public float alertness;

		// Token: 0x040023C7 RID: 9159
		[Token(Token = "0x40023C7")]
		[FieldOffset(Offset = "0x44")]
		public float energy;

		// Token: 0x040023C8 RID: 9160
		[Token(Token = "0x40023C8")]
		[FieldOffset(Offset = "0x48")]
		public float excitement;

		// Token: 0x040023C9 RID: 9161
		[Token(Token = "0x40023C9")]
		[FieldOffset(Offset = "0x4C")]
		public float chores;

		// Token: 0x040023CA RID: 9162
		[Token(Token = "0x40023CA")]
		[FieldOffset(Offset = "0x50")]
		public float hygiene;

		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		[FieldOffset(Offset = "0x54")]
		public float bladder;

		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		[FieldOffset(Offset = "0x58")]
		public float heat;

		// Token: 0x040023CD RID: 9165
		[Token(Token = "0x40023CD")]
		[FieldOffset(Offset = "0x5C")]
		public float drunk;

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x60")]
		public float breath;

		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		[FieldOffset(Offset = "0x64")]
		public float poisoned;

		// Token: 0x040023D0 RID: 9168
		[Token(Token = "0x40023D0")]
		[FieldOffset(Offset = "0x68")]
		public float blinded;

		// Token: 0x040023D1 RID: 9169
		[Token(Token = "0x40023D1")]
		[FieldOffset(Offset = "0x6C")]
		public int poisoner;

		// Token: 0x040023D2 RID: 9170
		[Token(Token = "0x40023D2")]
		[FieldOffset(Offset = "0x70")]
		public int den;

		// Token: 0x040023D3 RID: 9171
		[Token(Token = "0x40023D3")]
		[FieldOffset(Offset = "0x74")]
		public int kidnapper;

		// Token: 0x040023D4 RID: 9172
		[Token(Token = "0x40023D4")]
		[FieldOffset(Offset = "0x78")]
		public bool remFromWorld;

		// Token: 0x040023D5 RID: 9173
		[Token(Token = "0x40023D5")]
		[FieldOffset(Offset = "0x7C")]
		public float currentHealth;

		// Token: 0x040023D6 RID: 9174
		[Token(Token = "0x40023D6")]
		[FieldOffset(Offset = "0x80")]
		public float currentNerve;

		// Token: 0x040023D7 RID: 9175
		[Token(Token = "0x40023D7")]
		[FieldOffset(Offset = "0x84")]
		public float fsDirt;

		// Token: 0x040023D8 RID: 9176
		[Token(Token = "0x40023D8")]
		[FieldOffset(Offset = "0x88")]
		public float fsBlood;

		// Token: 0x040023D9 RID: 9177
		[Token(Token = "0x40023D9")]
		[FieldOffset(Offset = "0x90")]
		public List<Human.Wound> wounds;

		// Token: 0x040023DA RID: 9178
		[Token(Token = "0x40023DA")]
		[FieldOffset(Offset = "0x98")]
		public Vector3Int investigateLocation;

		// Token: 0x040023DB RID: 9179
		[Token(Token = "0x40023DB")]
		[FieldOffset(Offset = "0xA4")]
		public Vector3 investigatePosition;

		// Token: 0x040023DC RID: 9180
		[Token(Token = "0x40023DC")]
		[FieldOffset(Offset = "0xB0")]
		public Vector3 investigatePositionProjection;

		// Token: 0x040023DD RID: 9181
		[Token(Token = "0x40023DD")]
		[FieldOffset(Offset = "0xBC")]
		public float lastInvestigate;

		// Token: 0x040023DE RID: 9182
		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0xC0")]
		public bool persuit;

		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0xC1")]
		public bool seesPlayerOnPersuit;

		// Token: 0x040023E0 RID: 9184
		[Token(Token = "0x40023E0")]
		[FieldOffset(Offset = "0xC4")]
		public float persuitChaseLogicUses;

		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0xC8")]
		public int persuitTarget;

		// Token: 0x040023E2 RID: 9186
		[Token(Token = "0x40023E2")]
		[FieldOffset(Offset = "0xCC")]
		public bool persuitPlayer;

		// Token: 0x040023E3 RID: 9187
		[Token(Token = "0x40023E3")]
		[FieldOffset(Offset = "0xD0")]
		public int escalationLevel;

		// Token: 0x040023E4 RID: 9188
		[Token(Token = "0x40023E4")]
		[FieldOffset(Offset = "0xD4")]
		public float minimumInvestigationTimeMultiplier;

		// Token: 0x040023E5 RID: 9189
		[Token(Token = "0x40023E5")]
		[FieldOffset(Offset = "0xD8")]
		public NewAIController.ReactionState reactionState;

		// Token: 0x040023E6 RID: 9190
		[Token(Token = "0x40023E6")]
		[FieldOffset(Offset = "0xE0")]
		public List<int> atHome;

		// Token: 0x040023E7 RID: 9191
		[Token(Token = "0x40023E7")]
		[FieldOffset(Offset = "0xE8")]
		public bool convicted;

		// Token: 0x040023E8 RID: 9192
		[Token(Token = "0x40023E8")]
		[FieldOffset(Offset = "0xE9")]
		public bool unreportable;

		// Token: 0x040023E9 RID: 9193
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0xEA")]
		public bool ko;

		// Token: 0x040023EA RID: 9194
		[Token(Token = "0x40023EA")]
		[FieldOffset(Offset = "0xEC")]
		public float koTime;

		// Token: 0x040023EB RID: 9195
		[Token(Token = "0x40023EB")]
		[FieldOffset(Offset = "0xF0")]
		public bool res;

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0xF4")]
		public float resTime;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0xF8")]
		public float spooked;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0xFC")]
		public int spookCount;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x100")]
		public Human.Death death;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x108")]
		public List<CitizenAnimationController.RagdollSnapshot> ragdollSnapshot;

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x110")]
		public List<CitizenAnimationController.RagdollSnapshotWorld> ragdollSnapshotWorld;

		// Token: 0x040023F2 RID: 9202
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x118")]
		public List<Human.WalletItem> wallet;

		// Token: 0x040023F3 RID: 9203
		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x120")]
		public StateSaveData.CurrentGoalStateSave currentGoal;

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x128")]
		public int fingerprintLoop;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x130")]
		public List<string> currentConsumable;

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x138")]
		public List<int> trash;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x140")]
		public List<int> putDown;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x148")]
		public List<int> sightingCit;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x150")]
		public List<Human.Sighting> sightings;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x158")]
		public StateSaveData.AvoidConfineStateSave confine;

		// Token: 0x040023FB RID: 9211
		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0x160")]
		public List<StateSaveData.AvoidConfineStateSave> avoid;

		// Token: 0x040023FC RID: 9212
		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0x168")]
		public List<Human.InteractionDialogInstance> interactionDialog;
	}

	// Token: 0x020004F8 RID: 1272
	[Token(Token = "0x20004F8")]
	[Serializable]
	public class AvoidConfineStateSave
	{
		// Token: 0x06001BA6 RID: 7078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x9C0730", Offset = "0x9BF730", VA = "0x1809C0730")]
		public AvoidConfineStateSave()
		{
		}

		// Token: 0x040023FD RID: 9213
		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040023FE RID: 9214
		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0x14")]
		public bool st;
	}

	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	[Serializable]
	public class CurrentGoalStateSave
	{
		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x9C0740", Offset = "0x9BF740", VA = "0x1809C0740")]
		public CurrentGoalStateSave()
		{
		}

		// Token: 0x040023FF RID: 9215
		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0x10")]
		public string preset;

		// Token: 0x04002400 RID: 9216
		[Token(Token = "0x4002400")]
		[FieldOffset(Offset = "0x18")]
		public float priority;

		// Token: 0x04002401 RID: 9217
		[Token(Token = "0x4002401")]
		[FieldOffset(Offset = "0x1C")]
		public float trigerTime;

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0x20")]
		public float timestamp;

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0x24")]
		public float duration;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0x28")]
		public Vector3Int passedNode;

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		[FieldOffset(Offset = "0x34")]
		public int passedInteractable;

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0x38")]
		public int gameLocation;

		// Token: 0x04002407 RID: 9223
		[Token(Token = "0x4002407")]
		[FieldOffset(Offset = "0x3C")]
		public int room;

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x40")]
		public bool isAddress;

		// Token: 0x04002409 RID: 9225
		[Token(Token = "0x4002409")]
		[FieldOffset(Offset = "0x44")]
		public int passedGroup;

		// Token: 0x0400240A RID: 9226
		[Token(Token = "0x400240A")]
		[FieldOffset(Offset = "0x48")]
		public int jobID;

		// Token: 0x0400240B RID: 9227
		[Token(Token = "0x400240B")]
		[FieldOffset(Offset = "0x4C")]
		public int var;

		// Token: 0x0400240C RID: 9228
		[Token(Token = "0x400240C")]
		[FieldOffset(Offset = "0x50")]
		public List<StateSaveData.AIActionStateSave> actions;
	}

	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	[Serializable]
	public class AIActionStateSave
	{
		// Token: 0x06001BA8 RID: 7080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x9C0830", Offset = "0x9BF830", VA = "0x1809C0830")]
		public AIActionStateSave()
		{
		}

		// Token: 0x0400240D RID: 9229
		[Token(Token = "0x400240D")]
		[FieldOffset(Offset = "0x10")]
		public string preset;

		// Token: 0x0400240E RID: 9230
		[Token(Token = "0x400240E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 node;

		// Token: 0x0400240F RID: 9231
		[Token(Token = "0x400240F")]
		[FieldOffset(Offset = "0x24")]
		public int interactable;

		// Token: 0x04002410 RID: 9232
		[Token(Token = "0x4002410")]
		[FieldOffset(Offset = "0x28")]
		public int passedInteractable;

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x2C")]
		public int passedRoom;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x30")]
		public int passedGroup;

		// Token: 0x04002413 RID: 9235
		[Token(Token = "0x4002413")]
		[FieldOffset(Offset = "0x34")]
		public Vector3Int forcedNode;

		// Token: 0x04002414 RID: 9236
		[Token(Token = "0x4002414")]
		[FieldOffset(Offset = "0x40")]
		public bool repeat;

		// Token: 0x04002415 RID: 9237
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0x41")]
		public bool inserted;

		// Token: 0x04002416 RID: 9238
		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0x44")]
		public int iap;
	}

	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20004FB")]
	[Serializable]
	public class DoorStateSave
	{
		// Token: 0x06001BA9 RID: 7081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DoorStateSave()
		{
		}

		// Token: 0x04002417 RID: 9239
		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0x14")]
		public bool l;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		[FieldOffset(Offset = "0x18")]
		public float ds;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		[FieldOffset(Offset = "0x1C")]
		public float ls;

		// Token: 0x0400241B RID: 9243
		[Token(Token = "0x400241B")]
		[FieldOffset(Offset = "0x20")]
		public float ajar;

		// Token: 0x0400241C RID: 9244
		[Token(Token = "0x400241C")]
		[FieldOffset(Offset = "0x24")]
		public bool cs;
	}

	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20004FC")]
	[Serializable]
	public class MessageThreadSave
	{
		// Token: 0x06001BAA RID: 7082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x9C0850", Offset = "0x9BF850", VA = "0x1809C0850")]
		public MessageThreadSave()
		{
		}

		// Token: 0x0400241D RID: 9245
		[Token(Token = "0x400241D")]
		[FieldOffset(Offset = "0x10")]
		public int threadID;

		// Token: 0x0400241E RID: 9246
		[Token(Token = "0x400241E")]
		[FieldOffset(Offset = "0x14")]
		public DDSSaveClasses.TreeType msgType;

		// Token: 0x0400241F RID: 9247
		[Token(Token = "0x400241F")]
		[FieldOffset(Offset = "0x18")]
		public string treeID;

		// Token: 0x04002420 RID: 9248
		[Token(Token = "0x4002420")]
		[FieldOffset(Offset = "0x20")]
		public int participantA;

		// Token: 0x04002421 RID: 9249
		[Token(Token = "0x4002421")]
		[FieldOffset(Offset = "0x24")]
		public int participantB;

		// Token: 0x04002422 RID: 9250
		[Token(Token = "0x4002422")]
		[FieldOffset(Offset = "0x28")]
		public int participantC;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x2C")]
		public int participantD;

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x30")]
		public List<int> cc;

		// Token: 0x04002425 RID: 9253
		[Token(Token = "0x4002425")]
		[FieldOffset(Offset = "0x38")]
		public List<string> messages;

		// Token: 0x04002426 RID: 9254
		[Token(Token = "0x4002426")]
		[FieldOffset(Offset = "0x40")]
		public List<int> senders;

		// Token: 0x04002427 RID: 9255
		[Token(Token = "0x4002427")]
		[FieldOffset(Offset = "0x48")]
		public List<int> recievers;

		// Token: 0x04002428 RID: 9256
		[Token(Token = "0x4002428")]
		[FieldOffset(Offset = "0x50")]
		public List<float> timestamps;

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x58")]
		public float time;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x5C")]
		public StateSaveData.CustomDataSource ds;

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x60")]
		public int dsID;
	}

	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	public enum CustomDataSource
	{
		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		sender,
		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		groupID
	}

	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	[Serializable]
	public class AirDuctExplorationSave
	{
		// Token: 0x06001BAB RID: 7083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x9C0B50", Offset = "0x9BFB50", VA = "0x1809C0B50")]
		public AirDuctExplorationSave()
		{
		}

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x10")]
		public int grpID;

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x18")]
		public List<int> vents;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector3Int> ducts;
	}

	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20004FF")]
	[Serializable]
	public class ChangedLightswitch
	{
		// Token: 0x06001BAC RID: 7084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ChangedLightswitch()
		{
		}

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 locPos;

		// Token: 0x04002433 RID: 9267
		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 locEuler;

		// Token: 0x04002434 RID: 9268
		[Token(Token = "0x4002434")]
		[FieldOffset(Offset = "0x28")]
		public bool added;
	}
}
