package org.tempuri;

public class ICrearSolicitudProxy implements org.tempuri.ICrearSolicitud {
  private String _endpoint = null;
  private org.tempuri.ICrearSolicitud iCrearSolicitud = null;
  
  public ICrearSolicitudProxy() {
    _initICrearSolicitudProxy();
  }
  
  public ICrearSolicitudProxy(String endpoint) {
    _endpoint = endpoint;
    _initICrearSolicitudProxy();
  }
  
  private void _initICrearSolicitudProxy() {
    try {
      iCrearSolicitud = (new org.tempuri.CrearSolicitudLocator()).getBasicHttpBinding_ICrearSolicitud();
      if (iCrearSolicitud != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iCrearSolicitud)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iCrearSolicitud)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iCrearSolicitud != null)
      ((javax.xml.rpc.Stub)iCrearSolicitud)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.ICrearSolicitud getICrearSolicitud() {
    if (iCrearSolicitud == null)
      _initICrearSolicitudProxy();
    return iCrearSolicitud;
  }
  
  public java.lang.Integer generarSolicitud(java.lang.Integer codCliente, java.lang.Integer codProyecto, org.datacontract.schemas._2004._07.SolicitudService_Dominio.SolicitudDetalle[] detalleSolicitud) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.SolicitudService_Dominio.MyExcepcion{
    if (iCrearSolicitud == null)
      _initICrearSolicitudProxy();
    return iCrearSolicitud.generarSolicitud(codCliente, codProyecto, detalleSolicitud);
  }
  
  
}