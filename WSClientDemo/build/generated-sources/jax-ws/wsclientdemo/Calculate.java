
package wsclientdemo;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "Calculate", targetNamespace = "http://tempuri.org/", wsdlLocation = "http://localhost:59825/Calculate.asmx?wsdl")
public class Calculate
    extends Service
{

    private final static URL CALCULATE_WSDL_LOCATION;
    private final static WebServiceException CALCULATE_EXCEPTION;
    private final static QName CALCULATE_QNAME = new QName("http://tempuri.org/", "Calculate");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:59825/Calculate.asmx?wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        CALCULATE_WSDL_LOCATION = url;
        CALCULATE_EXCEPTION = e;
    }

    public Calculate() {
        super(__getWsdlLocation(), CALCULATE_QNAME);
    }

    public Calculate(WebServiceFeature... features) {
        super(__getWsdlLocation(), CALCULATE_QNAME, features);
    }

    public Calculate(URL wsdlLocation) {
        super(wsdlLocation, CALCULATE_QNAME);
    }

    public Calculate(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, CALCULATE_QNAME, features);
    }

    public Calculate(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public Calculate(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns CalculateSoap
     */
    @WebEndpoint(name = "CalculateSoap")
    public CalculateSoap getCalculateSoap() {
        return super.getPort(new QName("http://tempuri.org/", "CalculateSoap"), CalculateSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns CalculateSoap
     */
    @WebEndpoint(name = "CalculateSoap")
    public CalculateSoap getCalculateSoap(WebServiceFeature... features) {
        return super.getPort(new QName("http://tempuri.org/", "CalculateSoap"), CalculateSoap.class, features);
    }

    /**
     * 
     * @return
     *     returns CalculateSoap
     */
    @WebEndpoint(name = "CalculateSoap12")
    public CalculateSoap getCalculateSoap12() {
        return super.getPort(new QName("http://tempuri.org/", "CalculateSoap12"), CalculateSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns CalculateSoap
     */
    @WebEndpoint(name = "CalculateSoap12")
    public CalculateSoap getCalculateSoap12(WebServiceFeature... features) {
        return super.getPort(new QName("http://tempuri.org/", "CalculateSoap12"), CalculateSoap.class, features);
    }

    private static URL __getWsdlLocation() {
        if (CALCULATE_EXCEPTION!= null) {
            throw CALCULATE_EXCEPTION;
        }
        return CALCULATE_WSDL_LOCATION;
    }

}
