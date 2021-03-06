/**
 * Autogenerated by Thrift Compiler (0.12.0)
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

public partial class LocationService {
  public interface ISync {
    List<PositionViewEntity> getAllPositionInfo(string param);
    string getLocationInfoIncremental(string param);
  }

  public interface Iface : ISync {
    #if SILVERLIGHT
    IAsyncResult Begin_getAllPositionInfo(AsyncCallback callback, object state, string param);
    List<PositionViewEntity> End_getAllPositionInfo(IAsyncResult asyncResult);
    #endif
    #if SILVERLIGHT
    IAsyncResult Begin_getLocationInfoIncremental(AsyncCallback callback, object state, string param);
    string End_getLocationInfoIncremental(IAsyncResult asyncResult);
    #endif
  }

  public class Client : IDisposable, Iface {
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
    
    public IAsyncResult Begin_getAllPositionInfo(AsyncCallback callback, object state, string param)
    {
      return send_getAllPositionInfo(callback, state, param);
    }

    public List<PositionViewEntity> End_getAllPositionInfo(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_getAllPositionInfo();
    }

    #endif

    public List<PositionViewEntity> getAllPositionInfo(string param)
    {
      #if SILVERLIGHT
      var asyncResult = Begin_getAllPositionInfo(null, null, param);
      return End_getAllPositionInfo(asyncResult);

      #else
      send_getAllPositionInfo(param);
      return recv_getAllPositionInfo();

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_getAllPositionInfo(AsyncCallback callback, object state, string param)
    {
      oprot_.WriteMessageBegin(new TMessage("getAllPositionInfo", TMessageType.Call, seqid_));
      getAllPositionInfo_args args = new getAllPositionInfo_args();
      args.Param = param;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      return oprot_.Transport.BeginFlush(callback, state);
    }

    #else

    public void send_getAllPositionInfo(string param)
    {
      oprot_.WriteMessageBegin(new TMessage("getAllPositionInfo", TMessageType.Call, seqid_));
      getAllPositionInfo_args args = new getAllPositionInfo_args();
      args.Param = param;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      oprot_.Transport.Flush();
    }
    #endif

    public List<PositionViewEntity> recv_getAllPositionInfo()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      getAllPositionInfo_result result = new getAllPositionInfo_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "getAllPositionInfo failed: unknown result");
    }

    
    #if SILVERLIGHT
    
    public IAsyncResult Begin_getLocationInfoIncremental(AsyncCallback callback, object state, string param)
    {
      return send_getLocationInfoIncremental(callback, state, param);
    }

    public string End_getLocationInfoIncremental(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_getLocationInfoIncremental();
    }

    #endif

    public string getLocationInfoIncremental(string param)
    {
      #if SILVERLIGHT
      var asyncResult = Begin_getLocationInfoIncremental(null, null, param);
      return End_getLocationInfoIncremental(asyncResult);

      #else
      send_getLocationInfoIncremental(param);
      return recv_getLocationInfoIncremental();

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_getLocationInfoIncremental(AsyncCallback callback, object state, string param)
    {
      oprot_.WriteMessageBegin(new TMessage("getLocationInfoIncremental", TMessageType.Call, seqid_));
      getLocationInfoIncremental_args args = new getLocationInfoIncremental_args();
      args.Param = param;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      return oprot_.Transport.BeginFlush(callback, state);
    }

    #else

    public void send_getLocationInfoIncremental(string param)
    {
      oprot_.WriteMessageBegin(new TMessage("getLocationInfoIncremental", TMessageType.Call, seqid_));
      getLocationInfoIncremental_args args = new getLocationInfoIncremental_args();
      args.Param = param;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      oprot_.Transport.Flush();
    }
    #endif

    public string recv_getLocationInfoIncremental()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      getLocationInfoIncremental_result result = new getLocationInfoIncremental_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "getLocationInfoIncremental failed: unknown result");
    }

  }
  public class Processor : TProcessor {
    public Processor(ISync iface)
    {
      iface_ = iface;
      processMap_["getAllPositionInfo"] = getAllPositionInfo_Process;
      processMap_["getLocationInfoIncremental"] = getLocationInfoIncremental_Process;
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
        if (fn == null) {
          TProtocolUtil.Skip(iprot, TType.Struct);
          iprot.ReadMessageEnd();
          TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
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

    public void getAllPositionInfo_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      getAllPositionInfo_args args = new getAllPositionInfo_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      getAllPositionInfo_result result = new getAllPositionInfo_result();
      try
      {
        result.Success = iface_.getAllPositionInfo(args.Param);
        oprot.WriteMessageBegin(new TMessage("getAllPositionInfo", TMessageType.Reply, seqid)); 
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
        TApplicationException x = new TApplicationException      (TApplicationException.ExceptionType.InternalError," Internal error.");
        oprot.WriteMessageBegin(new TMessage("getAllPositionInfo", TMessageType.Exception, seqid));
        x.Write(oprot);
      }
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void getLocationInfoIncremental_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      getLocationInfoIncremental_args args = new getLocationInfoIncremental_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      getLocationInfoIncremental_result result = new getLocationInfoIncremental_result();
      try
      {
        result.Success = iface_.getLocationInfoIncremental(args.Param);
        oprot.WriteMessageBegin(new TMessage("getLocationInfoIncremental", TMessageType.Reply, seqid)); 
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
        TApplicationException x = new TApplicationException      (TApplicationException.ExceptionType.InternalError," Internal error.");
        oprot.WriteMessageBegin(new TMessage("getLocationInfoIncremental", TMessageType.Exception, seqid));
        x.Write(oprot);
      }
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getAllPositionInfo_args : TBase
  {
    private string _param;

    public string Param
    {
      get
      {
        return _param;
      }
      set
      {
        __isset.param = true;
        this._param = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool param;
    }

    public getAllPositionInfo_args() {
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
                Param = iprot.ReadString();
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
        TStruct struc = new TStruct("getAllPositionInfo_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Param != null && __isset.param) {
          field.Name = "param";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Param);
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
      StringBuilder __sb = new StringBuilder("getAllPositionInfo_args(");
      bool __first = true;
      if (Param != null && __isset.param) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Param: ");
        __sb.Append(Param);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getAllPositionInfo_result : TBase
  {
    private List<PositionViewEntity> _success;

    public List<PositionViewEntity> Success
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
    public struct Isset {
      public bool success;
    }

    public getAllPositionInfo_result() {
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
            case 0:
              if (field.Type == TType.List) {
                {
                  Success = new List<PositionViewEntity>();
                  TList _list4 = iprot.ReadListBegin();
                  for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                  {
                    PositionViewEntity _elem6;
                    _elem6 = new PositionViewEntity();
                    _elem6.Read(iprot);
                    Success.Add(_elem6);
                  }
                  iprot.ReadListEnd();
                }
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
        TStruct struc = new TStruct("getAllPositionInfo_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          if (Success != null) {
            field.Name = "Success";
            field.Type = TType.List;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            {
              oprot.WriteListBegin(new TList(TType.Struct, Success.Count));
              foreach (PositionViewEntity _iter7 in Success)
              {
                _iter7.Write(oprot);
              }
              oprot.WriteListEnd();
            }
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

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("getAllPositionInfo_result(");
      bool __first = true;
      if (Success != null && __isset.success) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Success: ");
        __sb.Append(Success);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getLocationInfoIncremental_args : TBase
  {
    private string _param;

    public string Param
    {
      get
      {
        return _param;
      }
      set
      {
        __isset.param = true;
        this._param = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool param;
    }

    public getLocationInfoIncremental_args() {
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
                Param = iprot.ReadString();
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
        TStruct struc = new TStruct("getLocationInfoIncremental_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Param != null && __isset.param) {
          field.Name = "param";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Param);
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
      StringBuilder __sb = new StringBuilder("getLocationInfoIncremental_args(");
      bool __first = true;
      if (Param != null && __isset.param) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Param: ");
        __sb.Append(Param);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class getLocationInfoIncremental_result : TBase
  {
    private string _success;

    public string Success
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
    public struct Isset {
      public bool success;
    }

    public getLocationInfoIncremental_result() {
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
            case 0:
              if (field.Type == TType.String) {
                Success = iprot.ReadString();
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
        TStruct struc = new TStruct("getLocationInfoIncremental_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          if (Success != null) {
            field.Name = "Success";
            field.Type = TType.String;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Success);
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

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("getLocationInfoIncremental_result(");
      bool __first = true;
      if (Success != null && __isset.success) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Success: ");
        __sb.Append(Success);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
