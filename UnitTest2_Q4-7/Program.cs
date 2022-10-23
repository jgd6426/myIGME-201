using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Q4_7
{
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set {;  }
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }

    public class RotaryPhone: Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {
            Console.WriteLine("Ring ring ring...");
        }
        public void HangUp()
        {
            Console.WriteLine("Bye bye");
        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }   
    }

    public class PushButtonPhone: Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {
            Console.WriteLine("Ring ring ring...");
        }
        public void HangUp()
        {
            Console.WriteLine("Bye bye");
        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    public class Tardis: RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }
        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }
        public void TimeTravel()
        {
            Console.WriteLine("Whoosh whoosh");
        }
        public static bool operator < (Tardis dr1, Tardis dr2)
        {
            return (dr1.whichDrWho < dr2.whichDrWho);
        }
        public static bool operator <= (Tardis dr1, Tardis dr2)
        {
            return (dr1.whichDrWho <= dr2.whichDrWho);
        }
        public static bool operator >(Tardis dr1, Tardis dr2)
        {
            return (dr1.whichDrWho > dr2.whichDrWho);
        }
        public static bool operator >= (Tardis dr1, Tardis dr2)
        {
            return (dr1.whichDrWho >= dr2.whichDrWho);
        }
        public static bool operator == (Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10)
            {
                return dr1 > dr2;
            }
            else if (dr2.whichDrWho == 10)
            {
                return dr2 > dr1;
            }
            else
            {
                return (dr1.whichDrWho == dr2.whichDrWho);
            }          
        }
        public static bool operator != (Tardis dr1, Tardis dr2)
        {
            return (dr1.whichDrWho != dr2.whichDrWho);
        }
    }

    public class PhoneBooth: PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {
            Console.WriteLine("door opened");
        }
        public void CloseDoor()
        {
            
        }
    }
    static internal class Program
    {
        static void UsePhone(object obj)
        {
            PhoneInterface phone = (PhoneInterface)obj;
            phone.MakeCall();

            phone.HangUp();

            // if obj = PhoneBooth --> OpenDoor()
            if (obj is PhoneBooth)
            {
                PhoneBooth booth = (PhoneBooth)obj;
                booth.OpenDoor();
            }

            // if obj = Tardis --> TimeTravel()
            else if (obj is Tardis)
            {
                Tardis tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
        static void Main(string[] args)
        {
            // create a Tardis object
            Tardis tardis = new Tardis();

            // create a PhoneBooth object
            PhoneBooth phoneBooth = new PhoneBooth();

            // pass each to UsePhone(object obj)
            UsePhone(tardis);
            UsePhone(phoneBooth);
        }
    }
}
