/**
 * SolicitudDetalle.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.SolicitudService_Dominio;

public class SolicitudDetalle  implements java.io.Serializable {
    private java.lang.Integer cantidadColabor;

    private java.lang.Integer codigo;

    private java.lang.String comentario;

    private java.lang.Integer id;

    private java.lang.String codExperienciaRubro;

    private java.lang.String codPerfil;

    private java.lang.String codTecnologia;

    public SolicitudDetalle() {
    }

    public SolicitudDetalle(
           java.lang.Integer cantidadColabor,
           java.lang.Integer codigo,
           java.lang.String comentario,
           java.lang.Integer id,
           java.lang.String codExperienciaRubro,
           java.lang.String codPerfil,
           java.lang.String codTecnologia) {
           this.cantidadColabor = cantidadColabor;
           this.codigo = codigo;
           this.comentario = comentario;
           this.id = id;
           this.codExperienciaRubro = codExperienciaRubro;
           this.codPerfil = codPerfil;
           this.codTecnologia = codTecnologia;
    }


    /**
     * Gets the cantidadColabor value for this SolicitudDetalle.
     * 
     * @return cantidadColabor
     */
    public java.lang.Integer getCantidadColabor() {
        return cantidadColabor;
    }


    /**
     * Sets the cantidadColabor value for this SolicitudDetalle.
     * 
     * @param cantidadColabor
     */
    public void setCantidadColabor(java.lang.Integer cantidadColabor) {
        this.cantidadColabor = cantidadColabor;
    }


    /**
     * Gets the codigo value for this SolicitudDetalle.
     * 
     * @return codigo
     */
    public java.lang.Integer getCodigo() {
        return codigo;
    }


    /**
     * Sets the codigo value for this SolicitudDetalle.
     * 
     * @param codigo
     */
    public void setCodigo(java.lang.Integer codigo) {
        this.codigo = codigo;
    }


    /**
     * Gets the comentario value for this SolicitudDetalle.
     * 
     * @return comentario
     */
    public java.lang.String getComentario() {
        return comentario;
    }


    /**
     * Sets the comentario value for this SolicitudDetalle.
     * 
     * @param comentario
     */
    public void setComentario(java.lang.String comentario) {
        this.comentario = comentario;
    }


    /**
     * Gets the id value for this SolicitudDetalle.
     * 
     * @return id
     */
    public java.lang.Integer getId() {
        return id;
    }


    /**
     * Sets the id value for this SolicitudDetalle.
     * 
     * @param id
     */
    public void setId(java.lang.Integer id) {
        this.id = id;
    }


    /**
     * Gets the codExperienciaRubro value for this SolicitudDetalle.
     * 
     * @return codExperienciaRubro
     */
    public java.lang.String getCodExperienciaRubro() {
        return codExperienciaRubro;
    }


    /**
     * Sets the codExperienciaRubro value for this SolicitudDetalle.
     * 
     * @param codExperienciaRubro
     */
    public void setCodExperienciaRubro(java.lang.String codExperienciaRubro) {
        this.codExperienciaRubro = codExperienciaRubro;
    }


    /**
     * Gets the codPerfil value for this SolicitudDetalle.
     * 
     * @return codPerfil
     */
    public java.lang.String getCodPerfil() {
        return codPerfil;
    }


    /**
     * Sets the codPerfil value for this SolicitudDetalle.
     * 
     * @param codPerfil
     */
    public void setCodPerfil(java.lang.String codPerfil) {
        this.codPerfil = codPerfil;
    }


    /**
     * Gets the codTecnologia value for this SolicitudDetalle.
     * 
     * @return codTecnologia
     */
    public java.lang.String getCodTecnologia() {
        return codTecnologia;
    }


    /**
     * Sets the codTecnologia value for this SolicitudDetalle.
     * 
     * @param codTecnologia
     */
    public void setCodTecnologia(java.lang.String codTecnologia) {
        this.codTecnologia = codTecnologia;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof SolicitudDetalle)) return false;
        SolicitudDetalle other = (SolicitudDetalle) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.cantidadColabor==null && other.getCantidadColabor()==null) || 
             (this.cantidadColabor!=null &&
              this.cantidadColabor.equals(other.getCantidadColabor()))) &&
            ((this.codigo==null && other.getCodigo()==null) || 
             (this.codigo!=null &&
              this.codigo.equals(other.getCodigo()))) &&
            ((this.comentario==null && other.getComentario()==null) || 
             (this.comentario!=null &&
              this.comentario.equals(other.getComentario()))) &&
            ((this.id==null && other.getId()==null) || 
             (this.id!=null &&
              this.id.equals(other.getId()))) &&
            ((this.codExperienciaRubro==null && other.getCodExperienciaRubro()==null) || 
             (this.codExperienciaRubro!=null &&
              this.codExperienciaRubro.equals(other.getCodExperienciaRubro()))) &&
            ((this.codPerfil==null && other.getCodPerfil()==null) || 
             (this.codPerfil!=null &&
              this.codPerfil.equals(other.getCodPerfil()))) &&
            ((this.codTecnologia==null && other.getCodTecnologia()==null) || 
             (this.codTecnologia!=null &&
              this.codTecnologia.equals(other.getCodTecnologia())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getCantidadColabor() != null) {
            _hashCode += getCantidadColabor().hashCode();
        }
        if (getCodigo() != null) {
            _hashCode += getCodigo().hashCode();
        }
        if (getComentario() != null) {
            _hashCode += getComentario().hashCode();
        }
        if (getId() != null) {
            _hashCode += getId().hashCode();
        }
        if (getCodExperienciaRubro() != null) {
            _hashCode += getCodExperienciaRubro().hashCode();
        }
        if (getCodPerfil() != null) {
            _hashCode += getCodPerfil().hashCode();
        }
        if (getCodTecnologia() != null) {
            _hashCode += getCodTecnologia().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(SolicitudDetalle.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "SolicitudDetalle"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("cantidadColabor");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "CantidadColabor"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("codigo");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "Codigo"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("comentario");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "Comentario"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("id");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "Id"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("codExperienciaRubro");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "codExperienciaRubro"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("codPerfil");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "codPerfil"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("codTecnologia");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/SolicitudService.Dominio", "codTecnologia"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
