// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueQueryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueQueryInfo.proto</summary>
  public static partial class ChessRogueQueryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueQueryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueQueryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGVzc1JvZ3VlUXVlcnlJbmZvLnByb3RvGh1DaGVzc1JvZ3VlUXVlcnlE",
            "aWNlSW5mby5wcm90bxoRR0VQR0xPQkNJS00ucHJvdG8aIkNoZXNzUm9ndWVR",
            "dWVyeURpZmZjdWx0eUluZm8ucHJvdG8aHUNoZXNzUm9ndWVRdWVyeUFlb25J",
            "bmZvLnByb3RvGhpDaGVzc1JvZ3VlVGFsZW50SW5mby5wcm90byLDAgoTQ2hl",
            "c3NSb2d1ZVF1ZXJ5SW5mbxIdChVleHBsb3JlZF9hcmVhX2lkX2xpc3QYBSAD",
            "KA0SKwoJYWVvbl9pbmZvGAggASgLMhguQ2hlc3NSb2d1ZVF1ZXJ5QWVvbklu",
            "Zm8SPAoVcm9ndWVfZGlmZmljdWx0eV9pbmZvGA4gASgLMh0uQ2hlc3NSb2d1",
            "ZVF1ZXJ5RGlmZmN1bHR5SW5mbxIUCgxhcmVhX2lkX2xpc3QYAyADKA0SKwoJ",
            "ZGljZV9pbmZvGAEgASgLMhguQ2hlc3NSb2d1ZVF1ZXJ5RGljZUluZm8SLQoX",
            "cm9ndWVfdmlydHVhbF9pdGVtX2luZm8YBiABKAsyDC5HRVBHTE9CQ0lLTRIw",
            "ChFyb2d1ZV90YWxlbnRfaW5mbxgPIAEoCzIVLkNoZXNzUm9ndWVUYWxlbnRJ",
            "bmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GEPGLOBCIKMReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueTalentInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo), global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo.Parser, new[]{ "ExploredAreaIdList", "AeonInfo", "RogueDifficultyInfo", "AreaIdList", "DiceInfo", "RogueVirtualItemInfo", "RogueTalentInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueQueryInfo : pb::IMessage<ChessRogueQueryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueQueryInfo> _parser = new pb::MessageParser<ChessRogueQueryInfo>(() => new ChessRogueQueryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueQueryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueQueryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryInfo(ChessRogueQueryInfo other) : this() {
      exploredAreaIdList_ = other.exploredAreaIdList_.Clone();
      aeonInfo_ = other.aeonInfo_ != null ? other.aeonInfo_.Clone() : null;
      rogueDifficultyInfo_ = other.rogueDifficultyInfo_ != null ? other.rogueDifficultyInfo_.Clone() : null;
      areaIdList_ = other.areaIdList_.Clone();
      diceInfo_ = other.diceInfo_ != null ? other.diceInfo_.Clone() : null;
      rogueVirtualItemInfo_ = other.rogueVirtualItemInfo_ != null ? other.rogueVirtualItemInfo_.Clone() : null;
      rogueTalentInfo_ = other.rogueTalentInfo_ != null ? other.rogueTalentInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryInfo Clone() {
      return new ChessRogueQueryInfo(this);
    }

    /// <summary>Field number for the "explored_area_id_list" field.</summary>
    public const int ExploredAreaIdListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_exploredAreaIdList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> exploredAreaIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExploredAreaIdList {
      get { return exploredAreaIdList_; }
    }

    /// <summary>Field number for the "aeon_info" field.</summary>
    public const int AeonInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo aeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo AeonInfo {
      get { return aeonInfo_; }
      set {
        aeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_difficulty_info" field.</summary>
    public const int RogueDifficultyInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo rogueDifficultyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo RogueDifficultyInfo {
      get { return rogueDifficultyInfo_; }
      set {
        rogueDifficultyInfo_ = value;
      }
    }

    /// <summary>Field number for the "area_id_list" field.</summary>
    public const int AreaIdListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_areaIdList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> areaIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AreaIdList {
      get { return areaIdList_; }
    }

    /// <summary>Field number for the "dice_info" field.</summary>
    public const int DiceInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo diceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo DiceInfo {
      get { return diceInfo_; }
      set {
        diceInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_virtual_item_info" field.</summary>
    public const int RogueVirtualItemInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.GEPGLOBCIKM rogueVirtualItemInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GEPGLOBCIKM RogueVirtualItemInfo {
      get { return rogueVirtualItemInfo_; }
      set {
        rogueVirtualItemInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_talent_info" field.</summary>
    public const int RogueTalentInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo rogueTalentInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo RogueTalentInfo {
      get { return rogueTalentInfo_; }
      set {
        rogueTalentInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueQueryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueQueryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!exploredAreaIdList_.Equals(other.exploredAreaIdList_)) return false;
      if (!object.Equals(AeonInfo, other.AeonInfo)) return false;
      if (!object.Equals(RogueDifficultyInfo, other.RogueDifficultyInfo)) return false;
      if(!areaIdList_.Equals(other.areaIdList_)) return false;
      if (!object.Equals(DiceInfo, other.DiceInfo)) return false;
      if (!object.Equals(RogueVirtualItemInfo, other.RogueVirtualItemInfo)) return false;
      if (!object.Equals(RogueTalentInfo, other.RogueTalentInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= exploredAreaIdList_.GetHashCode();
      if (aeonInfo_ != null) hash ^= AeonInfo.GetHashCode();
      if (rogueDifficultyInfo_ != null) hash ^= RogueDifficultyInfo.GetHashCode();
      hash ^= areaIdList_.GetHashCode();
      if (diceInfo_ != null) hash ^= DiceInfo.GetHashCode();
      if (rogueVirtualItemInfo_ != null) hash ^= RogueVirtualItemInfo.GetHashCode();
      if (rogueTalentInfo_ != null) hash ^= RogueTalentInfo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (diceInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DiceInfo);
      }
      areaIdList_.WriteTo(output, _repeated_areaIdList_codec);
      exploredAreaIdList_.WriteTo(output, _repeated_exploredAreaIdList_codec);
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      if (aeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AeonInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueTalentInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (diceInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DiceInfo);
      }
      areaIdList_.WriteTo(ref output, _repeated_areaIdList_codec);
      exploredAreaIdList_.WriteTo(ref output, _repeated_exploredAreaIdList_codec);
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      if (aeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AeonInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueTalentInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += exploredAreaIdList_.CalculateSize(_repeated_exploredAreaIdList_codec);
      if (aeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AeonInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDifficultyInfo);
      }
      size += areaIdList_.CalculateSize(_repeated_areaIdList_codec);
      if (diceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DiceInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueVirtualItemInfo);
      }
      if (rogueTalentInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTalentInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueQueryInfo other) {
      if (other == null) {
        return;
      }
      exploredAreaIdList_.Add(other.exploredAreaIdList_);
      if (other.aeonInfo_ != null) {
        if (aeonInfo_ == null) {
          AeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
        }
        AeonInfo.MergeFrom(other.AeonInfo);
      }
      if (other.rogueDifficultyInfo_ != null) {
        if (rogueDifficultyInfo_ == null) {
          RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
        }
        RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
      }
      areaIdList_.Add(other.areaIdList_);
      if (other.diceInfo_ != null) {
        if (diceInfo_ == null) {
          DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
        }
        DiceInfo.MergeFrom(other.DiceInfo);
      }
      if (other.rogueVirtualItemInfo_ != null) {
        if (rogueVirtualItemInfo_ == null) {
          RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.GEPGLOBCIKM();
        }
        RogueVirtualItemInfo.MergeFrom(other.RogueVirtualItemInfo);
      }
      if (other.rogueTalentInfo_ != null) {
        if (rogueTalentInfo_ == null) {
          RogueTalentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
        }
        RogueTalentInfo.MergeFrom(other.RogueTalentInfo);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (diceInfo_ == null) {
              DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
            }
            input.ReadMessage(DiceInfo);
            break;
          }
          case 26:
          case 24: {
            areaIdList_.AddEntriesFrom(input, _repeated_areaIdList_codec);
            break;
          }
          case 42:
          case 40: {
            exploredAreaIdList_.AddEntriesFrom(input, _repeated_exploredAreaIdList_codec);
            break;
          }
          case 50: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.GEPGLOBCIKM();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 66: {
            if (aeonInfo_ == null) {
              AeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(AeonInfo);
            break;
          }
          case 114: {
            if (rogueDifficultyInfo_ == null) {
              RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
            }
            input.ReadMessage(RogueDifficultyInfo);
            break;
          }
          case 122: {
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
            }
            input.ReadMessage(RogueTalentInfo);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (diceInfo_ == null) {
              DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
            }
            input.ReadMessage(DiceInfo);
            break;
          }
          case 26:
          case 24: {
            areaIdList_.AddEntriesFrom(ref input, _repeated_areaIdList_codec);
            break;
          }
          case 42:
          case 40: {
            exploredAreaIdList_.AddEntriesFrom(ref input, _repeated_exploredAreaIdList_codec);
            break;
          }
          case 50: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.GEPGLOBCIKM();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 66: {
            if (aeonInfo_ == null) {
              AeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(AeonInfo);
            break;
          }
          case 114: {
            if (rogueDifficultyInfo_ == null) {
              RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
            }
            input.ReadMessage(RogueDifficultyInfo);
            break;
          }
          case 122: {
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
            }
            input.ReadMessage(RogueTalentInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code