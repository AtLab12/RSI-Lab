
package org.example.jaxws.server_topdown;

import jakarta.xml.ws.*;

import javax.xml.namespace.QName;
import java.net.MalformedURLException;
import java.net.URL;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 3.0.2
 * Generated source version: 3.0
 * 
 */
@WebServiceClient(name = "PersonService", targetNamespace = "http://server.jaxws.example.org/", wsdlLocation = "file:/home/pawelk/RSI/Rsi-lab-8/src/main/resources/personservice.wsdl")
public class PersonService_Service
    extends Service
{

    private final static URL PERSONSERVICE_WSDL_LOCATION;
    private final static WebServiceException PERSONSERVICE_EXCEPTION;
    private final static QName PERSONSERVICE_QNAME = new QName("http://server.jaxws.example.org/", "PersonService");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("file:C:\\Studia\\RSI-Lab\\Proj5\\jaxws1\\src\\main\\resources\\personservice.wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        PERSONSERVICE_WSDL_LOCATION = url;
        PERSONSERVICE_EXCEPTION = e;
    }

    public PersonService_Service() {
        super(__getWsdlLocation(), PERSONSERVICE_QNAME);
    }

    public PersonService_Service(WebServiceFeature... features) {
        super(__getWsdlLocation(), PERSONSERVICE_QNAME, features);
    }

    public PersonService_Service(URL wsdlLocation) {
        super(wsdlLocation, PERSONSERVICE_QNAME);
    }

    public PersonService_Service(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, PERSONSERVICE_QNAME, features);
    }

    public PersonService_Service(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public PersonService_Service(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns PersonService
     */
    @WebEndpoint(name = "PersonServiceImplPort")
    public PersonService getPersonServiceImplPort() {
        return super.getPort(new QName("http://server.jaxws.example.org/", "PersonServiceImplPort"), PersonService.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns PersonService
     */
    @WebEndpoint(name = "PersonServiceImplPort")
    public PersonService getPersonServiceImplPort(WebServiceFeature... features) {
        return super.getPort(new QName("http://server.jaxws.example.org/", "PersonServiceImplPort"), PersonService.class, features);
    }

    private static URL __getWsdlLocation() {
        if (PERSONSERVICE_EXCEPTION!= null) {
            throw PERSONSERVICE_EXCEPTION;
        }
        return PERSONSERVICE_WSDL_LOCATION;
    }

}
