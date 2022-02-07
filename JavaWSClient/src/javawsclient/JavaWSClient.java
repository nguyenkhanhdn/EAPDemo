package javawsclient;
import CalculatorWS.Calculator;
import java.util.Scanner;
public class JavaWSClient {
    public static void main(String[] args) {
        int a,b;
        Scanner scan = new Scanner(System.in);
        System.out.print("Nhap a:");
        a = scan.nextInt();
        
        System.out.print("Nhap b:");
        b = scan.nextInt();
        CalculatorWS.Calculator client = new Calculator();
        
        int result = client.getCalculatorSoap().add(a, b);
        System.out.println(result);
    }
}
