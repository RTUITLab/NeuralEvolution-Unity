// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from data.proto</summary>
public static partial class DataReflection {

  #region Descriptor
  /// <summary>File descriptor for data.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgpkYXRhLnByb3RvImcKB0VudkRhdGESDwoHaXNBbGl2ZRgBIAEoCBIOCgZm",
          "b29kX3gYAiABKAISDgoGZm9vZF96GAMgASgCEgoKAmhwGAQgASgCEg8KB3Nh",
          "dGlldHkYBSABKAISDgoGcmV3YXJkGAYgASgCIhgKBkFjdGlvbhIOCgZhY3Rp",
          "b24YASABKAUiMwoJQWdlbnREYXRhEhEKCWVudl9zaGFwZRgBIAEoBRITCgtu",
          "dW1fYWN0aW9ucxgCIAEoBSIVCgdBZ2VudElkEgoKAmlkGAEgASgFMk8KCUxl",
          "YXJuQm9hchIdCghTZW5kRGF0YRIILkVudkRhdGEaBy5BY3Rpb24SIwoLQ3Jl",
          "YXRlQWdlbnQSCi5BZ2VudERhdGEaCC5BZ2VudElkYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EnvData), global::EnvData.Parser, new[]{ "IsAlive", "FoodX", "FoodZ", "Hp", "Satiety", "Reward" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Action), global::Action.Parser, new[]{ "Action_" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AgentData), global::AgentData.Parser, new[]{ "EnvShape", "NumActions" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AgentId), global::AgentId.Parser, new[]{ "Id" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class EnvData : pb::IMessage<EnvData> {
  private static readonly pb::MessageParser<EnvData> _parser = new pb::MessageParser<EnvData>(() => new EnvData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<EnvData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EnvData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EnvData(EnvData other) : this() {
    isAlive_ = other.isAlive_;
    foodX_ = other.foodX_;
    foodZ_ = other.foodZ_;
    hp_ = other.hp_;
    satiety_ = other.satiety_;
    reward_ = other.reward_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EnvData Clone() {
    return new EnvData(this);
  }

  /// <summary>Field number for the "isAlive" field.</summary>
  public const int IsAliveFieldNumber = 1;
  private bool isAlive_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool IsAlive {
    get { return isAlive_; }
    set {
      isAlive_ = value;
    }
  }

  /// <summary>Field number for the "food_x" field.</summary>
  public const int FoodXFieldNumber = 2;
  private float foodX_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float FoodX {
    get { return foodX_; }
    set {
      foodX_ = value;
    }
  }

  /// <summary>Field number for the "food_z" field.</summary>
  public const int FoodZFieldNumber = 3;
  private float foodZ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float FoodZ {
    get { return foodZ_; }
    set {
      foodZ_ = value;
    }
  }

  /// <summary>Field number for the "hp" field.</summary>
  public const int HpFieldNumber = 4;
  private float hp_;
  /// <summary>
  /// уровень жизни
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Hp {
    get { return hp_; }
    set {
      hp_ = value;
    }
  }

  /// <summary>Field number for the "satiety" field.</summary>
  public const int SatietyFieldNumber = 5;
  private float satiety_;
  /// <summary>
  /// уровень сытости
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Satiety {
    get { return satiety_; }
    set {
      satiety_ = value;
    }
  }

  /// <summary>Field number for the "reward" field.</summary>
  public const int RewardFieldNumber = 6;
  private float reward_;
  /// <summary>
  /// наказание или награда
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Reward {
    get { return reward_; }
    set {
      reward_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as EnvData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(EnvData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsAlive != other.IsAlive) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FoodX, other.FoodX)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FoodZ, other.FoodZ)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Hp, other.Hp)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Satiety, other.Satiety)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Reward, other.Reward)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (IsAlive != false) hash ^= IsAlive.GetHashCode();
    if (FoodX != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FoodX);
    if (FoodZ != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FoodZ);
    if (Hp != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Hp);
    if (Satiety != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Satiety);
    if (Reward != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Reward);
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (IsAlive != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsAlive);
    }
    if (FoodX != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(FoodX);
    }
    if (FoodZ != 0F) {
      output.WriteRawTag(29);
      output.WriteFloat(FoodZ);
    }
    if (Hp != 0F) {
      output.WriteRawTag(37);
      output.WriteFloat(Hp);
    }
    if (Satiety != 0F) {
      output.WriteRawTag(45);
      output.WriteFloat(Satiety);
    }
    if (Reward != 0F) {
      output.WriteRawTag(53);
      output.WriteFloat(Reward);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (IsAlive != false) {
      size += 1 + 1;
    }
    if (FoodX != 0F) {
      size += 1 + 4;
    }
    if (FoodZ != 0F) {
      size += 1 + 4;
    }
    if (Hp != 0F) {
      size += 1 + 4;
    }
    if (Satiety != 0F) {
      size += 1 + 4;
    }
    if (Reward != 0F) {
      size += 1 + 4;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(EnvData other) {
    if (other == null) {
      return;
    }
    if (other.IsAlive != false) {
      IsAlive = other.IsAlive;
    }
    if (other.FoodX != 0F) {
      FoodX = other.FoodX;
    }
    if (other.FoodZ != 0F) {
      FoodZ = other.FoodZ;
    }
    if (other.Hp != 0F) {
      Hp = other.Hp;
    }
    if (other.Satiety != 0F) {
      Satiety = other.Satiety;
    }
    if (other.Reward != 0F) {
      Reward = other.Reward;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          IsAlive = input.ReadBool();
          break;
        }
        case 21: {
          FoodX = input.ReadFloat();
          break;
        }
        case 29: {
          FoodZ = input.ReadFloat();
          break;
        }
        case 37: {
          Hp = input.ReadFloat();
          break;
        }
        case 45: {
          Satiety = input.ReadFloat();
          break;
        }
        case 53: {
          Reward = input.ReadFloat();
          break;
        }
      }
    }
  }

}

public sealed partial class Action : pb::IMessage<Action> {
  private static readonly pb::MessageParser<Action> _parser = new pb::MessageParser<Action>(() => new Action());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Action> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Action() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Action(Action other) : this() {
    action_ = other.action_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Action Clone() {
    return new Action(this);
  }

  /// <summary>Field number for the "action" field.</summary>
  public const int Action_FieldNumber = 1;
  private int action_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Action_ {
    get { return action_; }
    set {
      action_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Action);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Action other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Action_ != other.Action_) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Action_ != 0) hash ^= Action_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Action_ != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Action_);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Action_ != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Action_);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Action other) {
    if (other == null) {
      return;
    }
    if (other.Action_ != 0) {
      Action_ = other.Action_;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Action_ = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class AgentData : pb::IMessage<AgentData> {
  private static readonly pb::MessageParser<AgentData> _parser = new pb::MessageParser<AgentData>(() => new AgentData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AgentData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentData(AgentData other) : this() {
    envShape_ = other.envShape_;
    numActions_ = other.numActions_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentData Clone() {
    return new AgentData(this);
  }

  /// <summary>Field number for the "env_shape" field.</summary>
  public const int EnvShapeFieldNumber = 1;
  private int envShape_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int EnvShape {
    get { return envShape_; }
    set {
      envShape_ = value;
    }
  }

  /// <summary>Field number for the "num_actions" field.</summary>
  public const int NumActionsFieldNumber = 2;
  private int numActions_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int NumActions {
    get { return numActions_; }
    set {
      numActions_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AgentData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AgentData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EnvShape != other.EnvShape) return false;
    if (NumActions != other.NumActions) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (EnvShape != 0) hash ^= EnvShape.GetHashCode();
    if (NumActions != 0) hash ^= NumActions.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (EnvShape != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(EnvShape);
    }
    if (NumActions != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(NumActions);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (EnvShape != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(EnvShape);
    }
    if (NumActions != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumActions);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AgentData other) {
    if (other == null) {
      return;
    }
    if (other.EnvShape != 0) {
      EnvShape = other.EnvShape;
    }
    if (other.NumActions != 0) {
      NumActions = other.NumActions;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          EnvShape = input.ReadInt32();
          break;
        }
        case 16: {
          NumActions = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class AgentId : pb::IMessage<AgentId> {
  private static readonly pb::MessageParser<AgentId> _parser = new pb::MessageParser<AgentId>(() => new AgentId());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AgentId> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentId() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentId(AgentId other) : this() {
    id_ = other.id_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentId Clone() {
    return new AgentId(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AgentId);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AgentId other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AgentId other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Id = input.ReadInt32();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
