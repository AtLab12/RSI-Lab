package org.example.jaxws.server;

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