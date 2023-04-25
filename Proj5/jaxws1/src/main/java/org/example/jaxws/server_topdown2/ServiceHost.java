package org.example.jaxws.server_topdown2;


import jakarta.xml.ws.Endpoint;

import java.io.IOException;

import static java.lang.System.exit;

public class ServiceHost {
    public static void main(String[] args) {
        MyData.info();
        System.out.println("Web Service PersonService is running ...");
        PersonServiceImpl psi = new PersonServiceImpl();
        Endpoint.publish("http://10.8.0.7:8081/personservice", psi);
        System.out.println("Press ENTER to STOP PersonService ...");
        try {
            System.in.read();
        } catch (IOException e) {
            e.printStackTrace();
        }
        exit(0);
    }
}
