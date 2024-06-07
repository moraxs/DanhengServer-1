// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CellInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CellInfo.proto</summary>
  public static partial class CellInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CellInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CellInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5DZWxsSW5mby5wcm90bxoUQ2hlc3NSb2d1ZUNlbGwucHJvdG8ifQoIQ2Vs",
            "bEluZm8SEwoLR0xOUExMQUJIRlAYDiABKA0SIgoJY2VsbF9saXN0GAsgAygL",
            "Mg8uQ2hlc3NSb2d1ZUNlbGwSEwoLQUlJTklES09BTkQYBiABKA0SEwoLQ0hE",
            "R0ZIS0FOT0QYBCABKA0SDgoGY3VyX2lkGAwgASgNQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueCellReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CellInfo), global::EggLink.DanhengServer.Proto.CellInfo.Parser, new[]{ "GLNPLLABHFP", "CellList", "AIINIDKOAND", "CHDGFHKANOD", "CurId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CellInfo : pb::IMessage<CellInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CellInfo> _parser = new pb::MessageParser<CellInfo>(() => new CellInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CellInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CellInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellInfo(CellInfo other) : this() {
      gLNPLLABHFP_ = other.gLNPLLABHFP_;
      cellList_ = other.cellList_.Clone();
      aIINIDKOAND_ = other.aIINIDKOAND_;
      cHDGFHKANOD_ = other.cHDGFHKANOD_;
      curId_ = other.curId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellInfo Clone() {
      return new CellInfo(this);
    }

    /// <summary>Field number for the "GLNPLLABHFP" field.</summary>
    public const int GLNPLLABHFPFieldNumber = 14;
    private uint gLNPLLABHFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GLNPLLABHFP {
      get { return gLNPLLABHFP_; }
      set {
        gLNPLLABHFP_ = value;
      }
    }

    /// <summary>Field number for the "cell_list" field.</summary>
    public const int CellListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueCell> _repeated_cellList_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.ChessRogueCell.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueCell> cellList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueCell>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueCell> CellList {
      get { return cellList_; }
    }

    /// <summary>Field number for the "AIINIDKOAND" field.</summary>
    public const int AIINIDKOANDFieldNumber = 6;
    private uint aIINIDKOAND_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AIINIDKOAND {
      get { return aIINIDKOAND_; }
      set {
        aIINIDKOAND_ = value;
      }
    }

    /// <summary>Field number for the "CHDGFHKANOD" field.</summary>
    public const int CHDGFHKANODFieldNumber = 4;
    private uint cHDGFHKANOD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CHDGFHKANOD {
      get { return cHDGFHKANOD_; }
      set {
        cHDGFHKANOD_ = value;
      }
    }

    /// <summary>Field number for the "cur_id" field.</summary>
    public const int CurIdFieldNumber = 12;
    private uint curId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurId {
      get { return curId_; }
      set {
        curId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CellInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CellInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GLNPLLABHFP != other.GLNPLLABHFP) return false;
      if(!cellList_.Equals(other.cellList_)) return false;
      if (AIINIDKOAND != other.AIINIDKOAND) return false;
      if (CHDGFHKANOD != other.CHDGFHKANOD) return false;
      if (CurId != other.CurId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GLNPLLABHFP != 0) hash ^= GLNPLLABHFP.GetHashCode();
      hash ^= cellList_.GetHashCode();
      if (AIINIDKOAND != 0) hash ^= AIINIDKOAND.GetHashCode();
      if (CHDGFHKANOD != 0) hash ^= CHDGFHKANOD.GetHashCode();
      if (CurId != 0) hash ^= CurId.GetHashCode();
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
      if (CHDGFHKANOD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CHDGFHKANOD);
      }
      if (AIINIDKOAND != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AIINIDKOAND);
      }
      cellList_.WriteTo(output, _repeated_cellList_codec);
      if (CurId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurId);
      }
      if (GLNPLLABHFP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GLNPLLABHFP);
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
      if (CHDGFHKANOD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CHDGFHKANOD);
      }
      if (AIINIDKOAND != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AIINIDKOAND);
      }
      cellList_.WriteTo(ref output, _repeated_cellList_codec);
      if (CurId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurId);
      }
      if (GLNPLLABHFP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GLNPLLABHFP);
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
      if (GLNPLLABHFP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GLNPLLABHFP);
      }
      size += cellList_.CalculateSize(_repeated_cellList_codec);
      if (AIINIDKOAND != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AIINIDKOAND);
      }
      if (CHDGFHKANOD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CHDGFHKANOD);
      }
      if (CurId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CellInfo other) {
      if (other == null) {
        return;
      }
      if (other.GLNPLLABHFP != 0) {
        GLNPLLABHFP = other.GLNPLLABHFP;
      }
      cellList_.Add(other.cellList_);
      if (other.AIINIDKOAND != 0) {
        AIINIDKOAND = other.AIINIDKOAND;
      }
      if (other.CHDGFHKANOD != 0) {
        CHDGFHKANOD = other.CHDGFHKANOD;
      }
      if (other.CurId != 0) {
        CurId = other.CurId;
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
          case 32: {
            CHDGFHKANOD = input.ReadUInt32();
            break;
          }
          case 48: {
            AIINIDKOAND = input.ReadUInt32();
            break;
          }
          case 90: {
            cellList_.AddEntriesFrom(input, _repeated_cellList_codec);
            break;
          }
          case 96: {
            CurId = input.ReadUInt32();
            break;
          }
          case 112: {
            GLNPLLABHFP = input.ReadUInt32();
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
          case 32: {
            CHDGFHKANOD = input.ReadUInt32();
            break;
          }
          case 48: {
            AIINIDKOAND = input.ReadUInt32();
            break;
          }
          case 90: {
            cellList_.AddEntriesFrom(ref input, _repeated_cellList_codec);
            break;
          }
          case 96: {
            CurId = input.ReadUInt32();
            break;
          }
          case 112: {
            GLNPLLABHFP = input.ReadUInt32();
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