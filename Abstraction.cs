using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
       Console.WriteLine("Nama\t\t: Addnnan Nurwakhid");
       Console.WriteLine("NIM\t\t: 19.11.2736");
       Console.WriteLine("Kelas\t\t: Informatika 03_19");
       
       Console.WriteLine();
       Console.WriteLine("==== OS ====");
       Console.WriteLine();
       ACOperatingSystem os;
       
       os = new MacOS();
       os.pembuat();
       os.kernel();
       os.jenis();
       
       Console.WriteLine();
       
       os = new Windows();
       os.pembuat();
       os.kernel();
       os.jenis();
       
       
       Console.WriteLine();
       Console.WriteLine("==== BENDA ====");
       Console.WriteLine();
       
       IBenda benda;
       
       benda = new Handphone();
       benda.info();
       benda.suara();
       benda.jenis();
       
       Console.WriteLine();
       benda = new Motor();
       benda.info();
       benda.suara();
       benda.jenis();
     }
   }
   
   // Abstract Class 
   public abstract class ACOperatingSystem {
     public abstract void pembuat();
     public abstract void kernel();
     public abstract void jenis();
   }
   
   public class MacOS : ACOperatingSystem {
     public override void pembuat() {
       Console.WriteLine("Manufaktur : Apple ");
     }
     public override void kernel() {
       Console.WriteLine("Kernel : Darwin ");
     }
     public override void jenis() {
       Console.WriteLine("Jenis : Closed Source ");
     }
   }
   
   public class Windows : ACOperatingSystem {
     public override void pembuat() {
       Console.WriteLine("Manufaktur : Microsoft ");
     }
     public override void kernel() {
       Console.WriteLine("Kernel : Windows NT ");
     }
     public override void jenis() {
       Console.WriteLine("Jenis : Closed Source ");
     }
   }
   
   // Interface Class Benda
   
   public interface IBenda{
     void info();
     void suara();
     void jenis();
   }
   
  public class Handphone : IBenda {
     public void info() {
       Console.WriteLine("Ciri Khas Handphone: ");
     }
     public void suara() {
       Console.WriteLine("- Bersuara Ring Ring");
     }
     public void jenis() {
       Console.WriteLine("- Jenis: Elektronik ");
     }
   } 
   
   public class Motor : IBenda {
     public void info() {
       Console.WriteLine("Ciri Khas Motor: ");
     }
     public void suara() {
       Console.WriteLine("- Bersuara Brum Brum");
     }
     public void jenis() {
       Console.WriteLine("- Jenis: Kendaraan");
     }
   } 
 }