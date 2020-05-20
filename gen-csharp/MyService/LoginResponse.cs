/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace MyService
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class LoginResponse : TBase
  {
    private string _session_key;
    private bool _newbee;

    /// <summary>
    /// 세션키
    /// </summary>
    public string Session_key
    {
      get
      {
        return _session_key;
      }
      set
      {
        __isset.session_key = true;
        this._session_key = value;
      }
    }

    /// <summary>
    /// 신규 가입자인지 여부
    /// </summary>
    public bool Newbee
    {
      get
      {
        return _newbee;
      }
      set
      {
        __isset.newbee = true;
        this._newbee = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool session_key;
      public bool newbee;
    }

    public LoginResponse() {
      this._session_key = "1234";
      this.__isset.session_key = true;
      this._newbee = false;
      this.__isset.newbee = true;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Session_key = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Bool) {
                Newbee = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("LoginResponse");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Session_key != null && __isset.session_key) {
          field.Name = "session_key";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Session_key);
          oprot.WriteFieldEnd();
        }
        if (__isset.newbee) {
          field.Name = "newbee";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Newbee);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("LoginResponse(");
      bool __first = true;
      if (Session_key != null && __isset.session_key) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Session_key: ");
        __sb.Append(Session_key);
      }
      if (__isset.newbee) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Newbee: ");
        __sb.Append(Newbee);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
