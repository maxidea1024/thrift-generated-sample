//
// Autogenerated by Thrift Compiler (0.13.0)
//
// DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
//
if (typeof Int64 === 'undefined' && typeof require === 'function') {
  var Int64 = require('node-int64');
}


//HELPER FUNCTIONS AND STRUCTURES

MyService.Auth_Login_args = function (args) {
  this.request = null;
  if (args) {
    if (args.request !== undefined && args.request !== null) {
      this.request = new MyService.LoginRequest(args.request);
    }
  }
};
MyService.Auth_Login_args.prototype = {};
MyService.Auth_Login_args.prototype.read = function (input) {
  input.readStructBegin();
  while (true) {
    var ret = input.readFieldBegin();
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid) {
      case 1:
        if (ftype == Thrift.Type.STRUCT) {
          this.request = new MyService.LoginRequest();
          this.request.read(input);
        } else {
          input.skip(ftype);
        }
        break;
      case 0:
        input.skip(ftype);
        break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

MyService.Auth_Login_args.prototype.write = function (output) {
  output.writeStructBegin('Auth_Login_args');
  if (this.request !== null && this.request !== undefined) {
    output.writeFieldBegin('request', Thrift.Type.STRUCT, 1);
    this.request.write(output);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

MyService.Auth_Login_result = function (args) {
  this.success = null;
  if (args) {
    if (args.success !== undefined && args.success !== null) {
      this.success = new MyService.LoginResponse(args.success);
    }
  }
};
MyService.Auth_Login_result.prototype = {};
MyService.Auth_Login_result.prototype.read = function (input) {
  input.readStructBegin();
  while (true) {
    var ret = input.readFieldBegin();
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid) {
      case 0:
        if (ftype == Thrift.Type.STRUCT) {
          this.success = new MyService.LoginResponse();
          this.success.read(input);
        } else {
          input.skip(ftype);
        }
        break;
      case 0:
        input.skip(ftype);
        break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

MyService.Auth_Login_result.prototype.write = function (output) {
  output.writeStructBegin('Auth_Login_result');
  if (this.success !== null && this.success !== undefined) {
    output.writeFieldBegin('success', Thrift.Type.STRUCT, 0);
    this.success.write(output);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

MyService.Auth_Logout_args = function (args) {
  this.request = null;
  if (args) {
    if (args.request !== undefined && args.request !== null) {
      this.request = new MyService.LogoutRequest(args.request);
    }
  }
};
MyService.Auth_Logout_args.prototype = {};
MyService.Auth_Logout_args.prototype.read = function (input) {
  input.readStructBegin();
  while (true) {
    var ret = input.readFieldBegin();
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid) {
      case 1:
        if (ftype == Thrift.Type.STRUCT) {
          this.request = new MyService.LogoutRequest();
          this.request.read(input);
        } else {
          input.skip(ftype);
        }
        break;
      case 0:
        input.skip(ftype);
        break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

MyService.Auth_Logout_args.prototype.write = function (output) {
  output.writeStructBegin('Auth_Logout_args');
  if (this.request !== null && this.request !== undefined) {
    output.writeFieldBegin('request', Thrift.Type.STRUCT, 1);
    this.request.write(output);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

MyService.Auth_Logout_result = function (args) {
  this.success = null;
  if (args) {
    if (args.success !== undefined && args.success !== null) {
      this.success = new MyService.LogoutResponse(args.success);
    }
  }
};
MyService.Auth_Logout_result.prototype = {};
MyService.Auth_Logout_result.prototype.read = function (input) {
  input.readStructBegin();
  while (true) {
    var ret = input.readFieldBegin();
    var ftype = ret.ftype;
    var fid = ret.fid;
    if (ftype == Thrift.Type.STOP) {
      break;
    }
    switch (fid) {
      case 0:
        if (ftype == Thrift.Type.STRUCT) {
          this.success = new MyService.LogoutResponse();
          this.success.read(input);
        } else {
          input.skip(ftype);
        }
        break;
      case 0:
        input.skip(ftype);
        break;
      default:
        input.skip(ftype);
    }
    input.readFieldEnd();
  }
  input.readStructEnd();
  return;
};

MyService.Auth_Logout_result.prototype.write = function (output) {
  output.writeStructBegin('Auth_Logout_result');
  if (this.success !== null && this.success !== undefined) {
    output.writeFieldBegin('success', Thrift.Type.STRUCT, 0);
    this.success.write(output);
    output.writeFieldEnd();
  }
  output.writeFieldStop();
  output.writeStructEnd();
  return;
};

MyService.AuthClient = function (input, output) {
  this.input = input;
  this.output = (!output) ? input : output;
  this.seqid = 0;
};
MyService.AuthClient.prototype = {};

MyService.AuthClient.prototype.Login = function (request, callback) {
  this.send_Login(request, callback);
  if (!callback) {
    return this.recv_Login();
  }
};

MyService.AuthClient.prototype.send_Login = function (request, callback) {
  var params = {
    request: request
  };
  var args = new MyService.Auth_Login_args(params);
  try {
    this.output.writeMessageBegin('Login', Thrift.MessageType.CALL, this.seqid);
    args.write(this.output);
    this.output.writeMessageEnd();
    if (callback) {
      var self = this;
      this.output.getTransport().flush(true, function () {
        var result = null;
        try {
          result = self.recv_Login();
        } catch (e) {
          result = e;
        }
        callback(result);
      });
    } else {
      return this.output.getTransport().flush();
    }
  }
  catch (e) {
    if (typeof this.output.getTransport().reset === 'function') {
      this.output.getTransport().reset();
    }
    throw e;
  }
};

MyService.AuthClient.prototype.recv_Login = function () {
  var ret = this.input.readMessageBegin();
  var mtype = ret.mtype;
  if (mtype == Thrift.MessageType.EXCEPTION) {
    var x = new Thrift.TApplicationException();
    x.read(this.input);
    this.input.readMessageEnd();
    throw x;
  }
  var result = new MyService.Auth_Login_result();
  result.read(this.input);
  this.input.readMessageEnd();

  if (null !== result.success) {
    return result.success;
  }
  throw 'Login failed: unknown result';
};

MyService.AuthClient.prototype.Logout = function (request, callback) {
  this.send_Logout(request, callback);
  if (!callback) {
    return this.recv_Logout();
  }
};

MyService.AuthClient.prototype.send_Logout = function (request, callback) {
  var params = {
    request: request
  };
  var args = new MyService.Auth_Logout_args(params);
  try {
    this.output.writeMessageBegin('Logout', Thrift.MessageType.CALL, this.seqid);
    args.write(this.output);
    this.output.writeMessageEnd();
    if (callback) {
      var self = this;
      this.output.getTransport().flush(true, function () {
        var result = null;
        try {
          result = self.recv_Logout();
        } catch (e) {
          result = e;
        }
        callback(result);
      });
    } else {
      return this.output.getTransport().flush();
    }
  }
  catch (e) {
    if (typeof this.output.getTransport().reset === 'function') {
      this.output.getTransport().reset();
    }
    throw e;
  }
};

MyService.AuthClient.prototype.recv_Logout = function () {
  var ret = this.input.readMessageBegin();
  var mtype = ret.mtype;
  if (mtype == Thrift.MessageType.EXCEPTION) {
    var x = new Thrift.TApplicationException();
    x.read(this.input);
    this.input.readMessageEnd();
    throw x;
  }
  var result = new MyService.Auth_Logout_result();
  result.read(this.input);
  this.input.readMessageEnd();

  if (null !== result.success) {
    return result.success;
  }
  throw 'Logout failed: unknown result';
};
