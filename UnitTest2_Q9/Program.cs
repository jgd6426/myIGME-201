using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Q9
{
    public interface IExpectations
    {
        void LearnMusic();
    }
    public interface IActions
    {
        void Sing();
        void Dance();
    }
    public abstract class Acapella
    {
        public string voicePart;

        public abstract void WarmUp();

        public virtual void Critique()
        {
            
        }
    }
    public class Member: Acapella, IActions, IExpectations
    {
        public void Sing()
        {

        }
        public void Dance()
        {

        }
        public void LearnMusic()
        {

        }
        public override void WarmUp()
        {

        }
    }
    public class Eboard : Acapella, IActions, IExpectations
    {
        public void Sing()
        {

        }
        public void Dance()
        {

        }
        public void LearnMusic()
        {

        }
        public override void WarmUp()
        {

        }
        public override void Critique()
        {

        }
    }
    internal class Program
    {
        static void MyMethod(object obj)
        {
            // call supported methods based on object type
            IExpectations exp = (IExpectations)obj;
            exp.LearnMusic();

            IActions act = (IActions)obj;
            act.Sing();
            act.Dance();

            if (obj is Member)
            {
                Member memb = (Member)obj;
                memb.WarmUp();
            }

            else if (obj is Eboard)
            {
                Eboard eb = (Eboard)obj;
                eb.WarmUp();
                eb.Critique();
            }

        }
        static void Main(string[] args)
        {
            // create objects of 2 child classes
            Member regular_Member = new Member();

            Eboard music_Director = new Eboard();

            // call MyMethod
            MyMethod(regular_Member);
            MyMethod(music_Director);
        }
    }
}
