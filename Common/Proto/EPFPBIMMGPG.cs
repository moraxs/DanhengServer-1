// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EPFPBIMMGPG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EPFPBIMMGPG.proto</summary>
  public static partial class EPFPBIMMGPGReflection {

    #region Descriptor
    /// <summary>File descriptor for EPFPBIMMGPG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EPFPBIMMGPGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFUEZQQklNTUdQRy5wcm90bxoRSUZOT0VGTkVDREIucHJvdG8aEU9FQURI",
            "QU9BQUJKLnByb3RvGhFFRUVJRU1QUElQTC5wcm90bxoRQUlHRU5MQlBPQ0Qu",
            "cHJvdG8aEUFFTU1CSE5QQ0VELnByb3RvIrwBCgtFUEZQQklNTUdQRxIhCgtD",
            "SExDT0VIS0lCTRgNIAEoCzIMLklGTk9FRk5FQ0RCEiEKC0ZMS0pCUEpETlBD",
            "GAsgASgLMgwuT0VBREhBT0FBQkoSIQoLQ0xLTENQREJJQ0kYByABKAsyDC5B",
            "RU1NQkhOUENFRBIhCgtFSVBOUENMT0hETRgJIAEoCzIMLkVFRUlFTVBQSVBM",
            "EiEKC1BQR0tFQUlJQUxOGAogASgLMgwuQUlHRU5MQlBPQ0RCHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.IFNOEFNECDBReflection.Descriptor, global::EggLink.DanhengServer.Proto.OEADHAOAABJReflection.Descriptor, global::EggLink.DanhengServer.Proto.EEEIEMPPIPLReflection.Descriptor, global::EggLink.DanhengServer.Proto.AIGENLBPOCDReflection.Descriptor, global::EggLink.DanhengServer.Proto.AEMMBHNPCEDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EPFPBIMMGPG), global::EggLink.DanhengServer.Proto.EPFPBIMMGPG.Parser, new[]{ "CHLCOEHKIBM", "FLKJBPJDNPC", "CLKLCPDBICI", "EIPNPCLOHDM", "PPGKEAIIALN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EPFPBIMMGPG : pb::IMessage<EPFPBIMMGPG>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EPFPBIMMGPG> _parser = new pb::MessageParser<EPFPBIMMGPG>(() => new EPFPBIMMGPG());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EPFPBIMMGPG> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EPFPBIMMGPGReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EPFPBIMMGPG() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EPFPBIMMGPG(EPFPBIMMGPG other) : this() {
      cHLCOEHKIBM_ = other.cHLCOEHKIBM_ != null ? other.cHLCOEHKIBM_.Clone() : null;
      fLKJBPJDNPC_ = other.fLKJBPJDNPC_ != null ? other.fLKJBPJDNPC_.Clone() : null;
      cLKLCPDBICI_ = other.cLKLCPDBICI_ != null ? other.cLKLCPDBICI_.Clone() : null;
      eIPNPCLOHDM_ = other.eIPNPCLOHDM_ != null ? other.eIPNPCLOHDM_.Clone() : null;
      pPGKEAIIALN_ = other.pPGKEAIIALN_ != null ? other.pPGKEAIIALN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EPFPBIMMGPG Clone() {
      return new EPFPBIMMGPG(this);
    }

    /// <summary>Field number for the "CHLCOEHKIBM" field.</summary>
    public const int CHLCOEHKIBMFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.IFNOEFNECDB cHLCOEHKIBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IFNOEFNECDB CHLCOEHKIBM {
      get { return cHLCOEHKIBM_; }
      set {
        cHLCOEHKIBM_ = value;
      }
    }

    /// <summary>Field number for the "FLKJBPJDNPC" field.</summary>
    public const int FLKJBPJDNPCFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.OEADHAOAABJ fLKJBPJDNPC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OEADHAOAABJ FLKJBPJDNPC {
      get { return fLKJBPJDNPC_; }
      set {
        fLKJBPJDNPC_ = value;
      }
    }

    /// <summary>Field number for the "CLKLCPDBICI" field.</summary>
    public const int CLKLCPDBICIFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.AEMMBHNPCED cLKLCPDBICI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AEMMBHNPCED CLKLCPDBICI {
      get { return cLKLCPDBICI_; }
      set {
        cLKLCPDBICI_ = value;
      }
    }

    /// <summary>Field number for the "EIPNPCLOHDM" field.</summary>
    public const int EIPNPCLOHDMFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.EEEIEMPPIPL eIPNPCLOHDM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EEEIEMPPIPL EIPNPCLOHDM {
      get { return eIPNPCLOHDM_; }
      set {
        eIPNPCLOHDM_ = value;
      }
    }

    /// <summary>Field number for the "PPGKEAIIALN" field.</summary>
    public const int PPGKEAIIALNFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.AIGENLBPOCD pPGKEAIIALN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AIGENLBPOCD PPGKEAIIALN {
      get { return pPGKEAIIALN_; }
      set {
        pPGKEAIIALN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EPFPBIMMGPG);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EPFPBIMMGPG other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CHLCOEHKIBM, other.CHLCOEHKIBM)) return false;
      if (!object.Equals(FLKJBPJDNPC, other.FLKJBPJDNPC)) return false;
      if (!object.Equals(CLKLCPDBICI, other.CLKLCPDBICI)) return false;
      if (!object.Equals(EIPNPCLOHDM, other.EIPNPCLOHDM)) return false;
      if (!object.Equals(PPGKEAIIALN, other.PPGKEAIIALN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cHLCOEHKIBM_ != null) hash ^= CHLCOEHKIBM.GetHashCode();
      if (fLKJBPJDNPC_ != null) hash ^= FLKJBPJDNPC.GetHashCode();
      if (cLKLCPDBICI_ != null) hash ^= CLKLCPDBICI.GetHashCode();
      if (eIPNPCLOHDM_ != null) hash ^= EIPNPCLOHDM.GetHashCode();
      if (pPGKEAIIALN_ != null) hash ^= PPGKEAIIALN.GetHashCode();
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
      if (cLKLCPDBICI_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CLKLCPDBICI);
      }
      if (eIPNPCLOHDM_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EIPNPCLOHDM);
      }
      if (pPGKEAIIALN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PPGKEAIIALN);
      }
      if (fLKJBPJDNPC_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(FLKJBPJDNPC);
      }
      if (cHLCOEHKIBM_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CHLCOEHKIBM);
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
      if (cLKLCPDBICI_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CLKLCPDBICI);
      }
      if (eIPNPCLOHDM_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EIPNPCLOHDM);
      }
      if (pPGKEAIIALN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PPGKEAIIALN);
      }
      if (fLKJBPJDNPC_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(FLKJBPJDNPC);
      }
      if (cHLCOEHKIBM_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CHLCOEHKIBM);
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
      if (cHLCOEHKIBM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CHLCOEHKIBM);
      }
      if (fLKJBPJDNPC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FLKJBPJDNPC);
      }
      if (cLKLCPDBICI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CLKLCPDBICI);
      }
      if (eIPNPCLOHDM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EIPNPCLOHDM);
      }
      if (pPGKEAIIALN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PPGKEAIIALN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EPFPBIMMGPG other) {
      if (other == null) {
        return;
      }
      if (other.cHLCOEHKIBM_ != null) {
        if (cHLCOEHKIBM_ == null) {
          CHLCOEHKIBM = new global::EggLink.DanhengServer.Proto.IFNOEFNECDB();
        }
        CHLCOEHKIBM.MergeFrom(other.CHLCOEHKIBM);
      }
      if (other.fLKJBPJDNPC_ != null) {
        if (fLKJBPJDNPC_ == null) {
          FLKJBPJDNPC = new global::EggLink.DanhengServer.Proto.OEADHAOAABJ();
        }
        FLKJBPJDNPC.MergeFrom(other.FLKJBPJDNPC);
      }
      if (other.cLKLCPDBICI_ != null) {
        if (cLKLCPDBICI_ == null) {
          CLKLCPDBICI = new global::EggLink.DanhengServer.Proto.AEMMBHNPCED();
        }
        CLKLCPDBICI.MergeFrom(other.CLKLCPDBICI);
      }
      if (other.eIPNPCLOHDM_ != null) {
        if (eIPNPCLOHDM_ == null) {
          EIPNPCLOHDM = new global::EggLink.DanhengServer.Proto.EEEIEMPPIPL();
        }
        EIPNPCLOHDM.MergeFrom(other.EIPNPCLOHDM);
      }
      if (other.pPGKEAIIALN_ != null) {
        if (pPGKEAIIALN_ == null) {
          PPGKEAIIALN = new global::EggLink.DanhengServer.Proto.AIGENLBPOCD();
        }
        PPGKEAIIALN.MergeFrom(other.PPGKEAIIALN);
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
          case 58: {
            if (cLKLCPDBICI_ == null) {
              CLKLCPDBICI = new global::EggLink.DanhengServer.Proto.AEMMBHNPCED();
            }
            input.ReadMessage(CLKLCPDBICI);
            break;
          }
          case 74: {
            if (eIPNPCLOHDM_ == null) {
              EIPNPCLOHDM = new global::EggLink.DanhengServer.Proto.EEEIEMPPIPL();
            }
            input.ReadMessage(EIPNPCLOHDM);
            break;
          }
          case 82: {
            if (pPGKEAIIALN_ == null) {
              PPGKEAIIALN = new global::EggLink.DanhengServer.Proto.AIGENLBPOCD();
            }
            input.ReadMessage(PPGKEAIIALN);
            break;
          }
          case 90: {
            if (fLKJBPJDNPC_ == null) {
              FLKJBPJDNPC = new global::EggLink.DanhengServer.Proto.OEADHAOAABJ();
            }
            input.ReadMessage(FLKJBPJDNPC);
            break;
          }
          case 106: {
            if (cHLCOEHKIBM_ == null) {
              CHLCOEHKIBM = new global::EggLink.DanhengServer.Proto.IFNOEFNECDB();
            }
            input.ReadMessage(CHLCOEHKIBM);
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
          case 58: {
            if (cLKLCPDBICI_ == null) {
              CLKLCPDBICI = new global::EggLink.DanhengServer.Proto.AEMMBHNPCED();
            }
            input.ReadMessage(CLKLCPDBICI);
            break;
          }
          case 74: {
            if (eIPNPCLOHDM_ == null) {
              EIPNPCLOHDM = new global::EggLink.DanhengServer.Proto.EEEIEMPPIPL();
            }
            input.ReadMessage(EIPNPCLOHDM);
            break;
          }
          case 82: {
            if (pPGKEAIIALN_ == null) {
              PPGKEAIIALN = new global::EggLink.DanhengServer.Proto.AIGENLBPOCD();
            }
            input.ReadMessage(PPGKEAIIALN);
            break;
          }
          case 90: {
            if (fLKJBPJDNPC_ == null) {
              FLKJBPJDNPC = new global::EggLink.DanhengServer.Proto.OEADHAOAABJ();
            }
            input.ReadMessage(FLKJBPJDNPC);
            break;
          }
          case 106: {
            if (cHLCOEHKIBM_ == null) {
              CHLCOEHKIBM = new global::EggLink.DanhengServer.Proto.IFNOEFNECDB();
            }
            input.ReadMessage(CHLCOEHKIBM);
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