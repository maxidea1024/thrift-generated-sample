//
// Autogenerated by Thrift Compiler (0.13.0)
//
// DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
//
import Int64 = require('node-int64');

declare module MyService {
  enum ServicePlatformType {
    Google = 0,
    Apple = 1,
    Facebook = 2,
    Twitter = 3,
    OneStore = 4,
  }

  class LoginRequest {
    id: string;
    password: string;

      constructor(args?: { id?: string; password?: string; });
  }

  class LoginResponse {
    session_key: string;
    newbee: boolean;

      constructor(args?: { session_key?: string; newbee?: boolean; });
  }

  class LogoutRequest {
  }

  class LogoutResponse {
  }

  var MAX_PASSWORD_LEN: number;

  var DEFAULT_API_SERVER_URL: string;
}