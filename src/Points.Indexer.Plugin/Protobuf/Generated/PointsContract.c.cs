// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: points_contract.proto
// </auto-generated>
// Original file comments:
// the version of the language, use proto3 for contracts
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace Points.Contracts.Point {

  #region Events
  public partial class Joined : aelf::IEvent<Joined>
  {
    public global::System.Collections.Generic.IEnumerable<Joined> GetIndexed()
    {
      return new List<Joined>
      {
      };
    }

    public Joined GetNonIndexed()
    {
      return new Joined
      {
        DappId = DappId,
        Domain = Domain,
        Registrant = Registrant,
      };
    }
  }

  public partial class PointsChanged : aelf::IEvent<PointsChanged>
  {
    public global::System.Collections.Generic.IEnumerable<PointsChanged> GetIndexed()
    {
      return new List<PointsChanged>
      {
      };
    }

    public PointsChanged GetNonIndexed()
    {
      return new PointsChanged
      {
        PointsChangedDetails = PointsChangedDetails,
      };
    }
  }

  public partial class DappAdded : aelf::IEvent<DappAdded>
  {
    public global::System.Collections.Generic.IEnumerable<DappAdded> GetIndexed()
    {
      return new List<DappAdded>
      {
      };
    }

    public DappAdded GetNonIndexed()
    {
      return new DappAdded
      {
        DappId = DappId,
        DappInfo = DappInfo,
      };
    }
  }

  public partial class SelfIncreasingPointsRulesChanged : aelf::IEvent<SelfIncreasingPointsRulesChanged>
  {
    public global::System.Collections.Generic.IEnumerable<SelfIncreasingPointsRulesChanged> GetIndexed()
    {
      return new List<SelfIncreasingPointsRulesChanged>
      {
      };
    }

    public SelfIncreasingPointsRulesChanged GetNonIndexed()
    {
      return new SelfIncreasingPointsRulesChanged
      {
        DappId = DappId,
        PointName = PointName,
        UserPoints = UserPoints,
        KolPointsPercent = KolPointsPercent,
        InviterPointsPercent = InviterPointsPercent,
        Frequency = Frequency,
        EnableProportionalCalculation = EnableProportionalCalculation,
      };
    }
  }

  public partial class InviterApplied : aelf::IEvent<InviterApplied>
  {
    public global::System.Collections.Generic.IEnumerable<InviterApplied> GetIndexed()
    {
      return new List<InviterApplied>
      {
      };
    }

    public InviterApplied GetNonIndexed()
    {
      return new InviterApplied
      {
        Domain = Domain,
        DappId = DappId,
        Invitee = Invitee,
        Inviter = Inviter,
      };
    }
  }

  public partial class DappPointsRuleChanged : aelf::IEvent<DappPointsRuleChanged>
  {
    public global::System.Collections.Generic.IEnumerable<DappPointsRuleChanged> GetIndexed()
    {
      return new List<DappPointsRuleChanged>
      {
      };
    }

    public DappPointsRuleChanged GetNonIndexed()
    {
      return new DappPointsRuleChanged
      {
        Service = Service,
        DappEarningRules = DappEarningRules,
      };
    }
  }

  public partial class PointCreated : aelf::IEvent<PointCreated>
  {
    public global::System.Collections.Generic.IEnumerable<PointCreated> GetIndexed()
    {
      return new List<PointCreated>
      {
      };
    }

    public PointCreated GetNonIndexed()
    {
      return new PointCreated
      {
        DappId = DappId,
        TokenName = TokenName,
        Decimals = Decimals,
      };
    }
  }

  public partial class ReferralAccepted : aelf::IEvent<ReferralAccepted>
  {
    public global::System.Collections.Generic.IEnumerable<ReferralAccepted> GetIndexed()
    {
      return new List<ReferralAccepted>
      {
      };
    }

    public ReferralAccepted GetNonIndexed()
    {
      return new ReferralAccepted
      {
        DappId = DappId,
        Domain = Domain,
        Referrer = Referrer,
        Invitee = Invitee,
        Inviter = Inviter,
      };
    }
  }

  #endregion
  public static partial class PointsContractContainer
  {
    static readonly string __ServiceName = "PointsContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Points.Contracts.Point.InitializeInput> __Marshaller_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.InitializeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.SetReservedDomainListInput> __Marshaller_SetReservedDomainListInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.SetReservedDomainListInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetReservedDomainListOutput> __Marshaller_GetReservedDomainListOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetReservedDomainListOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.CreatePointInput> __Marshaller_CreatePointInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.CreatePointInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.CreatePointListInput> __Marshaller_CreatePointListInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.CreatePointListInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetPointInput> __Marshaller_GetPointInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetPointInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.PointInfo> __Marshaller_PointInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.PointInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.JoinInput> __Marshaller_JoinInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.JoinInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.SettleInput> __Marshaller_SettleInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.SettleInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.BatchSettleInput> __Marshaller_BatchSettleInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.BatchSettleInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetPointsBalanceInput> __Marshaller_GetPointsBalanceInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetPointsBalanceInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetPointsBalanceOutput> __Marshaller_GetPointsBalanceOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetPointsBalanceOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.AddDappInput> __Marshaller_AddDappInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.AddDappInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetDappInformationInput> __Marshaller_GetDappInformationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetDappInformationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetDappInformationOutput> __Marshaller_GetDappInformationOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetDappInformationOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.SetDappPointsRulesInput> __Marshaller_SetDappPointsRulesInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.SetDappPointsRulesInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.SetSelfIncreasingPointsRulesInput> __Marshaller_SetSelfIncreasingPointsRulesInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.SetSelfIncreasingPointsRulesInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetSelfIncreasingPointsRuleInput> __Marshaller_GetSelfIncreasingPointsRuleInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetSelfIncreasingPointsRuleInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetSelfIncreasingPointsRuleOutput> __Marshaller_GetSelfIncreasingPointsRuleOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetSelfIncreasingPointsRuleOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.ApplyToBeAdvocateInput> __Marshaller_ApplyToBeAdvocateInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.ApplyToBeAdvocateInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.DomainRelationshipInfo> __Marshaller_DomainRelationshipInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.DomainRelationshipInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.AcceptReferralInput> __Marshaller_AcceptReferralInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.AcceptReferralInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.GetReferralRelationInfoInput> __Marshaller_GetReferralRelationInfoInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.GetReferralRelationInfoInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Points.Contracts.Point.ReferralRelationInfo> __Marshaller_ReferralRelationInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Points.Contracts.Point.ReferralRelationInfo.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Points.Contracts.Point.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::Points.Contracts.Point.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetAdmin = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetAdmin",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address> __Method_GetAdmin = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetAdmin",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::Points.Contracts.Point.SetReservedDomainListInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetReservedDomainList = new aelf::Method<global::Points.Contracts.Point.SetReservedDomainListInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetReservedDomainList",
        __Marshaller_SetReservedDomainListInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Points.Contracts.Point.GetReservedDomainListOutput> __Method_GetReservedDomainList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Points.Contracts.Point.GetReservedDomainListOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetReservedDomainList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_GetReservedDomainListOutput);

    static readonly aelf::Method<global::Points.Contracts.Point.CreatePointInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreatePoint = new aelf::Method<global::Points.Contracts.Point.CreatePointInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreatePoint",
        __Marshaller_CreatePointInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.CreatePointListInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreatePointList = new aelf::Method<global::Points.Contracts.Point.CreatePointListInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreatePointList",
        __Marshaller_CreatePointListInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.GetPointInput, global::Points.Contracts.Point.PointInfo> __Method_GetPoint = new aelf::Method<global::Points.Contracts.Point.GetPointInput, global::Points.Contracts.Point.PointInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPoint",
        __Marshaller_GetPointInput,
        __Marshaller_PointInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetMaxApplyDomainCount = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetMaxApplyDomainCount",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.JoinInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Join = new aelf::Method<global::Points.Contracts.Point.JoinInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Join",
        __Marshaller_JoinInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.SettleInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Settle = new aelf::Method<global::Points.Contracts.Point.SettleInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Settle",
        __Marshaller_SettleInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.BatchSettleInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_BatchSettle = new aelf::Method<global::Points.Contracts.Point.BatchSettleInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "BatchSettle",
        __Marshaller_BatchSettleInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.GetPointsBalanceInput, global::Points.Contracts.Point.GetPointsBalanceOutput> __Method_GetPointsBalance = new aelf::Method<global::Points.Contracts.Point.GetPointsBalanceInput, global::Points.Contracts.Point.GetPointsBalanceOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPointsBalance",
        __Marshaller_GetPointsBalanceInput,
        __Marshaller_GetPointsBalanceOutput);

    static readonly aelf::Method<global::Points.Contracts.Point.AddDappInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddDapp = new aelf::Method<global::Points.Contracts.Point.AddDappInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddDapp",
        __Marshaller_AddDappInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.GetDappInformationInput, global::Points.Contracts.Point.GetDappInformationOutput> __Method_GetDappInformation = new aelf::Method<global::Points.Contracts.Point.GetDappInformationInput, global::Points.Contracts.Point.GetDappInformationOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDappInformation",
        __Marshaller_GetDappInformationInput,
        __Marshaller_GetDappInformationOutput);

    static readonly aelf::Method<global::Points.Contracts.Point.SetDappPointsRulesInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetDappPointsRules = new aelf::Method<global::Points.Contracts.Point.SetDappPointsRulesInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetDappPointsRules",
        __Marshaller_SetDappPointsRulesInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.SetSelfIncreasingPointsRulesInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetSelfIncreasingPointsRules = new aelf::Method<global::Points.Contracts.Point.SetSelfIncreasingPointsRulesInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetSelfIncreasingPointsRules",
        __Marshaller_SetSelfIncreasingPointsRulesInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.GetSelfIncreasingPointsRuleInput, global::Points.Contracts.Point.GetSelfIncreasingPointsRuleOutput> __Method_GetSelfIncreasingPointsRule = new aelf::Method<global::Points.Contracts.Point.GetSelfIncreasingPointsRuleInput, global::Points.Contracts.Point.GetSelfIncreasingPointsRuleOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSelfIncreasingPointsRule",
        __Marshaller_GetSelfIncreasingPointsRuleInput,
        __Marshaller_GetSelfIncreasingPointsRuleOutput);

    static readonly aelf::Method<global::Points.Contracts.Point.ApplyToBeAdvocateInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ApplyToBeAdvocate = new aelf::Method<global::Points.Contracts.Point.ApplyToBeAdvocateInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ApplyToBeAdvocate",
        __Marshaller_ApplyToBeAdvocateInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::Points.Contracts.Point.DomainRelationshipInfo> __Method_GetDomainApplyInfo = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::Points.Contracts.Point.DomainRelationshipInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDomainApplyInfo",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_DomainRelationshipInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_GetMaxApplyCount = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMaxApplyCount",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::Points.Contracts.Point.AcceptReferralInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AcceptReferral = new aelf::Method<global::Points.Contracts.Point.AcceptReferralInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AcceptReferral",
        __Marshaller_AcceptReferralInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Points.Contracts.Point.GetReferralRelationInfoInput, global::Points.Contracts.Point.ReferralRelationInfo> __Method_GetReferralRelationInfo = new aelf::Method<global::Points.Contracts.Point.GetReferralRelationInfoInput, global::Points.Contracts.Point.ReferralRelationInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetReferralRelationInfo",
        __Marshaller_GetReferralRelationInfoInput,
        __Marshaller_ReferralRelationInfo);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Points.Contracts.Point.PointsContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS12.Acs12Reflection.Descriptor.Services[0],
          global::Points.Contracts.Point.PointsContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    // /// <summary>Base class for the contract of PointsContract</summary>
    // public abstract partial class PointsContractBase : AElf.Sdk.CSharp.CSharpSmartContract<Points.Contracts.Point.PointsContractState>
    // {
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty Initialize(global::Points.Contracts.Point.InitializeInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetAdmin(global::AElf.Types.Address input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::AElf.Types.Address GetAdmin(global::Google.Protobuf.WellKnownTypes.Empty input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetReservedDomainList(global::Points.Contracts.Point.SetReservedDomainListInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Points.Contracts.Point.GetReservedDomainListOutput GetReservedDomainList(global::Google.Protobuf.WellKnownTypes.Empty input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty CreatePoint(global::Points.Contracts.Point.CreatePointInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty CreatePointList(global::Points.Contracts.Point.CreatePointListInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Points.Contracts.Point.PointInfo GetPoint(global::Points.Contracts.Point.GetPointInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetMaxApplyDomainCount(global::Google.Protobuf.WellKnownTypes.Int32Value input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty Join(global::Points.Contracts.Point.JoinInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty Settle(global::Points.Contracts.Point.SettleInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty BatchSettle(global::Points.Contracts.Point.BatchSettleInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Points.Contracts.Point.GetPointsBalanceOutput GetPointsBalance(global::Points.Contracts.Point.GetPointsBalanceInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty AddDapp(global::Points.Contracts.Point.AddDappInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Points.Contracts.Point.GetDappInformationOutput GetDappInformation(global::Points.Contracts.Point.GetDappInformationInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetDappPointsRules(global::Points.Contracts.Point.SetDappPointsRulesInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty SetSelfIncreasingPointsRules(global::Points.Contracts.Point.SetSelfIncreasingPointsRulesInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Points.Contracts.Point.GetSelfIncreasingPointsRuleOutput GetSelfIncreasingPointsRule(global::Points.Contracts.Point.GetSelfIncreasingPointsRuleInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty ApplyToBeAdvocate(global::Points.Contracts.Point.ApplyToBeAdvocateInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Points.Contracts.Point.DomainRelationshipInfo GetDomainApplyInfo(global::Google.Protobuf.WellKnownTypes.StringValue input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Int32Value GetMaxApplyCount(global::Google.Protobuf.WellKnownTypes.Empty input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Google.Protobuf.WellKnownTypes.Empty AcceptReferral(global::Points.Contracts.Point.AcceptReferralInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    //   public virtual global::Points.Contracts.Point.ReferralRelationInfo GetReferralRelationInfo(global::Points.Contracts.Point.GetReferralRelationInfoInput input)
    //   {
    //     throw new global::System.NotImplementedException();
    //   }
    //
    // }
    //
    // public static aelf::ServerServiceDefinition BindService(PointsContractBase serviceImpl)
    // {
    //   return aelf::ServerServiceDefinition.CreateBuilder()
    //       .AddDescriptors(Descriptors)
    //       .AddMethod(__Method_Initialize, serviceImpl.Initialize)
    //       .AddMethod(__Method_SetAdmin, serviceImpl.SetAdmin)
    //       .AddMethod(__Method_GetAdmin, serviceImpl.GetAdmin)
    //       .AddMethod(__Method_SetReservedDomainList, serviceImpl.SetReservedDomainList)
    //       .AddMethod(__Method_GetReservedDomainList, serviceImpl.GetReservedDomainList)
    //       .AddMethod(__Method_CreatePoint, serviceImpl.CreatePoint)
    //       .AddMethod(__Method_CreatePointList, serviceImpl.CreatePointList)
    //       .AddMethod(__Method_GetPoint, serviceImpl.GetPoint)
    //       .AddMethod(__Method_SetMaxApplyDomainCount, serviceImpl.SetMaxApplyDomainCount)
    //       .AddMethod(__Method_Join, serviceImpl.Join)
    //       .AddMethod(__Method_Settle, serviceImpl.Settle)
    //       .AddMethod(__Method_BatchSettle, serviceImpl.BatchSettle)
    //       .AddMethod(__Method_GetPointsBalance, serviceImpl.GetPointsBalance)
    //       .AddMethod(__Method_AddDapp, serviceImpl.AddDapp)
    //       .AddMethod(__Method_GetDappInformation, serviceImpl.GetDappInformation)
    //       .AddMethod(__Method_SetDappPointsRules, serviceImpl.SetDappPointsRules)
    //       .AddMethod(__Method_SetSelfIncreasingPointsRules, serviceImpl.SetSelfIncreasingPointsRules)
    //       .AddMethod(__Method_GetSelfIncreasingPointsRule, serviceImpl.GetSelfIncreasingPointsRule)
    //       .AddMethod(__Method_ApplyToBeAdvocate, serviceImpl.ApplyToBeAdvocate)
    //       .AddMethod(__Method_GetDomainApplyInfo, serviceImpl.GetDomainApplyInfo)
    //       .AddMethod(__Method_GetMaxApplyCount, serviceImpl.GetMaxApplyCount)
    //       .AddMethod(__Method_AcceptReferral, serviceImpl.AcceptReferral)
    //       .AddMethod(__Method_GetReferralRelationInfo, serviceImpl.GetReferralRelationInfo).Build();
    // }

  }
}
#endregion
