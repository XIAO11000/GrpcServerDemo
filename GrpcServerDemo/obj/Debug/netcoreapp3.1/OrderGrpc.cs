// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/order.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServerDemo {
  public static partial class Order
  {
    static readonly string __ServiceName = "order.Order";

    static readonly grpc::Marshaller<global::GrpcServerDemo.OrderRequest> __Marshaller_order_OrderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServerDemo.OrderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServerDemo.OrderResponse> __Marshaller_order_OrderResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServerDemo.OrderResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServerDemo.OrderRequest, global::GrpcServerDemo.OrderResponse> __Method_GetOrder = new grpc::Method<global::GrpcServerDemo.OrderRequest, global::GrpcServerDemo.OrderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOrder",
        __Marshaller_order_OrderRequest,
        __Marshaller_order_OrderResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServerDemo.OrderReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Order</summary>
    [grpc::BindServiceMethod(typeof(Order), "BindService")]
    public abstract partial class OrderBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcServerDemo.OrderResponse> GetOrder(global::GrpcServerDemo.OrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OrderBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetOrder, serviceImpl.GetOrder).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OrderBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServerDemo.OrderRequest, global::GrpcServerDemo.OrderResponse>(serviceImpl.GetOrder));
    }

  }
}
#endregion
