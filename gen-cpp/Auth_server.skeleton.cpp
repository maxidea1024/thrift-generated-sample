// This autogenerated skeleton file illustrates how to build a server.
// You should copy it to another filename to avoid overwriting it.

#include "Auth.h"
#include <thrift/protocol/TBinaryProtocol.h>
#include <thrift/server/TSimpleServer.h>
#include <thrift/transport/TServerSocket.h>
#include <thrift/transport/TBufferTransports.h>

using namespace ::apache::thrift;
using namespace ::apache::thrift::protocol;
using namespace ::apache::thrift::transport;
using namespace ::apache::thrift::server;

using namespace  ::MyService;

class AuthHandler : virtual public AuthIf {
 public:
  AuthHandler() {
    // Your initialization goes here
  }

  /**
   * API 서버에게 로그인을 요청합니다.
   * 
   * @param request
   */
  void Login(LoginResponse& _return, const LoginRequest& request) {
    // Your implementation goes here
    printf("Login\n");
  }

};

int main(int argc, char **argv) {
  int port = 9090;
  ::std::shared_ptr<AuthHandler> handler(new AuthHandler());
  ::std::shared_ptr<TProcessor> processor(new AuthProcessor(handler));
  ::std::shared_ptr<TServerTransport> serverTransport(new TServerSocket(port));
  ::std::shared_ptr<TTransportFactory> transportFactory(new TBufferedTransportFactory());
  ::std::shared_ptr<TProtocolFactory> protocolFactory(new TBinaryProtocolFactory());

  TSimpleServer server(processor, serverTransport, transportFactory, protocolFactory);
  server.serve();
  return 0;
}
