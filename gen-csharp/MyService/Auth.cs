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
    public partial class Auth
    {
        public interface ISync
        {
            /// <summary>
            /// API 서버에게 로그인을 요청합니다.
            /// </summary>
            /// <param name="request"></param>
            LoginResponse Login(LoginRequest request);
            /// <summary>
            /// API 서버에게 로그아웃을 요청합니다.
            /// </summary>
            /// <param name="request"></param>
            LogoutResponse Logout(LogoutRequest request);
        }

        public interface Iface : ISync
        {
            /// <summary>
            /// API 서버에게 로그인을 요청합니다.
            /// </summary>
            /// <param name="request"></param>
#if SILVERLIGHT
      IAsyncResult Begin_Login(AsyncCallback callback, object state, LoginRequest request);
      LoginResponse End_Login(IAsyncResult asyncResult);
#endif
            /// <summary>
            /// API 서버에게 로그아웃을 요청합니다.
            /// </summary>
            /// <param name="request"></param>
#if SILVERLIGHT
      IAsyncResult Begin_Logout(AsyncCallback callback, object state, LogoutRequest request);
      LogoutResponse End_Logout(IAsyncResult asyncResult);
#endif
        }

        public class Client : IDisposable, Iface
        {
            public Client(TProtocol prot) : this(prot, prot)
            {
            }

            public Client(TProtocol iprot, TProtocol oprot)
            {
                iprot_ = iprot;
                oprot_ = oprot;
            }

            protected TProtocol iprot_;
            protected TProtocol oprot_;
            protected int seqid_;

            public TProtocol InputProtocol
            {
                get { return iprot_; }
            }
            public TProtocol OutputProtocol
            {
                get { return oprot_; }
            }


            #region " IDisposable Support "
            private bool _IsDisposed;

            // IDisposable
            public void Dispose()
            {
                Dispose(true);
            }


            protected virtual void Dispose(bool disposing)
            {
                if (!_IsDisposed)
                {
                    if (disposing)
                    {
                        if (iprot_ != null)
                        {
                            ((IDisposable)iprot_).Dispose();
                        }
                        if (oprot_ != null)
                        {
                            ((IDisposable)oprot_).Dispose();
                        }
                    }
                }
                _IsDisposed = true;
            }
            #endregion



#if SILVERLIGHT
      
      public IAsyncResult Begin_Login(AsyncCallback callback, object state, LoginRequest request)
      {
        return send_Login(callback, state, request);
      }

      public LoginResponse End_Login(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_Login();
      }

#endif

            /// <summary>
            /// API 서버에게 로그인을 요청합니다.
            /// </summary>
            /// <param name="request"></param>
            public LoginResponse Login(LoginRequest request)
            {
#if SILVERLIGHT
        var asyncResult = Begin_Login(null, null, request);
        return End_Login(asyncResult);

#else
                send_Login(request);
                return recv_Login();

#endif
            }
#if SILVERLIGHT
      public IAsyncResult send_Login(AsyncCallback callback, object state, LoginRequest request)
      {
        oprot_.WriteMessageBegin(new TMessage("Login", TMessageType.Call, seqid_));
        Login_args args = new Login_args();
        args.Request = request;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        return oprot_.Transport.BeginFlush(callback, state);
      }

#else

            public void send_Login(LoginRequest request)
            {
                oprot_.WriteMessageBegin(new TMessage("Login", TMessageType.Call, seqid_));
                Login_args args = new Login_args();
                args.Request = request;
                args.Write(oprot_);
                oprot_.WriteMessageEnd();
                oprot_.Transport.Flush();
            }
#endif

            public LoginResponse recv_Login()
            {
                TMessage msg = iprot_.ReadMessageBegin();
                if (msg.Type == TMessageType.Exception)
                {
                    TApplicationException x = TApplicationException.Read(iprot_);
                    iprot_.ReadMessageEnd();
                    throw x;
                }
                Login_result result = new Login_result();
                result.Read(iprot_);
                iprot_.ReadMessageEnd();
                if (result.__isset.success)
                {
                    return result.Success;
                }
                throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "Login failed: unknown result");
            }


#if SILVERLIGHT
      
      public IAsyncResult Begin_Logout(AsyncCallback callback, object state, LogoutRequest request)
      {
        return send_Logout(callback, state, request);
      }

      public LogoutResponse End_Logout(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_Logout();
      }

#endif

            /// <summary>
            /// API 서버에게 로그아웃을 요청합니다.
            /// </summary>
            /// <param name="request"></param>
            public LogoutResponse Logout(LogoutRequest request)
            {
#if SILVERLIGHT
        var asyncResult = Begin_Logout(null, null, request);
        return End_Logout(asyncResult);

#else
                send_Logout(request);
                return recv_Logout();

#endif
            }
#if SILVERLIGHT
      public IAsyncResult send_Logout(AsyncCallback callback, object state, LogoutRequest request)
      {
        oprot_.WriteMessageBegin(new TMessage("Logout", TMessageType.Call, seqid_));
        Logout_args args = new Logout_args();
        args.Request = request;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        return oprot_.Transport.BeginFlush(callback, state);
      }

#else

            public void send_Logout(LogoutRequest request)
            {
                oprot_.WriteMessageBegin(new TMessage("Logout", TMessageType.Call, seqid_));
                Logout_args args = new Logout_args();
                args.Request = request;
                args.Write(oprot_);
                oprot_.WriteMessageEnd();
                oprot_.Transport.Flush();
            }
#endif

            public LogoutResponse recv_Logout()
            {
                TMessage msg = iprot_.ReadMessageBegin();
                if (msg.Type == TMessageType.Exception)
                {
                    TApplicationException x = TApplicationException.Read(iprot_);
                    iprot_.ReadMessageEnd();
                    throw x;
                }
                Logout_result result = new Logout_result();
                result.Read(iprot_);
                iprot_.ReadMessageEnd();
                if (result.__isset.success)
                {
                    return result.Success;
                }
                throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "Logout failed: unknown result");
            }

        }
        public class Processor : TProcessor
        {
            public Processor(ISync iface)
            {
                iface_ = iface;
                processMap_["Login"] = Login_Process;
                processMap_["Logout"] = Logout_Process;
            }

            protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
            private ISync iface_;
            protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

            public bool Process(TProtocol iprot, TProtocol oprot)
            {
                try
                {
                    TMessage msg = iprot.ReadMessageBegin();
                    ProcessFunction fn;
                    processMap_.TryGetValue(msg.Name, out fn);
                    if (fn == null)
                    {
                        TProtocolUtil.Skip(iprot, TType.Struct);
                        iprot.ReadMessageEnd();
                        TApplicationException x = new TApplicationException(TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
                        oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
                        x.Write(oprot);
                        oprot.WriteMessageEnd();
                        oprot.Transport.Flush();
                        return true;
                    }
                    fn(msg.SeqID, iprot, oprot);
                }
                catch (IOException)
                {
                    return false;
                }
                return true;
            }

            public void Login_Process(int seqid, TProtocol iprot, TProtocol oprot)
            {
                Login_args args = new Login_args();
                args.Read(iprot);
                iprot.ReadMessageEnd();
                Login_result result = new Login_result();
                try
                {
                    result.Success = iface_.Login(args.Request);
                    oprot.WriteMessageBegin(new TMessage("Login", TMessageType.Reply, seqid));
                    result.Write(oprot);
                }
                catch (TTransportException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error occurred in processor:");
                    Console.Error.WriteLine(ex.ToString());
                    TApplicationException x = new TApplicationException(TApplicationException.ExceptionType.InternalError, " Internal error.");
                    oprot.WriteMessageBegin(new TMessage("Login", TMessageType.Exception, seqid));
                    x.Write(oprot);
                }
                oprot.WriteMessageEnd();
                oprot.Transport.Flush();
            }

            public void Logout_Process(int seqid, TProtocol iprot, TProtocol oprot)
            {
                Logout_args args = new Logout_args();
                args.Read(iprot);
                iprot.ReadMessageEnd();
                Logout_result result = new Logout_result();
                try
                {
                    result.Success = iface_.Logout(args.Request);
                    oprot.WriteMessageBegin(new TMessage("Logout", TMessageType.Reply, seqid));
                    result.Write(oprot);
                }
                catch (TTransportException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error occurred in processor:");
                    Console.Error.WriteLine(ex.ToString());
                    TApplicationException x = new TApplicationException(TApplicationException.ExceptionType.InternalError, " Internal error.");
                    oprot.WriteMessageBegin(new TMessage("Logout", TMessageType.Exception, seqid));
                    x.Write(oprot);
                }
                oprot.WriteMessageEnd();
                oprot.Transport.Flush();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class Login_args : TBase
        {
            private LoginRequest _request;

            public LoginRequest Request
            {
                get
                {
                    return _request;
                }
                set
                {
                    __isset.request = true;
                    this._request = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool request;
            }

            public Login_args()
            {
            }

            public void Read(TProtocol iprot)
            {
                iprot.IncrementRecursionDepth();
                try
                {
                    TField field;
                    iprot.ReadStructBegin();
                    while (true)
                    {
                        field = iprot.ReadFieldBegin();
                        if (field.Type == TType.Stop)
                        {
                            break;
                        }
                        switch (field.ID)
                        {
                            case 1:
                                if (field.Type == TType.Struct)
                                {
                                    Request = new LoginRequest();
                                    Request.Read(iprot);
                                }
                                else
                                {
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

            public void Write(TProtocol oprot)
            {
                oprot.IncrementRecursionDepth();
                try
                {
                    TStruct struc = new TStruct("Login_args");
                    oprot.WriteStructBegin(struc);
                    TField field = new TField();
                    if (Request != null && __isset.request)
                    {
                        field.Name = "request";
                        field.Type = TType.Struct;
                        field.ID = 1;
                        oprot.WriteFieldBegin(field);
                        Request.Write(oprot);
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

            public override string ToString()
            {
                StringBuilder __sb = new StringBuilder("Login_args(");
                bool __first = true;
                if (Request != null && __isset.request)
                {
                    if (!__first) { __sb.Append(", "); }
                    __first = false;
                    __sb.Append("Request: ");
                    __sb.Append(Request == null ? "<null>" : Request.ToString());
                }
                __sb.Append(")");
                return __sb.ToString();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class Login_result : TBase
        {
            private LoginResponse _success;

            public LoginResponse Success
            {
                get
                {
                    return _success;
                }
                set
                {
                    __isset.success = true;
                    this._success = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool success;
            }

            public Login_result()
            {
            }

            public void Read(TProtocol iprot)
            {
                iprot.IncrementRecursionDepth();
                try
                {
                    TField field;
                    iprot.ReadStructBegin();
                    while (true)
                    {
                        field = iprot.ReadFieldBegin();
                        if (field.Type == TType.Stop)
                        {
                            break;
                        }
                        switch (field.ID)
                        {
                            case 0:
                                if (field.Type == TType.Struct)
                                {
                                    Success = new LoginResponse();
                                    Success.Read(iprot);
                                }
                                else
                                {
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

            public void Write(TProtocol oprot)
            {
                oprot.IncrementRecursionDepth();
                try
                {
                    TStruct struc = new TStruct("Login_result");
                    oprot.WriteStructBegin(struc);
                    TField field = new TField();

                    if (this.__isset.success)
                    {
                        if (Success != null)
                        {
                            field.Name = "Success";
                            field.Type = TType.Struct;
                            field.ID = 0;
                            oprot.WriteFieldBegin(field);
                            Success.Write(oprot);
                            oprot.WriteFieldEnd();
                        }
                    }
                    oprot.WriteFieldStop();
                    oprot.WriteStructEnd();
                }
                finally
                {
                    oprot.DecrementRecursionDepth();
                }
            }

            public override string ToString()
            {
                StringBuilder __sb = new StringBuilder("Login_result(");
                bool __first = true;
                if (Success != null && __isset.success)
                {
                    if (!__first) { __sb.Append(", "); }
                    __first = false;
                    __sb.Append("Success: ");
                    __sb.Append(Success == null ? "<null>" : Success.ToString());
                }
                __sb.Append(")");
                return __sb.ToString();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class Logout_args : TBase
        {
            private LogoutRequest _request;

            public LogoutRequest Request
            {
                get
                {
                    return _request;
                }
                set
                {
                    __isset.request = true;
                    this._request = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool request;
            }

            public Logout_args()
            {
            }

            public void Read(TProtocol iprot)
            {
                iprot.IncrementRecursionDepth();
                try
                {
                    TField field;
                    iprot.ReadStructBegin();
                    while (true)
                    {
                        field = iprot.ReadFieldBegin();
                        if (field.Type == TType.Stop)
                        {
                            break;
                        }
                        switch (field.ID)
                        {
                            case 1:
                                if (field.Type == TType.Struct)
                                {
                                    Request = new LogoutRequest();
                                    Request.Read(iprot);
                                }
                                else
                                {
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

            public void Write(TProtocol oprot)
            {
                oprot.IncrementRecursionDepth();
                try
                {
                    TStruct struc = new TStruct("Logout_args");
                    oprot.WriteStructBegin(struc);
                    TField field = new TField();
                    if (Request != null && __isset.request)
                    {
                        field.Name = "request";
                        field.Type = TType.Struct;
                        field.ID = 1;
                        oprot.WriteFieldBegin(field);
                        Request.Write(oprot);
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

            public override string ToString()
            {
                StringBuilder __sb = new StringBuilder("Logout_args(");
                bool __first = true;
                if (Request != null && __isset.request)
                {
                    if (!__first) { __sb.Append(", "); }
                    __first = false;
                    __sb.Append("Request: ");
                    __sb.Append(Request == null ? "<null>" : Request.ToString());
                }
                __sb.Append(")");
                return __sb.ToString();
            }

        }


#if !SILVERLIGHT
        [Serializable]
#endif
        public partial class Logout_result : TBase
        {
            private LogoutResponse _success;

            public LogoutResponse Success
            {
                get
                {
                    return _success;
                }
                set
                {
                    __isset.success = true;
                    this._success = value;
                }
            }


            public Isset __isset;
#if !SILVERLIGHT
            [Serializable]
#endif
            public struct Isset
            {
                public bool success;
            }

            public Logout_result()
            {
            }

            public void Read(TProtocol iprot)
            {
                iprot.IncrementRecursionDepth();
                try
                {
                    TField field;
                    iprot.ReadStructBegin();
                    while (true)
                    {
                        field = iprot.ReadFieldBegin();
                        if (field.Type == TType.Stop)
                        {
                            break;
                        }
                        switch (field.ID)
                        {
                            case 0:
                                if (field.Type == TType.Struct)
                                {
                                    Success = new LogoutResponse();
                                    Success.Read(iprot);
                                }
                                else
                                {
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

            public void Write(TProtocol oprot)
            {
                oprot.IncrementRecursionDepth();
                try
                {
                    TStruct struc = new TStruct("Logout_result");
                    oprot.WriteStructBegin(struc);
                    TField field = new TField();

                    if (this.__isset.success)
                    {
                        if (Success != null)
                        {
                            field.Name = "Success";
                            field.Type = TType.Struct;
                            field.ID = 0;
                            oprot.WriteFieldBegin(field);
                            Success.Write(oprot);
                            oprot.WriteFieldEnd();
                        }
                    }
                    oprot.WriteFieldStop();
                    oprot.WriteStructEnd();
                }
                finally
                {
                    oprot.DecrementRecursionDepth();
                }
            }

            public override string ToString()
            {
                StringBuilder __sb = new StringBuilder("Logout_result(");
                bool __first = true;
                if (Success != null && __isset.success)
                {
                    if (!__first) { __sb.Append(", "); }
                    __first = false;
                    __sb.Append("Success: ");
                    __sb.Append(Success == null ? "<null>" : Success.ToString());
                }
                __sb.Append(")");
                return __sb.ToString();
            }

        }

    }
}

