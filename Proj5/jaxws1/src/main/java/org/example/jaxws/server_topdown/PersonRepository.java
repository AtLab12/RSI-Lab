package org.example.jaxws.server_topdown;

import org.example.jaxws.server.Person;
import org.example.jaxws.server.PersonExistsEx;
import org.example.jaxws.server.PersonNotFoundEx;

import java.util.ArrayList;

public interface PersonRepository {
    ArrayList<Person> getAllPersons();

    Person getPerson(int id) throws PersonNotFoundEx;

    Person updatePerson(int id, String name, int age) throws
            PersonNotFoundEx;

    boolean deletePerson(int id) throws PersonNotFoundEx;

    Person addPerson(int id, String name, int age) throws PersonExistsEx;

    int countPersons();
}