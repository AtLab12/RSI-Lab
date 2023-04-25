package org.example.jaxws.server_topdown;

import org.example.jaxws.server.Person;
import org.example.jaxws.server.PersonExistsEx;
import org.example.jaxws.server.PersonNotFoundEx;

import java.util.ArrayList;

public interface PersonRepository {
    ArrayList<org.example.jaxws.server.Person> getAllPersons();

    org.example.jaxws.server.Person getPerson(int id) throws org.example.jaxws.server.PersonNotFoundEx;

    org.example.jaxws.server.Person updatePerson(int id, String name, int age) throws
            org.example.jaxws.server.PersonNotFoundEx;

    boolean deletePerson(int id) throws PersonNotFoundEx;

    Person addPerson(int id, String name, int age) throws PersonExistsEx;

    int countPersons();
}