/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javawsclient2;
import java.util.Scanner;
public class JavaWSClient2 {
    public static void main(String[] args) {
        int a,b;
        Scanner scan = new Scanner(System.in);
        System.out.print("Nhap a:");
        a = scan.nextInt();
        
        System.out.print("Nhap b:");
        b = scan.nextInt();
        
        //Proxy object
        Calculator client = new Calculator();
        
        int result = client.getCalculatorSoap().add(a, b);
        System.out.println(result);
    }
    
}
