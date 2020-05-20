/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#ifndef sample_TYPES_H
#define sample_TYPES_H

#include <iosfwd>

#include <thrift/Thrift.h>
#include <thrift/TApplicationException.h>
#include <thrift/TBase.h>
#include <thrift/protocol/TProtocol.h>
#include <thrift/transport/TTransport.h>

#include <functional>
#include <memory>


namespace MyService {

struct ServicePlatformType {
  enum type {
    Google = 0,
    Apple = 1,
    Facebook = 2,
    Twitter = 3,
    OneStore = 4
  };
};

extern const std::map<int, const char*> _ServicePlatformType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const ServicePlatformType::type& val);

std::string to_string(const ServicePlatformType::type& val);

class LoginRequest;

class LoginResponse;

typedef struct _LoginRequest__isset {
  _LoginRequest__isset() : id(true), password(true) {}
  bool id :1;
  bool password :1;
} _LoginRequest__isset;

class LoginRequest : public virtual ::apache::thrift::TBase {
 public:

  LoginRequest(const LoginRequest&);
  LoginRequest& operator=(const LoginRequest&);
  LoginRequest() : id("guest"), password("") {
  }

  virtual ~LoginRequest() noexcept;
  std::string id;
  std::string password;

  _LoginRequest__isset __isset;

  void __set_id(const std::string& val);

  void __set_password(const std::string& val);

  bool operator == (const LoginRequest & rhs) const
  {
    if (__isset.id != rhs.__isset.id)
      return false;
    else if (__isset.id && !(id == rhs.id))
      return false;
    if (__isset.password != rhs.__isset.password)
      return false;
    else if (__isset.password && !(password == rhs.password))
      return false;
    return true;
  }
  bool operator != (const LoginRequest &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const LoginRequest & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(LoginRequest &a, LoginRequest &b);

std::ostream& operator<<(std::ostream& out, const LoginRequest& obj);

typedef struct _LoginResponse__isset {
  _LoginResponse__isset() : session_key(true), newbee(true) {}
  bool session_key :1;
  bool newbee :1;
} _LoginResponse__isset;

class LoginResponse : public virtual ::apache::thrift::TBase {
 public:

  LoginResponse(const LoginResponse&);
  LoginResponse& operator=(const LoginResponse&);
  LoginResponse() : session_key("1234"), newbee(false) {
  }

  virtual ~LoginResponse() noexcept;
  std::string session_key;
  bool newbee;

  _LoginResponse__isset __isset;

  void __set_session_key(const std::string& val);

  void __set_newbee(const bool val);

  bool operator == (const LoginResponse & rhs) const
  {
    if (__isset.session_key != rhs.__isset.session_key)
      return false;
    else if (__isset.session_key && !(session_key == rhs.session_key))
      return false;
    if (__isset.newbee != rhs.__isset.newbee)
      return false;
    else if (__isset.newbee && !(newbee == rhs.newbee))
      return false;
    return true;
  }
  bool operator != (const LoginResponse &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const LoginResponse & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(LoginResponse &a, LoginResponse &b);

std::ostream& operator<<(std::ostream& out, const LoginResponse& obj);

} // namespace

#endif
