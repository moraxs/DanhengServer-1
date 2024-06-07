// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupRefreshInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GroupRefreshInfo.proto</summary>
  public static partial class GroupRefreshInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupRefreshInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupRefreshInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHcm91cFJlZnJlc2hJbmZvLnByb3RvGhtTY2VuZUdyb3VwUmVmcmVzaFR5",
            "cGUucHJvdG8aHFNjZW5lRW50aXR5UmVmcmVzaEluZm8ucHJvdG8ikgEKEEdy",
            "b3VwUmVmcmVzaEluZm8SDQoFc3RhdGUYBCABKA0SEAoIZ3JvdXBfaWQYASAB",
            "KA0SLwoOcmVmcmVzaF9lbnRpdHkYDiADKAsyFy5TY2VuZUVudGl0eVJlZnJl",
            "c2hJbmZvEiwKDHJlZnJlc2hfdHlwZRgHIAEoDjIWLlNjZW5lR3JvdXBSZWZy",
            "ZXNoVHlwZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneGroupRefreshTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GroupRefreshInfo), global::EggLink.DanhengServer.Proto.GroupRefreshInfo.Parser, new[]{ "State", "GroupId", "RefreshEntity", "RefreshType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GroupRefreshInfo : pb::IMessage<GroupRefreshInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupRefreshInfo> _parser = new pb::MessageParser<GroupRefreshInfo>(() => new GroupRefreshInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupRefreshInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GroupRefreshInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupRefreshInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupRefreshInfo(GroupRefreshInfo other) : this() {
      state_ = other.state_;
      groupId_ = other.groupId_;
      refreshEntity_ = other.refreshEntity_.Clone();
      refreshType_ = other.refreshType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupRefreshInfo Clone() {
      return new GroupRefreshInfo(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private uint state_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 1;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "refresh_entity" field.</summary>
    public const int RefreshEntityFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfo> _repeated_refreshEntity_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfo> refreshEntity_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfo> RefreshEntity {
      get { return refreshEntity_; }
    }

    /// <summary>Field number for the "refresh_type" field.</summary>
    public const int RefreshTypeFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.SceneGroupRefreshType refreshType_ = global::EggLink.DanhengServer.Proto.SceneGroupRefreshType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneGroupRefreshType RefreshType {
      get { return refreshType_; }
      set {
        refreshType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupRefreshInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupRefreshInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      if (GroupId != other.GroupId) return false;
      if(!refreshEntity_.Equals(other.refreshEntity_)) return false;
      if (RefreshType != other.RefreshType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (State != 0) hash ^= State.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      hash ^= refreshEntity_.GetHashCode();
      if (RefreshType != global::EggLink.DanhengServer.Proto.SceneGroupRefreshType.None) hash ^= RefreshType.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GroupId);
      }
      if (State != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(State);
      }
      if (RefreshType != global::EggLink.DanhengServer.Proto.SceneGroupRefreshType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) RefreshType);
      }
      refreshEntity_.WriteTo(output, _repeated_refreshEntity_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GroupId);
      }
      if (State != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(State);
      }
      if (RefreshType != global::EggLink.DanhengServer.Proto.SceneGroupRefreshType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) RefreshType);
      }
      refreshEntity_.WriteTo(ref output, _repeated_refreshEntity_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(State);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      size += refreshEntity_.CalculateSize(_repeated_refreshEntity_codec);
      if (RefreshType != global::EggLink.DanhengServer.Proto.SceneGroupRefreshType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RefreshType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupRefreshInfo other) {
      if (other == null) {
        return;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      refreshEntity_.Add(other.refreshEntity_);
      if (other.RefreshType != global::EggLink.DanhengServer.Proto.SceneGroupRefreshType.None) {
        RefreshType = other.RefreshType;
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
          case 8: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 32: {
            State = input.ReadUInt32();
            break;
          }
          case 56: {
            RefreshType = (global::EggLink.DanhengServer.Proto.SceneGroupRefreshType) input.ReadEnum();
            break;
          }
          case 114: {
            refreshEntity_.AddEntriesFrom(input, _repeated_refreshEntity_codec);
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
          case 8: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 32: {
            State = input.ReadUInt32();
            break;
          }
          case 56: {
            RefreshType = (global::EggLink.DanhengServer.Proto.SceneGroupRefreshType) input.ReadEnum();
            break;
          }
          case 114: {
            refreshEntity_.AddEntriesFrom(ref input, _repeated_refreshEntity_codec);
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