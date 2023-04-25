package org.example.jaxws.server_topdown;

import org.example.jaxws.server.Person;
import org.example.jaxws.server.PersonExistsEx;
import org.example.jaxws.server.PersonNotFoundEx;

import java.util.ArrayList;

public class PersonRepositoryImpl implements PersonRepository {
    private ArrayList<org.example.jaxws.server.Person> personList;

    public PersonRepositoryImpl() {
        personList = new ArrayList<>();
        personList.add(new org.example.jaxws.server.Person(1, "Mariusz", 9));
        personList.add(new org.example.jaxws.server.Person(2, "Andrzej", 10));
    }

    public ArrayList<org.example.jaxws.server.Person> getAllPersons() {
        return personList;
    }

    public org.example.jaxws.server.Person getPerson(int id) throws org.example.jaxws.server.PersonNotFoundEx {
        for (org.example.jaxws.server.Person thePerson : personList) {
            if (thePerson.getId() == id) {
                return thePerson;
            }
        }
        throw new org.example.jaxws.server.PersonNotFoundEx();
    }

    public org.example.jaxws.server.Person addPerson(int id, String name, int age) throws org.example.jaxws.server.PersonExistsEx {
        for (org.example.jaxws.server.Person thePerson : personList) {
            if (thePerson.getId() == id) {
                throw new PersonExistsEx();
            }
        }
        org.example.jaxws.server.Person person = new org.example.jaxws.server.Person(id, name, age);
        personList.add(person);
        return person;
    }

    public boolean deletePerson(int id) throws org.example.jaxws.server.PersonNotFoundEx {
        for (org.example.jaxws.server.Person person : personList) {
            if (person.getId() == id) {
                personList.remove(person);
                return true;
            }
        }
        throw new org.example.jaxws.server.PersonNotFoundEx();
    }

    public org.example.jaxws.server.Person updatePerson(int id, String name, int age) throws org.example.jaxws.server.PersonNotFoundEx {
        for (Person person : personList) {
            if (person.getId() == id) {
                person.setFirstName(name);
                person.setAge(age);
                return person;
            }
        }
        throw new PersonNotFoundEx();
    }

    public int countPersons() {
        return personList.size();
    }
}