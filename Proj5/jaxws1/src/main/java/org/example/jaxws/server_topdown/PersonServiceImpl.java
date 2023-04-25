package org.example.jaxws.server_topdown;

import jakarta.jws.WebMethod;
import jakarta.jws.WebService;
import org.example.jaxws.server.Person;
import org.example.jaxws.server.PersonExistsEx;
import org.example.jaxws.server.PersonNotFoundEx;
import org.example.jaxws.server.PersonRepository;
import org.example.jaxws.server.PersonRepositoryImpl;
import org.example.jaxws.server.PersonService;

import java.util.ArrayList;

@WebService(serviceName = "PersonService",
        endpointInterface = "org.example.jaxws.server.PersonService")
public class PersonServiceImpl implements PersonService {
    private final PersonRepository dataRepository = new PersonRepositoryImpl();

    @WebMethod
    public org.example.jaxws.server.Person getPerson(int id) throws org.example.jaxws.server.PersonNotFoundEx {
        System.out.println("...called getPerson id=" + id);
        return dataRepository.getPerson(id);
    }

    @WebMethod
    public ArrayList<org.example.jaxws.server.Person> getAllPersons() {
        System.out.println("...called getAllPersons");
        System.out.println("ide spac");
        try {
            Thread.sleep(2000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return dataRepository.getAllPersons();
    }

    @WebMethod
    public org.example.jaxws.server.Person addPerson(int id, String name, int age) throws PersonExistsEx {
        return dataRepository.addPerson(id, name, age);
    }

    @WebMethod
    public boolean deletePerson(int id) throws org.example.jaxws.server.PersonNotFoundEx {
        return dataRepository.deletePerson(id);
    }

    @WebMethod
    public int countPersons() {
        return dataRepository.countPersons();
    }

    @WebMethod
    public Person updatePerson(int id, String name, int age) throws PersonNotFoundEx {
        return dataRepository.updatePerson(id, name, age);
    }
}