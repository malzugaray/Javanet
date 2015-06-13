/**
 * ICrearSolicitud.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface ICrearSolicitud extends java.rmi.Remote {
    public java.lang.Integer generarSolicitud(java.lang.Integer codCliente, java.lang.Integer codProyecto, org.datacontract.schemas._2004._07.SolicitudService_Dominio.SolicitudDetalle[] detalleSolicitud) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.SolicitudService_Dominio.MyExcepcion;
}
