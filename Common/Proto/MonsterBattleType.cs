// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonsterBattleType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonsterBattleType.proto</summary>
  public static partial class MonsterBattleTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MonsterBattleType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterBattleTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdNb25zdGVyQmF0dGxlVHlwZS5wcm90byrgAQoRTW9uc3RlckJhdHRsZVR5",
            "cGUSHAoYTU9OU1RFUl9CQVRUTEVfVFlQRV9OT05FEAASJgoiTU9OU1RFUl9C",
            "QVRUTEVfVFlQRV9UUklHR0VSX0JBVFRMRRABEjIKLk1PTlNURVJfQkFUVExF",
            "X1RZUEVfRElSRUNUX0RJRV9TSU1VTEFURV9CQVRUTEUQAhIuCipNT05TVEVS",
            "X0JBVFRMRV9UWVBFX0RJUkVDVF9ESUVfU0tJUF9CQVRUTEUQAxIhCh1NT05T",
            "VEVSX0JBVFRMRV9UWVBFX05PX0JBVFRMRRAEQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.MonsterBattleType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MonsterBattleType {
    [pbr::OriginalName("MONSTER_BATTLE_TYPE_NONE")] None = 0,
    [pbr::OriginalName("MONSTER_BATTLE_TYPE_TRIGGER_BATTLE")] TriggerBattle = 1,
    [pbr::OriginalName("MONSTER_BATTLE_TYPE_DIRECT_DIE_SIMULATE_BATTLE")] DirectDieSimulateBattle = 2,
    [pbr::OriginalName("MONSTER_BATTLE_TYPE_DIRECT_DIE_SKIP_BATTLE")] DirectDieSkipBattle = 3,
    [pbr::OriginalName("MONSTER_BATTLE_TYPE_NO_BATTLE")] NoBattle = 4,
  }

  #endregion

}

#endregion Designer generated code