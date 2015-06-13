package upc.edu.pe.javanet.solicitudService;

//import org.apache.commons.beanutils.BeanUtils;

import java.io.Serializable;
import java.util.Date;

public class SolicitudDetalleUI  implements Serializable, Cloneable {
	
	private int id;

	private int cantidad ;
    private String perfil;
    private String tecnologia;
    private String experRubro;
    private String comentario="";
    
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public int getCantidad() {
		return cantidad;
	}
	public void setCantidad(int cantidad) {
		this.cantidad = cantidad;
	}
	public String getPerfil() {
		return perfil;
	}
	public void setPerfil(String perfil) {
		this.perfil = perfil;
	}
	public String getTecnologia() {
		return tecnologia;
	}
	public void setTecnologia(String tecnologia) {
		this.tecnologia = tecnologia;
	}
	public String getExperRubro() {
		return experRubro;
	}
	public void setExperRubro(String experRubro) {
		this.experRubro = experRubro;
	}
	public String getComentario() {
		return comentario;
	}
	public void setComentario(String comentario) {
		this.comentario = comentario;
	}
	
        

   /* @Override
    public Contact clone() throws CloneNotSupportedException {
        try {
            return (Contact) BeanUtils.cloneBean(this);
        } catch (Exception ex) {
            throw new CloneNotSupportedException();
        }
    }

    @Override
    public String toString() {
        return "Contact{" + "id=" + id + ", firstName=" + firstName
                + ", lastName=" + lastName + ", phone=" + phone + ", email="
                + email + ", birthDate=" + birthDate + '}';
    }*/

	
	
}
