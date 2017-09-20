using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitName
{
    class Program
    {
        static void Main(string[] args)
        {


            //int num = int.Parse(Console.ReadLine());
            //Number number = new Number(num);
            //Console.WriteLine(number.ReturnLastNumberName());


//            
//            int count = Integer.parseInt(shipType.getTag().toString());
//            if (lastCmd == -1)
//            {
//                count++;
//                lastCmd = 1;
//            }
//            if (count >= imageNo.length)
//            {
//                count = 0;
//                ammo -= 5;
//            }

//            shipType.setImageResource(imageNo[count]);
//            ammo++;
//            count++;
//            lastCmd = 1;
//            shipType.setTag(count);
//            numberOfAmmo.setText(ammo + "");
//        }
//    });
//        
//        int count = Integer.parseInt(shipType.getTag().toString());


//        numberOfAmmo.setText(ammo + "");
//    }
//});



            string[] images = { "purva", "vtora", "treta", "chetvurta0", "peta" };

            string comand = Console.ReadLine();
            int counter = 1;
           // int lastComand = 0;
            while (comand!="end")
            {
                
                if (comand=="p")
                {
                    //if (lastComand==-1)
                    //{
                    //    counter++;
                    //    lastComand = 1;
                    //}

                    if (counter>=images.Length)
                    {
                        Console.WriteLine("Max Lenght");
                    }
                    else
                    {
                        Console.WriteLine(images[counter] + " " + (counter+1));
                        counter++;
                    }


                    //lastComand = 1;
                }
                else if (comand == "m")
                {
                    counter--;
                    if (counter <= 0)
                    {
                        Console.WriteLine("Min Lenght");
                        counter = 1;
                    }
                    else
                    {
                        Console.WriteLine(images[counter-1] + " " + (counter ));
                        
                    }
                }
                //else if (comand=="m")
                //{
                //    //        if (lastCmd == 1)
                //    //        {
                //    //            count--;
                //    //            lastCmd = -1;
                //    //        }
                //    //        int temp = count - 1;
                //    //        if (temp < 0)
                //    //        {
                //    //            count = 5;
                //    //            temp = 4;
                //    //            ammo += 5;

                //    //        }
                //    //        lastCmd = -1;
                //    //        shipType.setImageResource(imageNo[temp]);
                //    //        shipType.setTag(count);
                //    //        temp--;
                //    //        count--;
                //    //        ammo--;

                //    if (lastComand==1)
                //    {
                //        counter--;
                //        lastComand = -1;
                //    }
                //    int temp = counter - 1;
                //    if (temp<0)
                //    {
                //        counter = 5;
                //        temp = 4;
                //    }
                //    lastComand = -1;
                //    Console.WriteLine(images[temp] + " " + counter);
                //    temp--;
                    
                //    counter--;
                    
                    
                //}
                comand = Console.ReadLine();
            }
        }
    }
}
