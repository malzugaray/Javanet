package upc.edu.pe.javanet.solicitudService;

//import org.apache.commons.beanutils.BeanUtils;

import java.rmi.RemoteException;
import java.util.*;

import com.vaadin.ui.Notification;
import com.vaadin.ui.Table;

import org.tempuri.ICrearSolicitudProxy;
import org.datacontract.schemas._2004._07.SolicitudService_Dominio.SolicitudDetalle;
import org.datacontract.schemas._2004._07.SolicitudService_Dominio.MyExcepcion;

public class SolicitudService {
	
	// Create dummy data by randomly combining first and last names
	static String[] cant = { "2", "1", "3"};
	static String[] perfil = { "SEMI SENIOR", "JUNIOR", "SENIOR"};
    static String[] tecnologia = { "JAVA", "JAVA", "NET"};
    static String[] expRubro = { "BANCA", "BANCA", "GOBIERNO"};

    private static SolicitudService instance;

    public static SolicitudService createDemoService() {
        if (instance == null) {

            final SolicitudService solicitudService = new SolicitudService();

            Random r = new Random(0);
            Calendar cal = Calendar.getInstance();
            for (int i = 0; i < 100; i++) {
                SolicitudDetalle solicitud = new SolicitudDetalle();
               // solicitud.setCantidad(cant[r.nextInt(cant.length)]);
               // solicitud.setPerfil(perfil[r.nextInt(perfil.length)]);
               // solicitud.setTecnologia(tecnologia[r.nextInt(tecnologia.length)]);
               // solicitud.setExperRubro(expRubro[r.nextInt(expRubro.length)]);
                                
                solicitudService.save(solicitud);
            }
            instance = solicitudService;
        }

        return instance;
    }

    private HashMap<Long, SolicitudDetalle> solicitudes = new HashMap<Long, SolicitudDetalle>();
    private long nextId = 0;

    public synchronized List<SolicitudDetalle> findAll(String stringFilter) {
        ArrayList arrayList = new ArrayList();
        for (SolicitudDetalle solicitud : solicitudes.values()) {
            try {
                boolean passesFilter = (stringFilter == null || stringFilter
                        .isEmpty())
                        || solicitud.toString().toLowerCase()
                                .contains(stringFilter.toLowerCase());
                if (passesFilter) {
                    //arrayList.add(solicitud.clone());
                }
            } catch (Exception ex) {  
            //} catch (CloneNotSupportedException ex) {
            	ex.printStackTrace();
            	//ex.getMessage("ERROR : " + SolicitudService.class.getName());
                //Logger.getLogger(ContactService.class.getName()).log(
                //        Level.SEVERE, null, ex);
            }
        }
        Collections.sort(arrayList, new Comparator<SolicitudDetalle>() {

            @Override
            public int compare(SolicitudDetalle o1, SolicitudDetalle o2) {
                return (int) (o2.getId() - o1.getId());
            }
        });
        return arrayList;
    }

    public synchronized long count() {
        return solicitudes.size();
    }

    public synchronized void delete(SolicitudDetalle value) {
    	solicitudes.remove(value.getId());
    }

    public synchronized void save(SolicitudDetalle entry) {
        //if (entry.getId() == null) {
       //     entry.setId(nextId++);
       // }
        try {
            //entry = (Solicitud) BeanUtils.cloneBean(entry);
        } catch (Exception ex) {
            throw new RuntimeException(ex);
        }
        //solicitudes.put(entry.getId(), entry);
    }
    
    public int grabar(int codCliente, int codProyecto, Table tableDetalle) throws RemoteException {
		
    	ICrearSolicitudProxy proxy = new ICrearSolicitudProxy();
  
    	//SolicitudDetalle[] listaDetalle; 
    	SolicitudDetalle listaDetalle[];
        listaDetalle = new SolicitudDetalle[tableDetalle.size()];
    			
    			
		//Notification.show("datos " + tableDetalle.getItemIds());
		
    	try {
    		for(int i=0; i< tableDetalle.size(); i++){
    			SolicitudDetalle solicitudDetalle = new SolicitudDetalle();
    			solicitudDetalle.setCantidadColabor(Integer.parseInt(tableDetalle.getContainerProperty(i+1,"Cantidad").getValue().toString()));
    			solicitudDetalle.setCodPerfil((String) tableDetalle.getContainerProperty(i+1,"Perfil").getValue());
    			solicitudDetalle.setCodTecnologia((String) tableDetalle.getContainerProperty(i+1,"Tecnolog�a").getValue());
    			solicitudDetalle.setCodExperienciaRubro((String) tableDetalle.getContainerProperty(i+1,"Experiencia en Rubro").getValue());
    			
    			listaDetalle[i] = solicitudDetalle;
    			//Notification.show("lista " + listaDetalle.size());
    			
    		}
    		
        	//llamar a servicio GeneracionService
    		int resultado = proxy.generarSolicitud(codCliente, codProyecto, listaDetalle);
    		return resultado;
    				
        } catch (MyExcepcion ex) {  
        //} catch (CloneNotSupportedException ex) {
        	//throw new MyExcepcion (ex.getDescription(), ex.getMesssage());
        	ex.printStackTrace();
        	//ex.getMessage("ERROR : " + SolicitudService.class.getName());
            //Logger.getLogger(ContactService.class.getName()).log(
            //        Level.SEVERE, null, ex);
        }
		
		
		return 0;
	}

}
