package org.example.jaxws.server;

import jakarta.jws.WebMethod;
import jakarta.jws.WebService;

import java.util.ArrayList;

@WebService
public interface PersonService {
    @WebMethod
    Person getPerson(int id) throws PersonNotFoundEx;
    @WebMethod
    Person addPerson(int id, String name, int age) throws PersonExistsEx;
    @WebMethod
    boolean deletePerson(int id) throws PersonNotFoundEx;
    @WebMethod
    ArrayList<Person> getAllPersons();
    @WebMethod
    int countPersons();
    @WebMethod
    Person updatePerson(int id, String name, int age) throws PersonExistsEx, PersonNotFoundEx;
}
