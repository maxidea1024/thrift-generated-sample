#
# Autogenerated by Thrift Compiler (0.13.0)
#
# DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
#
use 5.10.0;
use strict;
use warnings;
use Thrift::Exception;
use Thrift::MessageType;
use Thrift::Type;

use MyService::Types;


# HELPER FUNCTIONS AND STRUCTURES

package MyService::Auth_Login_args;
use base qw(Class::Accessor);
MyService::Auth_Login_args->mk_accessors( qw( request ) );

sub new {
  my $classname = shift;
  my $self      = {};
  my $vals      = shift || {};
  $self->{request} = undef;
  if (UNIVERSAL::isa($vals,'HASH')) {
    if (defined $vals->{request}) {
      $self->{request} = $vals->{request};
    }
  }
  return bless ($self, $classname);
}

sub getName {
  return 'Auth_Login_args';
}

sub read {
  my ($self, $input) = @_;
  my $xfer  = 0;
  my $fname;
  my $ftype = 0;
  my $fid   = 0;
  $xfer += $input->readStructBegin(\$fname);
  while (1)
  {
    $xfer += $input->readFieldBegin(\$fname, \$ftype, \$fid);
    if ($ftype == Thrift::TType::STOP) {
      last;
    }
    SWITCH: for($fid)
    {
      /^1$/ && do{      if ($ftype == Thrift::TType::STRUCT) {
        $self->{request} = MyService::LoginRequest->new();
        $xfer += $self->{request}->read($input);
      } else {
        $xfer += $input->skip($ftype);
      }
      last; };
        $xfer += $input->skip($ftype);
    }
    $xfer += $input->readFieldEnd();
  }
  $xfer += $input->readStructEnd();
  return $xfer;
}

sub write {
  my ($self, $output) = @_;
  my $xfer   = 0;
  $xfer += $output->writeStructBegin('Auth_Login_args');
  if (defined $self->{request}) {
    $xfer += $output->writeFieldBegin('request', Thrift::TType::STRUCT, 1);
    $xfer += $self->{request}->write($output);
    $xfer += $output->writeFieldEnd();
  }
  $xfer += $output->writeFieldStop();
  $xfer += $output->writeStructEnd();
  return $xfer;
}

package MyService::Auth_Login_result;
use base qw(Class::Accessor);
MyService::Auth_Login_result->mk_accessors( qw( success ) );

sub new {
  my $classname = shift;
  my $self      = {};
  my $vals      = shift || {};
  $self->{success} = undef;
  if (UNIVERSAL::isa($vals,'HASH')) {
    if (defined $vals->{success}) {
      $self->{success} = $vals->{success};
    }
  }
  return bless ($self, $classname);
}

sub getName {
  return 'Auth_Login_result';
}

sub read {
  my ($self, $input) = @_;
  my $xfer  = 0;
  my $fname;
  my $ftype = 0;
  my $fid   = 0;
  $xfer += $input->readStructBegin(\$fname);
  while (1)
  {
    $xfer += $input->readFieldBegin(\$fname, \$ftype, \$fid);
    if ($ftype == Thrift::TType::STOP) {
      last;
    }
    SWITCH: for($fid)
    {
      /^0$/ && do{      if ($ftype == Thrift::TType::STRUCT) {
        $self->{success} = MyService::LoginResponse->new();
        $xfer += $self->{success}->read($input);
      } else {
        $xfer += $input->skip($ftype);
      }
      last; };
        $xfer += $input->skip($ftype);
    }
    $xfer += $input->readFieldEnd();
  }
  $xfer += $input->readStructEnd();
  return $xfer;
}

sub write {
  my ($self, $output) = @_;
  my $xfer   = 0;
  $xfer += $output->writeStructBegin('Auth_Login_result');
  if (defined $self->{success}) {
    $xfer += $output->writeFieldBegin('success', Thrift::TType::STRUCT, 0);
    $xfer += $self->{success}->write($output);
    $xfer += $output->writeFieldEnd();
  }
  $xfer += $output->writeFieldStop();
  $xfer += $output->writeStructEnd();
  return $xfer;
}

package MyService::AuthIf;

use strict;


sub Login{
  my $self = shift;
  my $request = shift;

  die 'implement interface';
}

package MyService::AuthRest;

use strict;


sub new {
  my ($classname, $impl) = @_;
  my $self     ={ impl => $impl };

  return bless($self,$classname);
}

sub Login{
  my ($self, $request) = @_;

  my $request = ($request->{'request'}) ? $request->{'request'} : undef;
  return $self->{impl}->Login($request);
}

package MyService::AuthClient;


use base qw(MyService::AuthIf);
sub new {
  my ($classname, $input, $output) = @_;
  my $self      = {};
  $self->{input}  = $input;
  $self->{output} = defined $output ? $output : $input;
  $self->{seqid}  = 0;
  return bless($self,$classname);
}

sub Login{
  my $self = shift;
  my $request = shift;

    $self->send_Login($request);
  return $self->recv_Login();
}

sub send_Login{
  my $self = shift;
  my $request = shift;

  $self->{output}->writeMessageBegin('Login', Thrift::TMessageType::CALL, $self->{seqid});
  my $args = MyService::Auth_Login_args->new();
  $args->{request} = $request;
  $args->write($self->{output});
  $self->{output}->writeMessageEnd();
  $self->{output}->getTransport()->flush();
}

sub recv_Login{
  my $self = shift;

  my $rseqid = 0;
  my $fname;
  my $mtype = 0;

  $self->{input}->readMessageBegin(\$fname, \$mtype, \$rseqid);
  if ($mtype == Thrift::TMessageType::EXCEPTION) {
    my $x = Thrift::TApplicationException->new();
    $x->read($self->{input});
    $self->{input}->readMessageEnd();
    die $x;
  }
  my $result = MyService::Auth_Login_result->new();
  $result->read($self->{input});
  $self->{input}->readMessageEnd();

  if (defined $result->{success} ) {
    return $result->{success};
  }
  die "Login failed: unknown result";
}
package MyService::AuthProcessor;

use strict;


sub new {
    my ($classname, $handler) = @_;
    my $self      = {};
    $self->{handler} = $handler;
    return bless ($self, $classname);
}

sub process {
    my ($self, $input, $output) = @_;
    my $rseqid = 0;
    my $fname  = undef;
    my $mtype  = 0;

    $input->readMessageBegin(\$fname, \$mtype, \$rseqid);
    my $methodname = 'process_'.$fname;
    if (!$self->can($methodname)) {
      $input->skip(Thrift::TType::STRUCT);
      $input->readMessageEnd();
      my $x = Thrift::TApplicationException->new('Function '.$fname.' not implemented.', Thrift::TApplicationException::UNKNOWN_METHOD);
      $output->writeMessageBegin($fname, Thrift::TMessageType::EXCEPTION, $rseqid);
      $x->write($output);
      $output->writeMessageEnd();
      $output->getTransport()->flush();
      return;
    }
    $self->$methodname($rseqid, $input, $output);
    return 1;
}

sub process_Login {
    my ($self, $seqid, $input, $output) = @_;
    my $args = MyService::Auth_Login_args->new();
    $args->read($input);
    $input->readMessageEnd();
    my $result = MyService::Auth_Login_result->new();
    $result->{success} = $self->{handler}->Login($args->request);
    $output->writeMessageBegin('Login', Thrift::TMessageType::REPLY, $seqid);
    $result->write($output);
    $output->writeMessageEnd();
    $output->getTransport()->flush();
}

1;