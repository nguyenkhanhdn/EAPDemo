/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package wsclientdemo;

import java.util.Scanner;

/**
 *
 * @author KM
 */
public class WSClientDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int a,b;
        Scanner scan = new Scanner(System.in);
        System.out.print("Nhap a:");
        a = scan.nextInt();
        
        System.out.print("Nhap b:");
        b = scan.nextInt();
        
        //Proxy object
        Calculate client = new Calculate();
        
        int result = client.getCalculateSoap().add(a, b);
        System.out.println(result);
    }
}
