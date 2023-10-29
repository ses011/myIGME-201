using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Sarah Schneider

namespace Unit2_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artistic wGymnast = new Womens();
            Artistic mGymnast = new Mens();

            mGymnast.Vault();
            wGymnast.Vault();
        }
    }

    public interface IGymnastics
    {
        void Compete();
    }

    public interface IElite
    {
        void Olympics();
    }

    public abstract class Artistic
    {
        private byte events;

        public byte Events
        {
            get { return events; }
        }

        public abstract void Floor();

        public virtual void Vault() { }
    }

    public class Womens : Artistic, IElite, IGymnastics
    {
        private static int vHeight = 125;

        public void Compete() { }

        public void Olympics() { }

        public void Bars() { }

        public void Beam() { }

        public override void Vault()
        {
            Console.WriteLine("Womens vault table height of " + vHeight + " cm.");
        }

        public override void Floor() { }
    }

    public class Mens : Artistic, IElite, IGymnastics
    {
        private static int vHeight = 135;
        public void Compete() { }

        public void Olympics() { }

        public void ParallelBars() { }

        public void Rings() { }

        public void HighBar() { }
        
        public void PomelHorse() { }

        public override void Vault() 
        {
            Console.WriteLine("Mens vault table height of " + vHeight + " cm.");
        }

        public override void Floor() { }
    }
}
