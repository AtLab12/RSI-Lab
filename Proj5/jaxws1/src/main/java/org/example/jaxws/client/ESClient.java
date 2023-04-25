package org.example.jaxws.client;

import com.sun.xml.ws.client.BindingProviderProperties;
import jakarta.xml.ws.BindingProvider;
import org.example.jaxws.server_topdown.*;

import java.util.ArrayList;
import java.util.Map;
import java.util.Scanner;


public class ESClient {

    static Scanner scan = new Scanner(System.in);

    public static void main(String[] args) {
        MyData.info();
        PersonService_Service pService = new PersonService_Service();
        PersonService pServiceProxy = pService.getPersonServiceImplPort();
        ((BindingProvider) pServiceProxy).getRequestContext().put(BindingProviderProperties.REQUEST_TIMEOUT, 1000);
        ((BindingProvider) pServiceProxy).getRequestContext().put(BindingProviderProperties.CONNECT_TIMEOUT, 1000);


        while (true) {
            try {
                System.out.println("Wybierz operację: ");
                System.out.println("1 - Pokaż wszystkich");
                System.out.println("2 - Pokaż osobę o ID = x");
                System.out.println("3 - Dodaj osobę");
                System.out.println("4 - Edytuj osobę");
                System.out.println("5 - Usuń osobę");
                System.out.println("6 - Pokaż liczbę osób");
                System.out.println("7 - Koniec");

                int option = scan.nextInt();

                switch (option) {
                    case 1 -> {
                        ArrayList<Person> allPersons = pServiceProxy.getAllPersons();
                        for (Person person : allPersons) {
                            prettyPrintPerson(person);
                        }
                    }
                    case 2 -> {
                        System.out.println("Podaj id");
                        prettyPrintPerson(pServiceProxy.getPerson(scan.nextInt()));
                    }
                    case 3 -> {
                        Person newPerson = readPerson();
                        pServiceProxy.addPerson(newPerson.getId(), newPerson.getFirstName(), newPerson.getAge());
                        System.out.print("Dodano ");
                        prettyPrintPerson(newPerson);
                    }
                    case 4 -> {
                        Person newPerson = readPerson();
                        pServiceProxy.updatePerson(newPerson.getId(), newPerson.getFirstName(), newPerson.getAge());
                        System.out.println("Zaaktualizowano ");
                        prettyPrintPerson(newPerson);
                    }
                    case 5 -> {
                        System.out.println("Podaj id");
                        int id3 = scan.nextInt();
                        pServiceProxy.deletePerson(id3);
                        System.out.println("Usunięto");
                    }
                    case 6 -> {
                        System.out.println("W bazie danych znajduje się " + pServiceProxy.countPersons() + " osób");
                    }
                    case 7 -> {
                        return;
                    }
                    default -> System.out.println("Brak takiej operacji");
                }

            } catch (PersonExistsEx_Exception e) {
                System.out.println("Taki użytkownik już istnieje");
            } catch (PersonNotFoundEx_Exception e) {
                System.out.println("Nie znaleziono użytkownika");
            }  catch (jakarta.xml.ws.WebServiceException e) {
                System.out.println("Przekroczono czas odpowiedzi serwera");
            }

            catch (Exception e) {
                System.out.println("Wystąpił błąd "+e);
            }
        }
    }

    private static void prettyPrintPerson(Person person) {
        System.out.println("Osoba: " +
                "id - " + person.getId() +
                ", imie - \"" + person.getFirstName() +
                "\", wiek - " + person.getAge());
    }

    private static Person readPerson() {
        Person person = new Person();
        System.out.println("Podaj dane osoby:");
        System.out.print("Id - ");
        person.setId(scan.nextInt());
        scan.nextLine();
        System.out.print("Imie - ");
        person.setFirstName(scan.nextLine());
        System.out.print("Wiek - ");
        person.setAge(scan.nextInt());
        scan.nextLine();
        return person;
    }

}
