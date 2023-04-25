package org.example.jaxws.server_topdown2;

import java.net.Inet4Address;
import java.net.InetAddress;
import java.net.UnknownHostException;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class MyData {
    public static void info() {
        System.out.println("Płóciennik Tomasz 260404");
        System.out.println("Zawada Mikołaj 259431");
        LocalDateTime currentDateTime = LocalDateTime.now();
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd MMMM, HH:mm:ss");
        System.out.println(currentDateTime.format(formatter));
        System.out.println(System.getProperty("java.version"));
        System.out.println(System.getProperty("user.name"));
        System.out.println(System.getProperty("os.name"));
        try {
            InetAddress localhost = InetAddress.getLocalHost();
            InetAddress[] localIPs = InetAddress.getAllByName(localhost.getHostName());
            for (InetAddress addr : localIPs) {
                if (addr instanceof Inet4Address) {
                    System.out.println(addr.getHostAddress());
                }
            }
        } catch (UnknownHostException e) {
            e.printStackTrace();
        }

    }
}
