using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Sarah Schneider
 */

namespace Exam2_DW
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string adress;

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {

        public void Answer () { }

        public void MakeCall() { }

        public void HangUp() { }

        public override void Connect()  { }

        public override void Disconnect() { }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer() { }

        public void MakeCall() { }

        public void HangUp() { }

        public override void Connect() { }

        public override void Disconnect() { }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }
        
        public void TimeTravel() { }



        public static bool operator ==(Tardis dr1, Tardis dr2)
        {
            return dr1.WhichDrWho == (dr2.WhichDrWho);
        }

        public static bool operator !=(Tardis dr1, Tardis dr2)
        {
            return dr1.WhichDrWho == (dr2.WhichDrWho);
        }

        public static bool operator <(Tardis dr1, Tardis dr2)
        {
            if (dr1.WhichDrWho == 10)
            {
                return false;
            }
            else if (dr2.WhichDrWho == 10)
            {
                return true;
            }
            else
            {
                return dr1.WhichDrWho < (dr2.WhichDrWho);
            }
        }

        public static bool operator >(Tardis dr1, Tardis dr2)
        {
            if (dr1.WhichDrWho == 10)
            {
                return true;
            }
            else if (dr2.WhichDrWho == 10)
            {
                return false;
            }
            else
            {
                return dr1.WhichDrWho > (dr2.WhichDrWho);
            }
        }

        public static bool operator <=(Tardis dr1, Tardis dr2)
        {
            if (dr2.WhichDrWho == 10)
            {
                return true;
            }
            else if (dr1.WhichDrWho == 10)
            {
                return false;
            }
            else
            {
                return dr1.WhichDrWho <= (dr2.WhichDrWho);
            }
        }

        public static bool operator >=(Tardis dr1, Tardis dr2)
        {
            if (dr1.WhichDrWho == 10)
            {
                return true;
            }
            else if (dr2.WhichDrWho == 10)
            {
                return false;
            }
            else
            {
                return dr1.WhichDrWho <= (dr2.WhichDrWho);
            }
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() { }

        public void CloseDoor() { }

        
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);


        }

        static void UsePhone(object obj)
        {
            // question 6 - checks if obj is PhoneInterface and calls interface methods
            if (obj is PhoneInterface)
            {
                PhoneInterface phoneInterface = (PhoneInterface)obj;

                phoneInterface.MakeCall();
                phoneInterface.HangUp();
            }

            // question 7 - determines which kind of object obj is, calls the relevant methods for each class
            if (obj is Tardis)
            {
                Tardis tardis1 = (Tardis)obj;
                tardis1.TimeTravel();
            }
            else if (obj is PhoneBooth)
            {
                PhoneBooth phone = (PhoneBooth)obj;
                phone.OpenDoor();
            }

        }
    }
}
